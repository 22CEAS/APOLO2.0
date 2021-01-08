using AccesoDatos;
using DevComponents.DotNetBar.SuperGrid;
using DevExpress.XtraEditors;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Apolo
{
    public partial class frmProcesoIngreso : Form
    {
        public enum TipoVista { Inicial, Nuevo, Modificar, Guardar, Vista, Limpiar, Duplicar, Anular }
        DataTable tablaIngresoTipo;
        DataTable tablaMonedaTipo;
        DataTable tablaProveedor;
        DataTable tablaSede;

        Ingreso ingreso;
        IngresoDA ingresoDA;

        Boolean permitir = true;

        private int idUsuario;
        private string nombreUsuario = "CEAS";
        //private string lap_mac=

        private string licenciaCategoriaSO = "S.O";
        private string licenciaCategoriaOffice = "OFFICE";
        private string licenciaCategoriaAntivirus = "ANTIVIRUS";


        private double total = 0;
        private double ultimoMovimiento = 0;

        public frmProcesoIngreso()
        {
            InitializeComponent();
            Inicializado();
            estadoComponentes(TipoVista.Inicial);
        }

        public frmProcesoIngreso(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
            estadoComponentes(TipoVista.Inicial);
        }

        public void Inicializado()
        {

            ingresoDA = new IngresoDA();
            ingreso = new Ingreso();
            dtpFechaIngreso.Value = DateTime.Now;


            tablaProveedor = ingresoDA.ListarProveedores();
            cmbProveedor.DataSource = tablaProveedor;
            cmbProveedor.DisplayMember = "razonSocial";
            cmbProveedor.ValueMember = "idProveedor";
            cmbProveedor.SelectedIndex = 0;
            int i = cmbProveedor.SelectedIndex;

            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                txtRUC.Text = tablaProveedor.Rows[i]["ruc"].ToString();
            }

            tablaIngresoTipo = ingresoDA.ListarIngresoTipo();
            cmbTipoIngreso.DataSource = tablaIngresoTipo;
            cmbTipoIngreso.DisplayMember = "descripcion";
            cmbTipoIngreso.ValueMember = "idAuxiliar";

            tablaMonedaTipo = ingresoDA.ListarMonedaTipo();
            cmbMonedaTipo.DataSource = tablaMonedaTipo;
            cmbMonedaTipo.DisplayMember = "descripcion";
            cmbMonedaTipo.ValueMember = "idAuxiliar";

            //============================================
            tablaSede = ingresoDA.ListarSede();
            cmbSede.DataSource = tablaSede;
            cmbSede.DisplayMember = "nombreSede";
            cmbSede.ValueMember = "idSede";
            //============================================


            ingreso = new Ingreso();
            ingreso.Detalles = new BindingList<IngresoDetalle>();
            ingreso.DetallesTablets = new BindingList<IngresoDetalleTablet>();
            ingreso.DetallesMonitores = new BindingList<IngresoDetalleMonitor>();
            ingreso.DetallesImpresoras = new BindingList<IngresoDetalleImpresora>();
            ingreso.DetallesProyectores = new BindingList<IngresoDetalleProyector>();
            ObtenerDatosIngreso();

            dgvLaptopsSeleccionados.DataSource = ingreso.Detalles;
            vistaLaptops.OptionsBehavior.AutoPopulateColumns = false;
            vistaLaptops.OptionsSelection.MultiSelect = true;

            dgvMemoria.DataSource = ingreso.Memorias;
            vistaMemoria.OptionsBehavior.AutoPopulateColumns = false;
            vistaMemoria.OptionsSelection.MultiSelect = true;

            dgvDiscos.DataSource = ingreso.Discos;
            vistaDiscos.OptionsBehavior.AutoPopulateColumns = false;
            vistaDiscos.OptionsSelection.MultiSelect = true;

            dgvLicencias.DataSource = ingreso.Licencias;
            vistaLicencias.OptionsBehavior.AutoPopulateColumns = false;
            vistaLicencias.OptionsSelection.MultiSelect = true;

            dgvMonitores.DataSource = ingreso.DetallesMonitores;
            vistaMonitores.OptionsBehavior.AutoPopulateColumns = false;
            vistaMonitores.OptionsSelection.MultiSelect = true;

            dgvTablets.DataSource = ingreso.DetallesTablets;
            vistaTablets.OptionsBehavior.AutoPopulateColumns = false;
            vistaTablets.OptionsSelection.MultiSelect = true;

            dgvImpresoras.DataSource = ingreso.DetallesImpresoras;
            vistaImpresoras.OptionsBehavior.AutoPopulateColumns = false;
            vistaImpresoras.OptionsSelection.MultiSelect = true;

            dgvProyectores.DataSource = ingreso.DetallesProyectores;
            vistaProyectores.OptionsBehavior.AutoPopulateColumns = false;
            vistaProyectores.OptionsSelection.MultiSelect = true;

        }

        public void ObtenerDatosIngreso()
        {
            Cursor.Current = Cursors.WaitCursor;
            ingreso.IdProveedor = Convert.ToInt32(cmbProveedor.SelectedValue.ToString());
            ingreso.IdTipoIngreso = Convert.ToInt32(cmbTipoIngreso.SelectedValue.ToString());
            ingreso.IdMonedaTipo = Convert.ToInt32(cmbMonedaTipo.SelectedValue.ToString());
            ingreso.IdSede = Convert.ToInt32(cmbSede.SelectedValue.ToString());

            int i = cmbProveedor.SelectedIndex;
            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                ingreso.Ruc = tablaProveedor.Rows[i]["ruc"].ToString();
                ingreso.RazonSocial = tablaProveedor.Rows[i]["razonSocial"].ToString();
            }

            i = cmbTipoIngreso.SelectedIndex;
            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                ingreso.TipoIngreso = tablaIngresoTipo.Rows[i]["descripcion"].ToString();
            }

            i = cmbMonedaTipo.SelectedIndex;
            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                ingreso.MonedaTipo = tablaMonedaTipo.Rows[i]["descripcion"].ToString();
            }

            i = cmbSede.SelectedIndex;
            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                ingreso.TipoSede = tablaSede.Rows[i]["nombreSede"].ToString();
            }

            ingreso.FechaIngreso = dtpFechaIngreso.Value;
            ingreso.Factura = txtFactura.Text;
            ingreso.Guia = txtGuia.Text;
            string aux = txtMontoCambio.Text;
            aux = aux.Trim();
            ingreso.MontoCambio = (aux.Length == 0) ? 0 : Double.Parse(aux);

            //Aqui se va a hacer la suma de todo el Total
            ingreso.Total = 0;
            foreach (IngresoDetalle d in ingreso.Detalles)
            {
                ingreso.Total += d.Precio * d.Cantidad;
            }
            foreach (Licencia d in ingreso.Licencias)
            {
                ingreso.Total += d.Precio * d.Cantidad;
            }
            foreach (DiscoDuro d in ingreso.Discos)
            {
                ingreso.Total += d.Precio * d.Cantidad;
            }
            foreach (Memoria d in ingreso.Memorias)
            {
                ingreso.Total += d.Precio * d.Cantidad;
            }

            foreach (IngresoDetalleTablet d in ingreso.DetallesTablets)
            {
                ingreso.Total += d.Precio * d.Cantidad;
            }

            foreach (IngresoDetalleMonitor d in ingreso.DetallesMonitores)
            {
                ingreso.Total += d.Precio * d.Cantidad;
            }

            foreach (IngresoDetalleImpresora d in ingreso.DetallesImpresoras)
            {
                ingreso.Total += d.Precio * d.Cantidad;
            }

            foreach (IngresoDetalleProyector d in ingreso.DetallesProyectores)
            {
                ingreso.Total += d.Precio * d.Cantidad;
            }

        }

        public bool ValidarDatos()
        {
            Cursor.Current = Cursors.WaitCursor;
            if (ingreso.MonedaTipo == "DOLARES" && ingreso.MontoCambio == 0)
            {
                MessageBox.Show("No se puede grabar un Ingreso si no\nespecifica cuanto es el tipo de cambio.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return true;
            }

            if (ingreso.Detalles.Count == 0 && ingreso.Discos.Count == 0 && ingreso.Memorias.Count == 0 && ingreso.Licencias.Count == 0
                && ingreso.DetallesTablets.Count == 0 && ingreso.DetallesMonitores.Count == 0
                && ingreso.DetallesImpresoras.Count == 0 && ingreso.DetallesProyectores.Count == 0)
            {
                MessageBox.Show("No se puede grabar un Ingreso si no\nexisten laptops, memorias, disco o licencias seleccionadas.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return true;
            }

            if (ingreso.Factura.Length == 0)
            {
                MessageBox.Show("No se puede grabar un Ingreso si\nel número de factura está vacia.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return true;
            }

            for (int i = 0; i < ingreso.Discos.Count; i++)
            {
                if (ingreso.Discos[i].Precio == 0.00)
                {
                    MessageBox.Show("No se puede grabar un Ingreso si uno de los precios de los Discos es 0", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    return true;
                }
            }


            for (int i = 0; i < ingreso.Memorias.Count; i++)
            {
                if (ingreso.Memorias[i].Precio == 0.00)
                {
                    MessageBox.Show("No se puede grabar un Ingreso si uno de los precios de las Memorias es 0", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    return true;
                }
            }


            for (int i = 0; i < ingreso.Licencias.Count; i++)
            {
                if (ingreso.Licencias[i].Precio == 0.00)
                {
                    MessageBox.Show("No se puede grabar un Ingreso si uno de los precios de las Licencias es 0", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    return true;
                }
                if (ingreso.Licencias[i].Clave.Length == 0)
                {
                    MessageBox.Show("No se puede grabar un Ingreso si una de las claves de las Licencias está vacía.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    return true;
                }
            }


            return false;

        }

        public void estadoComponentes(TipoVista estado)
        {
            switch (estado)
            {
                case TipoVista.Inicial:
                    cmbProveedor.Enabled = false;
                    cmbTipoIngreso.Enabled = false;
                    cmbMonedaTipo.Enabled = false;
                    cmbSede.Enabled = false;
                    txtMontoCambio.Enabled = false;
                    txtFactura.Enabled = false;
                    txtGuia.Enabled = false;
                    dtpFechaIngreso.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    dgvMonitores.Enabled = false;
                    dgvTablets.Enabled = false;
                    dgvImpresoras.Enabled = false;
                    dgvProyectores.Enabled = false;
                    dgvDiscos.Enabled = false;
                    dgvMemoria.Enabled = false;
                    dgvLicencias.Enabled = false;
                    btnAgregarDisco.Enabled = false;
                    btnAgregarMemoria.Enabled = false;
                    btnAgregarLicencia.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnAgregarMonitores.Enabled = false;
                    btnAgregarTablets.Enabled = false;
                    btnAgregarImpresora.Enabled = false;
                    btnAgregarProyectores.Enabled = false;
                    btnVisualizarMonitores.Enabled = false;
                    btnVisualizarTablets.Enabled = false;
                    btnVisualizarImpresora.Enabled = false;
                    btnVisualizarProyectores.Enabled = false;
                    btnVisualizar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnAnular.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = false;
                    btnEditar.Enabled = false;
                    btnGrabar.Enabled = false;
                    limpiarComponentes();
                    ingreso = new Ingreso();
                    break;
                case TipoVista.Nuevo:
                    cmbProveedor.Enabled = true;
                    cmbTipoIngreso.Enabled = true;
                    cmbMonedaTipo.Enabled = true;
                    cmbSede.Enabled = true;
                    txtMontoCambio.Enabled = true;
                    txtFactura.Enabled = true;
                    txtGuia.Enabled = true;
                    dtpFechaIngreso.Enabled = true;
                    dgvLaptopsSeleccionados.Enabled = true;
                    dgvMonitores.Enabled = true;
                    dgvTablets.Enabled = true;
                    dgvImpresoras.Enabled = true;
                    dgvProyectores.Enabled = true;
                    dgvDiscos.Enabled = true;
                    dgvMemoria.Enabled = true;
                    dgvLicencias.Enabled = true;
                    btnAgregarDisco.Enabled = true;
                    btnAgregarMemoria.Enabled = true;
                    btnAgregarLicencia.Enabled = true;
                    btnAgregarProducto.Enabled = true;
                    btnAgregarMonitores.Enabled = true;
                    btnAgregarTablets.Enabled = true;
                    btnAgregarImpresora.Enabled = true;
                    btnAgregarProyectores.Enabled = true;
                    btnVisualizarMonitores.Enabled = true;
                    btnVisualizarTablets.Enabled = true;
                    btnVisualizarImpresora.Enabled = true;
                    btnVisualizarProyectores.Enabled = true;
                    btnVisualizar.Enabled = true;
                    btnNuevo.Enabled = false;
                    btnAnular.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnImprimir.Enabled = false;
                    btnEditar.Enabled = false;
                    btnGrabar.Enabled = true;
                    limpiarComponentes();
                    ingreso = new Ingreso();
                    break;
                case TipoVista.Guardar:
                    cmbProveedor.Enabled = false;
                    cmbTipoIngreso.Enabled = false;
                    cmbMonedaTipo.Enabled = false;
                    cmbSede.Enabled = false;
                    txtMontoCambio.Enabled = false;
                    txtFactura.Enabled = false;
                    txtGuia.Enabled = false;
                    dtpFechaIngreso.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    dgvMonitores.Enabled = false;
                    dgvTablets.Enabled = false;
                    dgvImpresoras.Enabled = false;
                    dgvProyectores.Enabled = false;
                    dgvDiscos.Enabled = false;
                    dgvMemoria.Enabled = false;
                    dgvLicencias.Enabled = false;
                    btnAgregarDisco.Enabled = false;
                    btnAgregarMemoria.Enabled = false;
                    btnAgregarLicencia.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnAgregarMonitores.Enabled = false;
                    btnAgregarTablets.Enabled = false;
                    btnAgregarImpresora.Enabled = false;
                    btnAgregarProyectores.Enabled = false;
                    btnVisualizarMonitores.Enabled = false;
                    btnVisualizarTablets.Enabled = false;
                    btnVisualizarImpresora.Enabled = false;
                    btnVisualizarProyectores.Enabled = false;
                    btnVisualizar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnAnular.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnEditar.Enabled = true;
                    btnGrabar.Enabled = false;
                    break;
                case TipoVista.Modificar:
                    cmbProveedor.Enabled = true;
                    cmbTipoIngreso.Enabled = true;
                    cmbMonedaTipo.Enabled = true;
                    cmbSede.Enabled = true;
                    txtMontoCambio.Enabled = true;
                    txtFactura.Enabled = true;
                    txtGuia.Enabled = true;
                    dtpFechaIngreso.Enabled = true;
                    dgvLaptopsSeleccionados.Enabled = true;
                    dgvMonitores.Enabled = true;
                    dgvTablets.Enabled = true;
                    dgvImpresoras.Enabled = true;
                    dgvProyectores.Enabled = true;
                    dgvDiscos.Enabled = true;
                    dgvMemoria.Enabled = true;
                    dgvLicencias.Enabled = true;
                    btnAgregarDisco.Enabled = true;
                    btnAgregarMemoria.Enabled = true;
                    btnAgregarLicencia.Enabled = true;
                    btnAgregarProducto.Enabled = true;
                    btnAgregarMonitores.Enabled = true;
                    btnAgregarTablets.Enabled = true;
                    btnAgregarImpresora.Enabled = true;
                    btnAgregarProyectores.Enabled = true;
                    btnVisualizarMonitores.Enabled = true;
                    btnVisualizarTablets.Enabled = true;
                    btnVisualizarImpresora.Enabled = true;
                    btnVisualizarProyectores.Enabled = true;
                    btnVisualizar.Enabled = true;
                    btnNuevo.Enabled = false;
                    btnAnular.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnImprimir.Enabled = false;
                    btnEditar.Enabled = false;
                    btnGrabar.Enabled = true;
                    break;
                case TipoVista.Vista:
                    cmbProveedor.Enabled = false;
                    cmbTipoIngreso.Enabled = false;
                    cmbMonedaTipo.Enabled = false;
                    cmbSede.Enabled = false;
                    txtMontoCambio.Enabled = false;
                    txtFactura.Enabled = false;
                    txtGuia.Enabled = false;
                    dtpFechaIngreso.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    dgvMonitores.Enabled = false;
                    dgvTablets.Enabled = false;
                    dgvImpresoras.Enabled = false;
                    dgvProyectores.Enabled = false;
                    dgvDiscos.Enabled = false;
                    dgvMemoria.Enabled = false;
                    dgvLicencias.Enabled = false;
                    btnAgregarDisco.Enabled = false;
                    btnAgregarMemoria.Enabled = false;
                    btnAgregarLicencia.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnAgregarMonitores.Enabled = false;
                    btnAgregarTablets.Enabled = false;
                    btnAgregarImpresora.Enabled = false;
                    btnAgregarProyectores.Enabled = false;
                    btnVisualizarMonitores.Enabled = false;
                    btnVisualizarTablets.Enabled = false;
                    btnVisualizarImpresora.Enabled = false;
                    btnVisualizarProyectores.Enabled = false;
                    btnVisualizar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnAnular.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnEditar.Enabled = true;
                    btnGrabar.Enabled = false;
                    //limpiarComponentes();
                    ingreso = new Ingreso();
                    break;
                case TipoVista.Limpiar:
                    cmbProveedor.Enabled = false;
                    cmbTipoIngreso.Enabled = false;
                    cmbMonedaTipo.Enabled = false;
                    cmbSede.Enabled = false;
                    txtMontoCambio.Enabled = false;
                    txtFactura.Enabled = false;
                    txtGuia.Enabled = false;
                    dtpFechaIngreso.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    dgvMonitores.Enabled = false;
                    dgvTablets.Enabled = false;
                    dgvImpresoras.Enabled = false;
                    dgvProyectores.Enabled = false;
                    dgvDiscos.Enabled = false;
                    dgvMemoria.Enabled = false;
                    dgvLicencias.Enabled = false;
                    btnAgregarDisco.Enabled = false;
                    btnAgregarMemoria.Enabled = false;
                    btnAgregarLicencia.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnAgregarMonitores.Enabled = false;
                    btnAgregarTablets.Enabled = false;
                    btnAgregarImpresora.Enabled = false;
                    btnAgregarProyectores.Enabled = false;
                    btnVisualizarMonitores.Enabled = false;
                    btnVisualizarTablets.Enabled = false;
                    btnVisualizarImpresora.Enabled = false;
                    btnVisualizarProyectores.Enabled = false;
                    btnVisualizar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnAnular.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = false;
                    btnEditar.Enabled = false;
                    btnGrabar.Enabled = false;
                    limpiarComponentes();
                    ingreso = new Ingreso();
                    break;
                case TipoVista.Duplicar:
                    cmbProveedor.Enabled = false;
                    cmbTipoIngreso.Enabled = false;
                    cmbMonedaTipo.Enabled = false;
                    cmbSede.Enabled = false;
                    txtMontoCambio.Enabled = false;
                    txtFactura.Enabled = false;
                    txtGuia.Enabled = false;
                    dtpFechaIngreso.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    dgvMonitores.Enabled = false;
                    dgvTablets.Enabled = false;
                    dgvImpresoras.Enabled = false;
                    dgvProyectores.Enabled = false;
                    dgvDiscos.Enabled = false;
                    dgvMemoria.Enabled = false;
                    dgvLicencias.Enabled = false;
                    btnAgregarDisco.Enabled = false;
                    btnAgregarMemoria.Enabled = false;
                    btnAgregarLicencia.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnAgregarMonitores.Enabled = false;
                    btnAgregarTablets.Enabled = false;
                    btnAgregarImpresora.Enabled = false;
                    btnAgregarProyectores.Enabled = false;
                    btnVisualizarMonitores.Enabled = false;
                    btnVisualizarTablets.Enabled = false;
                    btnVisualizarImpresora.Enabled = false;
                    btnVisualizarProyectores.Enabled = false;
                    btnVisualizar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnEditar.Enabled = true;
                    btnGrabar.Enabled = false;
                    limpiarComponentes();
                    ingreso = new Ingreso();
                    break;
                case TipoVista.Anular:
                    cmbProveedor.Enabled = false;
                    cmbTipoIngreso.Enabled = false;
                    cmbMonedaTipo.Enabled = false;
                    cmbSede.Enabled = false;
                    txtMontoCambio.Enabled = false;
                    txtFactura.Enabled = false;
                    txtGuia.Enabled = false;
                    dtpFechaIngreso.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    dgvMonitores.Enabled = false;
                    dgvTablets.Enabled = false;
                    dgvImpresoras.Enabled = false;
                    dgvProyectores.Enabled = false;
                    dgvDiscos.Enabled = false;
                    dgvMemoria.Enabled = false;
                    dgvLicencias.Enabled = false;
                    btnAgregarDisco.Enabled = false;
                    btnAgregarMemoria.Enabled = false;
                    btnAgregarLicencia.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnAgregarMonitores.Enabled = false;
                    btnAgregarTablets.Enabled = false;
                    btnAgregarImpresora.Enabled = false;
                    btnAgregarProyectores.Enabled = false;
                    btnVisualizarMonitores.Enabled = false;
                    btnVisualizarTablets.Enabled = false;
                    btnVisualizarImpresora.Enabled = false;
                    btnVisualizarProyectores.Enabled = false;
                    btnVisualizar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnAnular.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnEditar.Enabled = false;
                    btnGrabar.Enabled = false;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            cmbTipoIngreso.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
            cmbMonedaTipo.SelectedIndex = -1;
            cmbSede.SelectedIndex = -1;

            txtNroIngreso.Text = "";
            txtRUC.Text = "";
            txtGuia.Text = "";
            txtFactura.Text = "";
            txtMontoCambio.Text = "";
            dtpFechaIngreso.Value = DateTime.Now;
            dgvDiscos.DataSource = null;
            dgvMemoria.DataSource = null;
            dgvLicencias.DataSource = null;
            dgvLaptopsSeleccionados.DataSource = null;
            dgvImpresoras.DataSource = null;
            dgvTablets.DataSource = null;
            dgvMonitores.DataSource = null;
            dgvProyectores.DataSource = null;
        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmbProveedor.SelectedIndex;
            if (i >= 0)
            {
                ingreso.Ruc = tablaProveedor.Rows[i]["ruc"].ToString();
                txtRUC.Text = tablaProveedor.Rows[i]["ruc"].ToString();
                ingreso.RazonSocial = tablaProveedor.Rows[i]["razonSocial"].ToString();
            }
        }

        public void LlenarDatosIngreso()
        {
            cmbProveedor.SelectedValue = ingreso.IdProveedor;
            cmbTipoIngreso.SelectedValue = ingreso.IdTipoIngreso;
            cmbMonedaTipo.SelectedValue = ingreso.IdMonedaTipo;
            cmbSede.SelectedValue = ingreso.IdSede;
            txtRUC.Text = ingreso.Ruc;
            dtpFechaIngreso.Value = ingreso.FechaIngreso;
            txtFactura.Text = ingreso.Factura;
            txtGuia.Text = ingreso.Guia;
            txtNroIngreso.Text = ingreso.IdIngreso.ToString();
            txtMontoCambio.Text = (ingreso.MontoCambio == 0) ? "" : ingreso.MontoCambio.ToString();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            estadoComponentes(TipoVista.Vista);
            frmProcesoIngresoBuscar frmBP = new frmProcesoIngresoBuscar(this.idUsuario);
            if (frmBP.ShowDialog() == DialogResult.OK)
            {
                ingreso = frmBP.ObjSeleccionado;
                txtNroIngreso.Text = ingreso.IdIngreso.ToString();
                LlenarDatosIngreso();
                dgvLaptopsSeleccionados.DataSource = ingreso.Detalles;
                dgvLicencias.DataSource = ingreso.Licencias;
                dgvDiscos.DataSource = ingreso.Discos;
                dgvMemoria.DataSource = ingreso.Memorias;

                dgvTablets.DataSource = ingreso.DetallesTablets;
                dgvMonitores.DataSource = ingreso.DetallesMonitores;
                dgvImpresoras.DataSource = ingreso.DetallesImpresoras;
                dgvProyectores.DataSource = ingreso.DetallesProyectores;

                ObtenerTotal();
            }
            else
            {
                estadoComponentes(TipoVista.Inicial);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(TipoVista.Nuevo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas cancelar el proceso", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                estadoComponentes(TipoVista.Limpiar);
                ingreso = new Ingreso();
                dgvDiscos.DataSource = null;
                dgvMemoria.DataSource = null;
                dgvLicencias.DataSource = null;
                dgvLaptopsSeleccionados.DataSource = null;
                dgvTablets.DataSource = null;
                dgvImpresoras.DataSource = null;
                dgvMonitores.DataSource = null;
                dgvProyectores.DataSource = null;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ingreso.Estado == 7 || ingreso.Estado == 0)//en teoría 7 debería ser finalizado
            {
                MessageBox.Show("Este ingreso ya no se puede modificar", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Estas seguro que desea Modificar\n" + "el Ingreso N° :" + txtNroIngreso.Text, "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    estadoComponentes(TipoVista.Modificar);
                }
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (ingreso.Estado == 0)
            {
                MessageBox.Show("Este ingreso ya se encuentra en estado Anulado", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (ingreso.Estado == 8 || ingreso.Estado == 9)//los estados de aqui todavía están por definir
            {
                MessageBox.Show("Este ingreso no se puede anular", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Estas seguro que desea Anular este ingreso", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    ingreso.Estado = 0;
                    int error = ingresoDA.AnularIngreso(ingreso, this.nombreUsuario);
                    if (error == 0)
                    {
                        MessageBox.Show("Se anulo el Ingreso N° :" + ingreso.IdIngreso, "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Este ingreso no se puede anular. Contactese con el área de soporte", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    estadoComponentes(TipoVista.Anular);
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Imprimir el Ingreso", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {

                    SaveFileDialog fichero = new SaveFileDialog();
                    //fichero.Filter = "Excel (*.xls)|*.xls";
                    fichero.Filter = "Excel(*.xlsx) | *.xlsx";
                    fichero.FileName = "Ingreso_" + ingreso.IdIngreso.ToString();
                    if (fichero.ShowDialog() == DialogResult.OK)
                    {
                        Excel.Application aplicacion;
                        Excel.Workbook libros_trabajo;
                        Excel.Worksheet hoja_ingreso;

                        aplicacion = new Excel.Application();
                        libros_trabajo = (Excel.Workbook)aplicacion.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);

                        hoja_ingreso = (Excel.Worksheet)libros_trabajo.Worksheets.Add();
                        hoja_ingreso.Name = "Ingreso";
                        string cabecera = "Reporte de Ingreso";
                        ExportarDataGridViewExcel(ref hoja_ingreso, cabecera);


                        ((Excel.Worksheet)aplicacion.ActiveWorkbook.Sheets["Hoja1"]).Delete();

                        //libros_trabajo.SaveAs(fichero.FileName, Excel.XlFileFormat.xlWorkbookNormal);
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
                Cursor.Current = Cursors.Default;
            }
        }

        public void ExportarDataGridViewExcel(ref Excel.Worksheet hoja_trabajo, string nombreCabecera)
        {

            Cursor.Current = Cursors.WaitCursor;
            Excel.Range rango;
            int i = 0;

            //ORIGINAL
            /*
            int inicio = 10;
            int filaDetalle = inicio;
            int filaMemoria = inicio + ingreso.Detalles.Count + 4;
            int filaDisco = inicio + ingreso.Detalles.Count + 4 + ingreso.Memorias.Count + 4;
            int filaLicencia = inicio + ingreso.Detalles.Count + 4 + ingreso.Memorias.Count + 4 + ingreso.Discos.Count + 4;
            int filaImpresora = inicio + ingreso.Detalles.Count + 4 + ingreso.Memorias.Count + 4 + ingreso.Discos.Count + 4 + ingreso.Licencias.Count + 4;
            */


            int ultimaPosicion = 10;

            int inicio = 10;
            int filaDetalle = (ingreso.Detalles.Count > 0) ? inicio : -1;
            if (ingreso.Detalles.Count > 0) ultimaPosicion = ultimaPosicion + ingreso.Detalles.Count + 4;

            int filaMemoria = (ingreso.Memorias.Count > 0) ? ultimaPosicion : -1;
            if (ingreso.Memorias.Count > 0) ultimaPosicion = ultimaPosicion + ingreso.Memorias.Count + 4;

            int filaDisco = (ingreso.Discos.Count > 0) ? ultimaPosicion : -1;
            if (ingreso.Discos.Count > 0) ultimaPosicion = ultimaPosicion + ingreso.Discos.Count + 4;

            int filaLicencia = (ingreso.Licencias.Count > 0) ? ultimaPosicion : -1;
            if (ingreso.Licencias.Count > 0) ultimaPosicion = ultimaPosicion + ingreso.Licencias.Count + 4;

            int filaImpresora = (ingreso.DetallesImpresoras.Count > 0) ? ultimaPosicion : -1;
            if (ingreso.DetallesImpresoras.Count > 0) ultimaPosicion = ultimaPosicion + ingreso.DetallesImpresoras.Count + 4;

            int filaMonitor = (ingreso.DetallesMonitores.Count > 0) ? ultimaPosicion : -1;
            if (ingreso.DetallesMonitores.Count > 0) ultimaPosicion = ultimaPosicion + ingreso.DetallesMonitores.Count + 4;

            int filaTablet = (ingreso.DetallesTablets.Count > 0) ? ultimaPosicion : -1;
            if (ingreso.DetallesTablets.Count > 0) ultimaPosicion = ultimaPosicion + ingreso.DetallesTablets.Count + 4;

            int filaProyectorEcram = (ingreso.DetallesProyectores.Count > 0) ? ultimaPosicion : -1;
            if (ingreso.DetallesProyectores.Count > 0) ultimaPosicion = ultimaPosicion + ingreso.DetallesProyectores.Count + 4;



            /*
            if (ingreso.Detalles.Count > 0)
            {
                if (ingreso.Memorias.Count > 0)
                {
                    if (ingreso.Discos.Count > 0)
                    {
                        filaDetalle = inicio;
                        filaMemoria = inicio + ingreso.Detalles.Count + 4;
                        filaDisco = inicio + ingreso.Detalles.Count + 4 + ingreso.Memorias.Count + 4;
                        filaLicencia = inicio + ingreso.Detalles.Count + 4 + ingreso.Memorias.Count + 4 + ingreso.Discos.Count + 4;
                    }
                    else
                    {
                        filaDetalle = inicio;
                        filaMemoria = inicio + ingreso.Detalles.Count + 4;
                        filaLicencia = inicio + ingreso.Detalles.Count + 4 + ingreso.Memorias.Count + 4;
                    }
                }
                else
                {
                    if (ingreso.Discos.Count > 0)
                    {
                        filaDetalle = inicio;
                        filaDisco = inicio + ingreso.Detalles.Count + 4;
                        filaLicencia = inicio + ingreso.Detalles.Count + 4 + ingreso.Discos.Count + 4;
                    }
                    else
                    {
                        filaDetalle = inicio;
                        filaLicencia = inicio + ingreso.Detalles.Count + 4;
                    }

                }
            }
            else
            {
                if (ingreso.Memorias.Count > 0)
                {
                    if (ingreso.Discos.Count > 0)
                    {
                        filaMemoria = inicio;
                        filaDisco = inicio + ingreso.Memorias.Count + 4;
                        filaLicencia = inicio + ingreso.Memorias.Count + 4 + ingreso.Discos.Count + 4;
                    }
                    else
                    {
                        filaMemoria = inicio;
                        filaLicencia = inicio + ingreso.Memorias.Count + 4;
                    }
                }
                else
                {
                    if (ingreso.Discos.Count > 0)
                    {
                        filaDisco = inicio;
                        filaLicencia = inicio + ingreso.Discos.Count + 4;
                    }
                    else
                    {
                        filaLicencia = inicio;
                    }

                }
            }
            */




            //Recorremos el DataGridView rellenando la hoja de trabajo


            //==============================================================================================LAPTOPS/CPU
            foreach (IngresoDetalle det in ingreso.Detalles)
            {
                //int k = grd.Columns.Count + 64;
                int k = 15 + 64;
                char columF = (char)k;
                int fila2 = i + filaDetalle;
                string filaBorde = fila2.ToString();
                char columI = 'A';
                //Ponemos borde a las celdas
                rango = hoja_trabajo.Range[columI + fila2.ToString(), columF + fila2.ToString()];
                rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                rango.Style.Font.Bold = false;

                hoja_trabajo.Cells[i + filaDetalle, 1] = det.LaptopMarcaLC;
                hoja_trabajo.Cells[i + filaDetalle, 2] = det.LaptopNombreModeloLC;
                hoja_trabajo.Cells[i + filaDetalle, 3] = det.Laptop.PartNumber;
                hoja_trabajo.Cells[i + filaDetalle, 4] = (det.LaptopTamanoPantalla > 0) ? det.LaptopTamanoPantalla.ToString() : " ";
                hoja_trabajo.Cells[i + filaDetalle, 5] = (det.Laptop.Garantia == 1) ? "Si" : "No";
                hoja_trabajo.Cells[i + filaDetalle, 6] = det.Precio.ToString();
                hoja_trabajo.Cells[i + filaDetalle, 7] = det.Cantidad.ToString();
                string aux = "";
                aux = det.Laptop.Procesador.Modelo.NombreModelo + "/GEN" + det.Laptop.Procesador.Generacion.ToString();
                hoja_trabajo.Cells[i + filaDetalle, 8] = aux;
                hoja_trabajo.Cells[i + filaDetalle, 9] = (det.Laptop.Video.Capacidad > 0) ? det.Laptop.Video.Capacidad.ToString() + " GB" : " ";

                string tipoDisco1 = ""; int capDisco1 = 0; string tipoDisco2 = ""; int capDisco2 = 0;
                if (det.Laptop.Discos.Count > 0)
                {
                    if (det.Laptop.Discos.Count == 1)
                    {
                        tipoDisco1 = det.Laptop.Discos[0].TipoDisco;
                        capDisco1 = det.Laptop.Discos[0].Cantidad * det.Laptop.Discos[0].Capacidad;
                    }
                    else if (det.Laptop.Discos.Count >= 2)
                    {
                        tipoDisco1 = det.Laptop.Discos[0].TipoDisco;
                        capDisco1 = det.Laptop.Discos[0].Cantidad * det.Laptop.Discos[0].Capacidad;

                        tipoDisco2 = det.Laptop.Discos[1].TipoDisco;
                        capDisco2 = det.Laptop.Discos[1].Cantidad * det.Laptop.Discos[1].Capacidad;
                    }
                }

                hoja_trabajo.Cells[i + filaDetalle, 10] = (tipoDisco1.Length > 0) ? tipoDisco1 + " - " + capDisco1.ToString() + " GB" : "";
                hoja_trabajo.Cells[i + filaDetalle, 11] = (tipoDisco2.Length > 0) ? tipoDisco2 + " - " + capDisco2.ToString() + " GB" : "";

                int capacidadMem = 0;
                foreach (Memoria mem in det.Laptop.Memorias)
                {
                    capacidadMem += mem.Capacidad * mem.Cantidad;
                }
                hoja_trabajo.Cells[i + filaDetalle, 12] = capacidadMem.ToString() + " GB";

                Licencia windows = null; Licencia office = null; Licencia antivirus = null;

                if (det.Laptop.Licencias.Count > 0)
                {
                    windows = det.Laptop.Licencias.SingleOrDefault(p => p.Categoria == this.licenciaCategoriaSO);
                    office = det.Laptop.Licencias.SingleOrDefault(p => p.Categoria == this.licenciaCategoriaOffice);
                    antivirus = det.Laptop.Licencias.SingleOrDefault(p => p.Categoria == this.licenciaCategoriaAntivirus);

                }

                hoja_trabajo.Cells[i + filaDetalle, 13] = (windows != null) ? windows.Version : "";
                hoja_trabajo.Cells[i + filaDetalle, 14] = (office != null) ? office.Version : "";
                hoja_trabajo.Cells[i + filaDetalle, 15] = (antivirus != null) ? antivirus.Version : "";


                i++;
            }

            //==============================================================================================MEMORIAS
            i = 0;
            foreach (Memoria det in ingreso.Memorias)
            {
                //int k = grd.Columns.Count + 64;
                int k = 5 + 64;
                char columF = (char)k;
                int fila2 = i + filaMemoria;
                string filaBorde = fila2.ToString();
                char columI = 'A';
                //Ponemos borde a las celdas
                rango = hoja_trabajo.Range[columI + fila2.ToString(), columF + fila2.ToString()];
                rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                rango.Style.Font.Bold = false;

                hoja_trabajo.Cells[i + filaMemoria, 1] = det.TipoMemoria;
                hoja_trabajo.Cells[i + filaMemoria, 2] = det.Tipo;
                hoja_trabajo.Cells[i + filaMemoria, 3] = det.Capacidad;
                hoja_trabajo.Cells[i + filaMemoria, 4] = det.Cantidad;
                hoja_trabajo.Cells[i + filaMemoria, 5] = det.Precio.ToString();

                i++;
            }
            //==============================================================================================DISCO DURO
            i = 0;
            foreach (DiscoDuro det in ingreso.Discos)
            {
                //int k = grd.Columns.Count + 64;
                int k = 5 + 64;
                char columF = (char)k;
                int fila2 = i + filaDisco;
                string filaBorde = fila2.ToString();
                char columI = 'A';
                //Ponemos borde a las celdas
                rango = hoja_trabajo.Range[columI + fila2.ToString(), columF + fila2.ToString()];
                rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                rango.Style.Font.Bold = false;

                hoja_trabajo.Cells[i + filaDisco, 1] = det.TipoDisco;
                hoja_trabajo.Cells[i + filaDisco, 2] = det.Tamano;
                hoja_trabajo.Cells[i + filaDisco, 3] = det.Capacidad;
                hoja_trabajo.Cells[i + filaDisco, 4] = det.Cantidad;
                hoja_trabajo.Cells[i + filaDisco, 5] = det.Precio.ToString();

                i++;
            }

            //==============================================================================================LICENCIAS
            i = 0;
            foreach (Licencia det in ingreso.Licencias)
            {
                //int k = grd.Columns.Count + 64;
                int k = 6 + 64;
                char columF = (char)k;
                int fila2 = i + filaLicencia;
                string filaBorde = fila2.ToString();
                char columI = 'A';
                //Ponemos borde a las celdas
                rango = hoja_trabajo.Range[columI + fila2.ToString(), columF + fila2.ToString()];
                rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                rango.Style.Font.Bold = false;

                hoja_trabajo.Cells[i + filaLicencia, 1] = det.Categoria;
                hoja_trabajo.Cells[i + filaLicencia, 2] = det.Marca;
                hoja_trabajo.Cells[i + filaLicencia, 3] = det.Version;
                hoja_trabajo.Cells[i + filaLicencia, 4] = det.Clave;
                hoja_trabajo.Cells[i + filaLicencia, 5] = det.Cantidad;
                hoja_trabajo.Cells[i + filaLicencia, 6] = det.Precio.ToString();

                i++;
            }

            i = 0;
            foreach (IngresoDetalleImpresora det in ingreso.DetallesImpresoras)
            {
                //int k = grd.Columns.Count + 64;
                int k = 6 + 64;
                char columF = (char)k;
                int fila2 = i + filaImpresora;
                string filaBorde = fila2.ToString();
                char columI = 'A';
                //Ponemos borde a las celdas
                rango = hoja_trabajo.Range[columI + fila2.ToString(), columF + fila2.ToString()];
                rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                rango.Style.Font.Bold = false;

                hoja_trabajo.Cells[i + filaImpresora, 1] = det.ImpresoraMarca;
                hoja_trabajo.Cells[i + filaImpresora, 2] = det.ImpresoraNombreModelo;
                hoja_trabajo.Cells[i + filaImpresora, 3] = (det.ImpresoraMultifuncional == 1) ? "SI" : "NO";
                hoja_trabajo.Cells[i + filaImpresora, 4] = det.ImpresoraTipo;
                hoja_trabajo.Cells[i + filaImpresora, 5] = det.Cantidad;
                hoja_trabajo.Cells[i + filaImpresora, 6] = det.Precio;

                i++;
            }

            i = 0;
            foreach (IngresoDetalleMonitor det in ingreso.DetallesMonitores)
            {
                //int k = grd.Columns.Count + 64;
                int k = 9 + 64;
                char columF = (char)k;
                int fila2 = i + filaMonitor;
                string filaBorde = fila2.ToString();
                char columI = 'A';
                //Ponemos borde a las celdas
                rango = hoja_trabajo.Range[columI + fila2.ToString(), columF + fila2.ToString()];
                rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                rango.Style.Font.Bold = false;

                hoja_trabajo.Cells[i + filaMonitor, 1] = det.MonitorMarca;
                hoja_trabajo.Cells[i + filaMonitor, 2] = det.MonitorNombreModelo;
                hoja_trabajo.Cells[i + filaMonitor, 3] = det.MonitorTipo;
                hoja_trabajo.Cells[i + filaMonitor, 4] = det.MonitorTamanoPantalla;
                hoja_trabajo.Cells[i + filaMonitor, 5] = (det.MonitorHdmi == 1) ? "SI" : "NO";
                hoja_trabajo.Cells[i + filaMonitor, 6] = (det.MonitorVga == 1) ? "SI" : "NO";
                hoja_trabajo.Cells[i + filaMonitor, 7] = (det.MonitorDisplayPort == 1) ? "SI" : "NO";
                hoja_trabajo.Cells[i + filaMonitor, 8] = det.Cantidad;
                hoja_trabajo.Cells[i + filaMonitor, 9] = det.Precio;

                i++;
            }

            i = 0;
            foreach (IngresoDetalleTablet det in ingreso.DetallesTablets)
            {
                //int k = grd.Columns.Count + 64;
                int k = 8 + 64;
                char columF = (char)k;
                int fila2 = i + filaTablet;
                string filaBorde = fila2.ToString();
                char columI = 'A';
                //Ponemos borde a las celdas
                rango = hoja_trabajo.Range[columI + fila2.ToString(), columF + fila2.ToString()];
                rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                rango.Style.Font.Bold = false;

                hoja_trabajo.Cells[i + filaTablet, 1] = det.TabletMarca;
                hoja_trabajo.Cells[i + filaTablet, 2] = det.TabletNombreModelo;
                hoja_trabajo.Cells[i + filaTablet, 3] = det.TabletProcesador;


                hoja_trabajo.Cells[i + filaTablet, 4] = det.TabletRam + "GB";
                hoja_trabajo.Cells[i + filaTablet, 5] = det.TabletRom + "GB";


                hoja_trabajo.Cells[i + filaTablet, 6] = det.TabletTamanoPantalla;
                hoja_trabajo.Cells[i + filaTablet, 7] = det.Cantidad;
                hoja_trabajo.Cells[i + filaTablet, 8] = det.Precio;

                i++;
            }

            i = 0;
            foreach (IngresoDetalleProyector det in ingreso.DetallesProyectores)
            {
                //int k = grd.Columns.Count + 64;
                int k = 6 + 64;
                char columF = (char)k;
                int fila2 = i + filaProyectorEcram;
                string filaBorde = fila2.ToString();
                char columI = 'A';
                //Ponemos borde a las celdas
                rango = hoja_trabajo.Range[columI + fila2.ToString(), columF + fila2.ToString()];
                rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                rango.Style.Font.Bold = false;

                hoja_trabajo.Cells[i + filaProyectorEcram, 1] = det.ProyectorTipoEquipoProyector;
                hoja_trabajo.Cells[i + filaProyectorEcram, 2] = det.ProyectorMarca;
                hoja_trabajo.Cells[i + filaProyectorEcram, 3] = det.ProyectorNombreModelo;
                hoja_trabajo.Cells[i + filaProyectorEcram, 4] = det.ProyectorCaracteristica;
                hoja_trabajo.Cells[i + filaProyectorEcram, 5] = det.Cantidad;
                hoja_trabajo.Cells[i + filaProyectorEcram, 6] = det.Precio;

                i++;
            }

            //==============================================================================================MEMORIAS


            montaCabeceras(1, ref hoja_trabajo, nombreCabecera, filaDetalle, filaMemoria, filaDisco, filaLicencia, filaImpresora, filaMonitor, filaTablet, filaProyectorEcram);
        }

        private void montaCabeceras(int fila, ref Excel.Worksheet hoja, string nombreCabecera,
                                    int filaDetalle, int filaMemoria, int filaDisco, int filaLicencia, int filaImpresora, int filaMonitor, int filaTablet, int filaProyectorEcram)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                Excel.Range rango;

                //** Montamos el título en la línea 1 **
                hoja.Cells[fila, 1] = nombreCabecera;
                hoja.Range[hoja.Cells[fila, 1], hoja.Cells[fila, 15]].Merge();
                hoja.Range[hoja.Cells[fila, 1], hoja.Cells[fila, 15]].Interior.Color = Color.Orange;
                hoja.Range[hoja.Cells[fila, 1], hoja.Cells[fila, 15]].Style.Font.Bold = true;
                //Centramos los textos
                rango = hoja.Rows[fila];
                rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                //worksheet.Range[worksheet.Cells[rowNum, columnNum], worksheet.Cells[rowNum, columnNum]].Merge();
                int indice;

                hoja.Cells[fila + 1, 1] = "Ingreso N°";
                hoja.Cells[fila + 1, 2] = txtNroIngreso.Text;

                hoja.Cells[fila + 2, 1] = "Proveedor";
                hoja.Cells[fila + 2, 2] = ingreso.RazonSocial;
                hoja.Cells[fila + 3, 1] = "RUC";
                hoja.Cells[fila + 3, 2] = ingreso.Ruc;
                hoja.Cells[fila + 4, 1] = "Tipo Ingreso";
                hoja.Cells[fila + 4, 2] = ingreso.TipoIngreso;

                hoja.Cells[fila + 2, 5] = "Tipo Moneda";
                hoja.Cells[fila + 2, 6] = ingreso.MonedaTipo;
                hoja.Cells[fila + 3, 5] = "Monto Cambio";
                hoja.Cells[fila + 3, 6] = (ingreso.MontoCambio == 0) ? "" : ingreso.MontoCambio.ToString();
                hoja.Cells[fila + 4, 5] = "Monto Total";
                hoja.Cells[fila + 4, 6] = ingreso.Total.ToString();

                hoja.Cells[fila + 2, 8] = "Fecha Ingreso";
                hoja.Cells[fila + 2, 9] = ingreso.FechaIngreso.ToString("yyyy/MM/dd");
                hoja.Cells[fila + 3, 8] = "N° Factura";
                hoja.Cells[fila + 3, 9] = txtFactura.Text;
                hoja.Cells[fila + 4, 8] = "N° Guia";
                hoja.Cells[fila + 4, 9] = txtGuia.Text;


                if (ingreso.Detalles.Count > 0)
                {
                    hoja.Cells[filaDetalle - 2, 1] = "LAPTOP/CPU";
                    hoja.Cells[filaDetalle - 1, 1] = "Marca";
                    hoja.Cells[filaDetalle - 1, 2] = "Modelo";
                    hoja.Cells[filaDetalle - 1, 3] = "Part Number";
                    hoja.Cells[filaDetalle - 1, 4] = "Pantalla";
                    hoja.Cells[filaDetalle - 1, 5] = "Garantía";
                    hoja.Cells[filaDetalle - 1, 6] = "Precio";
                    hoja.Cells[filaDetalle - 1, 7] = "Cantidad";
                    hoja.Cells[filaDetalle - 1, 8] = "Procesador";
                    hoja.Cells[filaDetalle - 1, 9] = "Video";
                    hoja.Cells[filaDetalle - 1, 10] = "Disco 1";
                    hoja.Cells[filaDetalle - 1, 11] = "Disco 2";
                    hoja.Cells[filaDetalle - 1, 12] = "Memoria";
                    hoja.Cells[filaDetalle - 1, 13] = "S.O";
                    hoja.Cells[filaDetalle - 1, 14] = "Office";
                    hoja.Cells[filaDetalle - 1, 15] = "Antivirus";

                    //int i = grd.Columns.Count + 64;
                    int i = 15 + 64;
                    char columF = (char)i;
                    int fila2 = filaDetalle - 1;
                    string filaBorde = fila2.ToString();
                    char columI = 'A';
                    //Ponemos borde a las celdas
                    rango = hoja.Range[columI + fila2.ToString(), columF + fila2.ToString()];
                    rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    rango.Interior.Color = Color.Orange;
                    rango.Style.Font.Bold = true;
                    //Centramos los textos
                    rango = hoja.Rows[fila2];
                    rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    //for (int j = 0; j < grd.Columns.Count; j++)
                    for (int j = 0; j < 15; j++)
                    {
                        rango = hoja.Columns[j + 1];
                        rango.ColumnWidth = 13;
                    }
                }
                if (ingreso.Memorias.Count > 0)
                {
                    hoja.Cells[filaMemoria - 2, 1] = "Memorias";
                    hoja.Cells[filaMemoria - 1, 1] = "Modelo";
                    hoja.Cells[filaMemoria - 1, 2] = "Tipo";
                    hoja.Cells[filaMemoria - 1, 3] = "Capacidad";
                    hoja.Cells[filaMemoria - 1, 4] = "Cantidad";
                    hoja.Cells[filaMemoria - 1, 5] = "Precio";

                    //int i = grd.Columns.Count + 64;
                    int i = 5 + 64;
                    char columF = (char)i;
                    int fila2 = filaMemoria - 1;
                    string filaBorde = fila2.ToString();
                    char columI = 'A';
                    //Ponemos borde a las celdas
                    rango = hoja.Range[columI + fila2.ToString(), columF + fila2.ToString()];
                    rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    rango.Interior.Color = Color.Orange;
                    rango.Style.Font.Bold = true;
                    //Centramos los textos
                    rango = hoja.Rows[fila2];
                    rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    for (int j = 0; j < 5; j++)
                    {
                        rango = hoja.Columns[j + 1];
                        rango.ColumnWidth = 13;
                    }
                }

                if (ingreso.Discos.Count > 0)
                {
                    hoja.Cells[filaDisco - 2, 1] = "Discos";
                    hoja.Cells[filaDisco - 1, 1] = "Tipo";
                    hoja.Cells[filaDisco - 1, 2] = "Tamaño";
                    hoja.Cells[filaDisco - 1, 3] = "Capacidad";
                    hoja.Cells[filaDisco - 1, 4] = "Cantidad";
                    hoja.Cells[filaDisco - 1, 5] = "Precio";

                    //int i = grd.Columns.Count + 64;
                    int i = 5 + 64;
                    char columF = (char)i;
                    int fila2 = filaDisco - 1;
                    string filaBorde = fila2.ToString();
                    char columI = 'A';
                    //Ponemos borde a las celdas
                    rango = hoja.Range[columI + fila2.ToString(), columF + fila2.ToString()];
                    rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    rango.Interior.Color = Color.Orange;
                    rango.Style.Font.Bold = true;
                    //Centramos los textos
                    rango = hoja.Rows[fila2];
                    rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    for (int j = 0; j < 5; j++)
                    {
                        rango = hoja.Columns[j + 1];
                        rango.ColumnWidth = 13;
                    }
                }

                if (ingreso.Licencias.Count > 0)
                {
                    hoja.Cells[filaLicencia - 2, 1] = "Licencias";
                    hoja.Cells[filaLicencia - 1, 1] = "Categoria";
                    hoja.Cells[filaLicencia - 1, 2] = "Marca";
                    hoja.Cells[filaLicencia - 1, 3] = "Version";
                    hoja.Cells[filaLicencia - 1, 4] = "Clave";
                    hoja.Cells[filaLicencia - 1, 5] = "Cantidad";
                    hoja.Cells[filaLicencia - 1, 6] = "Precio";

                    //int i = grd.Columns.Count + 64;
                    int i = 6 + 64;
                    char columF = (char)i;
                    int fila2 = filaLicencia - 1;
                    string filaBorde = fila2.ToString();
                    char columI = 'A';
                    //Ponemos borde a las celdas
                    rango = hoja.Range[columI + fila2.ToString(), columF + fila2.ToString()];
                    rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    rango.Interior.Color = Color.Orange;
                    rango.Style.Font.Bold = true;
                    //Centramos los textos
                    rango = hoja.Rows[fila2];
                    rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    for (int j = 0; j < 6; j++)
                    {
                        rango = hoja.Columns[j + 1];
                        rango.ColumnWidth = 13;
                    }
                }

                if (ingreso.DetallesImpresoras.Count > 0)
                {
                    hoja.Cells[filaImpresora - 2, 1] = "IMPRESORAS";
                    hoja.Cells[filaImpresora - 1, 1] = "Marca";
                    hoja.Cells[filaImpresora - 1, 2] = "Modelo";
                    hoja.Cells[filaImpresora - 1, 3] = "Multifuncional";
                    hoja.Cells[filaImpresora - 1, 4] = "Tipo";
                    hoja.Cells[filaImpresora - 1, 5] = "Cantidad";
                    hoja.Cells[filaImpresora - 1, 6] = "Precio";

                    //int i = grd.Columns.Count + 64;
                    int i = 6 + 64;
                    char columF = (char)i;
                    int fila2 = filaImpresora - 1;
                    string filaBorde = fila2.ToString();
                    char columI = 'A';
                    //Ponemos borde a las celdas
                    rango = hoja.Range[columI + fila2.ToString(), columF + fila2.ToString()];
                    rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    rango.Interior.Color = Color.Orange;
                    rango.Style.Font.Bold = true;
                    //Centramos los textos
                    rango = hoja.Rows[fila2];
                    rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    for (int j = 0; j < 4; j++)
                    {
                        rango = hoja.Columns[j + 1];
                        rango.ColumnWidth = 13;
                    }
                }

                if (ingreso.DetallesMonitores.Count > 0)
                {
                    hoja.Cells[filaMonitor - 2, 1] = "MONITOR";
                    hoja.Cells[filaMonitor - 1, 1] = "Marca";
                    hoja.Cells[filaMonitor - 1, 2] = "Modelo";
                    hoja.Cells[filaMonitor - 1, 3] = "Tipo";
                    hoja.Cells[filaMonitor - 1, 4] = "Tamaño Pantalla";
                    hoja.Cells[filaMonitor - 1, 5] = "Hdmi";
                    hoja.Cells[filaMonitor - 1, 6] = "Vga";
                    hoja.Cells[filaMonitor - 1, 7] = "Display Port";
                    hoja.Cells[filaMonitor - 1, 8] = "Cantidad";
                    hoja.Cells[filaMonitor - 1, 9] = "Precio";

                    //int i = grd.Columns.Count + 64;
                    int i = 9 + 64;
                    char columF = (char)i;
                    int fila2 = filaMonitor - 1;
                    string filaBorde = fila2.ToString();
                    char columI = 'A';
                    //Ponemos borde a las celdas
                    rango = hoja.Range[columI + fila2.ToString(), columF + fila2.ToString()];
                    rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    rango.Interior.Color = Color.Orange;
                    rango.Style.Font.Bold = true;
                    //Centramos los textos
                    rango = hoja.Rows[fila2];
                    rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    for (int j = 0; j < 4; j++)
                    {
                        rango = hoja.Columns[j + 1];
                        rango.ColumnWidth = 13;
                    }
                }

                if (ingreso.DetallesTablets.Count > 0)
                {
                    hoja.Cells[filaTablet - 2, 1] = "TABLET";
                    hoja.Cells[filaTablet - 1, 1] = "Marca";
                    hoja.Cells[filaTablet - 1, 2] = "Modelo";
                    hoja.Cells[filaTablet - 1, 3] = "Procesador";
                    hoja.Cells[filaTablet - 1, 4] = "Ram";
                    hoja.Cells[filaTablet - 1, 5] = "Rom";
                    hoja.Cells[filaTablet - 1, 6] = "Tamaño Pantalla";
                    hoja.Cells[filaTablet - 1, 7] = "Cantidad";
                    hoja.Cells[filaTablet - 1, 8] = "Precio";

                    //int i = grd.Columns.Count + 64;
                    int i = 8 + 64;
                    char columF = (char)i;
                    int fila2 = filaTablet - 1;
                    string filaBorde = fila2.ToString();
                    char columI = 'A';
                    //Ponemos borde a las celdas
                    rango = hoja.Range[columI + fila2.ToString(), columF + fila2.ToString()];
                    rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    rango.Interior.Color = Color.Orange;
                    rango.Style.Font.Bold = true;
                    //Centramos los textos
                    rango = hoja.Rows[fila2];
                    rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    for (int j = 0; j < 4; j++)
                    {
                        rango = hoja.Columns[j + 1];
                        rango.ColumnWidth = 13;
                    }
                }

                if (ingreso.DetallesProyectores.Count > 0)
                {
                    hoja.Cells[filaProyectorEcram - 2, 1] = "PROYECTOR/ECRAM";
                    hoja.Cells[filaProyectorEcram - 1, 1] = "Tipo";
                    hoja.Cells[filaProyectorEcram - 1, 2] = "Marca";
                    hoja.Cells[filaProyectorEcram - 1, 3] = "Modelo";
                    hoja.Cells[filaProyectorEcram - 1, 4] = "Caracteristica";
                    hoja.Cells[filaProyectorEcram - 1, 5] = "Cantidad";
                    hoja.Cells[filaProyectorEcram - 1, 6] = "Precio";

                    //int i = grd.Columns.Count + 64;
                    int i = 6 + 64;
                    char columF = (char)i;
                    int fila2 = filaProyectorEcram - 1;
                    string filaBorde = fila2.ToString();
                    char columI = 'A';
                    //Ponemos borde a las celdas
                    rango = hoja.Range[columI + fila2.ToString(), columF + fila2.ToString()];
                    rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    rango.Interior.Color = Color.Orange;
                    rango.Style.Font.Bold = true;
                    //Centramos los textos
                    rango = hoja.Rows[fila2];
                    rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    for (int j = 0; j < 4; j++)
                    {
                        rango = hoja.Columns[j + 1];
                        rango.ColumnWidth = 13;
                    }
                }

                //======================================================AQUI PONER LO DEMAS



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de redondeo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void releaseObject(object obj)
        {
            Cursor.Current = Cursors.WaitCursor;
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

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cmbTipoIngreso.SelectedIndex != -1)
            {
                //! 0 -> COMPRA
                //! 1 -> SUBARRIENDO
                string tipo = cmbTipoIngreso.SelectedIndex.ToString();

                try
                {
                    IngresoDetalle detalle = new IngresoDetalle();
                    using (frmProcesoIngresoLaptopCpu frm = new frmProcesoIngresoLaptopCpu(this.idUsuario, this.nombreUsuario, tipo))
                    {
                        if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            BindingList<IngresoDetalle> auxiliares = new BindingList<IngresoDetalle>();
                            foreach (IngresoDetalle aux in ingreso.Detalles)
                            {
                                auxiliares.Add(aux);
                            }
                            detalle = frm.DETALLE;
                            detalle.IdIngresoDetalle = ingreso.Detalles.Count + 1;
                            auxiliares.Add(detalle);
                            ingreso.Detalles = auxiliares;
                            //ingreso.Detalles.Add(detalle);
                            dgvLaptopsSeleccionados.DataSource = ingreso.Detalles;
                            vistaLaptops.OptionsBehavior.AutoPopulateColumns = false;
                            vistaLaptops.OptionsSelection.MultiSelect = true;

                            ObtenerTotal();
                        }
                    }
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("Seleccione el tipo de ingreso");
            }

        }

        private void dgvLaptopsSeleccionados_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro deseas Eliminar esta detalle de Ingreso", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                int detTempId = -1;
                vistaLaptops.ClearColumnsFilter();

                for (int i = 0; i < vistaLaptops.RowCount; i++)
                    if (vistaLaptops.IsRowSelected(i) == true)
                        detTempId = int.Parse(vistaLaptops.GetRowCellValue(i, "IdIngresoDetalle").ToString());

                if (detTempId != -1)
                {
                    int indiceLC = 0;
                    foreach (IngresoDetalle detalle in ingreso.Detalles)
                    {
                        if (detalle.IdIngresoDetalle == detTempId)
                        {
                            break;
                        }
                        indiceLC++;
                    }

                    ingreso.Detalles.RemoveAt(indiceLC);
                    for (int i = 0; i < ingreso.Detalles.Count; i++)
                    {
                        ingreso.Detalles[i].IdIngresoDetalle = i + 1;
                    }

                    dgvLaptopsSeleccionados.DataSource = ingreso.Detalles;
                }
            }
            ObtenerTotal();

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {



            Cursor.Current = Cursors.WaitCursor;
            string numIngreso = txtNroIngreso.Text;
            if (cmbProveedor.SelectedValue == null)
            {
                MessageBox.Show("No se puede grabar un Ingreso si no\nha seleccionado un proveedor correcto.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return;
            }

            if (cmbTipoIngreso.SelectedIndex == -1)
            {
                MessageBox.Show("No se puede grabar un Ingreso si no\nespecifica el tipo de ingreso.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return;
            }

            if (cmbMonedaTipo.SelectedIndex == -1)
            {
                MessageBox.Show("No se puede grabar un Ingreso si no\nespecifica el tipo de moneda.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return;
            }

            if (cmbSede.SelectedIndex == -1)
            {
                MessageBox.Show("No se puede grabar un Ingreso si no\nespecifica la sede.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return;
            }
            ObtenerDatosIngreso();
            if (ValidarDatos())
            {
                return;
            }

            //MessageBox.Show(ingreso.Total.ToString());

            Cursor.Current = Cursors.WaitCursor;

            //VALIDAR SI ES COMPRA (0)  O ARRENDAMIENTO (1)
            //! 0 -> COMPRA
            //! 1 -> SUBARRIENDO

            if (numIngreso.Length == 0)
            {
                if (MessageBox.Show("Estas seguro que deseas Guardar este proceso de Ingreso", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {

                    int idIngreso = ingresoDA.InsertarIngreso(ingreso, this.nombreUsuario);


                    if (idIngreso == -1)
                    {
                        MessageBox.Show("Hubo error en Registrar el Ingreso, comunicarse con tu soporte", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    for (int i = 0; i < ingreso.Detalles.Count; i++)
                    {
                        ingreso.Detalles[i].IdIngresoDetalle = i + 1;
                    }
                    dgvLaptopsSeleccionados.DataSource = ingreso.Detalles;


                    for (int i = 0; i < ingreso.DetallesImpresoras.Count; i++)
                    {
                        ingreso.DetallesImpresoras[i].IdIngresoDetalleImpresora = i + 1;
                    }
                    dgvImpresoras.DataSource = ingreso.DetallesImpresoras;


                    for (int i = 0; i < ingreso.DetallesTablets.Count; i++)
                    {
                        ingreso.DetallesTablets[i].IdIngresoDetalleTablet = i + 1;
                    }
                    dgvTablets.DataSource = ingreso.DetallesTablets;


                    for (int i = 0; i < ingreso.DetallesMonitores.Count; i++)
                    {
                        ingreso.DetallesMonitores[i].IdIngresoDetalleMonitor = i + 1;
                    }
                    dgvMonitores.DataSource = ingreso.DetallesMonitores;


                    for (int i = 0; i < ingreso.DetallesProyectores.Count; i++)
                    {
                        ingreso.DetallesProyectores[i].IdIngresoDetalleProyector = i + 1;
                    }
                    dgvProyectores.DataSource = ingreso.DetallesProyectores;


                    MessageBox.Show("Se guardó el Ingreso", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    ingreso.IdIngreso = idIngreso;
                    txtNroIngreso.Text = idIngreso.ToString();
                    estadoComponentes(TipoVista.Guardar);
                }
            }
            else
            {
                if (MessageBox.Show("Estas seguro que desea Guardar los cambios", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    ingresoDA.ModificarIngreso(ingreso, this.nombreUsuario);
                    for (int i = 0; i < ingreso.Detalles.Count; i++)
                    {
                        ingreso.Detalles[i].IdIngresoDetalle = i + 1;
                    }
                    dgvLaptopsSeleccionados.DataSource = ingreso.Detalles;


                    for (int i = 0; i < ingreso.DetallesImpresoras.Count; i++)
                    {
                        ingreso.DetallesImpresoras[i].IdIngresoDetalleImpresora = i + 1;
                    }
                    dgvImpresoras.DataSource = ingreso.DetallesImpresoras;


                    for (int i = 0; i < ingreso.DetallesTablets.Count; i++)
                    {
                        ingreso.DetallesTablets[i].IdIngresoDetalleTablet = i + 1;
                    }
                    dgvTablets.DataSource = ingreso.DetallesTablets;


                    for (int i = 0; i < ingreso.DetallesMonitores.Count; i++)
                    {
                        ingreso.DetallesMonitores[i].IdIngresoDetalleMonitor = i + 1;
                    }
                    dgvMonitores.DataSource = ingreso.DetallesMonitores;


                    for (int i = 0; i < ingreso.DetallesProyectores.Count; i++)
                    {
                        ingreso.DetallesProyectores[i].IdIngresoDetalleProyector = i + 1;
                    }
                    dgvProyectores.DataSource = ingreso.DetallesProyectores;

                    MessageBox.Show("Se Modifico el Ingreso N° :" + txtNroIngreso.Text + " con exito", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    estadoComponentes(TipoVista.Guardar);
                }
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            vistaLaptops.ClearColumnsFilter();

            int detTempId = -1;
            for (int i = 0; i < vistaLaptops.RowCount; i++)
                if (vistaLaptops.IsRowSelected(i) == true)
                    detTempId = int.Parse(vistaLaptops.GetRowCellValue(i, "IdIngresoDetalle").ToString());

            if (detTempId != -1)
            {
                IngresoDetalle det = new IngresoDetalle();
                int indiceLC = 0;
                if (vistaLaptops.RowCount == 0) return;
                if (vistaLaptops.RowCount > 0)
                {
                    for (int i = 0; i < vistaLaptops.RowCount; i++)
                        if (vistaLaptops.IsRowSelected(i) == true)
                            detTempId = int.Parse(vistaLaptops.GetRowCellValue(i, "IdIngresoDetalle").ToString());
                    //detTempId = int.Parse(((GridCell)(((GridRow)dgvLaptopsSeleccionados.PrimaryGrid.ActiveRow)[6])).Value.ToString());

                    foreach (IngresoDetalle detalle in ingreso.Detalles)
                    {
                        if (detalle.IdIngresoDetalle == detTempId)
                            break;
                        indiceLC++;
                    }
                }

                string tipo = cmbTipoIngreso.SelectedIndex.ToString();
                using (frmProcesoIngresoLaptopCpu frm = new frmProcesoIngresoLaptopCpu(this.idUsuario, this.nombreUsuario, tipo, ingreso.Detalles[indiceLC]))
                {

                    ObtenerTotal();
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (vistaLaptops.RowCount > 0)
                        {
                            for (int i = 0; i < vistaLaptops.RowCount; i++)
                                if (vistaLaptops.IsRowSelected(i) == true)
                                    detTempId = int.Parse(vistaLaptops.GetRowCellValue(i, "IdIngresoDetalle").ToString());
                            //detTempId = int.Parse(((GridCell)(((GridRow)dgvLaptopsSeleccionados.PrimaryGrid.ActiveRow)[6])).Value.ToString());

                            int indiceLC2 = 0;
                            foreach (IngresoDetalle detalle in ingreso.Detalles)
                            {
                                if (detalle.IdIngresoDetalle == detTempId)
                                {
                                    break;
                                }
                                indiceLC2++;
                            }

                            ingreso.Detalles.RemoveAt(indiceLC2);
                            for (int i = 0; i < ingreso.Detalles.Count; i++)
                            {
                                ingreso.Detalles[i].IdIngresoDetalle = i + 1;
                            }

                            dgvLaptopsSeleccionados.DataSource = ingreso.Detalles;
                        }

                        det = frm.DETALLE;
                        det.IdIngresoDetalle = ingreso.Detalles.Count + 1;
                        ingreso.Detalles.Add(det);
                        dgvLaptopsSeleccionados.DataSource = ingreso.Detalles;
                        ObtenerTotal();
                    }
                }
            }
        }

        private void txtMontoCambio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = solonumeros(Convert.ToInt32(e.KeyChar));
        }

        public bool solonumeros(int code)
        {
            bool resultado;

            if (code == 46 && txtMontoCambio.Text.Contains("."))//se evalua si es punto y si es punto se rebiza si ya existe en el textbox
            {
                resultado = true;
            }
            else if ((((code >= 48) && (code <= 57)) || (code == 8) || code == 46)) //se evaluan las teclas validas
            {
                resultado = false;
            }
            else if (!permitir)
            {
                resultado = permitir;
            }
            else
            {
                resultado = true;
            }

            return resultado;
        }

        private void btnAgregarLicencia_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmProcesoIngresoLicencia frm = new frmProcesoIngresoLicencia())
                {
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        BindingList<Licencia> auxiliares = new BindingList<Licencia>();
                        foreach (Licencia aux in ingreso.Licencias)
                        {
                            auxiliares.Add(aux);
                        }

                        foreach (Licencia licenciaTraido in frm.LICENCIAS)
                        {
                            Licencia licTemp = new Licencia();
                            licTemp.IdModelo = licenciaTraido.IdModelo;
                            //bool exists = ingreso.Licencias.Any(x => x.IdModelo.Equals(licTemp.IdModelo));
                            bool exists = false;
                            if (!(exists))
                            {

                                licTemp.IdLicencia = auxiliares.Count + 1;
                                licTemp.Categoria = licenciaTraido.Categoria;
                                licTemp.IdModelo = licenciaTraido.IdModelo;
                                licTemp.Marca = licenciaTraido.Marca;
                                licTemp.Version = licenciaTraido.Version;
                                licTemp.Clave = licenciaTraido.Clave;
                                licTemp.Cantidad = licenciaTraido.Cantidad;
                                licTemp.Precio = 0.00;

                                auxiliares.Add(licTemp);
                            }
                        }
                        ingreso.Licencias = auxiliares;
                        dgvLicencias.DataSource = ingreso.Licencias;

                        ObtenerTotal();
                    }
                }
            }
            catch
            {

            }

        }

        private void dgvLicencias_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Estas seguro deseas Eliminar esta licencia", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    vistaLicencias.ClearColumnsFilter();
                    int detTempId = -1;
                    int h = 0;
                    for (h = 0; h < vistaLicencias.RowCount; h++)
                        if (vistaLicencias.IsRowSelected(h) == true)
                        {
                            detTempId = int.Parse(vistaLicencias.GetRowCellValue(h, "IdLicencia").ToString());
                            break;
                        }

                    if (detTempId != -1)
                    {
                        int indiceLC = 0;
                        foreach (Licencia licencia in ingreso.Licencias)
                        {
                            if (licencia.IdLicencia == detTempId)
                            {
                                break;
                            }
                            indiceLC++;
                        }
                        ingreso.Licencias.RemoveAt(indiceLC);

                        for (int i = 0; i < ingreso.Licencias.Count; i++)
                        {
                            ingreso.Licencias[i].IdLicencia = i + 1;
                        }

                        dgvLicencias.DataSource = ingreso.Licencias;
                    }

                }
                ObtenerTotal();
            }
            catch
            {
                MessageBox.Show("Entro al try cath1");
            }

        }

        private void vistaLicencias_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                vistaLicencias.ClearColumnsFilter();
                int idLicencia = -1;
                int h = 0;
                for (h = 0; h < vistaLicencias.RowCount; h++)
                    if (vistaLicencias.IsRowSelected(h) == true)
                    {
                        idLicencia = int.Parse(vistaLicencias.GetRowCellValue(h, "IdLicencia").ToString());
                        break;
                    }

                int aux;
                int cantidadLicencia;
                double auxDouble;
                double precio;
                string myStr;
                string clave = "";
                if (!(idLicencia == -1))
                {
                    myStr = vistaLicencias.GetRowCellValue(h, "Cantidad").ToString();
                    myStr = myStr.TrimStart('0');

                    if (myStr.Length > 0)
                    {
                        aux = int.Parse(myStr);
                        if (aux < 0) myStr = "1";
                    }
                    else myStr = "1";
                    cantidadLicencia = myStr.Length > 0 ? int.Parse(myStr) : 1;
                    //vistaLicencias.SetRowCellValue(h, "Cantidad", cantidadLicencia);

                    if (vistaLicencias.GetRowCellValue(h, "Clave") != null)
                    {
                        clave = vistaLicencias.GetRowCellValue(h, "Clave").ToString();
                        clave = clave.Trim();
                    }
                    //vistaLicencias.SetRowCellValue(h, "Clave", clave);

                    myStr = vistaLicencias.GetRowCellValue(h, "Precio").ToString(); ;
                    myStr = myStr.TrimStart('0');

                    if (myStr.Length > 0)
                    {
                        auxDouble = double.Parse(myStr);
                        if (auxDouble < 0) myStr = "0.00";
                    }
                    else myStr = "0";
                    precio = myStr.Length > 0 ? double.Parse(myStr) : 0.00;

                    //vistaLicencias.SetRowCellValue(h, "Precio", precio);

                    for (int j = 0; j < ingreso.Licencias.Count; j++)
                    {
                        if (idLicencia == ingreso.Licencias[j].IdLicencia)
                        {
                            ingreso.Licencias[j].Cantidad = cantidadLicencia;
                            ingreso.Licencias[j].Clave = clave;
                            ingreso.Licencias[j].Precio = precio;
                            break;
                        }
                    }
                    dgvLicencias.DataSource = ingreso.Licencias;
                }
                ObtenerTotal();
            }
            catch
            {
                MessageBox.Show("Entro al try cath2");
            }

        }

        private void btnAgregarMemoria_Click(object sender, EventArgs e)
        {
            using (frmProcesoIngresoMemoria frm = new frmProcesoIngresoMemoria())
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    BindingList<Memoria> auxiliares = new BindingList<Memoria>();
                    foreach (Memoria aux in ingreso.Memorias)
                    {
                        auxiliares.Add(aux);
                    }
                    foreach (Memoria memoriaTraido in frm.MEMORIAS)
                    {
                        Memoria memTemp = new Memoria();
                        memTemp.IdMemoria = memoriaTraido.IdMemoria;
                        bool exists = auxiliares.Any(x => x.IdMemoria.Equals(memTemp.IdMemoria));
                        if (!(exists))
                        {
                            memTemp.TipoMemoria = memoriaTraido.TipoMemoria;
                            memTemp.Tipo = memoriaTraido.Tipo;
                            memTemp.Capacidad = memoriaTraido.Capacidad;
                            memTemp.Cantidad = 1;
                            memTemp.Precio = 0.00;
                            auxiliares.Add(memTemp);
                        }
                    }
                    ingreso.Memorias = auxiliares;
                    dgvMemoria.DataSource = ingreso.Memorias;

                    ObtenerTotal();
                }
            }

        }

        private void dgvMemoria_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro deseas Eliminar esta memoria", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

                vistaMemoria.ClearColumnsFilter();

                int memoriaID = -1;
                int h = 0;
                for (h = 0; h < vistaMemoria.RowCount; h++)
                    if (vistaMemoria.IsRowSelected(h) == true)
                    {
                        memoriaID = int.Parse(vistaMemoria.GetRowCellValue(h, "IdMemoria").ToString());
                        break;
                    }

                if (memoriaID != -1)
                {
                    BindingList<Memoria> memorias = new BindingList<Memoria>();
                    for (int i = 0; i < vistaMemoria.RowCount; i++)
                    {
                        Memoria memoria = new Memoria();
                        memoria.IdMemoria = int.Parse(vistaMemoria.GetRowCellValue(i, "IdMemoria").ToString());
                        if (memoriaID != memoria.IdMemoria)
                        {
                            memoria.TipoMemoria = vistaMemoria.GetRowCellValue(i, "TipoMemoria").ToString();
                            memoria.Tipo = vistaMemoria.GetRowCellValue(i, "Tipo2").ToString();
                            memoria.Capacidad = int.Parse(vistaMemoria.GetRowCellValue(i, "Capacidad").ToString());
                            memoria.Cantidad = int.Parse(vistaMemoria.GetRowCellValue(i, "Cantidad").ToString());
                            memoria.Precio = Double.Parse(vistaMemoria.GetRowCellValue(i, "Precio").ToString());
                            memorias.Add(memoria);
                        }
                    }
                    ingreso.Memorias = memorias;
                    dgvMemoria.DataSource = ingreso.Memorias;
                }
            }
            ObtenerTotal();
        }

        private void vistaMemoria_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            vistaMemoria.ClearColumnsFilter();
            int memoriaId = -1;
            int h = 0;
            for (h = 0; h < vistaMemoria.RowCount; h++)
                if (vistaMemoria.IsRowSelected(h) == true)
                {
                    memoriaId = int.Parse(vistaMemoria.GetRowCellValue(h, "IdMemoria").ToString());
                    break;
                }

            int aux;
            double auxDouble;
            double precio;
            int cantidadMemoria;
            string myStr;
            if (!(memoriaId == -1))
            {
                myStr = vistaMemoria.GetRowCellValue(h, "Cantidad").ToString();
                myStr = myStr.TrimStart('0');

                if (myStr.Length > 0)
                {
                    aux = int.Parse(myStr);
                    if (aux < 0) myStr = "1";
                }
                else myStr = "1";
                cantidadMemoria = myStr.Length > 0 ? int.Parse(myStr) : 1;


                myStr = vistaMemoria.GetRowCellValue(h, "Precio").ToString();
                myStr = myStr.TrimStart('0');

                if (myStr.Length > 0)
                {
                    auxDouble = double.Parse(myStr);
                    if (auxDouble < 0) myStr = "0.00";
                }
                else myStr = "0";
                precio = myStr.Length > 0 ? double.Parse(myStr) : 0.00;

                for (int j = 0; j < ingreso.Memorias.Count; j++)
                {
                    if (memoriaId == ingreso.Memorias[j].IdMemoria)
                    {
                        ingreso.Memorias[j].Cantidad = cantidadMemoria;
                        ingreso.Memorias[j].Precio = precio;
                    }
                }
                dgvMemoria.DataSource = ingreso.Memorias;
            }
            ObtenerTotal();
        }

        private void btnAgregarDisco_Click(object sender, EventArgs e)
        {
            using (frmProcesoIngresoDisco frm = new frmProcesoIngresoDisco())
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    BindingList<DiscoDuro> auxiliares = new BindingList<DiscoDuro>();
                    foreach (DiscoDuro aux in ingreso.Discos)
                    {
                        auxiliares.Add(aux);
                    }

                    foreach (DiscoDuro discoTraido in frm.DISCOS)
                    {
                        DiscoDuro disTemp = new DiscoDuro();
                        disTemp.IdDisco = discoTraido.IdDisco;
                        bool exists = auxiliares.Any(x => x.IdDisco.Equals(disTemp.IdDisco));
                        if (!(exists))
                        {
                            disTemp.TipoDisco = discoTraido.TipoDisco;
                            disTemp.Capacidad = discoTraido.Capacidad;
                            disTemp.Tamano = discoTraido.Tamano;
                            disTemp.Cantidad = 1;
                            disTemp.Precio = 0.00;
                            auxiliares.Add(disTemp);
                        }
                    }
                    ingreso.Discos = auxiliares;
                    dgvDiscos.DataSource = ingreso.Discos;

                    ObtenerTotal();
                }
            }

        }

        private void dgvDiscos_DoubleClick(object sender, EventArgs e)
        {

            if (MessageBox.Show("Estas seguro deseas Eliminar este disco", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                vistaDiscos.ClearColumnsFilter();

                int discoID = -1;
                int h = 0;
                for (h = 0; h < vistaDiscos.RowCount; h++)
                    if (vistaDiscos.IsRowSelected(h) == true)
                    {
                        discoID = int.Parse(vistaDiscos.GetRowCellValue(h, "IdDisco").ToString());
                        break;
                    }

                if (discoID != -1)
                {
                    BindingList<DiscoDuro> discos = new BindingList<DiscoDuro>();
                    for (int i = 0; i < vistaDiscos.RowCount; i++)
                    {
                        DiscoDuro disco = new DiscoDuro();
                        disco.IdDisco = int.Parse(vistaDiscos.GetRowCellValue(i, "IdDisco").ToString());
                        if (discoID != disco.IdDisco)
                        {
                            disco.TipoDisco = vistaDiscos.GetRowCellValue(i, "TipoDisco").ToString();
                            disco.Tamano = vistaDiscos.GetRowCellValue(i, "Tamano").ToString();
                            disco.Capacidad = int.Parse(vistaDiscos.GetRowCellValue(i, "Capacidad").ToString());
                            disco.Cantidad = int.Parse(vistaDiscos.GetRowCellValue(i, "Cantidad").ToString());
                            disco.Precio = Double.Parse(vistaDiscos.GetRowCellValue(i, "Precio").ToString());
                            discos.Add(disco);
                        }
                    }
                    ingreso.Discos = discos;
                    dgvDiscos.DataSource = ingreso.Discos;
                }
            }
            ObtenerTotal();
        }

        private void vistaDiscos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int discoId = -1;
            vistaDiscos.ClearColumnsFilter();
            int h = 0;
            for (h = 0; h < vistaDiscos.RowCount; h++)
                if (vistaDiscos.IsRowSelected(h) == true)
                {
                    discoId = int.Parse(vistaDiscos.GetRowCellValue(h, "IdDisco").ToString());
                    break;
                }

            int aux;
            double auxDouble;
            double precio;
            int cantidadDisco;
            string myStr;
            if (!(discoId == -1))
            {
                myStr = vistaDiscos.GetRowCellValue(h, "Cantidad").ToString();
                myStr = myStr.TrimStart('0');

                if (myStr.Length > 0)
                {
                    aux = int.Parse(myStr);
                    if (aux < 0) myStr = "1";
                }
                else myStr = "1";
                cantidadDisco = myStr.Length > 0 ? int.Parse(myStr) : 1;
                //((GridCell)(((GridRow)dgvDisco.PrimaryGrid.ActiveRow)[2])).Value = cantidadDisco;


                myStr = vistaDiscos.GetRowCellValue(h, "Precio").ToString();
                myStr = myStr.TrimStart('0');

                if (myStr.Length > 0)
                {
                    auxDouble = double.Parse(myStr);
                    if (auxDouble < 0) myStr = "0.00";
                }
                else myStr = "0";
                precio = myStr.Length > 0 ? double.Parse(myStr) : 0.00;
                //((GridCell)(((GridRow)dgvDisco.PrimaryGrid.ActiveRow)[5])).Value = precio;



                for (int j = 0; j < ingreso.Discos.Count; j++)
                {
                    if (discoId == ingreso.Discos[j].IdDisco)
                    {
                        ingreso.Discos[j].Cantidad = cantidadDisco;
                        ingreso.Discos[j].Precio = precio;
                    }
                }
                dgvDiscos.DataSource = ingreso.Discos;
            }
            ObtenerTotal();
        }

        private void btnAgregarTablets_Click(object sender, EventArgs e)
        {
            if (cmbTipoIngreso.SelectedIndex != -1)
            {
                //! 0 -> COMPRA
                //! 1 -> SUBARRIENDO
                string tipo = cmbTipoIngreso.SelectedIndex.ToString();

                try
                {
                    IngresoDetalleTablet detalle = new IngresoDetalleTablet();
                    using (frmProcesoIngresoTablet frm = new frmProcesoIngresoTablet(this.idUsuario, this.nombreUsuario))
                    {
                        if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            BindingList<IngresoDetalleTablet> auxiliares = new BindingList<IngresoDetalleTablet>();
                            foreach (IngresoDetalleTablet aux in ingreso.DetallesTablets)
                            {
                                auxiliares.Add(aux);
                            }
                            detalle = frm.DETALLE;
                            detalle.IdIngresoDetalleTablet = ingreso.DetallesTablets.Count + 1;
                            auxiliares.Add(detalle);
                            ingreso.DetallesTablets = auxiliares;
                            //ingreso.Detalles.Add(detalle);
                            dgvTablets.DataSource = ingreso.DetallesTablets;
                            vistaTablets.OptionsBehavior.AutoPopulateColumns = false;
                            vistaTablets.OptionsSelection.MultiSelect = true;

                            //MessageBox.Show((detalle.Precio*detalle.Cantidad).ToString());

                            ObtenerTotal();

                        }
                    }
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("Seleccione el tipo de ingreso");
            }

        }

        private void dgvTablets_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro deseas Eliminar esta detalle de Ingreso", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                int detTempId = -1;
                vistaTablets.ClearColumnsFilter();
                for (int i = 0; i < vistaTablets.RowCount; i++)
                    if (vistaTablets.IsRowSelected(i) == true)
                        detTempId = int.Parse(vistaTablets.GetRowCellValue(i, "IdIngresoDetalleTablet").ToString());
                if (detTempId != -1)
                {
                    int indiceLC = 0;
                    foreach (IngresoDetalleTablet detalle in ingreso.DetallesTablets)
                    {
                        if (detalle.IdIngresoDetalleTablet == detTempId)
                        {
                            break;
                        }
                        indiceLC++;
                    }

                    ingreso.DetallesTablets.RemoveAt(indiceLC);
                    for (int i = 0; i < ingreso.DetallesTablets.Count; i++)
                    {
                        ingreso.DetallesTablets[i].IdIngresoDetalleTablet = i + 1;
                    }

                    dgvTablets.DataSource = ingreso.DetallesTablets;
                }
            }
            ObtenerTotal();
        }

        private void btnVisualizarTablets_Click(object sender, EventArgs e)
        {


            vistaTablets.ClearColumnsFilter();
            int detTempId = -1;
            for (int i = 0; i < vistaTablets.RowCount; i++)
                if (vistaTablets.IsRowSelected(i) == true)
                    detTempId = int.Parse(vistaTablets.GetRowCellValue(i, "IdIngresoDetalleTablet").ToString());

            if (detTempId != -1)
            {


                IngresoDetalleTablet det = new IngresoDetalleTablet();
                int indiceLC = 0;
                if (vistaTablets.RowCount == 0) return;
                if (vistaTablets.RowCount > 0)
                {
                    for (int i = 0; i < vistaTablets.RowCount; i++)
                        if (vistaTablets.IsRowSelected(i) == true)
                            detTempId = int.Parse(vistaTablets.GetRowCellValue(i, "IdIngresoDetalleTablet").ToString());

                    foreach (IngresoDetalleTablet detalle in ingreso.DetallesTablets)
                    {
                        if (detalle.IdIngresoDetalleTablet == detTempId)
                            break;
                        indiceLC++;
                    }
                }

                using (frmProcesoIngresoTablet frm = new frmProcesoIngresoTablet(this.idUsuario, this.nombreUsuario, ingreso.DetallesTablets[indiceLC]))
                {


                    ObtenerTotal();
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (vistaTablets.RowCount > 0)
                        {
                            for (int i = 0; i < vistaTablets.RowCount; i++)
                                if (vistaTablets.IsRowSelected(i) == true)
                                    detTempId = int.Parse(vistaTablets.GetRowCellValue(i, "IdIngresoDetalleTablet").ToString());

                            int indiceLC2 = 0;
                            foreach (IngresoDetalleTablet detalle in ingreso.DetallesTablets)
                            {




                                if (detalle.IdIngresoDetalleTablet == detTempId)
                                {
                                    break;
                                }
                                indiceLC2++;
                            }




                            ingreso.DetallesTablets.RemoveAt(indiceLC2);
                            for (int i = 0; i < ingreso.DetallesTablets.Count; i++)
                            {
                                ingreso.DetallesTablets[i].IdIngresoDetalleTablet = i + 1;
                            }
                            dgvTablets.DataSource = ingreso.DetallesTablets;
                        }

                        det = frm.DETALLE;
                        det.IdIngresoDetalleTablet = ingreso.DetallesTablets.Count + 1;
                        ingreso.DetallesTablets.Add(det);
                        dgvTablets.DataSource = ingreso.DetallesTablets;

                        ObtenerTotal();
                    }
                }
            }


        }

        private void btnAgregarMonitores_Click(object sender, EventArgs e)
        {
            if (cmbTipoIngreso.SelectedIndex != -1)
            {
                //! 0 -> COMPRA
                //! 1 -> SUBARRIENDO
                string tipo = cmbTipoIngreso.SelectedIndex.ToString();

                try
                {
                    IngresoDetalleMonitor detalle = new IngresoDetalleMonitor();
                    using (frmProcesoIngresoMonitor frm = new frmProcesoIngresoMonitor(this.idUsuario, this.nombreUsuario))
                    {
                        if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            BindingList<IngresoDetalleMonitor> auxiliares = new BindingList<IngresoDetalleMonitor>();
                            foreach (IngresoDetalleMonitor aux in ingreso.DetallesMonitores)
                            {
                                auxiliares.Add(aux);
                            }
                            detalle = frm.DETALLE;
                            detalle.IdIngresoDetalleMonitor = ingreso.DetallesMonitores.Count + 1;
                            auxiliares.Add(detalle);
                            ingreso.DetallesMonitores = auxiliares;
                            //ingreso.Detalles.Add(detalle);
                            dgvMonitores.DataSource = ingreso.DetallesMonitores;
                            vistaMonitores.OptionsBehavior.AutoPopulateColumns = false;
                            vistaMonitores.OptionsSelection.MultiSelect = true;

                            ObtenerTotal();
                        }
                    }
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("Seleccione el tipo de ingreso");
            }
        }

        private void dgvMonitores_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro deseas Eliminar esta detalle de Ingreso", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

                int detTempId = -1;
                vistaMonitores.ClearColumnsFilter();
                for (int i = 0; i < vistaMonitores.RowCount; i++)
                    if (vistaMonitores.IsRowSelected(i) == true)
                        detTempId = int.Parse(vistaMonitores.GetRowCellValue(i, "IdIngresoDetalleMonitor").ToString());

                if (detTempId != -1)
                {
                    int indiceLC = 0;
                    foreach (IngresoDetalleMonitor detalle in ingreso.DetallesMonitores)
                    {
                        if (detalle.IdIngresoDetalleMonitor == detTempId)
                        {
                            break;
                        }
                        indiceLC++;
                    }
                    ingreso.DetallesMonitores.RemoveAt(indiceLC);
                    for (int i = 0; i < ingreso.DetallesMonitores.Count; i++)
                    {
                        ingreso.DetallesMonitores[i].IdIngresoDetalleMonitor = i + 1;
                    }
                    dgvMonitores.DataSource = ingreso.DetallesMonitores;
                }
            }
            ObtenerTotal();
        }

        private void btnVisualizarMonitores_Click(object sender, EventArgs e)
        {
            vistaMonitores.ClearColumnsFilter();
            int detTempId = -1;
            for (int i = 0; i < vistaMonitores.RowCount; i++)
                if (vistaMonitores.IsRowSelected(i) == true)
                    detTempId = int.Parse(vistaMonitores.GetRowCellValue(i, "IdIngresoDetalleMonitor").ToString());

            if (detTempId != -1)
            {
                IngresoDetalleMonitor det = new IngresoDetalleMonitor();
                int indiceLC = 0;
                if (vistaMonitores.RowCount == 0) return;
                if (vistaMonitores.RowCount > 0)
                {
                    for (int i = 0; i < vistaMonitores.RowCount; i++)
                        if (vistaMonitores.IsRowSelected(i) == true)
                            detTempId = int.Parse(vistaMonitores.GetRowCellValue(i, "IdIngresoDetalleMonitor").ToString());

                    foreach (IngresoDetalleMonitor detalle in ingreso.DetallesMonitores)
                    {
                        if (detalle.IdIngresoDetalleMonitor == detTempId)
                            break;
                        indiceLC++;
                    }
                }

                using (frmProcesoIngresoMonitor frm = new frmProcesoIngresoMonitor(this.idUsuario, this.nombreUsuario, ingreso.DetallesMonitores[indiceLC]))
                {

                    ObtenerTotal();
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (vistaMonitores.RowCount > 0)
                        {
                            for (int i = 0; i < vistaMonitores.RowCount; i++)
                                if (vistaMonitores.IsRowSelected(i) == true)
                                    detTempId = int.Parse(vistaMonitores.GetRowCellValue(i, "IdIngresoDetalleMonitor").ToString());

                            int indiceLC2 = 0;
                            foreach (IngresoDetalleMonitor detalle in ingreso.DetallesMonitores)
                            {
                                if (detalle.IdIngresoDetalleMonitor == detTempId)
                                {
                                    break;
                                }
                                indiceLC2++;
                            }

                            ingreso.DetallesMonitores.RemoveAt(indiceLC2);
                            for (int i = 0; i < ingreso.DetallesMonitores.Count; i++)
                            {
                                ingreso.DetallesMonitores[i].IdIngresoDetalleMonitor = i + 1;
                            }

                            dgvMonitores.DataSource = ingreso.DetallesMonitores;
                        }

                        det = frm.DETALLE;
                        det.IdIngresoDetalleMonitor = ingreso.DetallesMonitores.Count + 1;
                        ingreso.DetallesMonitores.Add(det);
                        dgvMonitores.DataSource = ingreso.DetallesMonitores;
                        ObtenerTotal();
                    }
                }
            }
        }

        private void btnAgregarImpresora_Click(object sender, EventArgs e)
        {
            if (cmbTipoIngreso.SelectedIndex != -1)
            {
                //! 0 -> COMPRA
                //! 1 -> SUBARRIENDO
                string tipo = cmbTipoIngreso.SelectedIndex.ToString();

                try
                {
                    IngresoDetalleImpresora detalle = new IngresoDetalleImpresora();
                    using (frmProcesoIngresoImpresora frm = new frmProcesoIngresoImpresora(this.idUsuario, this.nombreUsuario))
                    {
                        if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            BindingList<IngresoDetalleImpresora> auxiliares = new BindingList<IngresoDetalleImpresora>();
                            foreach (IngresoDetalleImpresora aux in ingreso.DetallesImpresoras)
                            {
                                auxiliares.Add(aux);
                            }
                            detalle = frm.DETALLE;
                            detalle.IdIngresoDetalleImpresora = ingreso.DetallesImpresoras.Count + 1;
                            auxiliares.Add(detalle);
                            ingreso.DetallesImpresoras = auxiliares;
                            //ingreso.Detalles.Add(detalle);
                            dgvImpresoras.DataSource = ingreso.DetallesImpresoras;
                            vistaImpresoras.OptionsBehavior.AutoPopulateColumns = false;
                            vistaImpresoras.OptionsSelection.MultiSelect = true;

                            ObtenerTotal();
                        }
                    }
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("Seleccione el tipo de ingreso");
            }

        }

        private void dgvImpresoras_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro deseas Eliminar esta detalle de Ingreso", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                int detTempId = -1;
                vistaImpresoras.ClearColumnsFilter();
                for (int i = 0; i < vistaImpresoras.RowCount; i++)
                    if (vistaImpresoras.IsRowSelected(i) == true)
                        detTempId = int.Parse(vistaImpresoras.GetRowCellValue(i, "IdIngresoDetalleImpresora").ToString());

                if (detTempId != -1)
                {
                    int indiceLC = 0;
                    foreach (IngresoDetalleImpresora detalle in ingreso.DetallesImpresoras)
                    {
                        if (detalle.IdIngresoDetalleImpresora == detTempId)
                        {
                            break;
                        }
                        indiceLC++;
                    }
                    ingreso.DetallesImpresoras.RemoveAt(indiceLC);
                    for (int i = 0; i < ingreso.DetallesImpresoras.Count; i++)
                    {
                        ingreso.DetallesImpresoras[i].IdIngresoDetalleImpresora = i + 1;
                    }
                    dgvImpresoras.DataSource = ingreso.DetallesImpresoras;
                }
            }
            ObtenerTotal();
        }

        private void btnVisualizarImpresora_Click(object sender, EventArgs e)
        {
            vistaImpresoras.ClearColumnsFilter();
            int detTempId = -1;
            for (int i = 0; i < vistaImpresoras.RowCount; i++)
                if (vistaImpresoras.IsRowSelected(i) == true)
                    detTempId = int.Parse(vistaImpresoras.GetRowCellValue(i, "IdIngresoDetalleImpresora").ToString());

            if (detTempId != -1)
            {
                IngresoDetalleImpresora det = new IngresoDetalleImpresora();
                int indiceLC = 0;
                if (vistaImpresoras.RowCount == 0) return;
                if (vistaImpresoras.RowCount > 0)
                {
                    for (int i = 0; i < vistaImpresoras.RowCount; i++)
                        if (vistaImpresoras.IsRowSelected(i) == true)
                            detTempId = int.Parse(vistaImpresoras.GetRowCellValue(i, "IdIngresoDetalleImpresora").ToString());

                    foreach (IngresoDetalleImpresora detalle in ingreso.DetallesImpresoras)
                    {
                        if (detalle.IdIngresoDetalleImpresora == detTempId)
                            break;
                        indiceLC++;
                    }
                }

                using (frmProcesoIngresoImpresora frm = new frmProcesoIngresoImpresora(this.idUsuario, this.nombreUsuario, ingreso.DetallesImpresoras[indiceLC]))
                {

                    ObtenerTotal();
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (vistaImpresoras.RowCount > 0)
                        {
                            for (int i = 0; i < vistaImpresoras.RowCount; i++)
                                if (vistaImpresoras.IsRowSelected(i) == true)
                                    detTempId = int.Parse(vistaImpresoras.GetRowCellValue(i, "IdIngresoDetalleImpresora").ToString());

                            int indiceLC2 = 0;
                            foreach (IngresoDetalleImpresora detalle in ingreso.DetallesImpresoras)
                            {
                                if (detalle.IdIngresoDetalleImpresora == detTempId)
                                {
                                    break;
                                }
                                indiceLC2++;
                            }

                            ingreso.DetallesImpresoras.RemoveAt(indiceLC2);
                            for (int i = 0; i < ingreso.DetallesImpresoras.Count; i++)
                            {
                                ingreso.DetallesImpresoras[i].IdIngresoDetalleImpresora = i + 1;
                            }

                            dgvImpresoras.DataSource = ingreso.DetallesImpresoras;
                        }

                        det = frm.DETALLE;
                        det.IdIngresoDetalleImpresora = ingreso.DetallesImpresoras.Count + 1;
                        ingreso.DetallesImpresoras.Add(det);
                        dgvImpresoras.DataSource = ingreso.DetallesImpresoras;

                        ObtenerTotal();
                    }
                }
            }
        }

        private void btnAgregarProyectores_Click(object sender, EventArgs e)
        {
            if (cmbTipoIngreso.SelectedIndex != -1)
            {
                //! 0 -> COMPRA
                //! 1 -> SUBARRIENDO
                string tipo = cmbTipoIngreso.SelectedIndex.ToString();

                try
                {
                    IngresoDetalleProyector detalle = new IngresoDetalleProyector();
                    using (frmProcesoIngresoProyector frm = new frmProcesoIngresoProyector(this.idUsuario, this.nombreUsuario))
                    {
                        if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            BindingList<IngresoDetalleProyector> auxiliares = new BindingList<IngresoDetalleProyector>();
                            foreach (IngresoDetalleProyector aux in ingreso.DetallesProyectores)
                            {
                                auxiliares.Add(aux);
                            }
                            detalle = frm.DETALLE;
                            detalle.IdIngresoDetalleProyector = ingreso.DetallesProyectores.Count + 1;
                            auxiliares.Add(detalle);
                            ingreso.DetallesProyectores = auxiliares;
                            //ingreso.Detalles.Add(detalle);
                            dgvProyectores.DataSource = ingreso.DetallesProyectores;
                            vistaProyectores.OptionsBehavior.AutoPopulateColumns = false;
                            vistaProyectores.OptionsSelection.MultiSelect = true;

                            ObtenerTotal();
                        }
                    }
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("Seleccione el tipo de ingreso");
            }

        }

        private void dgvProyectores_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro deseas Eliminar esta detalle de Ingreso", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                int detTempId = -1;
                vistaProyectores.ClearColumnsFilter();
                for (int i = 0; i < vistaProyectores.RowCount; i++)
                    if (vistaProyectores.IsRowSelected(i) == true)
                        detTempId = int.Parse(vistaProyectores.GetRowCellValue(i, "IdIngresoDetalleProyector").ToString());

                if (detTempId != -1)
                {
                    int indiceLC = 0;
                    foreach (IngresoDetalleProyector detalle in ingreso.DetallesProyectores)
                    {
                        if (detalle.IdIngresoDetalleProyector == detTempId)
                        {
                            break;
                        }
                        indiceLC++;
                    }
                    ingreso.DetallesProyectores.RemoveAt(indiceLC);
                    for (int i = 0; i < ingreso.DetallesProyectores.Count; i++)
                    {
                        ingreso.DetallesProyectores[i].IdIngresoDetalleProyector = i + 1;
                    }
                    dgvProyectores.DataSource = ingreso.DetallesProyectores;
                }
            }
            ObtenerTotal();
        }

        private void btnVisualizarProyectores_Click(object sender, EventArgs e)
        {
            vistaProyectores.ClearColumnsFilter();
            int detTempId = -1;
            for (int i = 0; i < vistaProyectores.RowCount; i++)
                if (vistaProyectores.IsRowSelected(i) == true)
                    detTempId = int.Parse(vistaProyectores.GetRowCellValue(i, "IdIngresoDetalleProyector").ToString());

            if (detTempId != -1)
            {
                IngresoDetalleProyector det = new IngresoDetalleProyector();
                int indiceLC = 0;
                if (vistaProyectores.RowCount == 0) return;
                if (vistaProyectores.RowCount > 0)
                {
                    for (int i = 0; i < vistaProyectores.RowCount; i++)
                        if (vistaProyectores.IsRowSelected(i) == true)
                            detTempId = int.Parse(vistaProyectores.GetRowCellValue(i, "IdIngresoDetalleProyector").ToString());

                    foreach (IngresoDetalleProyector detalle in ingreso.DetallesProyectores)
                    {
                        if (detalle.IdIngresoDetalleProyector == detTempId)
                            break;
                        indiceLC++;
                    }
                }

                using (frmProcesoIngresoProyector frm = new frmProcesoIngresoProyector(this.idUsuario, this.nombreUsuario, ingreso.DetallesProyectores[indiceLC]))
                {

                    ObtenerTotal();
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (vistaProyectores.RowCount > 0)
                        {
                            for (int i = 0; i < vistaProyectores.RowCount; i++)
                                if (vistaProyectores.IsRowSelected(i) == true)
                                    detTempId = int.Parse(vistaProyectores.GetRowCellValue(i, "IdIngresoDetalleProyector").ToString());

                            int indiceLC2 = 0;
                            foreach (IngresoDetalleProyector detalle in ingreso.DetallesProyectores)
                            {
                                if (detalle.IdIngresoDetalleProyector == detTempId)
                                {
                                    break;
                                }
                                indiceLC2++;
                            }

                            ingreso.DetallesProyectores.RemoveAt(indiceLC2);
                            for (int i = 0; i < ingreso.DetallesProyectores.Count; i++)
                            {
                                ingreso.DetallesProyectores[i].IdIngresoDetalleProyector = i + 1;
                            }

                            dgvProyectores.DataSource = ingreso.DetallesProyectores;
                        }

                        det = frm.DETALLE;
                        det.IdIngresoDetalleProyector = ingreso.DetallesProyectores.Count + 1;
                        ingreso.DetallesProyectores.Add(det);
                        dgvProyectores.DataSource = ingreso.DetallesProyectores;
                        ObtenerTotal();
                    }
                }
            }
        }

        private void ObtenerTotal()
        {

            //Aqui se va a hacer la suma de todo el Total
            ingreso.Total = 0;
            foreach (IngresoDetalle d in ingreso.Detalles)
            {
                ingreso.Total += d.Precio * d.Cantidad;
            }
            foreach (Licencia d in ingreso.Licencias)
            {
                ingreso.Total += d.Precio * d.Cantidad;
            }
            foreach (DiscoDuro d in ingreso.Discos)
            {
                ingreso.Total += d.Precio * d.Cantidad;
            }
            foreach (Memoria d in ingreso.Memorias)
            {
                ingreso.Total += d.Precio * d.Cantidad;
            }

            foreach (IngresoDetalleTablet d in ingreso.DetallesTablets)
            {
                ingreso.Total += d.Precio * d.Cantidad;
            }

            foreach (IngresoDetalleMonitor d in ingreso.DetallesMonitores)
            {
                ingreso.Total += d.Precio * d.Cantidad;
            }

            foreach (IngresoDetalleImpresora d in ingreso.DetallesImpresoras)
            {
                ingreso.Total += d.Precio * d.Cantidad;
            }

            foreach (IngresoDetalleProyector d in ingreso.DetallesProyectores)
            {
                ingreso.Total += d.Precio * d.Cantidad;
            }

            label2.Text = $"TOTAL : {ingreso.Total}";


            /*
            if (ingreso.Total > 0)
            {
                cmbTipoIngreso.Enabled = false;
            }
            else
            {
                cmbTipoIngreso.Enabled = true;
            }
            */

        }

        private void frmProcesoIngreso_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int posY = 0;
        int posX = 0;
        private void pnlC_MouseMove(object sender, MouseEventArgs e)
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
    }
}
