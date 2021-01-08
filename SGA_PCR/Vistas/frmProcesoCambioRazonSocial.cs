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
    public partial class frmProcesoCambioRazonSocial : Form
    {

        public enum TipoVista { Inicial, Nuevo, Modificar, Guardar, Vista, Limpiar, Duplicar, Anular }
        DataTable tablaClienteActual;
        DataTable tablaClienteNuevo;
        DataTable tablaClienteSucursal;
        ClienteDA clienteDA;
        CambioRazonSocialDA cambioRazonSocialDA;
        BindingList<CambioRazonSocial> cambios;
        int IdClienteActual;
        String NumeroDniRucActual;
        int IdClienteNuevo;
        String NumeroDniRucNuevo;
        int IdClienteSucursal;



        private int idUsuario;
        private string nombreUsuario = "CEAS";

        private int posY = 0;
        private int posX = 0;

        public frmProcesoCambioRazonSocial()
        {
            InitializeComponent();
            Inicializado();
            estadoComponentes(TipoVista.Inicial);
        }

        public frmProcesoCambioRazonSocial(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
            estadoComponentes(TipoVista.Inicial);
        }

        public void Inicializado()
        {
            clienteDA = new ClienteDA();
            cambioRazonSocialDA = new CambioRazonSocialDA();
            cambios = new BindingList<CambioRazonSocial>();

            tablaClienteActual = clienteDA.ListarClientes();
            cmbCliente.DataSource = tablaClienteActual;
            cmbCliente.DisplayMember = "nombre_razonSocial";
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.SelectedIndex = -1;

            //int i = cmbCliente.SelectedIndex;

            //int idCliente = Convert.ToInt32(tablaClienteActual.Rows[i]["idCliente"].ToString());
            //txtNroDocumento.Text = tablaClienteActual.Rows[i]["nroDocumento"].ToString();

            tablaClienteNuevo = clienteDA.ListarClientes();
            cmbClienteNuevo.DataSource = tablaClienteNuevo;
            cmbClienteNuevo.DisplayMember = "nombre_razonSocial";
            cmbClienteNuevo.ValueMember = "idCliente";
            cmbClienteNuevo.SelectedIndex = -1;

            //i = cmbCliente.SelectedIndex;

            //idCliente = Convert.ToInt32(tablaClienteNuevo.Rows[i]["idCliente"].ToString());
            //txtNroDocumentoNuevo.Text = tablaClienteNuevo.Rows[i]["nroDocumento"].ToString();


            dgvLaptopsSeleccionados.DataSource = null;
            vistaLaptops.OptionsBehavior.AutoPopulateColumns = false;
            vistaLaptops.OptionsSelection.MultiSelect = true;

        }

        public void estadoComponentes(TipoVista estado)
        {
            switch (estado)
            {
                case TipoVista.Inicial:
                    cmbCliente.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    cmbClienteNuevo.Enabled = false;
                    txtNroDocumentoNuevo.Enabled = false;
                    cmbSucursalNuevo.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    limpiarComponentes();
                    cambios = new BindingList<CambioRazonSocial>();
                    break;
                case TipoVista.Nuevo:
                    cmbCliente.Enabled = true;
                    txtNroDocumento.Enabled = true;
                    cmbClienteNuevo.Enabled = true;
                    txtNroDocumentoNuevo.Enabled = true;
                    cmbSucursalNuevo.Enabled = true;
                    dgvLaptopsSeleccionados.Enabled = true;
                    btnAgregarProducto.Enabled = true;
                    btnNuevo.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnGrabar.Enabled = true;
                    limpiarComponentes();
                    cambios = new BindingList<CambioRazonSocial>();
                    break;
                case TipoVista.Guardar:
                    cmbCliente.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    cmbClienteNuevo.Enabled = false;
                    txtNroDocumentoNuevo.Enabled = false;
                    cmbSucursalNuevo.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    break;
                case TipoVista.Modificar:
                    cmbCliente.Enabled = true;
                    txtNroDocumento.Enabled = true;
                    cmbClienteNuevo.Enabled = true;
                    txtNroDocumentoNuevo.Enabled = true;
                    cmbSucursalNuevo.Enabled = true;
                    dgvLaptopsSeleccionados.Enabled = true;
                    btnAgregarProducto.Enabled = true;
                    btnNuevo.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnGrabar.Enabled = true;
                    break;
                case TipoVista.Vista:
                    cmbCliente.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    cmbClienteNuevo.Enabled = false;
                    txtNroDocumentoNuevo.Enabled = false;
                    cmbSucursalNuevo.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    cambios = new BindingList<CambioRazonSocial>();
                    break;
                case TipoVista.Limpiar:
                    cmbCliente.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    cmbClienteNuevo.Enabled = false;
                    txtNroDocumentoNuevo.Enabled = false;
                    cmbSucursalNuevo.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    limpiarComponentes();
                    cambios = new BindingList<CambioRazonSocial>();
                    break;
                case TipoVista.Duplicar:
                    cmbCliente.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    cmbClienteNuevo.Enabled = false;
                    txtNroDocumentoNuevo.Enabled = false;
                    cmbSucursalNuevo.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    limpiarComponentes();
                    cambios = new BindingList<CambioRazonSocial>();
                    break;
                case TipoVista.Anular:
                    cmbCliente.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    cmbClienteNuevo.Enabled = false;
                    txtNroDocumentoNuevo.Enabled = false;
                    cmbSucursalNuevo.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            cmbCliente.SelectedIndex = -1;
            cmbClienteNuevo.SelectedIndex = -1;
            cmbSucursalNuevo.SelectedIndex = -1;
            txtNroDocumento.Text = "";
            txtNroDocumentoNuevo.Text = "";
            dgvLaptopsSeleccionados.DataSource = null;
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmbCliente.SelectedIndex;
            if (i >= 0)
            {
                IdClienteActual = Convert.ToInt32(tablaClienteActual.Rows[i]["idCliente"].ToString());
                txtNroDocumento.Text = tablaClienteActual.Rows[i]["nroDocumento"].ToString();
                dgvLaptopsSeleccionados.DataSource = null;
            }
            else
            {
                IdClienteActual = -1;
                txtNroDocumento.Text = "";
            }
            cambios = new BindingList<CambioRazonSocial>();
        }

        private void cmbClienteNuevo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmbClienteNuevo.SelectedIndex;
            if (i >= 0)
            {
                IdClienteNuevo = Convert.ToInt32(tablaClienteNuevo.Rows[i]["idCliente"].ToString());
                txtNroDocumentoNuevo.Text = tablaClienteNuevo.Rows[i]["nroDocumento"].ToString();
                tablaClienteSucursal = clienteDA.ListarSucursalCliente(IdClienteNuevo);
                cmbSucursalNuevo.DataSource = (tablaClienteSucursal.Rows.Count > 0) ? tablaClienteSucursal : null;
                cmbSucursalNuevo.DisplayMember = "direccion";
                cmbSucursalNuevo.ValueMember = "idSucursal";
                cmbSucursalNuevo.SelectedIndex = (tablaClienteSucursal.Rows.Count > 0) ? 0 : -1;
            }
            else
            {
                IdClienteNuevo = -1;
                cmbSucursalNuevo.DataSource = null;
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
                cambios = new BindingList<CambioRazonSocial>();
                dgvLaptopsSeleccionados.DataSource = null;
            }
        }

        public bool validarDatos()
        {
            if (cmbCliente.SelectedValue == null)
            {
                MessageBox.Show("No se puede realizar el proceso\n si no se ha seleccionado una cliente correcto.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return false;
            }
            if (cmbClienteNuevo.SelectedValue == null)
            {
                MessageBox.Show("No se puede realizar el proceso\n si no se ha seleccionado una cliente correcto.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return false;
            }
            if (cmbSucursalNuevo.SelectedValue == null)
            {
                MessageBox.Show("No se puede realizar el proceso\n si no se ha seleccionado una cliente correcto.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return false;
            }

            if (cambios.Count == 0)
            {
                MessageBox.Show("No se puede grabar si no hay ningun equipo.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void ObtenerDatos()
        {
            IdClienteActual = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
            string aux1 = txtNroDocumento.Text;
            NumeroDniRucActual = aux1.Trim();

            IdClienteNuevo = Convert.ToInt32(cmbClienteNuevo.SelectedValue.ToString());
            string aux2 = txtNroDocumentoNuevo.Text;
            NumeroDniRucNuevo = aux2.Trim();
            IdClienteSucursal = Convert.ToInt32(cmbSucursalNuevo.SelectedValue.ToString());
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (validarDatos())
            {
                ObtenerDatos();

                if (MessageBox.Show("Estas seguro que deseas guardar este proceso", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    int error = 0;
                    error = cambioRazonSocialDA.InsertarCambioRazonSocial(cambios,IdClienteActual,IdClienteNuevo,IdClienteSucursal,NumeroDniRucActual,NumeroDniRucNuevo, this.nombreUsuario);

                    if (error == 0)
                    {
                        MessageBox.Show("Hubo error en el registro, comunicarse con tu soporte", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }

                    MessageBox.Show("Se guardó el proceso", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    estadoComponentes(TipoVista.Guardar);
                }
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue == null)
            {
                MessageBox.Show("No se puede agregar productos\n si no se ha seleccionado un cliente correcto.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return;
            }
            using (frmProcesoCambioRazonSocialAgregarProducto frm = new frmProcesoCambioRazonSocialAgregarProducto(IdClienteActual))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    BindingList<CambioRazonSocial> auxiliares = new BindingList<CambioRazonSocial>();
                    foreach (CambioRazonSocial aux in cambios)
                    {
                        auxiliares.Add(aux);
                    }

                    foreach (CambioRazonSocial detalleTraido in frm.DETALLES)
                    {
                        bool exists = auxiliares.Any(x => x.IdEquipo.Equals(detalleTraido.IdEquipo));
                        if (!(exists))
                        {
                            auxiliares.Add(detalleTraido);
                        }
                    }
                    cambios = auxiliares;
                }
            }

            dgvLaptopsSeleccionados.DataSource = cambios;
        }

        private void dgvLaptopsSeleccionados_DoubleClick(object sender, EventArgs e)
        {
            vistaLaptops.ClearColumnsFilter();
            if (vistaLaptops.RowCount > 0)
            {
                if (MessageBox.Show("Estas seguro deseas Eliminar este equipo de tu detalle", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    int equipoID = -1;
                    int h = 0;
                    for (h = 0; h < vistaLaptops.RowCount; h++)
                        if (vistaLaptops.IsRowSelected(h) == true)
                        {
                            equipoID = int.Parse(vistaLaptops.GetRowCellValue(h, "IdEquipo").ToString());
                            break;
                        }

                    int indice = 0;
                    foreach (CambioRazonSocial detalle in cambios)
                    {
                        if (detalle.IdEquipo == equipoID)
                        {
                            break;
                        }
                        indice++;
                    }
                    cambios.RemoveAt(indice);
                    dgvLaptopsSeleccionados.DataSource = cambios;
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlD_MouseMove(object sender, MouseEventArgs e)
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
