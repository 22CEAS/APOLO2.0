using AccesoDatos;
using DevComponents.DotNetBar.SuperGrid;
using DevExpress.Export;
using DevExpress.Printing.ExportHelpers;
using DevExpress.XtraPrinting;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apolo
{
    public partial class frmReporteCorteAlquiler : Form
    {
        DataTable tablaLaptops;
        DataTable usuario;
        ReporteDA reporteDA;
        CorteAlquilerDA corteDA;

        private int idUsuario;
        private string nombreUsuario = "CEAS";
        private int idAreaComercialSupervisor = 5;
        private int idArea;

        public frmReporteCorteAlquiler()
        {
            InitializeComponent();
            Inicializado();
        }

        public frmReporteCorteAlquiler(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
        }

        public void Inicializado()
        {
            reporteDA = new ReporteDA();
            corteDA = new CorteAlquilerDA();
            vista.OptionsBehavior.AutoPopulateColumns = false;
            vista.OptionsSelection.MultiSelect = true;

            usuario = corteDA.ObtenerArea(this.idUsuario);
            idArea = int.Parse(usuario.Rows[0]["idArea"].ToString());
            if (idArea == idAreaComercialSupervisor)
            {
                this.Anular.Visible = true;
            }
            else
            {
                this.Anular.Visible = false;
                this.FechaUltimaFactura.Width = 140;
                this.FechaCorteAlquiler.Width = 140;
            }

            giftCarga.Visible = false;
            //cargarData();
            bool i=cargarDataTabla();
        }
        
        void options_CustomizeSheetHeader(DevExpress.Export.ContextEventArgs e)
        {
            // Create a new row.
            CellObject row = new CellObject();
            XlFormattingObject rowFormatting = new XlFormattingObject();
            // Specify row values.
            row.Value = "CORTE ALQUILER";
            rowFormatting.Font = new XlCellFont { Bold = true, Size = 14 };
            rowFormatting.BackColor = Color.Orange;
            rowFormatting.Alignment = new DevExpress.Export.Xl.XlCellAlignment { HorizontalAlignment = DevExpress.Export.Xl.XlHorizontalAlignment.Center, VerticalAlignment = DevExpress.Export.Xl.XlVerticalAlignment.Top };
            row.Formatting = rowFormatting;
            // Add the created row to the output document.
            e.ExportContext.AddRow(new[] { row });
            // Add an empty row to the output document.
            e.ExportContext.AddRow();
            // Merge cells of two new rows. 
            if (idArea == idAreaComercialSupervisor)
            {
                e.ExportContext.MergeCells(new DevExpress.Export.Xl.XlCellRange(new DevExpress.Export.Xl.XlCellPosition(0, 0), new DevExpress.Export.Xl.XlCellPosition(8, 1))); //EL 6 SON LAS COLUMNAS QUE TIENE EL REPORTE
            }
            else
            {
                e.ExportContext.MergeCells(new DevExpress.Export.Xl.XlCellRange(new DevExpress.Export.Xl.XlCellPosition(0, 0), new DevExpress.Export.Xl.XlCellPosition(7, 1))); //EL 6 SON LAS COLUMNAS QUE TIENE EL REPORTE
            }
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
                    string file = "CORTE ALQUILER.xlsx";
                    dgvLaptops.ExportToXlsx(file, options);
                    System.Diagnostics.Process.Start(file);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString(), "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                Cursor.Current = Cursors.Default;
            }
        }

        private async void cargarData()
        {
            label1.Text = $"CANTIDAD REGISTRO: 0";
            Task<bool> task = new Task<bool>(cargarDataTabla);
            task.Start();
            //giftCarga.Image = Image.FromFile(@"C:\Users\User\Desktop\VERSIONES DE APOLO\progress.gif");
            giftCarga.Image = Image.FromFile(@".\progress.gif");
            giftCarga.SizeMode = PictureBoxSizeMode.StretchImage;
            bool resultado = await task;
            giftCarga.Enabled = false;
            giftCarga.Visible = false;
            label1.Text = $"CANTIDAD REGISTRO: {vista.RowCount.ToString()}";

        }

        public bool cargarDataTabla()
        {
            try
            {
                tablaLaptops = reporteDA.ListarCorteAlquiler();
                dgvLaptops.DataSource = tablaLaptops;
                dgvLaptops.Refresh();
                label1.Text = $"CANTIDAD REGISTRO: {vista.RowCount.ToString()}";
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message); 
            }
            return true;
        }

        private void dgvLaptops_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = $"CANTIDAD REGISTRO: {vista.RowCount.ToString()}";
        }

        private void dgvLaptops_MouseHover(object sender, EventArgs e)
        {
            label1.Text = $"CANTIDAD REGISTRO: {vista.RowCount.ToString()}";
        }

        int posY = 0;
        int posX = 0;

        private void pnlCV_MouseMove(object sender, MouseEventArgs e)
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnAnular_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (Int32.Parse(vista.GetFocusedRowCellValue("IdEstado").ToString()) == 0)
            {
                MessageBox.Show("No puedes anular un corte de alquiler que ya ha sido anulado", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            DialogResult rs = MessageBox.Show("Estas seguro que deseas anular este Corte de Alquiler", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (rs == DialogResult.Yes)
            {
                int idCorteAlquiler = Int32.Parse(vista.GetFocusedRowCellValue("IdCorteAlquiler").ToString());
                int error = 0;
                error = corteDA.AnularCorte(idCorteAlquiler, this.nombreUsuario);

                if (error == 0)
                {
                    MessageBox.Show("Hubo error en la anulación, comunicarse con tu soporte", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                MessageBox.Show("Se guardó el proceso", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                bool i = cargarDataTabla();
            }
        }


        private void vista_KeyUp(object sender, KeyEventArgs e)
        {
            int filas = vista.RowCount;
            if (filas > 0)
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.N))
                {
                    string aux = vista.GetFocusedValue().ToString();
                    if (aux.Length == 0)
                        aux = "a";
                    Clipboard.SetText(aux);
                }
        }

    }
}
