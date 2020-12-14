using AccesoDatos;
using DevComponents.DotNetBar.SuperGrid;
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

namespace Apolo
{
    public partial class frmProcesoIngresoLaptopCpu : Form
    {
        DataTable tablaMarca;
        DataTable tablaModelo;
        DataTable tablaDestino;
        DataTable tablaProcesador;
        DataTable tablaMemoria;
        DataTable tablaDisco;
        DataTable tablaVideo;
        DataTable tablaLicencia;
        IngresoDetalle detalle;

        IngresoDA ingresoDA;
        LC laptop;
        Procesador procesador;
        Video video;
        DiscoDuro disco;
        Memoria memoria;
        Licencia licencia;

        Boolean permitir = true;

        private int idUsuario;
        private string nombreUsuario = "CEAS";

        private string LicenciaSO = "S.O";

        private int laptopIdCategoria = 1;

        public frmProcesoIngresoLaptopCpu(int idUsuario, string nombreUsuario,string tipoIngreso)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();

            if (tipoIngreso == "1")
            {
                dgvSerieFabrica.Columns[1].HeaderText = "Codigo Laptop";              
            }
        }

        public frmProcesoIngresoLaptopCpu(int idUsuario, string nombreUsuario, string tipoIngreso, IngresoDetalle detalleTraido)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
            ObtenerListaLaptops(detalleTraido);
        }

        public void Inicializado()
        {
            ingresoDA = new IngresoDA();
            laptop = new LC();
            detalle = new IngresoDetalle();

            txtCantidad.Text = "1";

            tablaMarca = ingresoDA.ListarMarcas();
            cmbMarca.DataSource = tablaMarca;
            cmbMarca.DisplayMember = "nombre";
            cmbMarca.ValueMember = "idMarca";
            cmbMarca.SelectedIndex = 0;
            int i = cmbMarca.SelectedIndex;
            if (i >= 0) 
            {
                int idMarca = Convert.ToInt32(cmbMarca.SelectedValue.ToString());
                tablaModelo = ingresoDA.ListarModelos(idMarca);
                cmbModelo.DataSource = tablaModelo;
                cmbModelo.DisplayMember = "nombre";
                cmbModelo.ValueMember = "idModelo";
                cmbModelo.SelectedIndex = 0;
            }

            tablaProcesador = ingresoDA.ListarProcesadores();

            tablaMemoria = ingresoDA.ListarMemorias();

            tablaDisco = ingresoDA.ListarDiscosDuros();

            tablaVideo = ingresoDA.ListarTarjetaVideos();

            tablaLicencia = ingresoDA.ListarLicenciasSO();

            //=========================================================================
            tablaLicencia.Columns.Add("Seleccionar", typeof(bool));
            for (int h = 0; h < tablaLicencia.Rows.Count; h++)
            {
                tablaLicencia.Rows[h]["Seleccionar"] = false;
            }

            tablaMemoria.Columns.Add("Seleccionar", typeof(bool));
            for (int h = 0; h < tablaMemoria.Rows.Count; h++)
            {
                tablaMemoria.Rows[h]["Seleccionar"] = false;
            }

            tablaDisco.Columns.Add("Seleccionar", typeof(bool));
            for (int h = 0; h < tablaDisco.Rows.Count; h++)
            {
                tablaDisco.Rows[h]["Seleccionar"] = false;
            }

            tablaVideo.Columns.Add("Seleccionar", typeof(bool));
            for (int h = 0; h < tablaVideo.Rows.Count; h++)
            {
                tablaVideo.Rows[h]["Seleccionar"] = false;
            }

            tablaProcesador.Columns.Add("Seleccionar", typeof(bool));
            for (int h = 0; h < tablaProcesador.Rows.Count; h++)
            {
                tablaProcesador.Rows[h]["Seleccionar"] = false;
            }

            dgvLicencias.DataSource = tablaLicencia;
            vistaLicencias.OptionsBehavior.AutoPopulateColumns = false;
            vistaLicencias.OptionsSelection.MultiSelect = true;

            dgvMemorias.DataSource = tablaMemoria;
            vistaMemorias.OptionsBehavior.AutoPopulateColumns = false;
            vistaMemorias.OptionsSelection.MultiSelect = true;

            dgvDiscos.DataSource = tablaDisco;
            vistaDiscos.OptionsBehavior.AutoPopulateColumns = false;
            vistaDiscos.OptionsSelection.MultiSelect = true;

            dgvProcesadores.DataSource = tablaProcesador;
            vistaProcesadores.OptionsBehavior.AutoPopulateColumns = false;
            vistaProcesadores.OptionsSelection.MultiSelect = true;

            dgvVideos.DataSource = tablaVideo;
            vistaVideos.OptionsBehavior.AutoPopulateColumns = false;
            vistaVideos.OptionsSelection.MultiSelect = true;
            //=========================================================================
        }

        public void ObtenerListaLaptops(IngresoDetalle detalleTraido)
        {
            tabControl1.SelectedTab = tabProcesador;
            tabControl1.SelectedTab = tabMemoria;
            tabControl1.SelectedTab = tabVideo;
            tabControl1.SelectedTab = tabDiscoDuro;
            tabControl1.SelectedTab = tabLicencia;
            tabControl1.SelectedTab = tabClavesLicencias;
            tabControl1.SelectedTab = tabDetalle;
            
            vistaDiscos.ClearColumnsFilter();
            vistaLicencias.ClearColumnsFilter();
            vistaMemorias.ClearColumnsFilter();
            vistaProcesadores.ClearColumnsFilter();
            vistaVideos.ClearColumnsFilter();
                
            cmbMarca.SelectedValue = detalleTraido.LaptopIdMarca;
            cmbModelo.SelectedValue = detalleTraido.LaptopIdModelo;
            laptop = detalleTraido.Laptop;
            chbGarantia.Checked= (laptop.Garantia == 1) ? true : false;
            txtPantalla.Text = laptop.TamanoPantalla.ToString();
            txtPartNumber.Text = laptop.PartNumber.ToString();
            txtPrecio.Text = detalleTraido.Precio.ToString();
            txtCantidad.Text = detalleTraido.Cantidad.ToString();

            foreach (String serie in detalleTraido.Series)
            {
                DataGridViewRow row = (DataGridViewRow)dgvSerieFabrica.Rows[0].Clone();
                row.Cells[1].Value = serie;
                dgvSerieFabrica.Rows.Add(row);
            }

            foreach (String clave in detalleTraido.Windows)
            {
                DataGridViewRow row = (DataGridViewRow)dgvWindows.Rows[0].Clone();
                row.Cells[1].Value = clave;
                dgvWindows.Rows.Add(row);
            }

            foreach (Licencia licencia in laptop.Licencias)
            {
                for (int i = 0; i < tablaLicencia.Rows.Count; i++)
                {
                    if (licencia.IdModelo == int.Parse(tablaLicencia.Rows[i]["IdModelo"].ToString()))
                        tablaLicencia.Rows[i]["Seleccionar"] = true;
                }
            }
            dgvLicencias.DataSource = tablaLicencia;

            foreach (Memoria memoria in laptop.Memorias)
            {
                for (int i = 0; i < tablaMemoria.Rows.Count; i++)
                {
                    if (memoria.IdMemoria == int.Parse(tablaMemoria.Rows[i]["IdMemoria"].ToString()))
                        tablaMemoria.Rows[i]["Seleccionar"] = true;
                }
            }
            dgvMemorias.DataSource = tablaMemoria;
                      
            foreach (DiscoDuro disco in laptop.Discos)
            {
                for (int i = 0; i < tablaDisco.Rows.Count; i++)
                {
                    if (disco.IdDisco == int.Parse(tablaDisco.Rows[i]["IdDisco"].ToString()))
                        tablaDisco.Rows[i]["Seleccionar"] = true;
                }
            }
            dgvDiscos.DataSource = tablaDisco;

            for (int i=0;i< tablaVideo.Rows.Count; i++)
            {
                if (laptop.Video.IdVideo == int.Parse(tablaVideo.Rows[i]["IdVideo"].ToString()))
                    tablaVideo.Rows[i]["Seleccionar"] = true;
                else
                    tablaVideo.Rows[i]["Seleccionar"] = false;
            }
            dgvVideos.DataSource = tablaVideo;

            for (int i = 0; i < tablaProcesador.Rows.Count; i++)
            {
                if (laptop.Procesador.IdProcesador == int.Parse(tablaProcesador.Rows[i]["IdProcesador"].ToString()))
                    tablaProcesador.Rows[i]["Seleccionar"] = true;
                else
                    tablaProcesador.Rows[i]["Seleccionar"] = false;
            }
            dgvProcesadores.DataSource = tablaProcesador;
            
        }

        public bool llenarListaLaptops()
        {
            vistaDiscos.ClearColumnsFilter();
            vistaLicencias.ClearColumnsFilter();
            vistaMemorias.ClearColumnsFilter();
            vistaProcesadores.ClearColumnsFilter();
            vistaVideos.ClearColumnsFilter();

            bool flag = false;
            laptop = new LC();
            
            int j = cmbMarca.SelectedIndex;
            laptop.Modelo.IdMarca = Convert.ToInt32(cmbMarca.SelectedValue.ToString());
            laptop.Modelo.NombreMarca = tablaMarca.Rows[j]["nombre"].ToString();
            j = cmbModelo.SelectedIndex;
            laptop.Modelo.IdModelo = Convert.ToInt32(cmbModelo.SelectedValue.ToString());
            laptop.Modelo.NombreModelo = tablaModelo.Rows[j]["nombre"].ToString();
            laptop.TamanoPantalla = Double.Parse(txtPantalla.Text);
            laptop.PartNumber = txtPartNumber.Text;
            laptop.Garantia = (chbGarantia.Checked) ? 1 : 0;
            detalle.Laptop = laptop;
            detalle.Precio = Double.Parse(txtPrecio.Text);
            detalle.Cantidad = Convert.ToInt32(txtCantidad.Text);
            detalle.Series=null;
            detalle.Windows = null;
            detalle.Office = null;
            detalle.Antivirus = null;
            BindingList<String> series = new BindingList<String>();
            BindingList<String> windows = new BindingList<String>();
            BindingList<String> offices = new BindingList<String>();
            BindingList<String> antivirus = new BindingList<String>();

            for (int i = 0; i < dgvSerieFabrica.Rows.Count; i++)
            {
                if (!dgvSerieFabrica.Rows[i].IsNewRow)
                {
                    if (dgvSerieFabrica.Rows[i].Cells[1].Value != null)
                    {
                        String serie = dgvSerieFabrica.Rows[i].Cells[1].Value.ToString();
                        series.Add(serie);
                    }
                }
            }
            detalle.Series = series;

            for (int i = 0; i < dgvWindows.Rows.Count; i++)
            {
                if (!dgvWindows.Rows[i].IsNewRow)
                {
                    if (dgvWindows.Rows[i].Cells[1].Value != null)
                    {
                        String window = dgvWindows.Rows[i].Cells[1].Value.ToString();
                        windows.Add(window);
                    }
                }
            }
            detalle.Windows = windows;
            
            int filas = tablaProcesador.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                bool aux2 = bool.Parse(vistaProcesadores.GetRowCellValue(i, "Seleccionar").ToString());
                if (aux2)
                {
                    procesador = new Procesador();
                    procesador.IdProcesador = int.Parse(vistaProcesadores.GetRowCellValue(i, "idProcesador").ToString());
                    procesador.IdModelo = int.Parse(vistaProcesadores.GetRowCellValue(i, "idTipo").ToString());
                    procesador.Generacion = int.Parse(vistaProcesadores.GetRowCellValue(i, "generacion").ToString());
                    procesador.Modelo.NombreModelo = vistaProcesadores.GetRowCellValue(i, "tipo").ToString();
                    laptop.Procesador = procesador;
                    flag = true;
                }
            }

            filas = tablaVideo.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                bool aux2 = bool.Parse(vistaVideos.GetRowCellValue(i, "Seleccionar").ToString());
                if (aux2)
                {
                    video = new Video();
                    video.IdVideo = int.Parse(vistaVideos.GetRowCellValue(i, "idVideo").ToString());
                    video.IdModelo = int.Parse(vistaVideos.GetRowCellValue(i, "idModelo").ToString());
                    video.Capacidad = int.Parse(vistaVideos.GetRowCellValue(i, "capacidad").ToString());
                    video.Modelo.NombreModelo = vistaVideos.GetRowCellValue(i, "nombreModelo").ToString();
                    laptop.Video = video;
                    flag = true;
                }
            }

            filas = tablaMemoria.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                bool aux2 = bool.Parse(vistaMemorias.GetRowCellValue(i, "Seleccionar").ToString());
                if (aux2)
                {
                    memoria = new Memoria();
                    memoria.IdMemoria = int.Parse(vistaMemorias.GetRowCellValue(i, "idMemoria").ToString());
                    memoria.IdModelo = int.Parse(vistaMemorias.GetRowCellValue(i, "idTipo").ToString());
                    memoria.Capacidad = int.Parse(vistaMemorias.GetRowCellValue(i, "capacidad").ToString());
                    memoria.Modelo.NombreModelo = vistaMemorias.GetRowCellValue(i, "tipo").ToString();
                    memoria.Tipo = vistaMemorias.GetRowCellValue(i, "tipo2").ToString();
                    memoria.Cantidad = 1;
                    laptop.Memorias.Add(memoria);
                    flag = true;
                }
            }
            
            filas = tablaDisco.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                bool aux2 = bool.Parse(vistaDiscos.GetRowCellValue(i, "Seleccionar").ToString());
                if (aux2)
                {
                    disco = new DiscoDuro();
                    disco.IdDisco = int.Parse(vistaDiscos.GetRowCellValue(i, "idDisco").ToString());
                    disco.IdTipo = int.Parse(vistaDiscos.GetRowCellValue(i, "idTipo").ToString());
                    disco.Capacidad = int.Parse(vistaDiscos.GetRowCellValue(i, "capacidad").ToString());
                    disco.Tamano = vistaDiscos.GetRowCellValue(i, "tamano").ToString();
                    disco.TipoDisco = vistaDiscos.GetRowCellValue(i, "tipo").ToString();
                    disco.Cantidad = 1;
                    laptop.Discos.Add(disco);
                    flag = true;
                }
            }
            
            filas = tablaLicencia.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                bool aux2 = bool.Parse(vistaLicencias.GetRowCellValue(i, "Seleccionar").ToString());
                if (aux2)
                {
                    licencia = new Licencia();
                    licencia.IdCategoria = int.Parse(vistaLicencias.GetRowCellValue(i, "IdCategoria").ToString());
                    licencia.IdModelo = int.Parse(vistaLicencias.GetRowCellValue(i, "IdModelo").ToString());
                    licencia.Categoria = vistaLicencias.GetRowCellValue(i, "Categoria").ToString();
                    licencia.Version = vistaLicencias.GetRowCellValue(i, "Version").ToString();
                    laptop.Licencias.Add(licencia);
                    flag = true;
                }
            }

            return flag;
        }

        public bool validarDatos()
        {
            bool flag = true;

            tabControl1.SelectedTab = tabProcesador;
            tabControl1.SelectedTab = tabMemoria;
            tabControl1.SelectedTab = tabVideo;
            tabControl1.SelectedTab = tabDiscoDuro;
            tabControl1.SelectedTab = tabLicencia;
            tabControl1.SelectedTab = tabClavesLicencias;
            tabControl1.SelectedTab = tabDetalle;

            vistaDiscos.ClearColumnsFilter();
            vistaLicencias.ClearColumnsFilter();
            vistaMemorias.ClearColumnsFilter();
            vistaProcesadores.ClearColumnsFilter();
            vistaVideos.ClearColumnsFilter();

            //==============================================================================================

            if (cmbModelo.SelectedValue == null)
            {
                MessageBox.Show("No se puede grabar si no\nha seleccionado un modelo correcto.", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                tabControl1.SelectedTab = tabDetalle;
                return false;
            }
            
            //==============================================================================================

            int filas = tablaVideo.Rows.Count;
            int cantVideos = 0;
            for (int i = 0; i < filas; i++)
            {
                bool aux2 = bool.Parse(vistaVideos.GetRowCellValue(i, "Seleccionar").ToString());
                if (aux2)
                    cantVideos++;
            }
            if (cantVideos > 1)
            {
                MessageBox.Show("Solo seleccione una tarjeta de video", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                tabControl1.SelectedTab = tabVideo;
                return false;
            }
            
            //==============================================================================================

            filas = tablaProcesador.Rows.Count;
            int cantProcesadores = 0;
            for (int i = 0; i < filas; i++)
            {
                bool aux2 = bool.Parse(vistaProcesadores.GetRowCellValue(i, "Seleccionar").ToString());
                if (aux2)
                    cantProcesadores++;
            }
            if (cantProcesadores > 1)
            {
                MessageBox.Show("Solo seleccione un procesador", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                tabControl1.SelectedTab = tabProcesador;
                return false;
            }
            else if (cantProcesadores == 0)
            {
                MessageBox.Show("Debe seleccionar un procesador", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                tabControl1.SelectedTab = tabProcesador;
                return false;
            }

            //==============================================================================================

            filas = tablaDisco.Rows.Count;
            int cantDiscos = 0;
            for (int i = 0; i < filas; i++)
            {
                bool aux2 = bool.Parse(vistaDiscos.GetRowCellValue(i, "Seleccionar").ToString());
                if (aux2)
                    cantDiscos++;
            }
            if (cantDiscos > 2)
            {
                MessageBox.Show("Solo puede seleccionar 2 discos", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                tabControl1.SelectedTab = tabDiscoDuro;
                return false;
            }
            else if (cantDiscos == 0)
            {
                MessageBox.Show("Debe seleccionar almenos un disco duro", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                tabControl1.SelectedTab = tabDiscoDuro;
                return false;
            }

            //==============================================================================================

            filas = tablaMemoria.Rows.Count;
            int cantMemorias = 0;
            for (int i = 0; i < filas; i++)
            {
                bool aux2 = bool.Parse(vistaMemorias.GetRowCellValue(i, "Seleccionar").ToString());
                if (aux2)
                    cantMemorias++;
            }
            if (cantMemorias > 4)
            {
                MessageBox.Show("Solo puede seleccionar 4 memorias", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                tabControl1.SelectedTab = tabMemoria;
                return false;
            }
            else if (cantMemorias == 0)
            {
                MessageBox.Show("Debe seleccionar almenos una memoria", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                tabControl1.SelectedTab = tabMemoria;
                return false;
            }

            //==============================================================================================

            filas = tablaLicencia.Rows.Count;
            int cantWindows = 0;

            for (int i = 0; i < filas; i++)
            {
                bool aux2 = bool.Parse(vistaLicencias.GetRowCellValue(i, "Seleccionar").ToString());
                if (aux2)
                    if (vistaLicencias.GetRowCellValue(i, "Categoria").ToString() == LicenciaSO)
                        cantWindows++;
            }
            if (cantWindows > 1) //! AQUI SE VALIDA QUE SOLO SE PUEDA INGRESAR 1 LICENCIA O NIGUNA, PERO NUNCA MAS DE 1
            {
                MessageBox.Show($"Solo puede seleccionar una licencia. Usted seleccionó {cantWindows}", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                tabControl1.SelectedTab = tabLicencia;
                return false;
            }

            //==============================================================================================
            //Validación de cantidad de Claves de SO = a la cantidad de equipos

            int aux;
            int filasDgv;

            if (cantWindows == 1)
            {
                for (int i = 0; i < dgvWindows.Rows.Count; i++)
                {
                    if (dgvWindows.Rows[i].Cells[1].Value == null)
                    {
                        if (!dgvWindows.Rows[i].IsNewRow)
                        {
                            dgvWindows.Rows.Remove(dgvWindows.Rows[i]);
                            i = -1;
                        }
                    }
                }
                aux = int.Parse(txtCantidad.Text);
                filasDgv = dgvWindows.Rows.Count - 1;

                if (filasDgv < aux)
                {
                    MessageBox.Show("Falta ingresar " + (aux - filasDgv) + " filas para la licencia de Windows", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    tabControl1.SelectedTab = tabClavesLicencias;
                    return false;
                }
                else if (filasDgv > aux)
                {
                    MessageBox.Show("Hay " + (filasDgv - aux) + " filas de más en la licencia de Windows", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    tabControl1.SelectedTab = tabClavesLicencias;
                    return false;
                }

            }

            //==============================================================================================

            string partNumber = txtPartNumber.Text;
            partNumber = partNumber.Trim();
            if (!(partNumber.Length > 0))
            {
                MessageBox.Show("Ingrese un part number", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                tabControl1.SelectedTab = tabDetalle;
                return false;
            }

            //==============================================================================================

            string pantalla = txtPantalla.Text;
            pantalla = pantalla.Trim();
            if (!(pantalla.Length > 0))
            {
                MessageBox.Show("Ingrese un tamaño de pantalla válida", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                tabControl1.SelectedTab = tabDetalle;
                return false;
            }

            //==============================================================================================

            string precio = txtPrecio.Text;
            precio = precio.Trim();
            if (!(precio.Length > 0))
            {
                MessageBox.Show("Ingrese un precio válido", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                tabControl1.SelectedTab = tabDetalle;
                return false;
            }
            
            //==============================================================================================

            for (int i = 0; i < dgvSerieFabrica.Rows.Count; i++)
            {
                if (dgvSerieFabrica.Rows[i].Cells[1].Value == null)
                {
                    if (!dgvSerieFabrica.Rows[i].IsNewRow)
                    {
                        dgvSerieFabrica.Rows.Remove(dgvSerieFabrica.Rows[i]);
                        i = -1;
                    }
                }
            }

            aux = int.Parse(txtCantidad.Text);
            filasDgv = dgvSerieFabrica.Rows.Count - 1;
            
            if (filasDgv < aux)
            {
                MessageBox.Show("Falta ingresar " + (aux - filasDgv) + " filas para las series de fábrica", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                tabControl1.SelectedTab = tabDetalle;
                return false;
            }
            else if (filasDgv > aux)
            {
                MessageBox.Show("Hay " + (filasDgv - aux) + " filas de más para las series de fábrica", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                tabControl1.SelectedTab = tabDetalle;
                return false;
            }

            //==============================================================================================

            return true;
        }

        public IngresoDetalle DETALLE { get => detalle; set => detalle = value; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (llenarListaLaptops())
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            //string aux = txtCantidad.Text;
            //aux = aux.Trim();
            //if (aux.Length > 0)
            //{
            //    int cantidad = int.Parse(txtCantidad.Text);
            //    int cantFilas = dgvSerieFabrica.RowCount;
            //    if (cantFilas < cantidad)
            //    {
            //        for (int i = cantFilas; i < cantidad; i++)
            //        {
            //            DataGridViewRow row = (DataGridViewRow)dgvSerieFabrica.Rows[0].Clone();
            //            row.Cells[0].Value = i++;
            //            dgvSerieFabrica.Rows.Add(row);
            //        }
            //    }
            //    else
            //    {

            //    }

            //}
            string myStr = txtCantidad.Text;
            myStr = myStr.TrimStart('0');
            txtCantidad.Text = myStr.Length > 0 ? myStr : "1";
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                //MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dgvSerieFabrica_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvSerieFabrica.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvSerieFabrica_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
       {
            if (dgvSerieFabrica.CurrentRow == null)
                return;
            if (MessageBox.Show("Estas seguro deseas Eliminar esta serie", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                dgvSerieFabrica.Rows.Remove(dgvSerieFabrica.CurrentRow);
            }
        }

        private void dgvWindows_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvWindows.CurrentRow == null)
                return;
            if (MessageBox.Show("Estas seguro deseas Eliminar esta clave de windows", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                dgvWindows.Rows.Remove(dgvWindows.CurrentRow);
            }

        }

        private void dgvWindows_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvWindows.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
        /*
        private void dgvOffice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOffice.CurrentRow == null)
                return;
            if (MessageBox.Show("Estas seguro deseas Eliminar esta clave de office", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                dgvOffice.Rows.Remove(dgvOffice.CurrentRow);
            }

        }

        private void dgvOffice_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvOffice.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvAntivirus_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAntivirus.CurrentRow == null)
                return;
            if (MessageBox.Show("Estas seguro deseas Eliminar esta clave de antivirus", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                dgvAntivirus.Rows.Remove(dgvAntivirus.CurrentRow);
            }

        }

        private void dgvAntivirus_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvAntivirus.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
        */
        private void txtPantalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = solonumeros1(Convert.ToInt32(e.KeyChar));
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = solonumeros2(Convert.ToInt32(e.KeyChar));
        }

        public bool solonumeros1(int code)
        {
            bool resultado;
            if (code == 46 && txtPantalla.Text.Contains("."))//se evalua si es punto y si es punto se rebiza si ya existe en el textbox
                resultado = true;
            else if ((((code >= 48) && (code <= 57)) || (code == 8) || code == 46)) //se evaluan las teclas validas
                resultado = false;
            else if (!permitir)
                resultado = permitir;
            else
                resultado = true;
            return resultado;
        }

        public bool solonumeros2(int code)
        {
            bool resultado;
            if (code == 46 && txtPrecio.Text.Contains("."))//se evalua si es punto y si es punto se rebiza si ya existe en el textbox
                resultado = true;
            else if ((((code >= 48) && (code <= 57)) || (code == 8) || code == 46)) //se evaluan las teclas validas
                resultado = false;
            else if (!permitir)
                resultado = permitir;
            else
                resultado = true;
            return resultado;
        }

        private void btnSubirSeries_Click(object sender, EventArgs e)
        {
            try
            {
                string path;

                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    //DE ESTA MANERA FILTRAMOS TODOS LOS ARCHIVOS EXCEL EN EL NAVEGADOR DE ARCHIVOS
                    Filter = "Excel | *.xls;*.xlsx;",

                    //AQUÍ INDICAMOS QUE NOMBRE TENDRÁ EL NAVEGADOR DE ARCHIVOS COMO TITULO
                    Title = "Seleccionar Archivo"
                };

                //EN CASO DE SELECCIONAR EL ARCHIVO, ENTONCES PROCEDEMOS A ABRIR EL ARCHIVO CORRESPONDIENTE
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    DataTable miDataTable = new DataTable();
                    miDataTable.Columns.Add("serie");

                    path = openFileDialog.FileName;
                    SLDocument sl = new SLDocument(path);

                    int iRow = 2;
                    while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                    {
                        DataRow Renglon = miDataTable.NewRow();
                        Renglon["serie"] = sl.GetCellValueAsString(iRow, 1);
                        iRow++;
                        miDataTable.Rows.Add(Renglon);
                    }

                    dgvSerieFabrica.DataSource = miDataTable;
                    dgvSerieFabrica.AutoGenerateColumns= false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }


        }

        private void btnSubirSO_Click(object sender, EventArgs e)
        {
            try
            {
                string path;

                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    //DE ESTA MANERA FILTRAMOS TODOS LOS ARCHIVOS EXCEL EN EL NAVEGADOR DE ARCHIVOS
                    Filter = "Excel | *.xls;*.xlsx;",

                    //AQUÍ INDICAMOS QUE NOMBRE TENDRÁ EL NAVEGADOR DE ARCHIVOS COMO TITULO
                    Title = "Seleccionar Archivo"
                };

                //EN CASO DE SELECCIONAR EL ARCHIVO, ENTONCES PROCEDEMOS A ABRIR EL ARCHIVO CORRESPONDIENTE
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    DataTable miDataTable = new DataTable();
                    miDataTable.Columns.Add("sistemaOperativo");

                    path = openFileDialog.FileName;
                    SLDocument sl = new SLDocument(path);

                    int iRow = 2;
                    while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                    {
                        DataRow Renglon = miDataTable.NewRow();
                        Renglon["sistemaOperativo"] = sl.GetCellValueAsString(iRow, 1);
                        iRow++;
                        miDataTable.Rows.Add(Renglon);
                    }

                    dgvWindows.DataSource = miDataTable;
                    dgvWindows.AutoGenerateColumns = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void btnAgregarMarcaLaptop_Click(object sender, EventArgs e)
        {
            frmArchivoMarca frmBP = new frmArchivoMarca(this.idUsuario, this.nombreUsuario, this.laptopIdCategoria);
            if (frmBP.ShowDialog() == DialogResult.OK)
            {
            }

            tablaMarca = ingresoDA.ListarMarcas();
            cmbMarca.DataSource = tablaMarca;
            cmbMarca.DisplayMember = "nombre";
            cmbMarca.ValueMember = "idMarca";
            cmbMarca.SelectedIndex = 0;
            int i = cmbMarca.SelectedIndex;

            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                int idMarca = Convert.ToInt32(cmbMarca.SelectedValue.ToString());
                tablaModelo = ingresoDA.ListarModelos(idMarca);
                cmbModelo.DataSource = tablaModelo;
                cmbModelo.DisplayMember = "nombre";
                cmbModelo.ValueMember = "idModelo";
                cmbModelo.SelectedIndex = 0;
            }

        }

        private void btnAgregarModeloLaptop_Click(object sender, EventArgs e)
        {
            frmArchivoModelo frmBP = new frmArchivoModelo(this.idUsuario, this.nombreUsuario, this.laptopIdCategoria);
            if (frmBP.ShowDialog() == DialogResult.OK)
            {
            }

            tablaMarca = ingresoDA.ListarMarcas();
            cmbMarca.DataSource = tablaMarca;
            cmbMarca.DisplayMember = "nombre";
            cmbMarca.ValueMember = "idMarca";
            cmbMarca.SelectedIndex = 0;
            int i = cmbMarca.SelectedIndex;

            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                int idMarca = Convert.ToInt32(cmbMarca.SelectedValue.ToString());
                tablaModelo = ingresoDA.ListarModelos(idMarca);
                cmbModelo.DataSource = tablaModelo;
                cmbModelo.DisplayMember = "nombre";
                cmbModelo.ValueMember = "idModelo";
                cmbModelo.SelectedIndex = 0;
            }
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            bool flag = true;

            tabControl1.SelectedTab = tabProcesador;
            tabControl1.SelectedTab = tabMemoria;
            tabControl1.SelectedTab = tabVideo;
            tabControl1.SelectedTab = tabDiscoDuro;
            tabControl1.SelectedTab = tabLicencia;
            tabControl1.SelectedTab = tabClavesLicencias;
            tabControl1.SelectedTab = tabDetalle;

            vistaDiscos.ClearColumnsFilter();
            vistaLicencias.ClearColumnsFilter();
            vistaMemorias.ClearColumnsFilter();
            vistaProcesadores.ClearColumnsFilter();
            vistaVideos.ClearColumnsFilter();

            //======================================================================== PROCESADOR

            int canProces = 0;
            for (int i = 0; i < tablaProcesador.Rows.Count; i++)
            {
                bool aux2 = bool.Parse(vistaProcesadores.GetRowCellValue(i, "Seleccionar").ToString());
                if (aux2)
                {
                    string MarcaP = vistaProcesadores.GetRowCellValue(i, "marca").ToString();
                    string TipoP = vistaProcesadores.GetRowCellValue(i, "tipo").ToString();
                    string GeneracionP = vistaProcesadores.GetRowCellValue(i, "generacion").ToString();
                    canProces++;
                    txtProcesadorSeleccionado.ForeColor = Color.White;
                    txtProcesadorSeleccionado.BackColor = Color.Green;
                    txtProcesadorSeleccionado.Text = $"{MarcaP} {TipoP} {GeneracionP}";
                }
            }
            if (canProces > 1)
            {
                txtProcesadorSeleccionado.ForeColor = Color.Yellow;
                txtProcesadorSeleccionado.BackColor = Color.Red;
                txtProcesadorSeleccionado.Text = $"{canProces} SELECCIOANADOS";
            }
            if (canProces == 0)
            {
                txtProcesadorSeleccionado.ForeColor = Color.Yellow;
                txtProcesadorSeleccionado.BackColor = Color.Red;
                txtProcesadorSeleccionado.Text = "NN";
            }

            //=================================================================== MEMORIAS
        
            int canMemo = 0;
            for (int i = 0; i < tablaMemoria.Rows.Count; i++)
            {
                bool aux2 = bool.Parse(vistaMemorias.GetRowCellValue(i, "Seleccionar").ToString());
                if (aux2)
                {
                    string ModeloM = vistaMemorias.GetRowCellValue(i, "tipo").ToString();
                    string CapacidadM = vistaMemorias.GetRowCellValue(i, "capacidad").ToString();
                    string TipoM = vistaMemorias.GetRowCellValue(i, "tipo2").ToString();
                    canMemo++;
                    txtMemoriaSeleccionada.ForeColor = Color.White;
                    txtMemoriaSeleccionada.BackColor = Color.Green;
                    txtMemoriaSeleccionada.Text = $"{ModeloM} {CapacidadM} {TipoM}";
                }
            }
            if (canMemo > 1) //MAXIMO 4
            {
                if (canMemo > 4)
                {
                    txtMemoriaSeleccionada.ForeColor = Color.Yellow;
                    txtMemoriaSeleccionada.BackColor = Color.Red;
                    txtMemoriaSeleccionada.Text = $"{canMemo} SELECCIONADAS";
                }
                else
                {
                    txtMemoriaSeleccionada.ForeColor = Color.White;
                    txtMemoriaSeleccionada.BackColor = Color.Green;
                    txtMemoriaSeleccionada.Text = $"{canMemo} SELECCIONADAS";
                }

            }
            if (canMemo == 0)
            {
                txtMemoriaSeleccionada.ForeColor = Color.Yellow;
                txtMemoriaSeleccionada.BackColor = Color.Red;
                txtMemoriaSeleccionada.Text = "NN";
            }

            //================================================================ DISCO DURO
            
            int canDis = 0;
            for (int i = 0; i < tablaDisco.Rows.Count; i++)
            {
                bool aux2 = bool.Parse(vistaDiscos.GetRowCellValue(i, "Seleccionar").ToString());
                if (aux2)
                {
                    string TipoDD = vistaDiscos.GetRowCellValue(i, "tipo").ToString();
                    string TamDD = vistaDiscos.GetRowCellValue(i, "tamano").ToString();
                    string CapacidadDD = vistaDiscos.GetRowCellValue(i, "capacidad").ToString();
                    canDis++;
                    txtDiscoDuroSeleccionado.ForeColor = Color.White;
                    txtDiscoDuroSeleccionado.BackColor = Color.Green;
                    txtDiscoDuroSeleccionado.Text = $"{TipoDD} {TamDD} {CapacidadDD}";
                }
            }
            if (canDis > 1) //MAXIMO 2
            {
                if (canDis > 2)
                {
                    txtDiscoDuroSeleccionado.ForeColor = Color.Yellow;
                    txtDiscoDuroSeleccionado.BackColor = Color.Red;
                    txtDiscoDuroSeleccionado.Text = $"{canDis} SELECCIONADOS";
                }
                else
                {
                    txtDiscoDuroSeleccionado.ForeColor = Color.White;
                    txtDiscoDuroSeleccionado.BackColor = Color.Green;
                    txtDiscoDuroSeleccionado.Text = $"{canDis} SELECCIONADOS";
                }

            }
            if (canDis == 0)
            {
                txtDiscoDuroSeleccionado.ForeColor = Color.Yellow;
                txtDiscoDuroSeleccionado.BackColor = Color.Red;
                txtDiscoDuroSeleccionado.Text = "NN";
            }

            //================================================================== TARJETA DE VIDEO

            int canTarj = 0;
            for (int i = 0; i < tablaVideo.Rows.Count; i++)
            {
                bool aux2 = bool.Parse(vistaVideos.GetRowCellValue(i, "Seleccionar").ToString());
                if (aux2)
                {
                    string MarcaTDV = vistaVideos.GetRowCellValue(i, "marca").ToString();
                    string TipoTDV = vistaVideos.GetRowCellValue(i, "tipo").ToString();
                    string CapacidadTDV = vistaVideos.GetRowCellValue(i, "capacidad").ToString();
                    canTarj++;
                    txtTdvSeleccionado.ForeColor = Color.White;
                    txtTdvSeleccionado.BackColor = Color.Green;
                    txtTdvSeleccionado.Text = $"{MarcaTDV} {TipoTDV} {CapacidadTDV}";
                }
            }
            if (canTarj > 1) 
            {
                txtTdvSeleccionado.ForeColor = Color.Yellow;
                txtTdvSeleccionado.BackColor = Color.Red;
                txtTdvSeleccionado.Text = $"{canTarj} SELECCIONADOS";
            }
            else if (canTarj == 0)
            {
                txtTdvSeleccionado.ForeColor = Color.White;
                txtTdvSeleccionado.BackColor = Color.Green;
                txtTdvSeleccionado.Text = "NN";
            }

            //============================================================================= LICENCIAS

            int canLic = 0;
            for (int i = 0; i < tablaLicencia.Rows.Count; i++)
            {
                bool aux2 = bool.Parse(vistaLicencias.GetRowCellValue(i, "Seleccionar").ToString());
                if (aux2)
                {
                    string CategoriaLic = vistaLicencias.GetRowCellValue(i, "Categoria").ToString();
                    string VersionLic = vistaLicencias.GetRowCellValue(i, "Version").ToString();
                    canLic++;
                    txtLicenciaSeleccionada.ForeColor = Color.White;
                    txtLicenciaSeleccionada.BackColor = Color.Green;
                    txtLicenciaSeleccionada.Text = $"{CategoriaLic} {VersionLic}";
                }
            }
            if (canLic > 1)
            {
                txtLicenciaSeleccionada.ForeColor = Color.Yellow;
                txtLicenciaSeleccionada.BackColor = Color.Red;
                txtLicenciaSeleccionada.Text = $"{canLic} SELECCIONADAS";
            }
            else if (canLic == 0)
            {
                txtLicenciaSeleccionada.ForeColor = Color.White;
                txtLicenciaSeleccionada.BackColor = Color.Green;
                txtLicenciaSeleccionada.Text = "NN";
            }

        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmbMarca.SelectedIndex;
            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                int idMarca = Convert.ToInt32(tablaMarca.Rows[i]["idMarca"].ToString());
                tablaModelo = ingresoDA.ListarModelos(idMarca);
                cmbModelo.DataSource = (tablaModelo.Rows.Count > 0) ? tablaModelo : null;
                cmbModelo.DisplayMember = "nombre";
                cmbModelo.ValueMember = "idModelo";
                cmbModelo.SelectedIndex = (tablaModelo.Rows.Count > 0) ? 0 : -1;
            }

        }

    }
}
