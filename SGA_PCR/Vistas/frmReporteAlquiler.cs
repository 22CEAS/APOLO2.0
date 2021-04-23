using AccesoDatos;
using DevComponents.DotNetBar.SuperGrid;
using DevExpress.Export;
using DevExpress.Printing.ExportHelpers;
using DevExpress.XtraPrinting;
using Modelo;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Apolo
{
    public partial class frmReporteAlquiler : Form
    {

        DataTable tablaAlquiler;
        ReporteDA reporteDA;
        private int idUsuario;
        private string nombreUsuario = "CEAS";


        public frmReporteAlquiler()
        {
            InitializeComponent();
            Inicializado();
        }

        public frmReporteAlquiler(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
        }

        public void Inicializado()
        {
            CargarData();
        }

        public void CargarData()
        {
            try
            {
                reporteDA = new ReporteDA();
                tablaAlquiler = reporteDA.ListarReporteAlquileres();

                dgvAlquiler.DataSource = tablaAlquiler;
                vistaAlquiler.OptionsBehavior.AutoPopulateColumns = false;
                vistaAlquiler.OptionsSelection.MultiSelect = true;
                dgvAlquiler.Refresh();
                
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message); OMITIMOS EL MENSAJE
            }
        }

        private void frmReporteAlquiler_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int posY = 0;
        int posX = 0;
        private void pnlAlquileres_MouseMove(object sender, MouseEventArgs e)
        {
                if (e.Button != MouseButtons.Left)
                {
                    posX = e.X;
                    posY = e.Y;
                }
                else
                {
                    Left = Left + (e.X - posX);
                    Top = Top + (e.Y - posY);
                }
            
        }

        void options_CustomizeSheetHeader(DevExpress.Export.ContextEventArgs e)
        {
            // Create a new row.
            CellObject row = new CellObject();
            XlFormattingObject rowFormatting = new XlFormattingObject();
            // Specify row values.
            row.Value = "REPORTE ALQUILERES";
            rowFormatting.Font = new XlCellFont { Bold = true, Size = 14 };
            rowFormatting.BackColor = Color.Orange;
            rowFormatting.Alignment = new DevExpress.Export.Xl.XlCellAlignment { HorizontalAlignment = DevExpress.Export.Xl.XlHorizontalAlignment.Center, VerticalAlignment = DevExpress.Export.Xl.XlVerticalAlignment.Top };
            row.Formatting = rowFormatting;
            // Add the created row to the output document.
            e.ExportContext.AddRow(new[] { row });
            // Add an empty row to the output document.
            e.ExportContext.AddRow();
            // Merge cells of two new rows. 
            e.ExportContext.MergeCells(new DevExpress.Export.Xl.XlCellRange(new DevExpress.Export.Xl.XlCellPosition(0, 0), new DevExpress.Export.Xl.XlCellPosition(12, 1)));
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Exportar el reporte", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    DevExpress.Export.ExportSettings.DefaultExportType = ExportType.DataAware;
                    XlsxExportOptionsEx options = new XlsxExportOptionsEx();
                    options.CustomizeSheetHeader += options_CustomizeSheetHeader;
                    //options.CustomizeCell += op_CustomizeCell;
                    string file = "REPORTE ALQUILERES.xlsx";
                    dgvAlquiler.ExportToXlsx(file, options);
                    System.Diagnostics.Process.Start(file);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString(), "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    MessageBox.Show("Error al exportar la informacion | Si tiene un reporte de ALQUILERES ya abierto, cierrelo.", " ◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                Cursor.Current = Cursors.Default;

            }
        }

        private void vistaAlquiler_KeyUp(object sender, KeyEventArgs e)
        {
            int filas = vistaAlquiler.RowCount;
            if (filas > 0)
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.N))
                {
                    string aux = vistaAlquiler.GetFocusedValue().ToString();
                    if (aux.Length == 0)
                        aux = "a";
                    Clipboard.SetText(aux);
                }
        }
    }
}
