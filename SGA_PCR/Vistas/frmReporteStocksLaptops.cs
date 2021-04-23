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
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using System.Runtime.InteropServices;
using System.Globalization;

namespace Apolo
{
    public partial class frmReporteStocksLaptops : Form
    {

        DataTable tablaLaptops;
        ReporteDA reporteDA;
        private int idUsuario;
        private string nombreUsuario = "CEAS";
        DataTable tablaDisco;
        DataTable tablaMemoria;
        DataTable tablaLicencia;

        private string licenciaCategoriaSO = "S.O";
        private string licenciaCategoriaOffice = "OFFICE";
        private string licenciaCategoriaAntivirus = "ANTIVIRUS";

        DataTable tablaProcesadoresModelos;
        DataTable tablaProcesadoresGeneracion;

        private BindingList<LC> laptops;

        private int estadoDisponible = 2;
        private int idMarcaAppleLC = 1;
        private int idMarcaApplePC = 8;
        private int idCategoriaProcesador = 9;
        private string codTablaProcesadorGeneracion = "PROCESADOR_GENERACION";
        private int cantGeneraciones;
        private int cantModeloProcesador;
        private int[][] arregloLCGeneral;
        private int[][] arregloLCApple;


        private int GeneracionDesfasado = 3;


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
           int nLeftRect, // x-coordinate of upper-left corner
           int nTopRect, // y-coordinate of upper-left corner
           int nRightRect, // x-coordinate of lower-right corner
           int nBottomRect, // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
           );


        public frmReporteStocksLaptops()
        {
            InitializeComponent();
            Inicializado();
        }

