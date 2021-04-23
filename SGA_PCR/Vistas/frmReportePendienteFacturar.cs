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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Apolo
{
    public partial class frmReportePendienteFacturar : Form
    {

        DataTable tablaLaptops;
        DataTable DiscosDuros;
        DataTable memoriaLC;
        DataTable memoria;
        ReporteDA reporteDA;
        private int idUsuario;
        private string nombreUsuario = "CEAS";

        public frmReportePendienteFacturar()
        {
            InitializeComponent();
            Inicializado();
        }

        public frmReportePendienteFacturar(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
        }

        public void Inicializado()
        {
            //
        }



        void options_CustomizeSheetHeader(DevExpress.Export.ContextEventArgs e)
        {
            // Create a new row.
            CellObject row = new CellObject();
            XlFormattingObject rowFormatting = new XlFormattingObject();
            // Specify row values.
            row.Value = "PENDIENTE FACTURAR";
            rowFormatting.Font = new XlCellFont { Bold = true, Size = 14 };
            rowFormatting.BackColor = Color.Orange;
            rowFormatting.Alignment = new DevExpress.Export.Xl.XlCellAlignment { HorizontalAlignment = DevExpress.Export.Xl.XlHorizontalAlignment.Center, VerticalAlignment = DevExpress.Export.Xl.XlVerticalAlignment.Top };
            row.Formatting = rowFormatting;
            // Add the created row to the output document.
            e.ExportContext.AddRow(new[] { row });
            // Add an empty row to the output document.
            e.ExportContext.AddRow();
            // Merge cells of two new rows. 
            e.ExportContext.MergeCells(new DevExpress.Export.Xl.XlCellRange(new DevExpress.Export.Xl.XlCellPosition(0, 0), new DevExpress.Export.Xl.XlCellPosition(27, 1)));
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
                    string file = "PENDIENTE FACTURAR.xlsx";
                    dgvFacturas.ExportToXlsx(file, options);
                    System.Diagnostics.Process.Start(file);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString(), "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    MessageBox.Show("Error al exportar la informacion | Si tiene un reporte de PENDIENTE FACTURAR ya abierto, cierrelo.", " ◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                Cursor.Current = Cursors.Default;

            }
        }

        public bool cargarDataTabla()
        {
            try
            {
                reporteDA = new ReporteDA();
                tablaLaptops = reporteDA.ListarLaptopsPorFacturar();

                DiscosDuros = reporteDA.ListaDiscosDuros();
                memoriaLC = reporteDA.ListarMemoriasLC();
                memoria = reporteDA.ListarMemoriasMaestro();
                                
                tablaLaptops.Columns.Add("RAM");
                tablaLaptops.Columns.Add("DiscoDuro1");
                tablaLaptops.Columns.Add("DiscoDuro2");

                //PONER MEMORIA
                for (int i = 0; i < tablaLaptops.Rows.Count; i++)
                {
                    int idLC = int.Parse(tablaLaptops.Rows[i]["idLC"].ToString());

                    //RECORREMOS TABLA MEMORIALC
                    List<int> codigosMemorias = new List<int>(); //! IMPORTANTE
                    int aux = 0;
                    for (int j = 0; j < memoriaLC.Rows.Count; j++)
                    {
                        if (int.Parse(memoriaLC.Rows[j]["idLC"].ToString()) == idLC)
                        {
                            aux = int.Parse(memoriaLC.Rows[j]["cantidad"].ToString());
                            for (int h = 0; h < aux; h++)
                            {
                                codigosMemorias.Add(int.Parse(memoriaLC.Rows[j]["idMemoria"].ToString()));
                            }
                        }
                    }

                    //RECORREMOS TABLA MEMORIA
                    List<int> capacidadMemorias = new List<int>();
                    for (int k = 0; k < memoria.Rows.Count; k++)
                    {
                        for (int s = 0; s < codigosMemorias.Count; s++)
                        {
                            if (int.Parse(memoria.Rows[k]["idMemoria"].ToString()) == codigosMemorias[s])
                                capacidadMemorias.Add(int.Parse(memoria.Rows[k]["capacidad"].ToString()));

                        }
                    }

                    //RECORREMOS LAS CAPACIDAD
                    int suma = 0;
                    for (int b = 0; b < capacidadMemorias.Count; b++)
                    {
                        suma = suma + capacidadMemorias[b];
                    }

                    tablaLaptops.Rows[i]["RAM"] = suma + " GB";
                                       
                    //DISCO DURO 
                    int capacidadSSD = 0;
                    int capacidadHDD = 0;

                    for (int m = 0; m < DiscosDuros.Rows.Count; m++)
                    {
                        if (tablaLaptops.Rows[i]["IdLC"].ToString() == DiscosDuros.Rows[m]["IdLC"].ToString() && DiscosDuros.Rows[m]["TipoDisco"].ToString() == "HDD")
                        {
                            capacidadHDD = int.Parse(DiscosDuros.Rows[m]["Capacidad"].ToString()) * int.Parse(DiscosDuros.Rows[m]["Cantidad"].ToString());
                        }
                        if (tablaLaptops.Rows[i]["IdLC"].ToString() == DiscosDuros.Rows[m]["IdLC"].ToString() && DiscosDuros.Rows[m]["TipoDisco"].ToString() == "SSD")
                        {
                            capacidadSSD = int.Parse(DiscosDuros.Rows[m]["Capacidad"].ToString()) * int.Parse(DiscosDuros.Rows[m]["Cantidad"].ToString());
                        }
                    }

                    tablaLaptops.Rows[i]["DiscoDuro1"] = capacidadHDD;
                    tablaLaptops.Rows[i]["DiscoDuro2"] = capacidadSSD;

                }

                dgvFacturas.DataSource = tablaLaptops;
                vista.OptionsBehavior.AutoPopulateColumns = false;
                vista.OptionsSelection.MultiSelect = true;
                dgvFacturas.Refresh();

            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message); OMITIMOS EL MENSAJE
            }
            
            return true;
        }

        private void frmReportePendienteFacturar_Load(object sender, EventArgs e)
        {
            cargarData.PerformClick();
        }

        private void verResumen_Click_1(object sender, EventArgs e)
        {
            label1.Text = $"CANTIDAD REGISTRO: {vista.RowCount.ToString()}";
        }

        private async void cargarData_Click_1(object sender, EventArgs e)
        {
            label1.Text = $"CANTIDAD REGISTRO: 0";
            Task<bool> task = new Task<bool>(cargarDataTabla);
            task.Start();
            giftCarga.Image = Image.FromFile(@".\progress.gif");
            giftCarga.SizeMode = PictureBoxSizeMode.StretchImage;
            bool resultado = await task;
            giftCarga.Enabled = false;
            giftCarga.Visible = false;
            cargarData.Text = "DATA CARGADA";
            label1.Text = $"CANTIDAD REGISTRO: {vista.RowCount.ToString()}";
            cargarData.Visible = false;

        }

        private void dgvFacturas_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = $"CANTIDAD REGISTRO: {vista.RowCount.ToString()}";
        }

        private void dgvFacturas_MouseHover(object sender, EventArgs e)
        {
            label1.Text = $"CANTIDAD REGISTRO: {vista.RowCount.ToString()}";
        }

     
        int posY = 0;
        int posX = 0;

        private void pnlPF_MouseMove(object sender, MouseEventArgs e)
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
