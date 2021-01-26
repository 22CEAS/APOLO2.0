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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apolo
{
    public partial class frmArchivoClienteContacto : Form
    {
        public enum TipoVista { Inicial, Nuevo, Modificar, Guardar, Vista, Limpiar, Duplicar, Anular }
        DataTable tablaContactoCliente;
        DataTable tablaCliente;
        DataTable tablaContactoTipo;
        ClienteContacto contactoCliente;
        ClienteDA clienteDA;
        private int idUsuario;
        private string nombreUsuario = "CEAS";

        public frmArchivoClienteContacto()
        {
            InitializeComponent();
            Inicializado();
            estadoComponentes(TipoVista.Inicial);
        }
        public frmArchivoClienteContacto(int idUsuario, string nombreUsuario)
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
            contactoCliente = new ClienteContacto();

            tablaCliente = clienteDA.ListarClientes();
            cmbCliente.DataSource = tablaCliente;
            cmbCliente.DisplayMember = "nombre_razonSocial";
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.SelectedIndex = -1;

            tablaContactoTipo = clienteDA.ListarContactoTipo();
            cmbTipoContacto.DataSource = tablaContactoTipo;
            cmbTipoContacto.DisplayMember = "descripcion";
            cmbTipoContacto.ValueMember = "idAuxiliar";
            cmbTipoContacto.SelectedIndex = -1;

            dgvContactos.DataSource = null;
            vistaContactos.OptionsBehavior.AutoPopulateColumns = false;
            vistaContactos.OptionsSelection.MultiSelect = true;

        }
        public void estadoComponentes(TipoVista estado)
        {
            switch (estado)
            {
                case TipoVista.Inicial: //ya esta
                    btnNuevo.Enabled = (cmbCliente.SelectedIndex != -1) ? true : false;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = (cmbCliente.SelectedIndex != -1) ? true : false; ;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = (cmbCliente.SelectedIndex != -1) ? true : false;
                    cmbCliente.Enabled = true;
                    txtNombreContacto.Enabled = false;
                    txtCargo.Enabled = false;
                    cmbTipoContacto.Enabled = false;
                    txtEmail.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtAnexo.Enabled = false;
                    chbActivo.Enabled = false;
                    limpiarComponentes();
                    contactoCliente = new ClienteContacto();
                    break;
                case TipoVista.Nuevo: //ya esta
                    btnNuevo.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnImprimir.Enabled = false;
                    btnGrabar.Enabled = true;
                    btnEditar.Enabled = false;
                    cmbCliente.Enabled = false;
                    txtNombreContacto.Enabled = true;
                    txtCargo.Enabled = true;
                    cmbTipoContacto.Enabled = true;
                    txtEmail.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtAnexo.Enabled = true;
                    chbActivo.Enabled = false;
                    limpiarComponentes();
                    contactoCliente = new ClienteContacto();
                    break;
                case TipoVista.Guardar: //ya esta listo
                    btnNuevo.Enabled = (cmbCliente.SelectedIndex != -1) ? true : false;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = (cmbCliente.SelectedIndex != -1) ? true : false; ;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = (cmbCliente.SelectedIndex != -1) ? true : false;
                    cmbCliente.Enabled = true;
                    txtNombreContacto.Enabled = false;
                    txtCargo.Enabled = false;
                    cmbTipoContacto.Enabled = false;
                    txtEmail.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtAnexo.Enabled = false;
                    chbActivo.Enabled = false;
                    contactoCliente = new ClienteContacto();
                    break;
                case TipoVista.Modificar://ya esta
                    btnNuevo.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnImprimir.Enabled = false;
                    btnGrabar.Enabled = true;
                    btnEditar.Enabled = false;
                    cmbCliente.Enabled = false;
                    txtNombreContacto.Enabled = true;
                    txtCargo.Enabled = true;
                    cmbTipoContacto.Enabled = true;
                    txtEmail.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtAnexo.Enabled = true;
                    chbActivo.Enabled = true;
                    limpiarComponentes();
                    contactoCliente = new ClienteContacto();
                    break;
                case TipoVista.Vista:
                    btnNuevo.Enabled = (cmbCliente.SelectedIndex != -1) ? true : false;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = (cmbCliente.SelectedIndex != -1) ? true : false; ;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = (cmbCliente.SelectedIndex != -1) ? true : false;
                    cmbCliente.Enabled = true;
                    txtNombreContacto.Enabled = false;
                    txtCargo.Enabled = false;
                    cmbTipoContacto.Enabled = false;
                    txtEmail.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtAnexo.Enabled = false;
                    chbActivo.Enabled = false;
                    contactoCliente = new ClienteContacto();
                    break;
                case TipoVista.Limpiar: //ya esta
                    btnNuevo.Enabled = (cmbCliente.SelectedIndex != -1) ? true : false;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = false;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = false;
                    cmbCliente.Enabled = true;
                    txtNombreContacto.Enabled = false;
                    txtCargo.Enabled = false;
                    cmbTipoContacto.Enabled = false;
                    txtEmail.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtAnexo.Enabled = false;
                    chbActivo.Enabled = false;
                    limpiarComponentes();
                    contactoCliente = new ClienteContacto();
                    break;
                case TipoVista.Duplicar:  //ya esta
                    btnNuevo.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = false;
                    btnGrabar.Enabled = true;
                    btnEditar.Enabled = false;
                    cmbCliente.Enabled = true;
                    txtNombreContacto.Enabled = true;
                    txtCargo.Enabled = true;
                    cmbTipoContacto.Enabled = true;
                    txtEmail.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtAnexo.Enabled = true;
                    chbActivo.Enabled = true;
                    limpiarComponentes();
                    contactoCliente = new ClienteContacto();
                    break;
                case TipoVista.Anular:  //ya esta
                    btnNuevo.Enabled = (cmbCliente.SelectedIndex != -1) ? true : false;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = (cmbCliente.SelectedIndex != -1) ? true : false; ;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = (cmbCliente.SelectedIndex != -1) ? true : false;
                    cmbCliente.Enabled = true;
                    txtNombreContacto.Enabled = false;
                    txtCargo.Enabled = false;
                    cmbTipoContacto.Enabled = false;
                    txtEmail.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtAnexo.Enabled = false;
                    chbActivo.Enabled = false;
                    limpiarComponentes();
                    contactoCliente = new ClienteContacto();
                    break;
            }
        }
        public void limpiarComponentes()
        {
            txtNombreContacto.Text = "";
            txtCargo.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtAnexo.Text = "";
            cmbTipoContacto.SelectedIndex = -1;
            chbActivo.Checked = false;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            int i = cmbCliente.SelectedIndex;
            if (cmbCliente.SelectedIndex != -1)
            {
                estadoComponentes(TipoVista.Nuevo);
            }
            else estadoComponentes(TipoVista.Inicial);

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            vistaContactos.ClearColumnsFilter();

            int contactoID = -1;
            int h = 0;
            for (h = 0; h < vistaContactos.RowCount; h++)
                if (vistaContactos.IsRowSelected(h) == true)
                {
                    contactoID = int.Parse(vistaContactos.GetRowCellValue(h, "IdContacto").ToString());
                    break;
                }

            if (contactoID != -1)
            {
                estadoComponentes(TipoVista.Modificar);

                contactoCliente.IdContacto = int.Parse(vistaContactos.GetRowCellValue(h, "IdContacto").ToString());
                contactoCliente.Nombre = vistaContactos.GetRowCellValue(h, "NombreContacto").ToString();
                contactoCliente.Email = vistaContactos.GetRowCellValue(h, "Email").ToString();
                contactoCliente.Telefono = vistaContactos.GetRowCellValue(h, "Telefono").ToString();
                contactoCliente.Anexo = vistaContactos.GetRowCellValue(h, "Anexo").ToString();
                contactoCliente.Cargo = vistaContactos.GetRowCellValue(h, "Cargo").ToString();
                contactoCliente.Estado = int.Parse(vistaContactos.GetRowCellValue(h, "IdEstado").ToString());
                contactoCliente.NombreEstado = vistaContactos.GetRowCellValue(h, "Estado").ToString();
                contactoCliente.IdTipoContacto = int.Parse(vistaContactos.GetRowCellValue(h, "IdTipoContacto").ToString());
                contactoCliente.TipoContacto = vistaContactos.GetRowCellValue(h, "TipoContacto").ToString();

                cmbTipoContacto.SelectedValue = contactoCliente.IdTipoContacto;
                txtNombreContacto.Text = contactoCliente.Nombre;
                txtCargo.Text = contactoCliente.Cargo;
                txtEmail.Text = contactoCliente.Email;
                txtTelefono.Text = contactoCliente.Telefono;
                txtAnexo.Text = contactoCliente.Anexo;
                chbActivo.Checked = (contactoCliente.Estado == 1) ? true : false;
            }

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (validarCampos()) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                Cursor.Current = Cursors.Default;
                return;
            }

            llenar_Datos_Clientes();
            if (contactoCliente.IdContacto == 0)
            {
                if (MessageBox.Show("Estas seguro deseas Crear este Contacto", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    int idContacto = clienteDA.GuardarNuevoContacto(contactoCliente, this.nombreUsuario);

                    if (idContacto > 0)
                    {
                        MessageBox.Show("Se guardó exitosamente el Contacto. ","◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        dgvContactos.DataSource = null;
                        tablaContactoCliente = clienteDA.ListarContactoCliente(contactoCliente.IdCliente);
                        dgvContactos.DataSource = tablaContactoCliente;
                        estadoComponentes(TipoVista.Guardar);
                    }
                    else
                        MessageBox.Show("No se pudo guardar el Contacto", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                contactoCliente.Estado = (chbActivo.Checked) ? 1 : 0;

                if (MessageBox.Show("Estas seguro que desea Guardar los cambios", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    int idContacto = clienteDA.ModificarContacto(contactoCliente, this.nombreUsuario);

                    if (idContacto > 0)
                    {
                        MessageBox.Show("Se Modificó el contacto con éxito", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        dgvContactos.DataSource = null;
                        tablaContactoCliente = clienteDA.ListarContactoCliente(contactoCliente.IdCliente);
                        dgvContactos.DataSource = tablaContactoCliente;
                        estadoComponentes(TipoVista.Guardar);
                    }
                    else if (idContacto == 0)
                        MessageBox.Show("Ya existe un Contacto con las mismas características", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    else
                        MessageBox.Show("No se pudo guardar los cambios del Contacto del Cliente", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            Cursor.Current = Cursors.Default;
        }
        //VALIDACIONES CON EXPRESIONES REGULARES
        private bool validacionSoloNumeros(string numero) //PROBADO
        {
            return Regex.IsMatch(numero, "^[0-9]*$") ? true : false;
        }
        private bool validacionSoloLetras(string palabra) //PROBADO
        {
            return Regex.IsMatch(palabra, "^[a-zA-Z ]+$") ? true : false;

        }
        private bool validacionCorreoLeasein(string correo) //PROBADO
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            return Regex.IsMatch(correo, expresion) ? true : false;
        }
        public bool validarCampos()
        {
            bool isError = false;
            string aux = "";

            if (cmbCliente.SelectedIndex == -1)
            {
                isError = true;
                MessageBox.Show("No se puede crear un Contacto si el\ncliente seleccionado no es el correcto.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return isError;
            }

            aux = txtNombreContacto.Text;
            if (aux.Trim().Length == 0)
            {
                isError = true;
                MessageBox.Show("No se puede crear un Contacto si el\nnombre del contacto está vacio.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return isError;
            }

            aux = txtCargo.Text;
            if (aux.Trim().Length == 0)
            {
                isError = true;
                MessageBox.Show("No se puede crear un Contacto si el\ncargo del contacto está vacio.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return isError;
            }

            if (cmbTipoContacto.SelectedIndex == -1)
            {
                isError = true;
                MessageBox.Show("No se puede crear un Contacto si el\ntipo de contacto seleccionado no es el correcto.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return isError;
            }

            if (validacionCorreoLeasein(txtEmail.Text.Trim()) == false)
            {
                isError = true;
                MessageBox.Show("No se puede crear un Contacto si el\ncorreo no tiene un formato correcto.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return isError;
            }

            aux = txtTelefono.Text;
            if (aux.Trim().Length == 0)
            {
                isError = true;
                MessageBox.Show("No se puede crear un Contacto si el\nteléfono del contacto está vacio.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return isError;
            }

            if (validacionSoloNumeros(txtTelefono.Text.Trim()) == false)
            {
                isError = true;
                MessageBox.Show("No se puede crear un Contacto si el\nteléfono no tiene un formato correcto.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return isError;
            }

            aux = txtAnexo.Text;
            if (aux.Trim().Length == 0)
            {
                isError = true;
                MessageBox.Show("No se puede crear un Contacto si el\nanexo del contacto está vacio.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return isError;
            }

            //if (txtEmail.Text == "") isError = true;
            //if (txtTelefono.Text == "") isError = true;

            return isError;
        }
        private void llenar_Datos_Clientes()
        {
            string aux = "";
            contactoCliente.IdCliente = int.Parse(cmbCliente.SelectedValue.ToString());
            contactoCliente.IdTipoContacto = int.Parse(cmbTipoContacto.SelectedValue.ToString());
            aux= txtNombreContacto.Text;
            contactoCliente.Nombre = aux.Trim().ToUpper();
            aux = txtEmail.Text;
            contactoCliente.Email = aux.Trim().ToUpper();
            aux = txtTelefono.Text;
            contactoCliente.Telefono = aux.Trim().ToUpper();
            aux = txtAnexo.Text;
            contactoCliente.Anexo = aux.Trim().ToUpper();
            aux = txtCargo.Text;
            contactoCliente.Cargo = aux.Trim().ToUpper();

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoComponentes(TipoVista.Anular);
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Imprimir la lista de Sucursal del cliente", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                MessageBox.Show("Se imprimio la lista de Sucursales del cliente");
            }
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) //Para obligar a que sólo se introduzcan números
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                e.Handled = false;
            else //el resto de teclas pulsadas se desactivan
                e.Handled = true;
        }
        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmbCliente.SelectedIndex;
            if (cmbCliente.SelectedIndex != -1)
            {
                int idCliente = Convert.ToInt32(tablaCliente.Rows[i]["idCliente"].ToString());
                tablaContactoCliente = clienteDA.ListarContactoCliente(idCliente);
                dgvContactos.DataSource = tablaContactoCliente;
            }
            estadoComponentes(TipoVista.Inicial);
        }
        private void dgvContactos_Click(object sender, EventArgs e)
        {
            vistaContactos.ClearColumnsFilter();

            int contactoID = -1;
            int h = 0;
            for (h = 0; h < vistaContactos.RowCount; h++)
                if (vistaContactos.IsRowSelected(h) == true)
                {
                    contactoID = int.Parse(vistaContactos.GetRowCellValue(h, "IdContacto").ToString());
                    break;
                }

            if (contactoID != -1)
            {
                estadoComponentes(TipoVista.Vista);

                contactoCliente.IdContacto = int.Parse(vistaContactos.GetRowCellValue(h, "IdContacto").ToString());
                contactoCliente.Nombre = vistaContactos.GetRowCellValue(h, "NombreContacto").ToString();
                contactoCliente.Email = vistaContactos.GetRowCellValue(h, "Email").ToString();
                contactoCliente.Telefono = vistaContactos.GetRowCellValue(h, "Telefono").ToString();
                contactoCliente.Anexo = vistaContactos.GetRowCellValue(h, "Anexo").ToString();
                contactoCliente.Cargo = vistaContactos.GetRowCellValue(h, "Cargo").ToString();
                contactoCliente.Estado = int.Parse(vistaContactos.GetRowCellValue(h, "IdEstado").ToString());
                contactoCliente.NombreEstado = vistaContactos.GetRowCellValue(h, "Estado").ToString();
                contactoCliente.IdTipoContacto = int.Parse(vistaContactos.GetRowCellValue(h, "IdTipoContacto").ToString());
                contactoCliente.TipoContacto = vistaContactos.GetRowCellValue(h, "TipoContacto").ToString();

                cmbTipoContacto.SelectedValue = contactoCliente.IdTipoContacto;
                txtNombreContacto.Text = contactoCliente.Nombre;
                txtCargo.Text = contactoCliente.Cargo;
                txtEmail.Text = contactoCliente.Email;
                txtTelefono.Text = contactoCliente.Telefono;
                txtAnexo.Text = contactoCliente.Anexo;
                chbActivo.Checked = (contactoCliente.Estado == 1) ? true : false;
            }
        }

        int posY = 0;
        int posX = 0;
        private void pnlCS_MouseMove(object sender, MouseEventArgs e)
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
