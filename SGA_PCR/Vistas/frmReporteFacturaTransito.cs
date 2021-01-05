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
using Excel = Microsoft.Office.Interop.Excel;

namespace Apolo
{
    public partial class frmReporteFacturaTransito : Form
    {
        DataTable tablaFacturas;
        ReporteDA reporteDA;
        BindingList<Factura> facturas;
        private int idUsuario;
        private string nombreUsuario = "CEAS";

        public frmReporteFacturaTransito()
        {
            InitializeComponent();
            Inicializado();
        }

        public frmReporteFacturaTransito(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
        }

        public void Inicializado()
        {
            reporteDA = new ReporteDA();
            facturas = new BindingList<Factura>();
        }

        //DAR FORMATO A COLUMNAS
        void op_CustomizeCell(DevExpress.Export.CustomizeCellEventArgs ea)
        {
            if (ea.ColumnFieldName == "X")
            {
                ea.Formatting.BackColor = Color.Red;
                ea.Handled = true;
            }
        }

        void options_CustomizeSheetHeader(DevExpress.Export.ContextEventArgs e)
        {
            // Create a new row.
            CellObject row = new CellObject();
            XlFormattingObject rowFormatting = new XlFormattingObject();
            // Specify row values.
            row.Value = "Facturas Transito";
            rowFormatting.Font = new XlCellFont { Bold = true, Size = 14 };
            rowFormatting.BackColor = Color.Orange;
            rowFormatting.Alignment = new DevExpress.Export.Xl.XlCellAlignment { HorizontalAlignment = DevExpress.Export.Xl.XlHorizontalAlignment.Center, VerticalAlignment = DevExpress.Export.Xl.XlVerticalAlignment.Top };
            row.Formatting = rowFormatting;
            // Add the created row to the output document.
            e.ExportContext.AddRow(new[] { row });
            // Add an empty row to the output document.
            e.ExportContext.AddRow();
            // Merge cells of two new rows. 
            e.ExportContext.MergeCells(new DevExpress.Export.Xl.XlCellRange(new DevExpress.Export.Xl.XlCellPosition(0, 0), new DevExpress.Export.Xl.XlCellPosition(14, 1))); //EL 18 SON LAS COLUMNAS QUE TIENE EL REPORTE
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Estas seguro que desea Exportar el reporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    DevExpress.Export.ExportSettings.DefaultExportType = ExportType.DataAware;
                    XlsxExportOptionsEx options = new XlsxExportOptionsEx();
                    options.CustomizeSheetHeader += options_CustomizeSheetHeader;
                    //options.CustomizeCell += op_CustomizeCell;
                    string file = "FACTURAS EN TRANSITO.xlsx";
                    dgvEquiposCodigos.ExportToXlsx(file, options);
                    System.Diagnostics.Process.Start(file);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar la informacion | Si tiene un reporte de FACTURAS EN TRANSITO ya abierto, cierrelo.", " ◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                Cursor.Current = Cursors.Default;
            }
        }

        private async void cargarData_Click(object sender, EventArgs e)
        {
            label1.Text = $"CANTIDAD REGISTRO: 0";
            Task<bool> task = new Task<bool>(cargarDataTabla);
            task.Start();
            giftCarga.Image = Image.FromFile(@".\progress.gif");
            giftCarga.SizeMode = PictureBoxSizeMode.StretchImage;
            bool resultado = await task; //#
            giftCarga.Enabled = false;
            giftCarga.Visible = false;
            cargarData.Text = "DATA CARGADA";
            label1.Text = $"CANTIDAD REGISTRO: {vistaCodigo.RowCount.ToString()}";
            cargarData.Visible = false;

        }

        public bool cargarDataTabla()
        {
            try
            {
                tablaFacturas = reporteDA.ListarFacturasTransito();

                facturas = new BindingList<Factura>();
                int rec = 0;
                while (rec < tablaFacturas.Rows.Count)
                {
                    Factura fact = new Factura();
                    fact.IdFacturaTransito = Convert.ToInt32(tablaFacturas.Rows[rec]["idFacturaTransito"].ToString());

                    fact.CodigoLC = tablaFacturas.Rows[rec]["codigoEquipo"].ToString();
                    fact.FechaPago = Convert.ToDateTime(tablaFacturas.Rows[rec]["fecEmisiom"].ToString());
                    fact.FechaIniPago = (tablaFacturas.Rows[rec]["fecIniPago"] is DBNull) ? Convert.ToDateTime("1/01/1900 00:00:00") : Convert.ToDateTime(tablaFacturas.Rows[rec]["fecIniPago"].ToString());
                    fact.FechaFinPago = (tablaFacturas.Rows[rec]["fecFinPago"] is DBNull) ? Convert.ToDateTime("1/01/1900 00:00:00") : Convert.ToDateTime(tablaFacturas.Rows[rec]["fecFinPago"].ToString());
                    fact.RucDni = tablaFacturas.Rows[rec]["ruc"].ToString();
                    fact.RazonSocial = tablaFacturas.Rows[rec]["razonSocial"].ToString();
                    fact.NumeroOC = tablaFacturas.Rows[rec]["numeroOC"].ToString();
                    fact.NumeroDocRef = tablaFacturas.Rows[rec]["guiaSalida"].ToString();
                    fact.NumeroFactura = tablaFacturas.Rows[rec]["numFacturaTransito"].ToString();
                    fact.TotalSoles = Convert.ToDouble(tablaFacturas.Rows[rec]["totalSoles"].ToString());
                    fact.TotalDolares = Convert.ToDouble(tablaFacturas.Rows[rec]["totalDolares"].ToString());
                    fact.CostoSoles = Convert.ToDouble(tablaFacturas.Rows[rec]["costoSoles"].ToString());
                    fact.CostoDolares = Convert.ToDouble(tablaFacturas.Rows[rec]["costoDolares"].ToString());
                    fact.CantidadEquipos = Convert.ToInt32(tablaFacturas.Rows[rec]["cantidadEquipos"].ToString());
                    fact.ObservacionXLevantar = tablaFacturas.Rows[rec]["observacion"].ToString() ;

                    fact.TipoFacturaTransito = 1;

                    rec++;
                    facturas.Add(fact);
                }

                dgvEquiposCodigos.DataSource = facturas;
                vistaCodigo.OptionsBehavior.AutoPopulateColumns = false;
                vistaCodigo.OptionsSelection.MultiSelect = true;
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
            }

            return true;
        }
        
        private void dgvEquiposCodigos_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = $"CANTIDAD REGISTRO: {vistaCodigo.RowCount.ToString()}";
        }

        private void dgvEquiposCodigos_MouseHover(object sender, EventArgs e)
        {
            label1.Text = $"CANTIDAD REGISTRO: {vistaCodigo.RowCount.ToString()}";
        }

        private void frmReporteFacturaTransito_Load(object sender, EventArgs e)
        {
            cargarDataTabla();
            //cargarData.PerformClick();
        }

        int posY = 0;
        int posX = 0;

        private void pnlFTr_MouseMove(object sender, MouseEventArgs e)
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
    }
}