        public frmReporteStocksLaptops(int idUsuario, string nombreUsuario)
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
            row.Value = "INVENTARIOS LAPTOPS";
            rowFormatting.Font = new XlCellFont { Bold = true, Size = 14 };
            rowFormatting.BackColor = Color.Orange;
            rowFormatting.Alignment = new DevExpress.Export.Xl.XlCellAlignment { HorizontalAlignment = DevExpress.Export.Xl.XlHorizontalAlignment.Center, VerticalAlignment = DevExpress.Export.Xl.XlVerticalAlignment.Top };
            row.Formatting = rowFormatting;
            // Add the created row to the output document.
            e.ExportContext.AddRow(new[] { row });
            // Add an empty row to the output document.
            e.ExportContext.AddRow();
            // Merge cells of two new rows. 
            e.ExportContext.MergeCells(new DevExpress.Export.Xl.XlCellRange(new DevExpress.Export.Xl.XlCellPosition(0, 0), new DevExpress.Export.Xl.XlCellPosition(20, 1)));
        }

        

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Exportar el reporte", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                //Cursor.Current = Cursors.WaitCursor;
                try
                {
                    DevExpress.Export.ExportSettings.DefaultExportType = ExportType.Default;
                    XlsxExportOptionsEx options = new XlsxExportOptionsEx();
                    options.CustomizeSheetHeader += options_CustomizeSheetHeader;
                    //options.CustomizeCell += op_CustomizeCell;
                    string file = "INVENTARIOS LAPTOPS.xlsx";
                    dgvLaptops.ExportToXlsx(file, options);
                    System.Diagnostics.Process.Start(file);
                    //btnExportar2_Click();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString(), "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    MessageBox.Show("Error al exportar la informacion | Si tiene un reporte de INVENTARIO ya abierto, cierrelo.", " ◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                //Cursor.Current = Cursors.Default;

            }
        }

        private void btnExportar2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Estas seguro que desea Exportar el reporte", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                //Cursor.Current = Cursors.WaitCursor;
                try
                {

                    SaveFileDialog fichero = new SaveFileDialog();
                    //fichero.Filter = "Excel (*.xls)|*.xls";
                    fichero.Filter = "Excel(*.xlsx) | *.xlsx";
                    fichero.FileName = "Laptops";
                    if (fichero.ShowDialog() == DialogResult.OK)
                    {
                        Excel.Application aplicacion;
                        Excel.Workbook libros_trabajo;
                        Excel.Worksheet hoja_pre_alquiler;

                        aplicacion = new Excel.Application();
                        libros_trabajo = (Excel.Workbook)aplicacion.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);

                        hoja_pre_alquiler = (Excel.Worksheet)libros_trabajo.Worksheets.Add();
                        hoja_pre_alquiler.Name = "Laptops";
                        string cabecera = "RESUMEN EQUIPOS DISPONIBLES/DESFASADOS";
                        ExportarDataGridViewExcel(ref hoja_pre_alquiler, cabecera);


                        ((Excel.Worksheet)aplicacion.ActiveWorkbook.Sheets["Hoja1"]).Delete();

                        libros_trabajo.SaveAs(fichero.FileName, Excel.XlFileFormat.xlOpenXMLWorkbook);
                        libros_trabajo.Close(true);
                        releaseObject(libros_trabajo);
                        aplicacion.Quit();
                        releaseObject(aplicacion);
                        MessageBox.Show("Se generó el reporte con éxito", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString(), "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                //Cursor.Current = Cursors.Default;
            }
        }

        public void ExportarDataGridViewExcel(ref Excel.Worksheet hoja_trabajo, string nombreCabecera)
        {
            Excel.Range rango;

            int cantColumnas = tablaProcesadoresGeneracion.Rows.Count + 3; //
            int filas = vista.RowCount;

            int k = cantColumnas - 1 + 64;
            char columF = (char)k;
            int fila2 = 12; //! ORIGINAL 3
            string filaBorde = fila2.ToString();
            char columI = 'A';
            //Ponemos borde a las celdas


            rango = hoja_trabajo.Range[columI + fila2.ToString(), columF + fila2.ToString()];
            rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            rango.Style.Font.Bold = false;

            

            for (int i = 1; i <= this.cantModeloProcesador * 2 + 4; i++)
            {
                rango = hoja_trabajo.Range[columI + (i + 9).ToString(), columF + (i + 9).ToString()];
                rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            }

            //CANTIDAD DE LAPTOP/MAC POR GENERACION
            for (int i = 0; i < this.cantGeneraciones; i++)
            {
                int cantGenLCGeneral = 0;
                int cantGenLCApple = 0;
                for (int j = 0; j < this.cantModeloProcesador; j++)
                {
                    string generacion = tablaProcesadoresGeneracion.Rows[i]["descripcion"].ToString();
                    string nombreProcesador = tablaProcesadoresModelos.Rows[j]["nombre"].ToString();

                    hoja_trabajo.Cells[fila2 + 1 + j, i + 2] = arregloLCGeneral[i][j];

                    hoja_trabajo.Cells[fila2 + 1 + cantModeloProcesador + 1 + j, i + 2] = arregloLCApple[i][j];

                    cantGenLCGeneral += arregloLCGeneral[i][j];
                    cantGenLCApple += arregloLCApple[i][j];
                }
                hoja_trabajo.Cells[fila2, i + 2] = cantGenLCGeneral;
                hoja_trabajo.Cells[fila2 + cantModeloProcesador + 1, i + 2] = cantGenLCApple;
                
            }

            
            //CANTIDAD DE LAPTOP POR PROCESADOR -> LAP Y MAC
            for (int j = 0; j < this.cantModeloProcesador; j++)
            {
                int cantProLCGeneral = 0;
                int cantProLCApple = 0;
                for (int i = 0; i < this.cantGeneraciones; i++)
                {
                    cantProLCGeneral += arregloLCGeneral[i][j];
                    cantProLCApple += arregloLCApple[i][j];
                }
                hoja_trabajo.Cells[fila2 + 1 + j, cantGeneraciones + 2] = cantProLCGeneral;
                hoja_trabajo.Cells[fila2 + cantModeloProcesador + 1 + 1 + j, cantGeneraciones + 2] = cantProLCApple;

                
            }

            

            var cantidadLCGeneral = new BindingList<LC>(laptops.Where(p => p.IdMarca != this.idMarcaAppleLC && p.IdMarca != this.idMarcaApplePC && p.Estado == this.estadoDisponible).ToList());
            var cantidadLCApple = new BindingList<LC>(laptops.Where(p => p.IdMarca == this.idMarcaAppleLC && p.IdMarca != this.idMarcaApplePC && p.Estado == this.estadoDisponible).ToList());
            

            hoja_trabajo.Cells[fila2, cantGeneraciones + 2] = cantidadLCGeneral.Count;
            hoja_trabajo.Cells[fila2 + cantModeloProcesador + 1, cantGeneraciones + 2] = cantidadLCApple.Count;

            montaCabeceras(10, ref hoja_trabajo, nombreCabecera); //ORIGINAL:1
        }

        private void montaCabeceras(int fila, ref Excel.Worksheet hoja, string nombreCabecera)
        {
            try
            {
                Excel.Range rango;
                int cantColumnas = tablaProcesadoresGeneracion.Rows.Count + 2;

                //** Montamos el título en la línea 1 **
                hoja.Cells[fila, 1] = nombreCabecera;
                hoja.Range[hoja.Cells[fila, 1], hoja.Cells[fila, cantColumnas]].Merge();
                hoja.Range[hoja.Cells[fila, 1], hoja.Cells[fila, cantColumnas]].Interior.Color = Color.FromArgb(218, 152, 36);//FromArgb(255, 132, 0)
                hoja.Range[hoja.Cells[fila, 1], hoja.Cells[fila, cantColumnas]].Style.Font.Bold = true;

                hoja.Range[hoja.Cells[fila + 1, 1], hoja.Cells[fila + 1, cantColumnas - 1]].Interior.Color = Color.FromArgb(218, 152, 36);
                hoja.Range[hoja.Cells[fila + 1, cantColumnas], hoja.Cells[fila + 1, cantColumnas]].Interior.Color = Color.FromArgb(218, 152, 36);

                hoja.Range[hoja.Cells[fila + 2, 1], hoja.Cells[fila + 2, cantColumnas]].Interior.Color = Color.FromArgb(252, 228, 215);
                hoja.Range[hoja.Cells[fila + 3 + cantModeloProcesador, 1], hoja.Cells[fila + 3 + cantModeloProcesador, cantColumnas]].Interior.Color = Color.FromArgb(252, 228, 215);

                //Centramos los textos
                rango = hoja.Rows[fila];
                rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                for (int k = 0; k < cantGeneraciones; k++)
                {
                    string genPro = tablaProcesadoresGeneracion.Rows[k]["descripcion"].ToString();
                    hoja.Cells[fila + 1, k + 2] = genPro;
                }

                hoja.Cells[fila + 1, cantGeneraciones + 2] = "Total en Almacen";
                hoja.Cells[fila + 1, 1] = "Generación";
                hoja.Cells[fila + 2, 1] = "LAPTOP";


                //REPORTE SEGUN ESTADO

                hoja.Cells[1, 1] = "DISPONIBLES";
                hoja.Cells[1, 1].Interior.Color = Color.FromArgb(231, 177, 80);//FromArgb(255, 132, 0)
                hoja.Cells[1, 2] = txtDisponibles.Text;

                hoja.Cells[2, 1] = "ALQUILADAS";
                hoja.Cells[2, 1].Interior.Color = Color.FromArgb(231, 177, 80);//FromArgb(255, 132, 0)
                hoja.Cells[2, 2] = txtAlquilados.Text;

                hoja.Cells[3, 1] = "RESERVADAS";
                hoja.Cells[3, 1].Interior.Color = Color.FromArgb(231, 177, 80);//FromArgb(255, 132, 0)
                hoja.Cells[3, 2] = txtReservadas.Text;

                hoja.Cells[4, 1] = "PERSONAL PCR";
                hoja.Cells[4, 1].Interior.Color = Color.FromArgb(231, 177, 80);//FromArgb(255, 132, 0)
                hoja.Cells[4, 2] = txtPersonales.Text;

                hoja.Cells[5, 1] = "DESFASADAS";
                hoja.Cells[5, 1].Interior.Color = Color.FromArgb(231, 177, 80);//FromArgb(255, 132, 0)
                hoja.Cells[5, 2] = txtDesfasadas.Text;

                /*
                hoja.Cells[6, 1] = "TOTAL OFICINA";
                hoja.Cells[6, 1].Interior.Color = Color.FromArgb(218, 152, 36);//FromArgb(255, 132, 0)
                hoja.Cells[6, 2] = (int.Parse(txtReservadas.Text) + int.Parse(txtDisponibles.Text)+int.Parse(txtDesfasadas.Text)).ToString();
                */




                for (int k = 0; k < cantModeloProcesador; k++)
                {
                    string modPro = tablaProcesadoresModelos.Rows[k]["nombre"].ToString();
                    hoja.Cells[fila + 3 + k, 1] = modPro;
                }

                hoja.Cells[fila + 3 + cantModeloProcesador, 1] = "MACKBOOK";

                for (int k = 0; k < cantModeloProcesador; k++)
                {
                    string modPro = tablaProcesadoresModelos.Rows[k]["nombre"].ToString();
                    hoja.Cells[fila + 3 + cantModeloProcesador + 1 + k, 1] = modPro;
                }

                int fila2 = fila + 2;
                rango = hoja.Rows[fila2];
                rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                for (int j = 0; j < cantColumnas + 2; j++)
                {
                    rango = hoja.Columns[j + 1];
                    rango.ColumnWidth = 15;
                }

                rango = hoja.Rows[fila + 3 + cantModeloProcesador];
                rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                for (int j = 0; j < cantColumnas + 2; j++)
                {
                    rango = hoja.Columns[j + 1];
                    rango.ColumnWidth = 15;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de redondeo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Error mientras liberaba objecto " + ex.ToString(), "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                GC.Collect();
            }
        }

        private void verResumen_Click(object sender, EventArgs e)
        {
            txtCantidadFiltrada.Text = vista.RowCount.ToString();

        }

        public void verReporte()
        {
            int contador = 0;

            //PRE-ALQUILER
            vista.ActiveFilterString = "[EstadoNombre] like '%PRE-ALQUILER%'";
            int canPreAlquiler = vista.RowCount;
            contador = contador + canPreAlquiler;
            //lblDisponible.Text = $"DISPONIBLES: {cantidadReporte.ToString()}";
            txtReservadas.Text = canPreAlquiler.ToString();

            //DISPONIBLE
            vista.ActiveFilterString = "[EstadoNombre] like '%DISPONIBLE%'";
            int canDisponibles = vista.RowCount;
            contador = contador + canDisponibles;
            //lblDisponible.Text = $"DISPONIBLES: {cantidadReporte.ToString()}";
            txtDisponibles.Text = canDisponibles.ToString();

            //DESFASADO
            vista.ActiveFilterString = "[EstadoNombre] like '%DESFASADO%'";
            int canDesfasado = vista.RowCount;
            contador = contador + canDesfasado;
            //lblDisponible.Text = $"DISPONIBLES: {cantidadReporte.ToString()}";
            txtDesfasadas.Text = canDesfasado.ToString();

            //ALQUILADO
            vista.ActiveFilterString = "[EstadoNombre] like '%ALQUILADO%'";
            int cantidadAlquilado = vista.RowCount;
            contador = contador + cantidadAlquilado;
            //lblAlquilados.Text = $"ALQUILADOS: {(cantidadReporte + aux).ToString()}";
            txtAlquilados.Text = cantidadAlquilado.ToString();

            //PERSONAL
            vista.ActiveFilterString = "[EstadoNombre] like '%PERSONALPCR%'";
            int canPersonalPCR = vista.RowCount;
            contador = contador + canPersonalPCR;
            //lblPersonal.Text = $"PERSONAL PCR: {cantidadReporte.ToString()}";
            txtPersonales.Text = canPersonalPCR.ToString();


            
            //TOTAL
            //lblTotalLaptops.Text = $"TOTAL LAPTOPS: {(contador-cantidadReporte).ToString()}";
            txtTotalLaptops.Text = (canPreAlquiler+canDisponibles + canDesfasado ).ToString();
            vista.ActiveFilterString = "[EstadoNombre] null";
            

            /*
            //ACTIVAR DASHBOARD
            string[] series = { "LAPTOPS RESERVADAS", "LAPTOPS DISPONIBLES", "LAPTOPS DESFASADAS", "LAPTOPS ALQUILADAS", "LAPTOPS PERSONAL PCR" };
            int[] puntos = { int.Parse(txtReservadas.Text), int.Parse(txtDisponibles.Text), int.Parse(txtDesfasadas.Text), int.Parse(txtAlquilados.Text), int.Parse(txtPersonales.Text)};
            
            for (int i = 0; i < series.Length; i++)
            {
                Series serie = DashInventario.Series.Add(series[i]);
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }
            */

        }


        private async void cargarData_Click(object sender, EventArgs e)
        {
            //label1.Text = $"CANTIDAD FILTRADA: ";
            Task<bool> task = new Task<bool>(cargarDataTabla);
            task.Start();
            giftCarga.Image = Image.FromFile(@".\progress.gif");
            giftCarga.SizeMode = PictureBoxSizeMode.StretchImage;
            bool resultado = await task;
            giftCarga.Enabled = false;
            giftCarga.Visible = false;
            cargarData.Text = "DATA CARGADA";
            //label1.Text = $"CANTIDAD FILTRADA: {vista.RowCount.ToString()}";
            txtCantidadFiltrada.Text = vista.RowCount.ToString();
            cargarData.Visible = false;
            verReporte();
        }

        public bool cargarDataTabla()
        {
            try
            {
                reporteDA = new ReporteDA();
                tablaLaptops = reporteDA.ListarLaptopsInventario();
                tablaProcesadoresModelos = reporteDA.tablaProcesadoresModelos(idCategoriaProcesador);
                tablaProcesadoresGeneracion = reporteDA.tablaProcesadoresGeneracion(codTablaProcesadorGeneracion);

                laptops = new BindingList<LC>();
                tablaDisco = reporteDA.ListarLaptopDisco();
                tablaMemoria = reporteDA.ListarLaptopMemoria();
                tablaLicencia = reporteDA.ListarLaptopLicencia();
                DataView viewDisco = new DataView(tablaDisco);
                DataView viewMemoria = new DataView(tablaMemoria);
                DataView viewLicencia = new DataView(tablaLicencia);
                int rec = 0;
                while (rec < tablaLaptops.Rows.Count)
                {
                    LC laptop = new LC();
                    laptop.IdLC = Convert.ToInt32(tablaLaptops.Rows[rec]["idLC"].ToString());
                    laptop.Codigo = tablaLaptops.Rows[rec]["codigo"].ToString();
                    laptop.IdMarca = int.Parse(tablaLaptops.Rows[rec]["idMarca"].ToString());
                    laptop.MarcaLC = tablaLaptops.Rows[rec]["marcaLC"].ToString();
                    laptop.NombreModeloLC = tablaLaptops.Rows[rec]["nombreModeloLC"].ToString();
                    laptop.TamanoPantalla = double.Parse(tablaLaptops.Rows[rec]["tamanoPantalla"].ToString());
                    laptop.TipoProcesador = tablaLaptops.Rows[rec]["tipoProcesador"].ToString();
                    laptop.IdGeneracionProcesador = int.Parse(tablaLaptops.Rows[rec]["idGeneracionProcesador"].ToString());
                    laptop.GeneracionProcesador = int.Parse(tablaLaptops.Rows[rec]["generacionProcesador"].ToString());
                    laptop.IdTipoProcesador = int.Parse(tablaLaptops.Rows[rec]["idTipoProcesador"].ToString());
                    laptop.NombreModeloVideo = tablaLaptops.Rows[rec]["nombreModeloVideo"].ToString().Length > 0 ? tablaLaptops.Rows[rec]["nombreModeloVideo"].ToString() : "";
                    laptop.CapacidadVideo = Convert.ToInt32(tablaLaptops.Rows[rec]["capacidadVideo"].ToString());
                    laptop.EstadoNombre = tablaLaptops.Rows[rec]["estado"].ToString();
                    /*
                    if (tablaLaptops.Rows[rec]["fecTraslado"].ToString() == " ")
                    {
                        laptop.FechaTraslado = "";
                    }
                    else
                    {
                        laptop.FechaTraslado = tablaLaptops.Rows[rec]["fecTraslado"].ToString();
                    }
                    */
                    
                    if (laptop.EstadoNombre == "DISPONIBLE")
                    {
                        if (laptop.GeneracionProcesador <= this.GeneracionDesfasado)
                        {
                            laptop.EstadoNombre = "DESFASADO";
                        }
                    }

                    laptop.Estado = int.Parse(tablaLaptops.Rows[rec]["idEstado"].ToString());
                    laptop.Cliente = tablaLaptops.Rows[rec]["cliente"].ToString();
                    laptop.RucCliente = tablaLaptops.Rows[rec]["rucCliente"].ToString();
                    laptop.Ubicacion = tablaLaptops.Rows[rec]["ubicacion"].ToString();
                    laptop.SerieFabrica = tablaLaptops.Rows[rec]["serieFabrica"].ToString();

                    
                    laptop.IdSede = tablaLaptops.Rows[rec]["idSede"].ToString();
                    laptop.IdSalida= tablaLaptops.Rows[rec]["idSalidaAlquilado"].ToString();
                    laptop.FechaTraslado = tablaLaptops.Rows[rec]["fecTraslado"].ToString();

                    if(laptop.EstadoNombre == "ALQUILADO" || laptop.EstadoNombre == "PERSONAL PCR" || laptop.EstadoNombre == "PRESTADO" || laptop.EstadoNombre == "VENDIDO")
                        laptop.TipoSede = " ";
                    else
                        laptop.TipoSede= tablaLaptops.Rows[rec]["Sede"].ToString();

                    viewDisco.RowFilter = "idLC = " + laptop.IdLC.ToString();
                    viewMemoria.RowFilter = "idLC = " + laptop.IdLC.ToString();
                    viewLicencia.RowFilter = "idLC = " + laptop.IdLC.ToString();
                    laptop.SetDisco(viewDisco);
                    laptop.SetMemoria(viewMemoria);
                    laptop.SetLicencia(viewLicencia);

                    if (laptop.Discos.Count > 0)
                    {
                        if (laptop.Discos.Count == 1)
                        {
                            laptop.Disco1 = laptop.Discos[0].TipoDisco;
                            laptop.CapacidadDisco1 = (laptop.Discos[0].Cantidad * laptop.Discos[0].Capacidad).ToString() + " GB";
                            laptop.Disco2 = "";
                            laptop.CapacidadDisco2 = "";
                        }
                        else if (laptop.Discos.Count >= 2)
                        {
                            laptop.Disco1 = laptop.Discos[0].TipoDisco;
                            laptop.CapacidadDisco1 = (laptop.Discos[0].Cantidad * laptop.Discos[0].Capacidad).ToString() + " GB";

                            laptop.Disco2 = laptop.Discos[1].TipoDisco;
                            laptop.CapacidadDisco2 = (laptop.Discos[1].Cantidad * laptop.Discos[1].Capacidad).ToString() + " GB";
                        }
                    }
                    else if (laptop.Discos.Count == 0)
                    {
                        laptop.Disco1 = "";
                        laptop.CapacidadDisco1 = "";
                        laptop.Disco2 = "";
                        laptop.CapacidadDisco2 = "";
                    }

                    int capacidadMem = 0;
                    foreach (Memoria mem in laptop.Memorias)
                    {
                        capacidadMem += mem.Capacidad * mem.Cantidad;
                    }
                    laptop.CapacidadMemoria = capacidadMem.ToString() + " GB";

                    Licencia windows = null; Licencia office = null; Licencia antivirus = null;

                    if (laptop.Licencias.Count > 0)
                    {
                        windows = laptop.Licencias.SingleOrDefault(p => p.Categoria == this.licenciaCategoriaSO);
                        office = laptop.Licencias.SingleOrDefault(p => p.Categoria == this.licenciaCategoriaOffice);
                        antivirus = laptop.Licencias.SingleOrDefault(p => p.Categoria == this.licenciaCategoriaAntivirus);

                    }

                    laptop.LicenciaWindows = (windows != null) ? windows.Version : "";
                    laptop.LicenciaOffice = (office != null) ? office.Version : "";
                    laptop.LicenciaAntivirus = (antivirus != null) ? antivirus.Version : "";

                    laptop.Licencias = null;
                    laptop.Discos = null;
                    laptop.Memorias = null;

                    laptop.LicenciaWindows = tablaLaptops.Rows[rec]["VersionWindows"].ToString();
                    laptop.LicenciaOffice = tablaLaptops.Rows[rec]["VersionOffice"].ToString();

                    //laptop.IdSalida = tablaLaptops.Rows[rec]["idSalida"].ToString();

                    laptops.Add(laptop);
                    rec++;
                }

                this.cantGeneraciones = tablaProcesadoresGeneracion.Rows.Count;
                this.cantModeloProcesador = tablaProcesadoresModelos.Rows.Count;

                this.arregloLCGeneral = new int[cantGeneraciones][];
                this.arregloLCApple = new int[cantGeneraciones][];

                for (int i = 0; i < this.cantGeneraciones; i++)
                {
                    this.arregloLCGeneral[i] = new int[this.cantModeloProcesador];
                    this.arregloLCApple[i] = new int[this.cantModeloProcesador];

                    for (int j = 0; j < this.cantModeloProcesador; j++)
                    {
                        int idGen = int.Parse(tablaProcesadoresGeneracion.Rows[i]["idAuxiliar"].ToString());
                        int idModPro = int.Parse(tablaProcesadoresModelos.Rows[j]["idModelo"].ToString());
                        var cantidad = new BindingList<LC>(laptops.Where(p => p.IdMarca != this.idMarcaAppleLC && p.IdGeneracionProcesador == idGen && p.IdTipoProcesador == idModPro && p.IdMarca != this.idMarcaApplePC && p.Estado == this.estadoDisponible).ToList());
                        this.arregloLCGeneral[i][j] = cantidad.Count;
                        cantidad = new BindingList<LC>(laptops.Where(p => p.IdMarca == this.idMarcaAppleLC && p.IdGeneracionProcesador == idGen && p.IdTipoProcesador == idModPro && p.IdMarca != this.idMarcaApplePC && p.Estado == this.estadoDisponible).ToList());
                        this.arregloLCApple[i][j] = cantidad.Count;
                    }
                }


                dgvLaptops.DataSource = laptops;
                vista.OptionsBehavior.AutoPopulateColumns = false;
                vista.OptionsSelection.MultiSelect = true;


                dgvLaptops.Refresh();

            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message); OMITIMOS EL MENSAJE
            }


            return true;
        }

        private void frmReporteStocksLaptops_Load(object sender, EventArgs e)
        {

            cargarData.PerformClick();

        }

        private void dgvLaptops_MouseHover(object sender, EventArgs e)
        {
            //label1.Text = $"CANTIDAD FILTRADA:";
            txtCantidadFiltrada.Text = vista.RowCount.ToString();
        }

        private void dgvLaptops_MouseLeave(object sender, EventArgs e)
        {
            //label1.Text = $"CANTIDAD FILTRADA:";
            txtCantidadFiltrada.Text = vista.RowCount.ToString();
        }



        private void vista_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            txtCantidadFiltrada.Text = vista.RowCount.ToString();
        }

    

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            panel7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width,
                 panel7.Height, 30, 30));
        }

        int posY = 0;
        int posX = 0;
        private void pnlInv_MouseMove(object sender, MouseEventArgs e)
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
