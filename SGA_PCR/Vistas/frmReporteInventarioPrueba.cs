﻿using AccesoDatos;
using DevComponents.DotNetBar.SuperGrid;
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
using System.Runtime.InteropServices;

namespace Apolo
{
    public partial class frmReporteInventarioPrueba : Form
    {

        DataTable tablaLaptops;
        ReporteDA reporteDA;
        private int idUsuario;
        private string nombreUsuario = "CEAS";
        DataTable tablaDisco;
        DataTable tablaMemoria;
        DataTable tablaLicencia;

        DataTable tablaProcesadoresModelos;
        DataTable tablaProcesadoresGeneracion;

        private BindingList<LC> laptops;

        private string licenciaCategoriaSO = "S.O";
        private string licenciaCategoriaOffice = "OFFICE";
        private string licenciaCategoriaAntivirus = "ANTIVIRUS";
        private int estadoDisponible=2;

        private int idMarcaAppleLC = 1;
        private int idMarcaApplePC = 8;
        private int idCategoriaProcesador = 9;
        private string codTablaProcesadorGeneracion = "PROCESADOR_GENERACION";
        private int cantGeneraciones;
        private int cantModeloProcesador;
        private int[][] arregloLCGeneral;
        private int[][] arregloLCApple;

        public frmReporteInventarioPrueba()
        {
            InitializeComponent();
            Inicializado();
        }

        public frmReporteInventarioPrueba(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
        }

        public void Inicializado()
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
                laptop.TipoProcesador = tablaLaptops.Rows[rec]["tipoProcesador"].ToString();
                laptop.IdGeneracionProcesador = int.Parse(tablaLaptops.Rows[rec]["idGeneracionProcesador"].ToString());
                laptop.GeneracionProcesador= int.Parse(tablaLaptops.Rows[rec]["generacionProcesador"].ToString());
                laptop.IdTipoProcesador = int.Parse(tablaLaptops.Rows[rec]["idTipoProcesador"].ToString());
                laptop.NombreModeloVideo = tablaLaptops.Rows[rec]["nombreModeloVideo"].ToString().Length > 0 ? tablaLaptops.Rows[rec]["nombreModeloVideo"].ToString() : "";
                laptop.CapacidadVideo = Convert.ToInt32(tablaLaptops.Rows[rec]["capacidadVideo"].ToString());
                laptop.EstadoNombre = tablaLaptops.Rows[rec]["estado"].ToString();
                laptop.Estado = int.Parse(tablaLaptops.Rows[rec]["idEstado"].ToString());
                laptop.Cliente = tablaLaptops.Rows[rec]["cliente"].ToString();
                laptop.Ubicacion = tablaLaptops.Rows[rec]["ubicacion"].ToString();
                laptop.SerieFabrica = tablaLaptops.Rows[rec]["serieFabrica"].ToString();
                viewDisco.RowFilter = "idLC = " + laptop.IdLC.ToString();
                viewMemoria.RowFilter = "idLC = " + laptop.IdLC.ToString();
                viewLicencia.RowFilter = "idLC = " + laptop.IdLC.ToString();
                laptop.SetDisco(viewDisco);
                laptop.SetMemoria(viewMemoria);
                laptop.SetLicencia(viewLicencia);

                string tipoDisco1 = ""; int capDisco1 = 0; string tipoDisco2 = ""; int capDisco2 = 0;
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

                //laptop.IdSalida = tablaLaptops.Rows[rec]["idSalida"].ToString();

                laptops.Add(laptop);
                rec++;
            }

