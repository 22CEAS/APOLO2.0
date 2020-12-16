using AccesoDatos;
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

namespace Apolo
{
    public partial class frmProcesoAlquiler : Form
    {
        public enum TipoVista { Inicial, Nuevo, Modificar, Guardar, Vista, Limpiar, Duplicar, Anular }
        System.Data.DataTable tablaCliente;
        System.Data.DataTable tablaClienteSucursal;
        System.Data.DataTable tablaDisco;
        System.Data.DataTable tablaMemoria;
        System.Data.DataTable tablaLicencia;
        ClienteDA clienteDA;
        AlquilerDA alquilerDA;
        Alquiler alquiler;
        LC artTemp;

        private int idUsuario;
        private string nombreUsuario = "CEAS";
        private int maxCantidadDiscos=2;

        private string licenciaCategoriaSO = "S.O";
        private string licenciaCategoriaOffice = "OFFICE";
        private string licenciaCategoriaAntivirus = "ANTIVIRUS";

        public frmProcesoAlquiler()
        {
            InitializeComponent();
            Inicializado();
            estadoComponentes(TipoVista.Inicial);
        }

        public frmProcesoAlquiler(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
            estadoComponentes(TipoVista.Inicial);
        }

        public void Inicializado()
        {

            //tablaLicencia.Columns.Add("Seleccionar", typeof(bool));

            clienteDA = new ClienteDA();
            alquilerDA = new AlquilerDA();

            artTemp = new LC();
            dtpFechaTraslado.Value = DateTime.Now;
            dtpIniPlazo.Value = DateTime.Now;
            //dtpFinPlazo.Value = DateTime.Now;
            dtpFinPlazo.MinDate = dtpIniPlazo.Value;

            tablaCliente = clienteDA.ListarClientes();
            cmbCliente.DataSource = tablaCliente;
            cmbCliente.DisplayMember = "nombre_razonSocial";
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.SelectedIndex = 0;
            int i = cmbCliente.SelectedIndex;

            txtNroDocumento.Text = tablaCliente.Rows[i]["nroDocumento"].ToString();

            //Listar Sucursales correspondientes al cliente

            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                int idCliente = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
                tablaClienteSucursal = clienteDA.ListarSucursalCliente(idCliente);
                cmbSucursal.DataSource = tablaClienteSucursal;
                cmbSucursal.DisplayMember = "direccion";
                cmbSucursal.ValueMember = "idSucursal";
                cmbSucursal.SelectedIndex = 0;
            }

            alquiler = new Alquiler();
            alquiler.Detalles = new BindingList<AlquilerDetalle>();
            ObtenerDatosAlquiler();
            dgvEquipos.DataSource = alquiler.Detalles;
            vistaEquipos.OptionsBehavior.AutoPopulateColumns = false;
            vistaEquipos.OptionsSelection.MultiSelect = true;
            vistaMemorias.OptionsBehavior.AutoPopulateColumns = false;
            vistaMemorias.OptionsSelection.MultiSelect = true;
            vistaDiscos.OptionsBehavior.AutoPopulateColumns = false;
            vistaDiscos.OptionsSelection.MultiSelect = true;
            vistaLicencias.OptionsBehavior.AutoPopulateColumns = false;
            vistaLicencias.OptionsSelection.MultiSelect = true;

            lblContador.Text = $"CANTIDAD REGISTRO: {alquiler.Detalles.Count.ToString()}";

        }

        public void ObtenerDatosAlquiler()
        {

            alquiler.IdCliente = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
            alquiler.IdSucursal = Convert.ToInt32(cmbSucursal.SelectedValue.ToString());
            alquiler.FechaSalida = dtpFechaTraslado.Value;
            alquiler.FechaIniContrato = dtpIniPlazo.Value;
            alquiler.FechaFinContrato = dtpFinPlazo.Value;
            string aux1 = "";
            aux1= txtNroContrato.Text;
            alquiler.NroContrato = aux1.Trim();
            string aux2 = "";
            aux2 = txtNroOC.Text;
            alquiler.NroOC = aux2.Trim();
            string aux3 = "";
            aux3 = txtNroDocumento.Text;
            alquiler.RucDni = aux3.Trim();

        }

