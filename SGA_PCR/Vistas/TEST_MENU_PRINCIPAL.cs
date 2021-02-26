using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Modelo;
using AccesoDatos;
using DevComponents.DotNetBar.SuperGrid;
using DevExpress.Export;
using DevExpress.Printing.ExportHelpers;
using DevExpress.XtraPrinting;
using Excel = Microsoft.Office.Interop.Excel;
using DevExpress.XtraGrid.Views.Grid;

namespace Apolo
{
    public partial class TEST_MENU_PRINCIPAL : Form
    {
        int canDisponibles = 0;

        DataTable tablaLaptops;
        DataTable tablaMontos;
        ReporteDA reporteDA;
        private int idUsuario;
        private string nombreUsuario = "CEAS";
        DataTable tablaDisco;
        DataTable tablaMemoria;
        DataTable tablaLicencia;
        DataTable MontoFacturadoMes;

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

        Accesos_usuarios accesos_usuarios;
        AccesosUsuarioDA accesos_usuarioDA;

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

        private int idUser;
        private string nameUser;


        private int totalDispo = 0;
        private int totalPronosticador = 0;

        private int GeneracionDesfasado = 3;
        

        public TEST_MENU_PRINCIPAL(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            Inicializado(idUsuario, nombreUsuario);
        }

        public void Inicializado(int idUsuario, string nombreUsuario)
        {
            accesos_usuarioDA = new AccesosUsuarioDA();
            accesos_usuarios = new Accesos_usuarios();

            this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 1300, 650, 20, 20));
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;