            dgvLaptops.DataSource = laptops;

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
                    var cantidad = new BindingList<LC>(laptops.Where(p => p.IdMarca != this.idMarcaAppleLC && p.IdGeneracionProcesador == idGen && p.IdTipoProcesador == idModPro && p.IdMarca != this.idMarcaApplePC && p.Estado==this.estadoDisponible).ToList());
                    this.arregloLCGeneral[i][j] = cantidad.Count;
                    cantidad = new BindingList<LC>(laptops.Where(p => p.IdMarca == this.idMarcaAppleLC && p.IdGeneracionProcesador == idGen && p.IdTipoProcesador == idModPro && p.IdMarca != this.idMarcaApplePC && p.Estado == this.estadoDisponible).ToList());
                    this.arregloLCApple[i][j] = cantidad.Count;
                }
            }

            vista.GetFocusedValue();


        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void EnviarCodigo(string correo, string body, out string codigo, out int idUsuario)
        {
            
            idUsuario = 1;
            codigo = "123456";

            /*-------------------------MENSAJE DE CORREO----------------------*/

            //Creamos un nuevo Objeto de mensaje
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            //Direccion de correo electronico a la que queremos enviar el mensaje
            mmsg.To.Add(correo);
            mmsg.CC.Add("carlos.arango@leasein.pe");

            //Nota: La propiedad To es una colección que permite enviar el mensaje a más de un destinatario

            //Asunto
            mmsg.Subject = "Corte de Alquiler";
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

            //Direccion de correo electronico que queremos que reciba una copia del mensaje
            //mmsg.Bcc.Add("lucet.lp2@gmail.com"); //Opcional

            //Cuerpo del Mensaje
            mmsg.Body = body;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true; //Si no queremos que se envíe como HTML

            //Correo electronico desde la que enviamos el mensaje
            mmsg.From = new System.Net.Mail.MailAddress("apolo.leasein@gmail.com");

            /*-------------------------CLIENTE DE CORREO----------------------*/

            //Creamos un objeto de cliente de correo
            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

            //Hay que crear las credenciales del correo emisor
            cliente.UseDefaultCredentials = false;
            cliente.Credentials =
                new System.Net.NetworkCredential("apolo.leasein@gmail.com", "Apolo2021");
            //https://www.google.com/settings/security/lesssecureapps
            //Lo siguiente es obligatorio si enviamos el mensaje desde Gmail

            cliente.Port = 587;
            cliente.EnableSsl = true;


            cliente.Host = "smtp.gmail.com"; //Para Gmail "smtp.gmail.com";

            cliente.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;

            /*-------------------------ENVIO DE CORREO----------------------*/

            try
            {
                //Enviamos el mensaje      
                cliente.Send(mmsg);
                return;
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                MessageBox.Show(ex.Message);
                //Aquí gestionamos los errores al intentar enviar el correo
                return;

            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            int idUsuario;
            string codigo;
            string body = @"<html>
                            <head>
                            <style>
                            table {
                              width:100%;
                            }
                            table, th, td {
                              border: 1px solid black;
                              border-collapse: collapse;
                            }
                            th, td {
                              padding: 15px;
                              text-align: left;
                            }
                            #t01 tr:nth-child(even) {
                              background-color: #eee;
                            }
                            #t01 tr:nth-child(odd) {
                             background-color: #fff;
                            }
                            #t01 th {
                              background-color: orange;
                              color: white;
                            }
                            </style>
                            </head>
                            <body>

                        <h1>Datalle sobre el recojo de los equipos</h1></br>

                        <table id='t01'>
                          <tr>
                            <th>Código Equipo</th>
                            <th>Tipo Equipo</th>
                            <th>Fecha Corte</th>
                          </tr>
                        ";
            string cadena = "";
            foreach(LC laptop in laptops)
            {
                cadena += "<tr>";
                cadena += "<td>" + laptop.Codigo + "</td>";
                cadena += "<td>" + "LAPTOP" + "</td>";
                cadena += "<td>" + "2021/01/08" + "</td>";
                cadena += "</tr>";
            }
            cadena += "</table> </ body > </ html > ";
            body += cadena;
            EnviarCodigo("c.arango@pucp.pe",body, out codigo, out idUsuario);
            //if (MessageBox.Show("Estas seguro que desea Exportar el reporte", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            //{
            //    Cursor.Current = Cursors.WaitCursor;
            //    try
            //    {

            //        SaveFileDialog fichero = new SaveFileDialog();
            //        //fichero.Filter = "Excel (*.xls)|*.xls";
            //        fichero.Filter = "Excel(*.xlsx) | *.xlsx";
            //        fichero.FileName = "Laptops";
            //        if (fichero.ShowDialog() == DialogResult.OK)
            //        {
            //            Excel.Application aplicacion;
            //            Excel.Workbook libros_trabajo;
            //            Excel.Worksheet hoja_pre_alquiler;

            //            aplicacion = new Excel.Application();
            //            libros_trabajo = (Excel.Workbook)aplicacion.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);

            //            hoja_pre_alquiler = (Excel.Worksheet)libros_trabajo.Worksheets.Add();
            //            hoja_pre_alquiler.Name = "Laptops";
            //            string cabecera = "Equipos Disponibles";
            //            ExportarDataGridViewExcel(ref hoja_pre_alquiler, cabecera);


            //            ((Excel.Worksheet)aplicacion.ActiveWorkbook.Sheets["Hoja1"]).Delete();

            //            libros_trabajo.SaveAs(fichero.FileName, Excel.XlFileFormat.xlOpenXMLWorkbook);
            //            libros_trabajo.Close(true);
            //            releaseObject(libros_trabajo);
            //            aplicacion.Quit();
            //            releaseObject(aplicacion);
            //            MessageBox.Show("Se generó el reporte con éxito", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString(), "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //    }
            //    Cursor.Current = Cursors.Default;
            //}
        }

        public void ExportarDataGridViewExcel(ref Excel.Worksheet hoja_trabajo, string nombreCabecera)
        {
            Excel.Range rango;

            
            int cantColumnas = tablaProcesadoresGeneracion.Rows.Count + 3;
            int filas = vista.RowCount;


            int k = cantColumnas-1 + 64;
            char columF = (char)k;
            int fila2 = 3;
            string filaBorde = fila2.ToString();
            char columI = 'A';
            //Ponemos borde a las celdas
            rango = hoja_trabajo.Range[columI + fila2.ToString(), columF + fila2.ToString()];
            rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            rango.Style.Font.Bold = false;


            for (int i = 1; i <= this.cantModeloProcesador*2 + 4; i++)
            {
                rango = hoja_trabajo.Range[columI + i.ToString(), columF + i.ToString()];
                rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            }

            for (int i = 0; i < this.cantGeneraciones; i++)
            {
                int cantGenLCGeneral = 0;
                int cantGenLCApple = 0;
                for (int j = 0; j < this.cantModeloProcesador; j++)
                {
                    string generacion = tablaProcesadoresGeneracion.Rows[i]["descripcion"].ToString();
                    string nombreProcesador = tablaProcesadoresModelos.Rows[j]["nombre"].ToString();

                    hoja_trabajo.Cells[fila2 + 1 + j, i + 2] = arregloLCGeneral[i][j];

                    hoja_trabajo.Cells[fila2 + 1+ cantModeloProcesador + 1 + j, i + 2] = arregloLCApple[i][j];

                    cantGenLCGeneral += arregloLCGeneral[i][j];
                    cantGenLCApple += arregloLCApple[i][j];
                }
                hoja_trabajo.Cells[fila2, i + 2] = cantGenLCGeneral;
                hoja_trabajo.Cells[fila2 + cantModeloProcesador + 1, i + 2] = cantGenLCApple;
            }


            for (int j = 0; j < this.cantModeloProcesador; j++)
            {
                int cantProLCGeneral = 0;
                int cantProLCApple = 0;
                for (int i = 0; i < this.cantGeneraciones; i++)
                {
                    cantProLCGeneral += arregloLCGeneral[i][j];
                    cantProLCApple += arregloLCApple[i][j];
                }
                hoja_trabajo.Cells[fila2+1+j, cantGeneraciones + 2] = cantProLCGeneral;
                hoja_trabajo.Cells[fila2 + cantModeloProcesador + 1 + 1 + j, cantGeneraciones + 2] = cantProLCApple;
            }

            var cantidadLCGeneral = new BindingList<LC>(laptops.Where(p => p.IdMarca != this.idMarcaAppleLC && p.IdMarca != this.idMarcaApplePC && p.Estado == this.estadoDisponible).ToList());
            var cantidadLCApple = new BindingList<LC>(laptops.Where(p => p.IdMarca == this.idMarcaAppleLC && p.IdMarca != this.idMarcaApplePC && p.Estado == this.estadoDisponible).ToList());

            hoja_trabajo.Cells[fila2, cantGeneraciones + 2] = cantidadLCGeneral.Count;
            hoja_trabajo.Cells[fila2 + cantModeloProcesador + 1, cantGeneraciones + 2] = cantidadLCApple.Count; 

            montaCabeceras(1, ref hoja_trabajo, nombreCabecera);
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
                hoja.Range[hoja.Cells[fila, 1], hoja.Cells[fila, cantColumnas]].Interior.Color = Color.FromArgb(196, 89, 19);//FromArgb(255, 132, 0)
                hoja.Range[hoja.Cells[fila, 1], hoja.Cells[fila, cantColumnas]].Style.Font.Bold = true;

                hoja.Range[hoja.Cells[fila + 1, 1], hoja.Cells[fila + 1, cantColumnas-1]].Interior.Color = Color.FromArgb(196, 89, 19);
                hoja.Range[hoja.Cells[fila + 1, cantColumnas], hoja.Cells[fila + 1, cantColumnas]].Interior.Color = Color.FromArgb(130, 61, 10);

                hoja.Range[hoja.Cells[fila + 2, 1], hoja.Cells[fila + 2, cantColumnas]].Interior.Color = Color.FromArgb(252, 228, 215);
                hoja.Range[hoja.Cells[fila + 3 + cantModeloProcesador, 1], hoja.Cells[fila + 3 + cantModeloProcesador, cantColumnas]].Interior.Color = Color.FromArgb(252, 228, 215);

                //Centramos los textos
                rango = hoja.Rows[fila];
                rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                
                for (int k = 0; k < cantGeneraciones; k++)
                {
                    string genPro = tablaProcesadoresGeneracion.Rows[k]["descripcion"].ToString();
                    hoja.Cells[fila + 1, k+2] = genPro;
                }

                hoja.Cells[fila + 1, cantGeneraciones + 2] = "Total en Almacen";
                hoja.Cells[fila + 1, 1] = "Generación";
                hoja.Cells[fila + 2, 1] = "LAPTOP";

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

                for (int j = 0; j < cantColumnas+2; j++)
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

        private void vista_KeyUp(object sender, KeyEventArgs e)
        {
            //if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.N))
            //{
            //    string aux = vista.GetFocusedValue().ToString();
            //    MessageBox.Show(aux);
            //    Clipboard.SetText(aux);
            //}
        }
    }
}