        public void estadoComponentes(TipoVista estado)
        {
            switch (estado)
            {
                case TipoVista.Inicial:
                    cmbCliente.Enabled = false;
                    cmbSucursal.Enabled = false;
                    dtpFechaTraslado.Enabled = false;
                    dtpIniPlazo.Enabled = false;
                    dtpFinPlazo.Enabled = false;
                    txtNroContrato.Enabled = false;
                    txtNroOC.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    dgvEquipos.Enabled = false;
                    dgvDiscos.Enabled = false;
                    dgvMemoria.Enabled = false;
                    dgvLicencias.Enabled = false;
                    btnAgregarDisco.Enabled = false;
                    btnGuardarDisco.Enabled = false;
                    btnAgregarMemoria.Enabled = false;
                    btnGuardarMemoria.Enabled = false;
                    btnAgregarLicencia.Enabled = false;
                    btnEliminarLicencia.Enabled = false;
                    btnCaducidadLicencia.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnAgregarGuia.Enabled = false;
                    btnSeleccionarFilas.Enabled = false;
                    btnDeseleccionarFilas.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnAnular.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = false;
                    btnGrabarPreAlquiler.Enabled = false;
                    btnEditar.Enabled = false;
                    limpiarComponentes();
                    alquiler = new Alquiler();
                    break;
                case TipoVista.Nuevo:
                    cmbCliente.Enabled = true;
                    cmbSucursal.Enabled = true;
                    dtpFechaTraslado.Enabled = true;
                    dtpIniPlazo.Enabled = false;
                    dtpFinPlazo.Enabled = false;
                    txtNroContrato.Enabled = true;
                    txtNroOC.Enabled = true;
                    txtNroDocumento.Enabled = true;
                    dgvEquipos.Enabled = true;
                    vistaEquipos.ClearColumnsFilter();
                    dgvDiscos.Enabled = (vistaEquipos.RowCount > 0) ? true : false;
                    dgvMemoria.Enabled = (vistaEquipos.RowCount > 0) ? true : false;
                    dgvLicencias.Enabled = (vistaEquipos.RowCount > 0) ? true : false;
                    btnAgregarDisco.Enabled = (vistaEquipos.RowCount > 0)?true:false; 
                    btnGuardarDisco.Enabled = (vistaEquipos.RowCount > 0) ? true : false;
                    btnAgregarMemoria.Enabled = (vistaEquipos.RowCount > 0) ? true : false; 
                    btnGuardarMemoria.Enabled = (vistaEquipos.RowCount > 0) ? true : false; 
                    btnAgregarLicencia.Enabled = (vistaEquipos.RowCount > 0) ? true : false; 
                    btnEliminarLicencia.Enabled = (vistaEquipos.RowCount > 0) ? true : false; 
                    btnCaducidadLicencia.Enabled = (vistaEquipos.RowCount > 0) ? true : false; 
                    btnAgregarProducto.Enabled = true;
                    btnAgregarGuia.Enabled = false;
                    btnSeleccionarFilas.Enabled = false;
                    btnDeseleccionarFilas.Enabled = false;
                    btnNuevo.Enabled = false;
                    btnAnular.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnImprimir.Enabled = false;
                    btnGrabarPreAlquiler.Enabled = true;
                    btnEditar.Enabled = false;
                    limpiarComponentes();
                    alquiler = new Alquiler();
                    break;
                case TipoVista.Guardar:
                    cmbCliente.Enabled = false;
                    cmbSucursal.Enabled = false;
                    dtpFechaTraslado.Enabled = false;
                    dtpIniPlazo.Enabled = false;
                    dtpFinPlazo.Enabled = false;
                    txtNroContrato.Enabled = false;
                    txtNroOC.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    dgvEquipos.Enabled = false;
                    dgvMemoria.Enabled = false;
                    dgvDiscos.Enabled = false;
                    dgvLicencias.Enabled = false;
                    btnAgregarDisco.Enabled = false;
                    btnGuardarDisco.Enabled = false;
                    btnAgregarMemoria.Enabled = false;
                    btnGuardarMemoria.Enabled = false;
                    btnAgregarLicencia.Enabled = false;
                    btnEliminarLicencia.Enabled = false;
                    btnCaducidadLicencia.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnAgregarGuia.Enabled = false;
                    btnSeleccionarFilas.Enabled = false;
                    btnDeseleccionarFilas.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnAnular.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnGrabarPreAlquiler.Enabled = false;
                    btnEditar.Enabled = true;
                    //limpiarComponentes();
                    //alquiler = new Alquiler();
                    //limpiarComponentes();
                    break;
                case TipoVista.Modificar:
                    cmbCliente.Enabled = true;
                    cmbSucursal.Enabled = true;
                    dtpFechaTraslado.Enabled = true;
                    dtpIniPlazo.Enabled = false;
                    dtpFinPlazo.Enabled = false;
                    txtNroContrato.Enabled = true;
                    txtNroOC.Enabled = true;
                    txtNroDocumento.Enabled = true;
                    dgvEquipos.Enabled = true;
                    dgvDiscos.Enabled = true;
                    dgvMemoria.Enabled = true;
                    dgvLicencias.Enabled = true;
                    btnAgregarDisco.Enabled = true;
                    btnGuardarDisco.Enabled = true;
                    btnAgregarMemoria.Enabled = true;
                    btnGuardarMemoria.Enabled = true;
                    btnAgregarLicencia.Enabled = true;
                    btnEliminarLicencia.Enabled = true;
                    btnCaducidadLicencia.Enabled = true;
                    btnAgregarProducto.Enabled = true;
                    btnAgregarGuia.Enabled = true;
                    btnSeleccionarFilas.Enabled = true;
                    btnDeseleccionarFilas.Enabled = true;
                    btnNuevo.Enabled = false;
                    btnAnular.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnImprimir.Enabled = false;
                    btnGrabarPreAlquiler.Enabled = true;
                    btnEditar.Enabled = false;
                    //limpiarComponentes();
                    //alquiler = new Alquiler();
                    break;
                case TipoVista.Vista:
                    cmbCliente.Enabled = false;
                    cmbSucursal.Enabled = false;
                    dtpFechaTraslado.Enabled = false;
                    dtpIniPlazo.Enabled = false;
                    dtpFinPlazo.Enabled = false;
                    txtNroContrato.Enabled = false;
                    txtNroOC.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    dgvEquipos.Enabled = false;
                    dgvMemoria.Enabled = false;
                    dgvDiscos.Enabled = false;
                    dgvLicencias.Enabled = false;
                    btnAgregarDisco.Enabled = false;
                    btnGuardarDisco.Enabled = false;
                    btnAgregarMemoria.Enabled = false;
                    btnGuardarMemoria.Enabled = false;
                    btnAgregarLicencia.Enabled = false;
                    btnEliminarLicencia.Enabled = false;
                    btnCaducidadLicencia.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnAgregarGuia.Enabled = false;
                    btnSeleccionarFilas.Enabled = false;
                    btnDeseleccionarFilas.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnAnular.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnGrabarPreAlquiler.Enabled = false;
                    btnEditar.Enabled = true;
                    //limpiarComponentes();
                    alquiler = new Alquiler();
                    break;
                case TipoVista.Limpiar:
                    cmbCliente.Enabled = false;
                    cmbSucursal.Enabled = false;
                    dtpFechaTraslado.Enabled = false;
                    dtpIniPlazo.Enabled = false;
                    dtpFinPlazo.Enabled = false;
                    txtNroContrato.Enabled = false;
                    txtNroOC.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    dgvEquipos.Enabled = false;
                    dgvMemoria.Enabled = false;
                    dgvDiscos.Enabled = false;
                    dgvLicencias.Enabled = false;
                    btnAgregarDisco.Enabled = false;
                    btnGuardarDisco.Enabled = false;
                    btnAgregarMemoria.Enabled = false;
                    btnGuardarMemoria.Enabled = false;
                    btnAgregarLicencia.Enabled = false;
                    btnEliminarLicencia.Enabled = false;
                    btnCaducidadLicencia.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnAgregarGuia.Enabled = false;
                    btnSeleccionarFilas.Enabled = false;
                    btnDeseleccionarFilas.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnAnular.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = false;
                    btnGrabarPreAlquiler.Enabled = false;
                    btnEditar.Enabled = false;
                    limpiarComponentes();
                    alquiler = new Alquiler();
                    break;
                case TipoVista.Duplicar:
                    cmbCliente.Enabled = false;
                    cmbSucursal.Enabled = false;
                    dtpFechaTraslado.Enabled = false;
                    dtpIniPlazo.Enabled = false;
                    dtpFinPlazo.Enabled = false;
                    txtNroContrato.Enabled = false;
                    txtNroOC.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    dgvEquipos.Enabled = false;
                    dgvMemoria.Enabled = false;
                    dgvDiscos.Enabled = false;
                    dgvLicencias.Enabled = false;
                    btnAgregarDisco.Enabled = false;
                    btnGuardarDisco.Enabled = false;
                    btnAgregarMemoria.Enabled = false;
                    btnGuardarMemoria.Enabled = false;
                    btnAgregarLicencia.Enabled = false;
                    btnEliminarLicencia.Enabled = false;
                    btnCaducidadLicencia.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnAgregarGuia.Enabled = false;
                    btnSeleccionarFilas.Enabled = false;
                    btnDeseleccionarFilas.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnGrabarPreAlquiler.Enabled = false;
                    btnEditar.Enabled = true;
                    limpiarComponentes();
                    alquiler = new Alquiler();
                    break;
                case TipoVista.Anular:
                    cmbCliente.Enabled = false;
                    cmbSucursal.Enabled = false;
                    dtpFechaTraslado.Enabled = false;
                    dtpIniPlazo.Enabled = false;
                    dtpFinPlazo.Enabled = false;
                    txtNroContrato.Enabled = false;
                    txtNroOC.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    dgvEquipos.Enabled = false;
                    dgvMemoria.Enabled = false;
                    dgvDiscos.Enabled = false;
                    dgvLicencias.Enabled = false;
                    btnAgregarDisco.Enabled = false;
                    btnGuardarDisco.Enabled = false;
                    btnAgregarMemoria.Enabled = false;
                    btnGuardarMemoria.Enabled = false;
                    btnAgregarLicencia.Enabled = false;
                    btnEliminarLicencia.Enabled = false;
                    btnCaducidadLicencia.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnAgregarGuia.Enabled = false;
                    btnSeleccionarFilas.Enabled = false;
                    btnDeseleccionarFilas.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnAnular.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnGrabarPreAlquiler.Enabled = false;
                    btnEditar.Enabled = false;
                    //limpiarComponentes();
                    //alquiler = new Alquiler();
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtNroAlquiler.Text = "";
            txtNroContrato.Text = "";
            txtNroOC.Text = "";
            dtpFechaTraslado.Value = DateTime.Now;
            dtpIniPlazo.Value = DateTime.Now;

            cmbCliente.SelectedIndex = -1;
            cmbSucursal.SelectedIndex = -1;
            txtNroDocumento.Text = "";

            dgvDiscos.DataSource = null;
            dgvMemoria.DataSource = null;
            dgvLicencias.DataSource = null;
            dgvEquipos.DataSource = null;
        }
        
        private void btnGrabarPreAlquiler_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string numAlquiler = txtNroAlquiler.Text;
            if (cmbCliente.SelectedValue == null)
            {
                MessageBox.Show("No se puede grabar un Alquiler si no\nha seleccionado un cliente correcto.", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return;
            }
            if (cmbSucursal.SelectedValue == null)
            {
                MessageBox.Show("No se puede grabar un Alquiler si no\nha seleccionado una sucursal correcto.", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return;
            }
            ObtenerDatosAlquiler();
            if (alquiler.Detalles.Count == 0)
            {
                MessageBox.Show("No se puede grabar un Alquiler si no\nexisten laptops seleccionados.", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return;
            }

            if (numAlquiler.Length == 0)
            {
                if (MessageBox.Show("Estas seguro que deseas Guardar este proceso de Pre-Alquiler", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    int idAlquiler = alquilerDA.InsertarPreAlquiler(alquiler, this.nombreUsuario);

                    if (idAlquiler==0)
                    {
                        MessageBox.Show("Hubo error en Registrar el Pre-Alquiler, comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    MessageBox.Show("Se guardó el Pre-Alquiler", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    alquiler.IdAlquiler = idAlquiler;
                    txtNroAlquiler.Text = idAlquiler.ToString();
                    estadoComponentes(TipoVista.Guardar);
                }
            }
            else
            {
                bool cambioEstado = true;
                int indiceLC = 0;
                foreach (AlquilerDetalle detalle in alquiler.Detalles)
                {
                    if (alquiler.Detalles[indiceLC].GuiaSalida.Length == 0)
                    {
                        cambioEstado = false;
                        break;
                    }
                    indiceLC++;
                }
                if (cambioEstado && alquiler.Estado==6)
                {
                    if (MessageBox.Show("Deseas Cambiar el estado de Pre-Alquiler a Alquilado", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        alquiler.Estado = 4;
                    }
                }
                if (MessageBox.Show("Estas seguro que desea Guardar los cambios", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    //ObtenerDatosPedido();
                    alquilerDA.ModificarAlquiler(alquiler, this.nombreUsuario);
                    MessageBox.Show("Se Modifico el Alquiler N° :" + txtNroAlquiler.Text + " con exito", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    estadoComponentes(TipoVista.Guardar);
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas cancelar el proceso", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                estadoComponentes(TipoVista.Limpiar);
                alquiler = new Alquiler();
                dgvDiscos.DataSource = null;
                dgvMemoria.DataSource = null;
                dgvLicencias.DataSource = null;
                dgvEquipos.DataSource = null;
            }
        }

        public void LlenarDatosAlquiler()
        {
            cmbCliente.SelectedValue = alquiler.IdCliente;
            cmbSucursal.SelectedValue = alquiler.IdSucursal;
            txtNroDocumento.Text = alquiler.RucDni;
            dtpFechaTraslado.Value = alquiler.FechaSalida;
            dtpIniPlazo.Value = alquiler.FechaIniContrato;
            dtpFinPlazo.Value = alquiler.FechaFinContrato;
            txtNroContrato.Text = alquiler.NroContrato;
            txtNroOC.Text = alquiler.NroOC;
            txtNroAlquiler.Text = alquiler.IdAlquiler.ToString();

            if(alquiler.Estado!=0)
                for (int i=0;i<alquiler.Detalles.Count;i++)
                {
                    tablaDisco = alquilerDA.ListarLaptopDisco(alquiler.Detalles[i].Laptop.IdLC);
                    tablaMemoria = alquilerDA.ListarLaptopMemoria(alquiler.Detalles[i].Laptop.IdLC);
                    tablaLicencia = alquilerDA.ListarLaptopLicencia(alquiler.Detalles[i].Laptop.IdLC);

                    alquiler.Detalles[i].Laptop.SetDisco(tablaDisco);
                    alquiler.Detalles[i].Laptop.SetMemoria(tablaMemoria);
                    alquiler.Detalles[i].Laptop.SetLicencia(tablaLicencia);
                }
            

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            estadoComponentes(TipoVista.Vista);
            frmProcesoAlquilerBuscar frmBP = new frmProcesoAlquilerBuscar(this.idUsuario);
            if (frmBP.ShowDialog() == DialogResult.OK)
            {
                alquiler = frmBP.ObjSeleccionado;
                if (alquiler.Estado==6 || alquiler.Estado == 4)//Esto es si está en un estado donde todavía se puede modificar la laptop
                {
                    for (int i=0;i<alquiler.Detalles.Count;i++)
                    {
                        alquiler.Detalles[i].Laptop = alquilerDA.LlenarDetalleDeUnaLaptop(alquiler.Detalles[i].Laptop.IdLC);
                    }
                }
                else
                {
                    for (int i = 0; i < alquiler.Detalles.Count; i++)
                    {
                        alquiler.Detalles[i].Laptop = alquilerDA.LlenarDetalleDeUnaLaptopDesdeMismoAlquilerDetalle(alquiler.Detalles[i]);
                    }
                }
                txtNroAlquiler.Text = alquiler.IdAlquiler.ToString();
                LlenarDatosAlquiler();
                dgvEquipos.DataSource = alquiler.Detalles;
            }
            else
            {
                estadoComponentes(TipoVista.Inicial);
            }

            lblContador.Text = $"CANTIDAD REGISTRO: {alquiler.Detalles.Count.ToString()}";
        }

        private void btnAgregarGuia_Click(object sender, EventArgs e)
        {
            bool flag = false;
            vistaLicencias.ClearColumnsFilter();
            vistaEquipos.ClearColumnsFilter();
            int filas = vistaEquipos.RowCount;
            for (int i = 0; i < filas; i++)
            {
                bool aux2 = bool.Parse(vistaEquipos.GetRowCellValue(i, "Seleccionar").ToString());
                if (aux2)
                    flag = true;
            }

            if (flag)
            {
                using (frmProcesoAgregarGuia frm = new frmProcesoAgregarGuia())
                {
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        filas = alquiler.Detalles.Count;
                        for (int i = 0; i < filas; i++)
                        {
                            bool aux2 = bool.Parse(vistaEquipos.GetRowCellValue(i, "Seleccionar").ToString());
                            if (aux2)
                            {
                                int idLc = int.Parse(vistaEquipos.GetRowCellValue(i, "IdLC").ToString());

                                int indiceLC = 0;
                                foreach (AlquilerDetalle detalle in alquiler.Detalles)
                                {
                                    if (detalle.Laptop.IdLC == idLc)
                                    {
                                        break;
                                    }
                                    indiceLC++;
                                }
                                alquiler.Detalles[indiceLC].GuiaSalida = frm.GuiaDevuelto;
                            }
                        }
                    }
                }
            }

            dgvEquipos.DataSource = null;
            dgvEquipos.DataSource = alquiler.Detalles;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(TipoVista.Nuevo);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (alquiler.Estado == 7 || alquiler.Estado == 0)//en teoría 7 debería ser finalizado
            {
                MessageBox.Show("Este alquiler ya no se puede modificar", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Estas seguro que desea Modificar\n" + "el Alquiler N° :" + txtNroAlquiler.Text, "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    estadoComponentes(TipoVista.Modificar);
                }
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (alquiler.Estado == 0)
            {
                MessageBox.Show("Este alquiler ya se encuentra en estado Anulado", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (alquiler.Estado == 8 || alquiler.Estado == 9)//los estados de aqui todavía están por definir
            {
                MessageBox.Show("Este alquiler no se puede anular", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Estas seguro que desea Anular este alquiler", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    alquiler.Estado = 0;
                    alquilerDA.AnularAlquiler(alquiler,this.nombreUsuario);
                    MessageBox.Show("Se anulo el Alquiler N° :" + alquiler.IdAlquiler, "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estadoComponentes(TipoVista.Anular);
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void dtpFinPlazo_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan tSpan = dtpFinPlazo.Value - dtpIniPlazo.Value;
            int numDiasTrans = tSpan.Days+1;
            lblNroDias.Text = numDiasTrans.ToString()+" días";
        }

        private void dtpFechaTraslado_ValueChanged(object sender, EventArgs e)
        {
            dtpIniPlazo.Value = dtpFechaTraslado.Value;
        }

        private void dtpIniPlazo_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFinPlazo.Value < dtpIniPlazo.Value) dtpFinPlazo.Value = dtpIniPlazo.Value;
            dtpFinPlazo.MinDate = dtpIniPlazo.Value;
            DateTime aux = dtpIniPlazo.Value;
            aux = aux.AddMonths(1);
            dtpFinPlazo.Value = aux.AddDays(-1);



            TimeSpan tSpan = dtpFinPlazo.Value - dtpIniPlazo.Value;
            int numDiasTrans = tSpan.Days + 1;
            lblNroDias.Text = numDiasTrans.ToString() + " días";
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

            int i = cmbCliente.SelectedIndex;
            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                int idCliente = Convert.ToInt32(tablaCliente.Rows[i]["idCliente"].ToString());
                txtNroDocumento.Text = tablaCliente.Rows[i]["nroDocumento"].ToString();
                tablaClienteSucursal = clienteDA.ListarSucursalCliente(idCliente);
                cmbSucursal.DataSource = (tablaClienteSucursal.Rows.Count > 0) ? tablaClienteSucursal : null;
                cmbSucursal.DisplayMember = "direccion";
                cmbSucursal.ValueMember = "idSucursal";
                cmbSucursal.SelectedIndex = (tablaClienteSucursal.Rows.Count > 0) ? 0 : -1;
            }


        }



        private void btnAgregarLicencia_Click(object sender, EventArgs e)
        {

            int equipoTempId = -1;
            vistaEquipos.ClearColumnsFilter();
            for (int i = 0; i < vistaEquipos.RowCount; i++)
                if (vistaEquipos.IsRowSelected(i) == true)
                    equipoTempId = int.Parse(vistaEquipos.GetRowCellValue(i, "IdLC").ToString());

            if (equipoTempId != -1)
            {
                using (frmProcesoEditarLicencia frm = new frmProcesoEditarLicencia())
                {
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        artTemp.IdLC = equipoTempId;

                        int indice = 0;
                        foreach (AlquilerDetalle detalle in alquiler.Detalles)
                        {
                            if (detalle.Laptop.IdLC == artTemp.IdLC)
                            {
                                break;
                            }
                            indice++;
                        }
                        BindingList<Licencia> licenciaAux = new BindingList<Licencia>();
                        foreach (Licencia licenciaTraido in frm.LICENCIAS)
                        {
                            Licencia licTemp = new Licencia();
                            licTemp.IdLicencia = licenciaTraido.IdLicencia;
                            licTemp.Categoria = licenciaTraido.Categoria;
                            bool exists = alquiler.Detalles[indice].Laptop.Licencias.Any(x => x.Categoria.Equals(licTemp.Categoria));
                            if (!(exists))
                            {
                                licTemp.Categoria = licenciaTraido.Categoria;
                                licTemp.Marca = licenciaTraido.Marca;
                                licTemp.Version = licenciaTraido.Version;
                                licTemp.Clave = licenciaTraido.Clave;

                                licenciaAux.Add(licTemp);
                            }
                        }

                        bool error = true;

                        if (licenciaAux.Count > 0)
                            error = alquilerDA.InsertarLaptopLicenciaPrimeraVez(artTemp.IdLC, licenciaAux, this.nombreUsuario);
                        else return;

                        if (!error)
                        {
                            MessageBox.Show("Hubo error en agregar las licencias seleccionadas, comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            return;
                        }

                        foreach (Licencia licenciaTraido in licenciaAux)
                        {
                            alquiler.Detalles[indice].Laptop.Licencias.Add(licenciaTraido);
                        }

                        MessageBox.Show("Se realizó el cambio de piezas", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        tablaLicencia = alquilerDA.ListarLaptopLicencia(artTemp.IdLC);
                        //dgvLicencia.PrimaryGrid.DataSource = tablaLicencia;
                        dgvLicencias.DataSource = tablaLicencia;
                    }
                }
            }

        }

        private void btnCaducidadLicencia_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Estas seguro deseas Poner en caducidad esta licencia", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                int licTempId = -1;
                vistaLicencias.ClearColumnsFilter();
                for (int i = 0; i < vistaLicencias.RowCount; i++)
                    if (vistaLicencias.IsRowSelected(i) == true)
                        licTempId = int.Parse(vistaLicencias.GetRowCellValue(i, "IdLicencia").ToString());


                int equipoTempId = -1;
                vistaEquipos.ClearColumnsFilter();
                for (int i = 0; i < vistaEquipos.RowCount; i++)
                    if (vistaEquipos.IsRowSelected(i) == true)
                        equipoTempId = int.Parse(vistaEquipos.GetRowCellValue(i, "IdLC").ToString());


                bool error;
                if (licTempId != -1 && equipoTempId != -1)
                {
                    artTemp.IdLC = equipoTempId;
                    //int licTempId = int.Parse(((GridCell)(((GridRow)dgvLicencia.PrimaryGrid.ActiveRow)[4])).Value.ToString());

                    error = alquilerDA.ActualizarLaptopLicencia(artTemp.IdLC, licTempId, this.nombreUsuario, 0);
                    if (!error)
                    {
                        MessageBox.Show("Hubo error en poner en caducidad esta licencia, comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    int indiceLC = 0;
                    foreach (AlquilerDetalle detalle in alquiler.Detalles)
                    {
                        if (detalle.Laptop.IdLC == artTemp.IdLC)
                        {
                            break;
                        }
                        indiceLC++;
                    }
                    //Hasta aqui ya se encontro la licencia del ID y el indice de donde se ubica en el detalle

                    int indiceLic = 0;
                    foreach (Licencia licencia in alquiler.Detalles[indiceLC].Laptop.Licencias)
                    {
                        if (licencia.IdLicencia == licTempId)
                        {
                            break;
                        }
                        indiceLic++;
                    }

                    alquiler.Detalles[indiceLC].Laptop.Licencias.RemoveAt(indiceLic);

                    MessageBox.Show("Se eliminó la pieza seleccionada", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    tablaLicencia = alquilerDA.ListarLaptopLicencia(artTemp.IdLC);
                    //dgvLicencia.PrimaryGrid.DataSource = tablaLicencia;
                    dgvLicencias.DataSource = tablaLicencia;
                }
            }
        }

        private void btnEliminarLicencia_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Estas seguro deseas Eliminar esta licencia", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

                int licTempId = -1;
                vistaLicencias.ClearColumnsFilter();
                for (int i = 0; i < vistaLicencias.RowCount; i++)
                    if (vistaLicencias.IsRowSelected(i) == true)
                        licTempId = int.Parse(vistaLicencias.GetRowCellValue(i, "IdLicencia").ToString());

                int equipoTempId = -1;
                vistaEquipos.ClearColumnsFilter();
                for (int i = 0; i < vistaEquipos.RowCount; i++)
                    if (vistaEquipos.IsRowSelected(i) == true)
                        equipoTempId = int.Parse(vistaEquipos.GetRowCellValue(i, "IdLC").ToString());



                bool error;
                //if (dgvLicencia.PrimaryGrid.Rows.Count > 0)
                if (licTempId != -1 && equipoTempId != -1)
                {
                    artTemp.IdLC = equipoTempId;
                    //int licTempId = int.Parse(((GridCell)(((GridRow)dgvLicencia.PrimaryGrid.ActiveRow)[4])).Value.ToString());

                    error = alquilerDA.ActualizarLaptopLicencia(artTemp.IdLC, licTempId, this.nombreUsuario, 1);
                    if (!error)
                    {
                        MessageBox.Show("Hubo error en eliminar esta licencia, comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    int indiceLC = 0;
                    foreach (AlquilerDetalle detalle in alquiler.Detalles)
                    {
                        if (detalle.Laptop.IdLC == artTemp.IdLC)
                        {
                            break;
                        }
                        indiceLC++;
                    }
                    //Hasta aqui ya se encontro la licencia del ID y el indice de donde se ubica en el detalle

                    int indiceLic = 0;
                    foreach (Licencia licencia in alquiler.Detalles[indiceLC].Laptop.Licencias)
                    {
                        if (licencia.IdLicencia == licTempId)
                        {
                            break;
                        }
                        indiceLic++;
                    }

                    alquiler.Detalles[indiceLC].Laptop.Licencias.RemoveAt(indiceLic);

                    MessageBox.Show("Se eliminó la pieza seleccionada", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    tablaLicencia = alquilerDA.ListarLaptopLicencia(artTemp.IdLC);
                    //dgvLicencia.PrimaryGrid.DataSource = tablaLicencia;
                    dgvLicencias.DataSource = tablaLicencia;
                }
            }
        }

        
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Imprimir el Alquiler", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {

                    SaveFileDialog fichero = new SaveFileDialog();
                    //fichero.Filter = "Excel (*.xls)|*.xls";
                    fichero.Filter = "Excel(*.xlsx) | *.xlsx";
                    fichero.FileName = "Alquiler_" + alquiler.IdAlquiler.ToString();
                    if (fichero.ShowDialog() == DialogResult.OK)
                    {
                        Excel.Application aplicacion;
                        Excel.Workbook libros_trabajo;
                        Excel.Worksheet hoja_pre_alquiler;

                        aplicacion = new Excel.Application();
                        libros_trabajo = (Excel.Workbook)aplicacion.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);

                        hoja_pre_alquiler = (Excel.Worksheet)libros_trabajo.Worksheets.Add();
                        hoja_pre_alquiler.Name = "Alquiler";
                        string cabecera = "Reporte de Alquiler";
                        ExportarDataGridViewExcel(ref hoja_pre_alquiler, cabecera);


                        ((Excel.Worksheet)aplicacion.ActiveWorkbook.Sheets["Hoja1"]).Delete();

                        //libros_trabajo.SaveAs(fichero.FileName, Excel.XlFileFormat.xlWorkbookNormal);
                        libros_trabajo.SaveAs(fichero.FileName, Excel.XlFileFormat.xlOpenXMLWorkbook);
                        libros_trabajo.Close(true);
                        releaseObject(libros_trabajo);
                        aplicacion.Quit();
                        releaseObject(aplicacion);
                        MessageBox.Show("Se generó el reporte con éxito", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString(), "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                Cursor.Current = Cursors.Default;
            }
        }

        public void ExportarDataGridViewExcel(ref Excel.Worksheet hoja_trabajo,  string nombreCabecera)
        {
            Excel.Range rango;
            int i = 0;
            //Recorremos el DataGridView rellenando la hoja de trabajo
            foreach (AlquilerDetalle det in alquiler.Detalles)
            {
                //int k = grd.Columns.Count + 64;
                int k = 13 + 64;
                char columF = (char)k;
                int fila2 = i + 8;
                string filaBorde = fila2.ToString();
                char columI = 'A';
                //Ponemos borde a las celdas
                rango = hoja_trabajo.Range[columI + fila2.ToString(), columF + fila2.ToString()];
                rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                rango.Style.Font.Bold = false;

                hoja_trabajo.Cells[i + 8, 1] = det.GuiaSalida;
                hoja_trabajo.Cells[i + 8, 2] = "LAPTOP " + det.Laptop.Codigo;
                hoja_trabajo.Cells[i + 8, 3] = det.Laptop.Modelo.NombreMarca;
                hoja_trabajo.Cells[i + 8, 4] = det.Laptop.Modelo.NombreModelo;
                string aux = "";
                aux = det.Laptop.Procesador.Modelo.NombreModelo + "/GEN" + det.Laptop.Procesador.Generacion.ToString();
                hoja_trabajo.Cells[i + 8, 5] = aux;
                hoja_trabajo.Cells[i + 8, 6] = det.Laptop.Video.Capacidad.ToString() + " GB";

                hoja_trabajo.Cells[i + 8, 10] = det.Laptop.TamanoPantalla.ToString();

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

                hoja_trabajo.Cells[i + 8, 7] = (tipoDisco1.Length > 0) ? tipoDisco1 + " - " + capDisco1.ToString() + " GB" : "";
                hoja_trabajo.Cells[i + 8, 8] = (tipoDisco2.Length > 0) ? tipoDisco2 + " - " + capDisco2.ToString() + " GB" : "";

                int capacidadMem = 0;
                foreach (Memoria mem in det.Laptop.Memorias)
                {
                    capacidadMem += mem.Capacidad * mem.Cantidad;
                }
                hoja_trabajo.Cells[i + 8, 9] = capacidadMem.ToString() + " GB";

                Licencia windows = null; Licencia office = null; Licencia antivirus = null;

                if (det.Laptop.Licencias.Count > 0)
                {
                    windows = det.Laptop.Licencias.SingleOrDefault(p => p.Categoria == this.licenciaCategoriaSO);
                    office = det.Laptop.Licencias.SingleOrDefault(p => p.Categoria == this.licenciaCategoriaOffice);
                    antivirus = det.Laptop.Licencias.SingleOrDefault(p => p.Categoria == this.licenciaCategoriaAntivirus);

                }

                hoja_trabajo.Cells[i + 8, 11] = (windows != null) ? windows.Version : "";
                hoja_trabajo.Cells[i + 8, 12] = (office != null) ? office.Version : "";
                hoja_trabajo.Cells[i + 8, 13] = (antivirus != null) ? antivirus.Version : "";


                i++;
            }
            montaCabeceras(1, ref hoja_trabajo, nombreCabecera);
        }

        private void montaCabeceras(int fila, ref Excel.Worksheet hoja, string nombreCabecera)
        {
            try
            {
                Excel.Range rango;

                //** Montamos el título en la línea 1 **
                hoja.Cells[fila, 1] = nombreCabecera;
                hoja.Range[hoja.Cells[fila, 1], hoja.Cells[fila, 13]].Merge();
                hoja.Range[hoja.Cells[fila, 1], hoja.Cells[fila, 13]].Interior.Color = Color.Silver;
                hoja.Range[hoja.Cells[fila, 1], hoja.Cells[fila, 13]].Style.Font.Bold = true;
                //Centramos los textos
                rango = hoja.Rows[fila];
                rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                //worksheet.Range[worksheet.Cells[rowNum, columnNum], worksheet.Cells[rowNum, columnNum]].Merge();
                int indice;

                hoja.Cells[fila + 1, 1] = "Alquiler N°";
                hoja.Cells[fila + 1, 2] = txtNroAlquiler.Text;

                hoja.Cells[fila + 2, 1] = "Cliente°";
                indice = cmbCliente.SelectedIndex;
                hoja.Cells[fila + 2, 2] = tablaCliente.Rows[indice]["nombre_razonSocial"].ToString();
                hoja.Cells[fila + 3, 1] = "Dirección";
                indice = cmbSucursal.SelectedIndex;
                hoja.Cells[fila + 3, 2] = tablaClienteSucursal.Rows[indice]["direccion"].ToString();
                hoja.Cells[fila + 4, 1] = "RUC";
                hoja.Cells[fila + 4, 2] = txtNroDocumento.Text;

                hoja.Cells[fila + 2, 5] = "Fecha Traslado";
                hoja.Cells[fila + 2, 6] = dtpFechaTraslado.Value.ToString("yyyy/MM/dd");
                hoja.Cells[fila + 3, 5] = "Fecha Inicio Contrato";
                hoja.Cells[fila + 3, 6] = dtpIniPlazo.Value.ToString("yyyy/MM/dd");
                hoja.Cells[fila + 4, 5] = "Fecha Fin Contrato";
                hoja.Cells[fila + 4, 6] = dtpFinPlazo.Value.ToString("yyyy/MM/dd");

                hoja.Cells[fila + 2, 8] = "N° Contrato";
                hoja.Cells[fila + 2, 9] = txtNroContrato.Text;
                hoja.Cells[fila + 3, 8] = "N° OC";
                hoja.Cells[fila + 3, 9] = txtNroOC.Text;

                hoja.Cells[fila + 6, 1] = "Nro Guia";
                hoja.Cells[fila + 6, 2] = "Equipo";
                hoja.Cells[fila + 6, 3] = "Marca";
                hoja.Cells[fila + 6, 4] = "Modelo";
                hoja.Cells[fila + 6, 5] = "Procesador";
                hoja.Cells[fila + 6, 6] = "Video";
                hoja.Cells[fila + 6, 7] = "Disco 1";
                hoja.Cells[fila + 6, 8] = "Disco 2";
                hoja.Cells[fila + 6, 9] = "Memoria";
                hoja.Cells[fila + 6, 10] = "Pantalla";
                hoja.Cells[fila + 6, 11] = "S.O";
                hoja.Cells[fila + 6, 12] = "Office";
                hoja.Cells[fila + 6, 13] = "Antivirus";

                //int i = grd.Columns.Count + 64;
                int i = 13 + 64;
                char columF = (char)i;
                int fila2 = fila + 6;
                string filaBorde = fila2.ToString();
                char columI = 'A';
                //Ponemos borde a las celdas
                rango = hoja.Range[columI + fila2.ToString(), columF + fila2.ToString()];
                rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                rango.Interior.Color = Color.Silver;
                rango.Style.Font.Bold = true;
                //Centramos los textos
                rango = hoja.Rows[fila2];
                rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                //for (int j = 0; j < grd.Columns.Count; j++)
                for (int j = 0; j < 13; j++)
                {
                    rango = hoja.Columns[j + 1];
                    rango.ColumnWidth = 13;
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
                MessageBox.Show("Error mientras liberaba objecto " + ex.ToString(), "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                GC.Collect();
            }
        }


        private void vistaDiscos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
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

            int aux;
            int cantidadDisco;
            string myStr;
            if (discoID != -1)
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
                //================================SE HIZO ESTE BLOQUE EN VEZ DEL SIGUIENTE================
                BindingList<DiscoDuro> discos = new BindingList<DiscoDuro>();
                for (int i = 0; i < vistaDiscos.RowCount; i++)
                {
                    DiscoDuro disco = new DiscoDuro();
                    disco.IdDisco = int.Parse(vistaDiscos.GetRowCellValue(i, "IdDisco").ToString());
                    if (discoID != disco.IdDisco)
                    {
                        disco.TipoDisco = vistaDiscos.GetRowCellValue(i, "TipoDisco").ToString();
                        disco.Capacidad = int.Parse(vistaDiscos.GetRowCellValue(i, "Capacidad").ToString());
                        disco.Cantidad = int.Parse(vistaDiscos.GetRowCellValue(i, "Cantidad").ToString());
                        disco.Tamano = vistaDiscos.GetRowCellValue(i, "Tamano").ToString();
                        discos.Add(disco);
                    }
                    else
                    {
                        disco.TipoDisco = vistaDiscos.GetRowCellValue(i, "TipoDisco").ToString();
                        disco.Capacidad = int.Parse(vistaDiscos.GetRowCellValue(i, "Capacidad").ToString());
                        disco.Cantidad = cantidadDisco;
                        disco.Tamano = vistaDiscos.GetRowCellValue(i, "Tamano").ToString();
                        discos.Add(disco);
                    }
                }
                dgvDiscos.DataSource = discos;
                //=====================================================================================
                //vistaDiscos.SetRowCellValue(h, "Cantidad", cantidadDisco);
                //=====================================================================================
            }
        }

        private void dgvDiscos_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro deseas Eliminar este disco", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                bool error;

                vistaDiscos.ClearColumnsFilter();

                int discoID = -1;
                int h = 0;
                for (h = 0; h < vistaDiscos.RowCount; h++)
                    if (vistaDiscos.IsRowSelected(h) == true)
                    {
                        discoID = int.Parse(vistaDiscos.GetRowCellValue(h, "IdDisco").ToString());
                        break;
                    }

                int equipoTempId = -1;
                vistaEquipos.ClearColumnsFilter();
                for (int i = 0; i < vistaEquipos.RowCount; i++)
                    if (vistaEquipos.IsRowSelected(i) == true)
                        equipoTempId = int.Parse(vistaEquipos.GetRowCellValue(i, "IdLC").ToString());
                               
                if (discoID != -1 && equipoTempId != -1)
                {
                    artTemp.IdLC = equipoTempId;

                    int indice = 0;
                    foreach (AlquilerDetalle detalle in alquiler.Detalles)
                    {
                        if (detalle.Laptop.IdLC == artTemp.IdLC)
                        {
                            break;
                        }
                        indice++;
                    }

                    BindingList<DiscoDuro> discos = new BindingList<DiscoDuro>();
                    for (int i = 0; i < vistaDiscos.RowCount; i++)
                    {
                        DiscoDuro disco = new DiscoDuro();
                        disco.IdDisco = int.Parse(vistaDiscos.GetRowCellValue(i, "IdDisco").ToString());
                        if (discoID != disco.IdDisco)
                        {
                            disco.TipoDisco = vistaDiscos.GetRowCellValue(i, "TipoDisco").ToString();
                            disco.Capacidad = int.Parse(vistaDiscos.GetRowCellValue(i, "Capacidad").ToString());
                            disco.Cantidad = int.Parse(vistaDiscos.GetRowCellValue(i, "Cantidad").ToString());
                            disco.Tamano = vistaDiscos.GetRowCellValue(i, "Tamano").ToString();
                            discos.Add(disco);
                        }
                    }
                    error = alquilerDA.ActualizarLaptopDisco(artTemp.IdLC, discos, this.nombreUsuario);
                    if (!error)
                    {
                        MessageBox.Show("Hubo error, no se pudo eliminar este disco, comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    alquiler.Detalles[indice].Laptop.Discos = discos;
                    MessageBox.Show("Se eliminó la pieza seleccionada", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    tablaDisco = alquilerDA.ListarLaptopDisco(artTemp.IdLC);
                    dgvDiscos.DataSource = tablaDisco;
                }
            }
        }

        private void btnAgregarDisco_Click(object sender, EventArgs e)
        {
            int equipoTempId = -1;
            vistaEquipos.ClearColumnsFilter();
            for (int i = 0; i < vistaEquipos.RowCount; i++)
                if (vistaEquipos.IsRowSelected(i) == true)
                    equipoTempId = int.Parse(vistaEquipos.GetRowCellValue(i, "IdLC").ToString());
            
            if (equipoTempId!=-1)
            {
                int cantidadDiscos = vistaDiscos.RowCount;
                if (cantidadDiscos < this.maxCantidadDiscos)
                {
                    using (frmProcesoEditarDisco frm = new frmProcesoEditarDisco(cantidadDiscos, this.maxCantidadDiscos))
                    {
                        if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            artTemp.IdLC = equipoTempId;

                            int indice = 0;
                            foreach (AlquilerDetalle detalle in alquiler.Detalles)
                            {
                                if (detalle.Laptop.IdLC == artTemp.IdLC)
                                {
                                    break;
                                }
                                indice++;
                            }

                            foreach (DiscoDuro discoTraido in frm.DISCOS)
                            {
                                DiscoDuro disTemp = new DiscoDuro();
                                disTemp.IdDisco = discoTraido.IdDisco;
                                bool exists = alquiler.Detalles[indice].Laptop.Discos.Any(x => x.IdDisco.Equals(disTemp.IdDisco));
                                if (!(exists))
                                {
                                    disTemp.TipoDisco = discoTraido.TipoDisco;
                                    disTemp.Capacidad = discoTraido.Capacidad;
                                    disTemp.Cantidad = 1;
                                    alquiler.Detalles[indice].Laptop.Discos.Add(disTemp);
                                }
                            }

                            bool error;
                            if (vistaDiscos.RowCount > 0)
                            {
                                error = alquilerDA.ActualizarLaptopDisco(artTemp.IdLC, alquiler.Detalles[indice].Laptop.Discos, this.nombreUsuario);
                            }
                            else
                            {
                                error = alquilerDA.InsertarLaptopDiscosPrimeraVez(artTemp.IdLC, alquiler.Detalles[indice].Laptop.Discos, this.nombreUsuario);
                            }

                            if (!error)
                            {
                                MessageBox.Show("Hubo error en agregar los discos seleccionados, comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                return;
                            }

                            MessageBox.Show("Se realizó el cambio de piezas", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            tablaDisco = alquilerDA.ListarLaptopDisco(artTemp.IdLC);
                            dgvDiscos.DataSource = tablaDisco;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No puedes agregar más de " + this.maxCantidadDiscos + " discos duros", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }

        }

        private void btnGuardarDisco_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Estas seguro deseas Guardar los cambios hechos en tus discos actuales", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                bool error;

                vistaDiscos.ClearColumnsFilter();


                int equipoTempId = -1;
                vistaEquipos.ClearColumnsFilter();
                for (int i = 0; i < vistaEquipos.RowCount; i++)
                    if (vistaEquipos.IsRowSelected(i) == true)
                        equipoTempId = int.Parse(vistaEquipos.GetRowCellValue(i, "IdLC").ToString());


                if (vistaDiscos.RowCount>0 && equipoTempId != -1)
                {
                    artTemp.IdLC = equipoTempId;

                    int indice = 0;
                    foreach (AlquilerDetalle detalle in alquiler.Detalles)
                    {
                        if (detalle.Laptop.IdLC == artTemp.IdLC)
                        {
                            break;
                        }
                        indice++;
                    }

                    BindingList<DiscoDuro> discos = new BindingList<DiscoDuro>();
                    for (int i = 0; i < vistaDiscos.RowCount; i++)
                    {
                        DiscoDuro disco = new DiscoDuro();
                        disco.IdDisco = int.Parse(vistaDiscos.GetRowCellValue(i, "IdDisco").ToString());
                        disco.TipoDisco = vistaDiscos.GetRowCellValue(i, "TipoDisco").ToString();
                        disco.Capacidad = int.Parse(vistaDiscos.GetRowCellValue(i, "Capacidad").ToString());
                        disco.Cantidad = int.Parse(vistaDiscos.GetRowCellValue(i, "Cantidad").ToString());
                        disco.Tamano = vistaDiscos.GetRowCellValue(i, "Tamano").ToString();
                        discos.Add(disco);
                    }

                    int maxCant = alquilerDA.ValidarCantidadLaptopDiscos(artTemp.IdLC, discos);
                    if (maxCant == -1)
                    {
                        MessageBox.Show("Uno de los discos tiene una cantidad mayor al stock actual", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }

                    error = alquilerDA.ActualizarLaptopDisco(artTemp.IdLC, discos, this.nombreUsuario);
                    if (!error)
                    {
                        MessageBox.Show("Hubo error en el cambio de piezas, comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    alquiler.Detalles[indice].Laptop.Discos = discos;
                    MessageBox.Show("Se realizó el cambio de piezas", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }


        private void vistaMemorias_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            vistaMemorias.ClearColumnsFilter();

            int memoriaID = -1;
            int h = 0;
            for (h = 0; h < vistaMemorias.RowCount; h++)
                if (vistaMemorias.IsRowSelected(h) == true)
                {
                    memoriaID = int.Parse(vistaMemorias.GetRowCellValue(h, "IdMemoria").ToString());
                    break;
                }


            int aux;
            int cantidadMemoria;
            string myStr;
            if (memoriaID != -1)
            {
                myStr = vistaMemorias.GetRowCellValue(h, "Cantidad").ToString();
                myStr = myStr.TrimStart('0');

                if (myStr.Length > 0)
                {
                    aux = int.Parse(myStr);
                    if (aux < 0) myStr = "1";
                }
                else myStr = "1";
                cantidadMemoria = myStr.Length > 0 ? int.Parse(myStr) : 1;

                //================================SE HIZO ESTE BLOQUE EN VEZ DEL SIGUIENTE================
                BindingList<Memoria> memorias = new BindingList<Memoria>();
                for (int i = 0; i < vistaMemorias.RowCount; i++)
                {
                    Memoria memoria = new Memoria();
                    memoria.IdMemoria = int.Parse(vistaMemorias.GetRowCellValue(i, "IdMemoria").ToString());
                    if (memoriaID != memoria.IdMemoria)
                    {
                        memoria.TipoMemoria = vistaMemorias.GetRowCellValue(i, "TipoMemoria").ToString();
                        memoria.Tipo = vistaMemorias.GetRowCellValue(i, "Tipo2").ToString();
                        memoria.Capacidad = int.Parse(vistaMemorias.GetRowCellValue(i, "Capacidad").ToString());
                        memoria.Cantidad = int.Parse(vistaMemorias.GetRowCellValue(i, "Cantidad").ToString());
                        memorias.Add(memoria);
                    }
                    else
                    {
                        memoria.TipoMemoria = vistaMemorias.GetRowCellValue(i, "TipoMemoria").ToString();
                        memoria.Tipo = vistaMemorias.GetRowCellValue(i, "Tipo2").ToString();
                        memoria.Capacidad = int.Parse(vistaMemorias.GetRowCellValue(i, "Capacidad").ToString());
                        memoria.Cantidad = cantidadMemoria;
                        memorias.Add(memoria);
                    }
                }
                dgvMemoria.DataSource = memorias;
                //=====================================================================================
                //vistaDiscos.SetRowCellValue(h, "Cantidad", cantidadDisco);
                //=====================================================================================

            }

        }

        private void dgvMemoria_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro deseas Eliminar esta memoria", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                bool error;

                vistaMemorias.ClearColumnsFilter();

                int memoriaID = -1;
                int h = 0;
                for (h = 0; h < vistaMemorias.RowCount; h++)
                    if (vistaMemorias.IsRowSelected(h) == true)
                    {
                        memoriaID = int.Parse(vistaMemorias.GetRowCellValue(h, "IdMemoria").ToString());
                        break;
                    }



                int equipoTempId = -1;
                vistaEquipos.ClearColumnsFilter();
                for (int i = 0; i < vistaEquipos.RowCount; i++)
                    if (vistaEquipos.IsRowSelected(i) == true)
                        equipoTempId = int.Parse(vistaEquipos.GetRowCellValue(i, "IdLC").ToString());



                if (memoriaID != -1 && equipoTempId != -1)
                {
                    artTemp.IdLC = equipoTempId;

                    int indice = 0;
                    foreach (AlquilerDetalle detalle in alquiler.Detalles)
                    {
                        if (detalle.Laptop.IdLC == artTemp.IdLC)
                        {
                            break;
                        }
                        indice++;
                    }

                    BindingList<Memoria> memorias = new BindingList<Memoria>();
                    for (int i = 0; i < vistaMemorias.RowCount; i++)
                    {
                        Memoria memoria = new Memoria();
                        //int memoriaID = int.Parse(((GridCell)(((GridRow)dgvMemorias.PrimaryGrid.ActiveRow)[3])).Value.ToString());
                        memoria.IdMemoria = int.Parse(vistaMemorias.GetRowCellValue(i, "IdMemoria").ToString());
                        if (memoriaID != memoria.IdMemoria)
                        {
                            memoria.TipoMemoria = vistaMemorias.GetRowCellValue(i, "TipoMemoria").ToString();
                            memoria.Tipo = vistaMemorias.GetRowCellValue(i, "Tipo2").ToString();
                            memoria.Capacidad = int.Parse(vistaMemorias.GetRowCellValue(i, "Capacidad").ToString());
                            memoria.Cantidad = int.Parse(vistaMemorias.GetRowCellValue(i, "Cantidad").ToString());
                            memorias.Add(memoria);

                        }
                    }
                    error = alquilerDA.ActualizarLaptopMemoria(artTemp.IdLC, memorias, this.nombreUsuario);
                    if (!error)
                    {
                        MessageBox.Show("Hubo error, no se pudo eliminar esta memoria, comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    alquiler.Detalles[indice].Laptop.Memorias = memorias;
                    MessageBox.Show("Se eliminó la pieza seleccionada", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    tablaMemoria = alquilerDA.ListarLaptopMemoria(artTemp.IdLC);
                    dgvMemoria.DataSource = tablaMemoria;
                }
            }
        }

        private void btnAgregarMemoria_Click(object sender, EventArgs e)
        {

            int equipoTempId = -1;
            vistaEquipos.ClearColumnsFilter();
            for (int i = 0; i < vistaEquipos.RowCount; i++)
                if (vistaEquipos.IsRowSelected(i) == true)
                    equipoTempId = int.Parse(vistaEquipos.GetRowCellValue(i, "IdLC").ToString());


            if (equipoTempId!=-1)
            {
                using (frmProcesoEditarMemoria frm = new frmProcesoEditarMemoria())
                {
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        artTemp.IdLC = equipoTempId;

                        int indice = 0;
                        foreach (AlquilerDetalle detalle in alquiler.Detalles)
                        {
                            if (detalle.Laptop.IdLC == artTemp.IdLC)
                            {
                                break;
                            }
                            indice++;
                        }

                        foreach (Memoria memoriaTraido in frm.MEMORIAS)
                        {
                            Memoria memTemp = new Memoria();
                            memTemp.IdMemoria = memoriaTraido.IdMemoria;
                            bool exists = alquiler.Detalles[indice].Laptop.Memorias.Any(x => x.IdMemoria.Equals(memTemp.IdMemoria));
                            if (!(exists))
                            {
                                memTemp.TipoMemoria = memoriaTraido.TipoMemoria;
                                memTemp.Capacidad = memoriaTraido.Capacidad;
                                memTemp.Tipo = memoriaTraido.Tipo;
                                memTemp.Cantidad = 1;
                                alquiler.Detalles[indice].Laptop.Memorias.Add(memTemp);
                            }
                        }

                        bool error;
                        if (vistaMemorias.RowCount > 0)
                        {
                            error = alquilerDA.ActualizarLaptopMemoria(artTemp.IdLC, alquiler.Detalles[indice].Laptop.Memorias, this.nombreUsuario);
                        }
                        else
                        {
                            error = alquilerDA.InsertarLaptopMemoriasPrimeraVez(artTemp.IdLC, alquiler.Detalles[indice].Laptop.Memorias, this.nombreUsuario);
                        }

                        if (!error)
                        {
                            MessageBox.Show("Hubo error en agregar las memorias seleccionadas, comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            return;
                        }

                        MessageBox.Show("Se realizó el cambio de piezas", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        tablaMemoria = alquilerDA.ListarLaptopMemoria(artTemp.IdLC);
                        dgvMemoria.DataSource = tablaMemoria;
                    }
                }
            }

        }

        private void btnGuardarMemoria_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Estas seguro deseas Guardar los cambios hechos en tus memorias actuales", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                bool error;
                vistaMemorias.ClearColumnsFilter();

                int equipoTempId = -1;
                vistaEquipos.ClearColumnsFilter();
                for (int i = 0; i < vistaEquipos.RowCount; i++)
                    if (vistaEquipos.IsRowSelected(i) == true)
                        equipoTempId = int.Parse(vistaEquipos.GetRowCellValue(i, "IdLC").ToString());


                if (vistaMemorias.RowCount > 0 && equipoTempId!=-1)
                {
                    artTemp.IdLC = equipoTempId;

                    int indice = 0;
                    foreach (AlquilerDetalle detalle in alquiler.Detalles)
                    {
                        if (detalle.Laptop.IdLC == artTemp.IdLC)
                        {
                            break;
                        }
                        indice++;
                    }

                    BindingList<Memoria> memorias = new BindingList<Memoria>();
                    for (int i = 0; i < vistaMemorias.RowCount; i++)
                    {
                        Memoria memoria = new Memoria();

                        memoria.IdMemoria = int.Parse(vistaMemorias.GetRowCellValue(i, "IdMemoria").ToString());
                        memoria.TipoMemoria = vistaMemorias.GetRowCellValue(i, "TipoMemoria").ToString();
                        memoria.Tipo = vistaMemorias.GetRowCellValue(i, "Tipo2").ToString();
                        memoria.Capacidad = int.Parse(vistaMemorias.GetRowCellValue(i, "Capacidad").ToString());
                        memoria.Cantidad = int.Parse(vistaMemorias.GetRowCellValue(i, "Cantidad").ToString());
                        memorias.Add(memoria);
                    }

                    int maxCant = alquilerDA.ValidarCantidadLaptopMemoria(artTemp.IdLC, memorias);
                    if (maxCant == -1)
                    {
                        MessageBox.Show("Uno de las memorias tiene una cantidad mayor al stock actual", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }

                    error = alquilerDA.ActualizarLaptopMemoria(artTemp.IdLC, memorias, this.nombreUsuario);
                    if (!error)
                    {
                        MessageBox.Show("Hubo error en el cambio de piezas, comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    alquiler.Detalles[indice].Laptop.Memorias = memorias;
                    MessageBox.Show("Se realizó el cambio de piezas", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }


        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            using (frmProcesoAlquilerAgregarProducto frm = new frmProcesoAlquilerAgregarProducto())
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    BindingList<AlquilerDetalle> auxiliares = new BindingList<AlquilerDetalle>();
                    foreach (AlquilerDetalle aux in alquiler.Detalles)
                    {
                        auxiliares.Add(aux);
                    }
                    foreach (LC laptopTraido in frm.LAPTOPS)
                    {
                        AlquilerDetalle dp = new AlquilerDetalle();
                        artTemp = new LC();
                        artTemp.IdLC = laptopTraido.IdLC;
                        bool exists = auxiliares.Any(x => x.Laptop.IdLC.Equals(artTemp.IdLC));
                        if (!(exists))
                        {
                            tablaDisco = alquilerDA.ListarLaptopDisco(artTemp.IdLC);
                            tablaMemoria = alquilerDA.ListarLaptopMemoria(artTemp.IdLC);
                            tablaLicencia = alquilerDA.ListarLaptopLicencia(artTemp.IdLC);
                            laptopTraido.SetDisco(tablaDisco);
                            laptopTraido.SetMemoria(tablaMemoria);
                            laptopTraido.SetLicencia(tablaLicencia);

                            dp.Laptop = laptopTraido;
                            auxiliares.Add(dp);
                        }
                    }

                    alquiler.Detalles = auxiliares;
                }
            }

            dgvEquipos.DataSource = alquiler.Detalles;
            lblContador.Text = $"CANTIDAD REGISTRO: {alquiler.Detalles.Count.ToString()}";
            if (alquiler.Detalles.Count > 0)
            {
                dgvDiscos.Enabled = true;
                dgvMemoria.Enabled = true;
                dgvLicencias.Enabled = true;
                btnAgregarDisco.Enabled = true;
                btnGuardarDisco.Enabled = true;
                btnAgregarMemoria.Enabled = true;
                btnGuardarMemoria.Enabled = true;
                btnAgregarLicencia.Enabled = true;
                btnEliminarLicencia.Enabled = true;
                btnCaducidadLicencia.Enabled = true;
            }
        }

        private void dgvEquipos_Click(object sender, EventArgs e)
        {
            vistaEquipos.ClearColumnsFilter();

            int equipoID = -1;
            int h = 0;
            for (h = 0; h < vistaEquipos.RowCount; h++)
                if (vistaEquipos.IsRowSelected(h) == true)
                {
                    equipoID = int.Parse(vistaEquipos.GetRowCellValue(h, "IdLC").ToString());
                    break;
                }


            if (equipoID != -1)
            {
                artTemp = new LC();
                artTemp.IdLC = equipoID;

                int indice = 0;
                foreach (AlquilerDetalle detalle in alquiler.Detalles)
                {
                    if (detalle.Laptop.IdLC == artTemp.IdLC)
                    {
                        break;
                    }
                    indice++;
                }

                tablaDisco = alquilerDA.ListarLaptopDisco(artTemp.IdLC);
                tablaMemoria = alquilerDA.ListarLaptopMemoria(artTemp.IdLC);
                tablaLicencia = alquilerDA.ListarLaptopLicencia(artTemp.IdLC);
                dgvDiscos.DataSource = tablaDisco;
                dgvMemoria.DataSource = tablaMemoria;
                dgvLicencias.DataSource = tablaLicencia;
            }
        }

        private void dgvEquipos_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro deseas Eliminar esta laptop de tu detalle de Alquiler", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                bool error;
                vistaEquipos.ClearColumnsFilter();

                int equipoID = -1;
                int h = 0;
                for (h = 0; h < vistaEquipos.RowCount; h++)
                    if (vistaEquipos.IsRowSelected(h) == true)
                    {
                        equipoID = int.Parse(vistaEquipos.GetRowCellValue(h, "IdLC").ToString());
                        break;
                    }

                if (equipoID != -1)
                {
                    artTemp.IdLC = equipoID;

                    int indiceLC = 0;
                    foreach (AlquilerDetalle detalle in alquiler.Detalles)
                    {
                        if (detalle.Laptop.IdLC == artTemp.IdLC)
                        {
                            break;
                        }
                        indiceLC++;
                    }

                    alquiler.Detalles.RemoveAt(indiceLC);

                    dgvEquipos.DataSource = alquiler.Detalles;
                }
            }

            lblContador.Text = $"CANTIDAD REGISTRO: {alquiler.Detalles.Count.ToString()}";
        }

        private void btnSeleccionarFilas_Click(object sender, EventArgs e)
        {
            int filas = vistaEquipos.RowCount;
            for (int i = 0; i < filas; i++)
            {
                vistaEquipos.SetRowCellValue(i, "Seleccionar", true);
            }
        }

        private void btnDeseleccionarFilas_Click(object sender, EventArgs e)
        {
            int filas = vistaEquipos.RowCount;
            for (int i = 0; i < filas; i++)
            {
                vistaEquipos.SetRowCellValue(i, "Seleccionar", false);
            }
        }
    }
}