            lblFecPronosticador.Text = "<- Seleccione una fecha";
            lblCantidadTotal.Text = "";
            int DiaMinimo = DateTime.Now.Day;
            CalendarioDash.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DiaMinimo);

            panelArchivo.Visible = false;
            panelProceso.Visible = false;
            panelReporte.Visible = false;
            panelConfiguracion.Visible = false;
            MenuVertical.Width = 0;

            usuarioConectado.Text = idUsuario.ToString();
            this.idUser = idUsuario;
            this.nameUser = nombreUsuario;

            verificandoPermisos();

            //NUEVO DASH
            CargarInventarioDash();
            CargarFacturacionDash();
        }
        
        private void verificandoPermisos()
        {
            //BLOQUEAR O DESBLOQUEAR ITEMS DENTRO DE ARCHIVO-------------------
            Button[] botones_archivo = 
            { btnMProcesador, btnMDisco, btnMMemoria, btnMTarjetaVideo, btnMCliente, btnMSucursal, btnMProveedor,btnMKAM,btnMLicencias,
                btnPCompra, btnPDevolucion, btnPAlquiler, btnPCambio, btnPSubirFactura, btnPReparacion, btnPCambioComp, btnPCambioDescr, btnPLevantarObser,btnPMovInternos,btnPCorteAlquiler,btnPNotaCredito,btnPFacturasTrans,btnPTarifas,
                brnRCuadroVenc,  btnRPendienteFact, btnRPendienteRec, btnRObservacionDeu, btnRInventario, btnRMemorias, btnRDiscos, btnRLicencias, btnRReparacion,btnRFacturasTrans,btnRFacturas,btnAlquileres,btnRCorteAlquiler,
                btnCUsuarios, btnCPermisos};
            string[] idSubmodulo_archivo = 
            { "1a", "2a", "3a", "4a", "5a", "6a", "7a", "8a", "9a",
              "1b", "2b", "3b", "5b", "6b", "7b", "8b", "9b", "10b","11b","12b","13b","14b","15b",
              "1c", "3c", "4c", "5c", "7c", "8c", "9c", "10c","13c","14c","15c","16c","17c",
              "1d", "2d" };

            List<string> accesos = new List<string>();
            accesos = accesos_usuarioDA.Obtener_accessos(this.idUser);
            int index = 0;

            foreach (string codigo in accesos)
            {
                index = Array.IndexOf(idSubmodulo_archivo, codigo);
                botones_archivo[index].Enabled = true;
            }

        }
        
        private void TEST_MENU_PRINCIPAL_Load(object sender, EventArgs e)
        {            
            //lblFecPronosticador.Text = "<- Seleccione una fecha";
            //lblCantidadTotal.Text = "";
            //int DiaMinimo= DateTime.Now.Day;
            //CalendarioDash.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DiaMinimo);
        }
             
        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
        
        private void pnlLaptopsDisponibles_Paint(object sender, PaintEventArgs e)
        {
            pnlLaptopsDisponibles.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlLaptopsDisponibles.Width,
                 pnlLaptopsDisponibles.Height, 30, 30));
        }

        private void pnlPronosticadorInfo_Paint(object sender, PaintEventArgs e)
        {
            pnlPronosticadorInfo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlPronosticadorInfo.Width,
                 pnlPronosticadorInfo.Height, 30, 30));
        }

        private void pnlResumenInventario_Paint(object sender, PaintEventArgs e)
        {
            pnlResumenInventario.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlResumenInventario.Width,
                 pnlResumenInventario.Height, 30, 30));
        }

        //========================================== NUEVO DASH
        
        private void CargarInventarioDash()
        {
            reporteDA = new ReporteDA();
            tablaLaptops = reporteDA.ListarLaptopsInventario();
            tablaProcesadoresModelos = reporteDA.tablaProcesadoresModelos(idCategoriaProcesador);
            tablaProcesadoresGeneracion = reporteDA.tablaProcesadoresGeneracion(codTablaProcesadorGeneracion);
            laptops = new BindingList<LC>();
   

            int rec = 0;
            while (rec < tablaLaptops.Rows.Count)
            {
                LC laptop = new LC();
                laptop.IdMarca = int.Parse(tablaLaptops.Rows[rec]["idMarca"].ToString());
                laptop.IdGeneracionProcesador = int.Parse(tablaLaptops.Rows[rec]["idGeneracionProcesador"].ToString());
                laptop.GeneracionProcesador = int.Parse(tablaLaptops.Rows[rec]["generacionProcesador"].ToString()); 
                laptop.IdTipoProcesador = int.Parse(tablaLaptops.Rows[rec]["idTipoProcesador"].ToString());
                laptop.Estado = int.Parse(tablaLaptops.Rows[rec]["idEstado"].ToString());
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
                    var cantidad = new BindingList<LC>(laptops.Where(p => p.IdMarca != this.idMarcaAppleLC && p.GeneracionProcesador> this.GeneracionDesfasado && p.IdGeneracionProcesador == idGen && p.IdTipoProcesador == idModPro && p.IdMarca != this.idMarcaApplePC && p.Estado == this.estadoDisponible).ToList());
                    this.arregloLCGeneral[i][j] = cantidad.Count;
                    cantidad = new BindingList<LC>(laptops.Where(p => p.IdMarca == this.idMarcaAppleLC && p.GeneracionProcesador > this.GeneracionDesfasado && p.IdGeneracionProcesador == idGen && p.IdTipoProcesador == idModPro && p.IdMarca != this.idMarcaApplePC && p.Estado == this.estadoDisponible).ToList());
                    this.arregloLCApple[i][j] = cantidad.Count;
                }
            }


            dgvLapDispo.DataSource = laptops;
            vistaLapDispo.OptionsBehavior.AutoPopulateColumns = false;
            vistaLapDispo.OptionsSelection.MultiSelect = true;



            //-------------------------------------------------
            DataTable resumen = new DataTable();
            resumen.Columns.Add("PROCESADORdash");
            resumen.Columns.Add("LAPdash");
            resumen.Columns.Add("MACdash");
            DataRow dr = null;


            //CANTIDAD DE LAPTOP POR PROCESADOR -> LAP Y MAC
            for (int j = 0; j < this.cantModeloProcesador; j++)
            {
                dr = resumen.NewRow();
                dr["PROCESADORdash"] = tablaProcesadoresModelos.Rows[j]["nombre"].ToString();
                int cantProLCGeneral = 0;
                int cantProLCApple = 0;
                for (int i = 0; i < this.cantGeneraciones; i++)
                {
                    cantProLCGeneral += arregloLCGeneral[i][j];
                    cantProLCApple += arregloLCApple[i][j];
                }
                dr["LAPdash"] = cantProLCGeneral.ToString();
                dr["MACdash"] = cantProLCApple.ToString();
                totalDispo = totalDispo + cantProLCGeneral + cantProLCApple;
                resumen.Rows.Add(dr);
            }


            lblTotalDispo.Text = totalDispo.ToString();


            dgvLapDispo.DataSource = resumen;
            vistaLapDispo.OptionsBehavior.AutoPopulateColumns = false;
            vistaLapDispo.OptionsSelection.MultiSelect = true;

            //CARGAR FECHA ACTUAL
            lblFechaActual.Text = $"Fecha: {DateTime.Now.ToShortDateString()}";
            lblFecPron.Text = "Seleccione fecha";
            
        }

        private void pnlProsticar_Paint(object sender, PaintEventArgs e)
        {
            pnlProsticar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlProsticar.Width,
                 pnlProsticar.Height, 20, 20));
        }
              
        private void pnlProsticar_Click(object sender, EventArgs e)
        {
            CalendarioDash.Visible = true;
        }

        private void CargarInventarioPronosticadorDash()
        {
            laptops = new BindingList<LC>();

            List<String> codigosPronosticador = new List<String>();
            int canDisponibles = 0;


            //PENDIENTE POR RECOGER
            reporteDA = new ReporteDA();
            tablaLaptops = reporteDA.ListarLaptopsPorRecogerDASH();


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
                laptop.GeneracionProcesador = int.Parse(tablaLaptops.Rows[rec]["generacionProcesador"].ToString());
                laptop.IdTipoProcesador = int.Parse(tablaLaptops.Rows[rec]["idTipoProcesador"].ToString());
                laptop.EstadoNombre = tablaLaptops.Rows[rec]["estado"].ToString();
                laptop.Estado = int.Parse(tablaLaptops.Rows[rec]["idEstado"].ToString());

                laptops.Add(laptop);
                rec++;
            }

            tablaLaptops = reporteDA.ListarLaptopsPorVencerPRONOSTICADOR();

            DataView aux = new DataView(tablaLaptops);
            aux.RowFilter = $"fecFinContrato < #{CalendarioDash.SelectionRange.Start.ToString("yyyy-MM-dd")}#";
            rec = 0;


            foreach (DataRowView row in aux)
            {
                LC laptop = new LC();
                laptop.IdLC = Convert.ToInt32(row["idLC"].ToString());
                laptop.Codigo = row["Codigo"].ToString();
                laptop.IdMarca = Convert.ToInt32(row["idMarca"].ToString());
                laptop.MarcaLC = row["MarcaLC"].ToString();
                laptop.NombreModeloLC = row["NombreModeloLC"].ToString();
                laptop.TipoProcesador = row["TipoProcesador"].ToString();
                laptop.IdGeneracionProcesador = Convert.ToInt32(row["idGeneracionProcesador"].ToString());
                laptop.GeneracionProcesador = Convert.ToInt32(row["GeneracionProcesador"].ToString());
                laptop.IdTipoProcesador = Convert.ToInt32(row["idTipoProcesador"].ToString());
                laptop.EstadoNombre = row["estado"].ToString();
                laptop.Estado = Convert.ToInt32(row["idEstado"].ToString());

                laptops.Add(laptop);
                rec++;
            }



            //MessageBox.Show(laptops.Count.ToString());

            canDisponibles = laptops.Count;
      

            //!---------------------------------------------------------------------
            lblFecPron.Text = $"Fecha: {CalendarioDash.SelectionRange.Start.ToShortDateString()}";
        

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
                    var cantidad = new BindingList<LC>(laptops.Where(p => p.IdMarca != this.idMarcaAppleLC && p.GeneracionProcesador > this.GeneracionDesfasado && p.IdGeneracionProcesador == idGen && p.IdTipoProcesador == idModPro && p.IdMarca != this.idMarcaApplePC).ToList());
                    this.arregloLCGeneral[i][j] = cantidad.Count;
                    cantidad = new BindingList<LC>(laptops.Where(p => p.IdMarca == this.idMarcaAppleLC && p.GeneracionProcesador > this.GeneracionDesfasado && p.IdGeneracionProcesador == idGen && p.IdTipoProcesador == idModPro && p.IdMarca != this.idMarcaApplePC).ToList());
                    this.arregloLCApple[i][j] = cantidad.Count;
                }
            }

            //-------------------------------------------------
            DataTable resumen = new DataTable();
            resumen.Columns.Add("PROCESADORprono");
            resumen.Columns.Add("LAPprono");
            resumen.Columns.Add("MACprono");
            DataRow dr = null;


            //CANTIDAD DE LAPTOP POR PROCESADOR -> LAP Y MAC
            totalPronosticador =0;
            for (int j = 0; j < this.cantModeloProcesador; j++)
            {
                dr = resumen.NewRow();
                dr["PROCESADORprono"] = tablaProcesadoresModelos.Rows[j]["nombre"].ToString();
                int cantProLCGeneral = 0;
                int cantProLCApple = 0;
                for (int i = 0; i < this.cantGeneraciones; i++)
                {
                    cantProLCGeneral += arregloLCGeneral[i][j];
                    cantProLCApple += arregloLCApple[i][j];
                }
                dr["LAPprono"] = cantProLCGeneral.ToString();
                dr["MACprono"] = cantProLCApple.ToString();


                totalPronosticador = totalPronosticador + cantProLCGeneral + cantProLCApple;

                resumen.Rows.Add(dr);
            }
            lblTotalProno.Text = totalPronosticador.ToString();
            lblTotalProno.Visible = true;


            dgvLapDispoPronosticador.DataSource = resumen;
            vistaLapDispoPronosticador.OptionsBehavior.AutoPopulateColumns = true;
            vistaLapDispoPronosticador.OptionsSelection.MultiSelect = true;
      


            lblFecPronosticador.Text = "Fecha: " + CalendarioDash.SelectionRange.Start.ToShortDateString();
            lblCantidadTotal.Text= (totalPronosticador + totalDispo).ToString();

        }

        private void CalendarioDash_DateSelected(object sender, DateRangeEventArgs e)
        {
            CalendarioDash.Visible = false;
            CargarInventarioPronosticadorDash();
        }

        private void lblInvtoFact_Click(object sender, EventArgs e)
        {
            pnlInventarioOfi.Visible = false;
            pnlFacturacionOfi.Visible = true;
        }

        private void panel9_Paint_1(object sender, PaintEventArgs e)
        {
            panel9.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel9.Width,
                 panel9.Height, 30, 30));
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            panel10.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel10.Width,
                 panel10.Height, 30, 30));
        }

        private void CargarFacturacionDash()
        {
            reporteDA = new ReporteDA();
            tablaLaptops = reporteDA.ListarLaptopsPorFacturarDASH();

            dgvFacturacionDash.DataSource = tablaLaptops;
            vistaFacturacionDash.OptionsBehavior.AutoPopulateColumns = false;
            vistaFacturacionDash.OptionsSelection.MultiSelect = true;

            vistaFacturacionDash.Columns["cliente"].GroupIndex = -1;
            

            float MontoPendienteFacturar = 0;
            for (int i = 0; i < vistaFacturacionDash.RowCount; i++)
            {
                MontoPendienteFacturar = MontoPendienteFacturar + float.Parse(tablaLaptops.Rows[i]["DeudaSoles"].ToString());
            }
            
            lblPendientePorFacturar.Text = string.Format("{0:C0}", MontoPendienteFacturar);
            MontoFacturadoMes = reporteDA.VerMontoFacturadoMes();


            lblMontoFacturado.Text = string.Format("{0:C0}", MontoFacturadoMes.Rows[0]["total"]);//MONTO FACTURADO EN EL MES
            if(lblMontoFacturado.Text=="")
                lblMontoFacturado.Text = string.Format("{0:C0}", 0);

            lblFechaMF.Text= $"Desde el 01/{DateTime.Now.Month}/{DateTime.Now.Year} al { DateTime.Now.ToShortDateString()}";

            lblFecPF.Text = $"Al {DateTime.Now.ToShortDateString()}";
            //TOTAL DE MONTOS


            tablaMontos = reporteDA.ListarLaptopsPorFacturarDASH_segun_dias();

            double menor_15 = 0;
            double entre_15_45 = 0;
            double mas_45 = 0;

            for (int i = 0; i < tablaMontos.Rows.Count; i++)
            {
                if (int.Parse(tablaMontos.Rows[i]["diasVencidos"].ToString()) < 15)
                {
                    menor_15 = menor_15 + double.Parse(tablaMontos.Rows[i]["PendienteFacturarSoles"].ToString());
                }
                if (int.Parse(tablaMontos.Rows[i]["diasVencidos"].ToString()) >= 15 && int.Parse(tablaMontos.Rows[i]["diasVencidos"].ToString()) <= 45)
                {
                    entre_15_45 = entre_15_45 + double.Parse(tablaMontos.Rows[i]["PendienteFacturarSoles"].ToString());
                }
                if (int.Parse(tablaMontos.Rows[i]["diasVencidos"].ToString()) > 45)
                {
                    mas_45 = mas_45 + double.Parse(tablaMontos.Rows[i]["PendienteFacturarSoles"].ToString());
                }
            }
        }

        private void lblFactToInv_Click(object sender, EventArgs e)
        {
            pnlFacturacionOfi.Visible = false;
            pnlInventarioOfi.Visible = true;
        }

        private void btnOCDash_Click(object sender, EventArgs e)
        {

            if (pnlInventarioOfi.Visible == true || pnlFacturacionOfi.Visible == true)
            {
                //CERRAR
                pnlInventarioOfi.Visible = false;
                pnlFacturacionOfi.Visible = false;
            }
            else
            {
                if (pnlInventarioOfi.Visible == false && pnlFacturacionOfi.Visible == false)
                {
                    //VOLVER A ABRIR
                    pnlInventarioOfi.Visible = true;
                }
            }

        }

        private void CerrarDash()
        {
            pnlInventarioOfi.Visible = false;
            pnlFacturacionOfi.Visible = false;
        }

        private void lblPronosticar_Click(object sender, EventArgs e)
        {
            CalendarioDash.Visible = true;
        }

        //========================= Menu ==================================

        private void hideSubMenu()
        {
            if (panelArchivo.Visible == true)
                panelArchivo.Visible = false;
            if (panelProceso.Visible == true)
                panelProceso.Visible = false;
            if (panelReporte.Visible == true)
                panelReporte.Visible = false;
            if (panelConfiguracion.Visible == true)
                panelConfiguracion.Visible = false;
        }

        private void showSubMenu(Panel subMenu) //! MOVIMIENTO SUB-MENUS
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }

        private void btnSlideMenu_Click(object sender, EventArgs e) //! MOVIMIENTO SLIDER IZQUIERDA/DERECHA
        {
            if (MenuVertical.Width == 350)
                MenuVertical.Width = 80;
            else
                MenuVertical.Width = 350;
        }

        private void btnExit_Click(object sender, EventArgs e) //! BOTON SALIR DE APOLO
        {
            DialogResult dialogResult = MessageBox.Show("DESEAS SALIR DE APOLO?", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 350)
            {
                pictureBox1.Visible = true;
                MenuVertical.Width = 0;
            }
            else
            {
                pnlFacturacionOfi.Visible = false;
                pnlInventarioOfi.Visible = false;
                pictureBox1.Visible = false;
                MenuVertical.Width = 350;
            }

        }

        private void btnMaestro_Click(object sender, EventArgs e)
        {
            showSubMenu(panelArchivo);
        }

        private void btnProceso_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProceso);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReporte);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            showSubMenu(panelConfiguracion);
        }


        //========================= Maestros ==================================
        private void btnMProcesador_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmArchivoCrearProcesador")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmArchivoCrearProcesador f2 = new frmArchivoCrearProcesador(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnMDisco_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmArchivoCrearDiscoDuro")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmArchivoCrearDiscoDuro f2 = new frmArchivoCrearDiscoDuro(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnMMemoria_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmArchivoCrearMemoria")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmArchivoCrearMemoria f2 = new frmArchivoCrearMemoria(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnMTarjetaVideo_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmArchivoCrearTarjetaVideo")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmArchivoCrearTarjetaVideo f2 = new frmArchivoCrearTarjetaVideo(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnMCliente_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmCrearCliente")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmArchivoCrearCliente f2 = new frmArchivoCrearCliente(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnMSucursal_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmArchivoClienteSucursal")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmArchivoClienteSucursal f2 = new frmArchivoClienteSucursal(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnMProveedor_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmCrearProveedor")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmArchivoCrearProveedor f2 = new frmArchivoCrearProveedor(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnMKAM_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmArchivoKam")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmArchivoKam f2 = new frmArchivoKam(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnMLicencias_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmArchivoLicencias")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmArchivoLicencias f2 = new frmArchivoLicencias(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }


        //========================= Procesos ==================================

        private void btnPNotaCredito_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmProcesoNotaCredito")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmProcesoNotaCredito f2 = new frmProcesoNotaCredito(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnPFacturasTrans_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmProcesoFacturaTransito")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmProcesoFacturaTransito f2 = new frmProcesoFacturaTransito(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnPTarifas_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmProcesoTarifa")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmProcesoTarifa f2 = new frmProcesoTarifa(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnPCompra_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmProcesoIngreso")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmProcesoIngreso f2 = new frmProcesoIngreso(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnPDevolucion_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmProcesoDevolucion")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmProcesoDevolucion f2 = new frmProcesoDevolucion(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnPAlquiler_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmProcesoAlquiler")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmProcesoAlquiler f2 = new frmProcesoAlquiler(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnPRenovacion_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmProcesoRenovacion")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmProcesoRenovacion f2 = new frmProcesoRenovacion(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnPCambio_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmProcesoCambio")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmProcesoCambio f2 = new frmProcesoCambio(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnPSubirFactura_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmProcesoSubirFacturas")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmProcesoSubirFacturas f2 = new frmProcesoSubirFacturas(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnPReparacion_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmProcesoReparacion")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmProcesoReparacion f2 = new frmProcesoReparacion(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnPCambioComp_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmProcesoCambioComponentes")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmProcesoCambioComponentes f2 = new frmProcesoCambioComponentes(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnPCambioDescr_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmProcesoCambioDescripcion")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmProcesoCambioDescripcion f2 = new frmProcesoCambioDescripcion(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnPLevantarObser_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmProcesoLevantamientoObservaciones")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmProcesoLevantamientoObservaciones f2 = new frmProcesoLevantamientoObservaciones(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnPMovInternos_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmProcesoSalida")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmProcesoSalida f2 = new frmProcesoSalida(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnPCorteAlquiler_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmProcesoCorteAlquiler")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmProcesoCorteAlquiler f2 = new frmProcesoCorteAlquiler(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }


        //========================= Reportes ==================================

        private void brnRCuadroVenc_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmReporteCV")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmReporteCV f2 = new frmReporteCV(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnRPendienteFact_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmReportePendienteFacturar")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmReportePendienteFacturar f2 = new frmReportePendienteFacturar(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnRPendienteRec_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmReportePendienteRecoger")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmReportePendienteRecoger f2 = new frmReportePendienteRecoger(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }

        }

        private void btnRObservacionDeu_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmReportePendienteReposicion")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmReportePendienteReposicion f2 = new frmReportePendienteReposicion(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnRLapVencer_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmReporteAlquileresPorVencer")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmReporteAlquileresPorVencer f2 = new frmReporteAlquileresPorVencer(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnRInventario_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmReporteStocksLaptops")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmReporteStocksLaptops f2 = new frmReporteStocksLaptops(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnRMemorias_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmReporteMemoria")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmReporteMemoria f2 = new frmReporteMemoria(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnRDiscos_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmReporteDisco")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmReporteDisco f2 = new frmReporteDisco(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnRLicencias_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmReporteLicencia")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmReporteLicencia f2 = new frmReporteLicencia(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnRReparacion_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmReporteMantenimiento")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmReporteMantenimiento f2 = new frmReporteMantenimiento(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnRAlquileres_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmReporteAlquiler")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmReporteAlquiler f2 = new frmReporteAlquiler(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }
        
        private void btnRFacturasTrans_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmReporteFacturaTransito")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmReporteFacturaTransito f2 = new frmReporteFacturaTransito(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnRFacturas_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmReporteFacturas")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmReporteFacturas f2 = new frmReporteFacturas(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }
               
        private void btnRFacturasPorVencer_Click(object sender, EventArgs e)
        {

            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmReporteFacturasPorVencer")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmReporteFacturasPorVencer f2 = new frmReporteFacturasPorVencer(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnRCorteAlquiler_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmReporteCorteAlquiler")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmReporteCorteAlquiler f2 = new frmReporteCorteAlquiler(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnRAlquileres2_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmReporteAlquiler")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmReporteAlquiler f2 = new frmReporteAlquiler(this.idUser, this.nameUser);
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnRCompras_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmReporteCompras")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmReporteCompras f2 = new frmReporteCompras();
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        //========================= Configuracion ==================================

        private void btnCPermisos_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmConfiguracionPermisos")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmConfiguracionPermisos f2 = new frmConfiguracionPermisos();
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

        private void btnCUsuarios_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmConfiguracionUsuarios")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                MenuVertical.Width = 0;
                frmConfiguracionUsuarios f2 = new frmConfiguracionUsuarios();
                f2.MdiParent = this;
                CerrarDash();
                f2.Show();
            }
        }

    }
}

