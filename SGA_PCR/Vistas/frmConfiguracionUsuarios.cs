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
    public partial class frmConfiguracionUsuarios : Form
    {

        public enum TipoVista { Inicial, Nuevo, Modificar, Guardar, Vista, Limpiar, Duplicar, Anular, Cancelar }

        DataTable tablaAreas;
        DataTable tablaPerfiles;
        DataTable tablaEstados;
        DataTable tablaUsuarios;

        AreaDA areaDA;
        PerfilDA perfilDA;
        EstadosDA estadosDA;
        UsuarioDA usuarioDA;

        public frmConfiguracionUsuarios()
        {
            InitializeComponent();
            estadoComponentes(TipoVista.Inicial);
            Inicializando();
        }

        public void Inicializando()
        {
            areaDA = new AreaDA();
            perfilDA = new PerfilDA();
            estadosDA = new EstadosDA();
            usuarioDA = new UsuarioDA();

            //! AREA
            tablaAreas = areaDA.ListarAreas();
            cmbArea.DataSource = tablaAreas;
            cmbArea.DisplayMember = "descripcionArea";
            cmbArea.ValueMember = "idArea";

            //! PERFIL
            tablaPerfiles = perfilDA.ListarPerfiles();
            cmbPerfil.DataSource = tablaPerfiles;
            cmbPerfil.DisplayMember = "descripcion";
            cmbPerfil.ValueMember = "idPerfil";


            //! ESTADO
            tablaEstados = estadosDA.ListarEstados();
            cmbEstado.DataSource = tablaEstados;
            cmbEstado.DisplayMember = "nombreEstado";
            cmbEstado.ValueMember = "idEstado";


            cmbArea.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            cmbPerfil.SelectedIndex = -1;

            tablaUsuarios = usuarioDA.ListUsers();
            dgvUsuario.DataSource = tablaUsuarios;
            vistaUsuario.OptionsBehavior.AutoPopulateColumns = false;
            vistaUsuario.OptionsSelection.MultiSelect = true;
        }

        public void estadoComponentes(TipoVista estado)
        {
            switch (estado)
            {
                case TipoVista.Inicial: //ya esta

                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = true;

                    txtDni.Enabled = false;
                    txtNombre.Enabled = false;
                    txtUsuario.Enabled = false;
                    txtClaveUsuario.Enabled = false;
                    txtEmail.Enabled = false;
                    cmbArea.Enabled = false;
                    cmbEstado.Enabled = false;
                    cmbPerfil.Enabled = false;

                    dgvUsuario.Enabled = true;
                    limpiar_componentes();
                    break;
                case TipoVista.Nuevo: //ya esta
                    //Inicializado(idUsuario, nombreUsuario);
                    limpiar_componentes();
                    btnNuevo.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnGrabar.Enabled = true;
                    btnEditar.Enabled = false;

                    txtDni.Enabled = true;
                    txtNombre.Enabled = true;
                    txtUsuario.Enabled = true;
                    txtClaveUsuario.Enabled = true;
                    txtEmail.Enabled = true;
                    cmbArea.Enabled = true;
                    cmbEstado.Enabled = true;
                    cmbPerfil.Enabled = true;
                    dgvUsuario.Enabled = false;
                    break;
                case TipoVista.Guardar: //ya esta listo
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = true;
                    dgvUsuario.Enabled = false;
                    break;
                case TipoVista.Modificar://ya esta //Inicializado(idUsuario, nombreUsuario);
                    btnNuevo.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnGrabar.Enabled = true;
                    btnEditar.Enabled = false;
                    dgvUsuario.Enabled = false;

                    txtDni.Enabled = false;
                    txtNombre.Enabled = true;
                    txtUsuario.Enabled = false;
                    txtClaveUsuario.Enabled = true;
                    txtEmail.Enabled = true;
                    cmbArea.Enabled = true;
                    cmbEstado.Enabled = true;
                    cmbPerfil.Enabled = true;
                    dgvUsuario.Enabled = false;
                    break;
                case TipoVista.Cancelar://ya esta //Inicializado(idUsuario, nombreUsuario);
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = true;

                    txtDni.Enabled = false;
                    txtNombre.Enabled = false;
                    txtUsuario.Enabled = false;
                    txtClaveUsuario.Enabled = false;
                    txtEmail.Enabled = false;
                    cmbArea.Enabled = false;
                    cmbEstado.Enabled = false;
                    cmbPerfil.Enabled = false;
                    dgvUsuario.Enabled = true;
                    limpiar_componentes();
                    break;
                case TipoVista.Limpiar: //ya esta
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = false;
                    break;

            }
        }

        private void limpiar_componentes()
        {
            txtDni.Text = "";
            txtNombre.Text = "";
            txtUsuario.Text = "";
            txtClaveUsuario.Text = "";
            txtEmail.Text = "";
            cmbArea.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            cmbPerfil.SelectedIndex = -1;
        }
                
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(TipoVista.Nuevo);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estadoComponentes(TipoVista.Modificar);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estás seguro de cancelar el proceso","◄ AVISO | LEASEIN ►");
            estadoComponentes(TipoVista.Cancelar);
        }

        public bool validarCampos()
        {
            bool isError = false;
            
            if (txtEmail.Text.Trim().Length == 0 || validacionCorreoLeasein(txtEmail.Text.Trim()) == false)
            {
                isError = true;
                MessageBox.Show("REVISE EL CORREO", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtClaveUsuario.Text.Trim().Length <= 4)
            {
                isError = true;
                MessageBox.Show("LA CONTRASEÑA DEBE TENER UNA LONGITUD MINIMA DE 5", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtUsuario.Text.Trim().Length == 0)
            {
                isError = true;
                MessageBox.Show("REVISE EL USUARIO", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtNombre.Text.Trim().Length == 0 || validacionSoloLetras(txtNombre.Text.Trim()) == false)
            {
                isError = true;
                MessageBox.Show("REVISE EL NOMBRE", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtDni.Text.Trim().Length != 8 || validacionSoloNumeros(txtDni.Text.Trim()) == false) //VALIDACION DNI
            {
                isError = true;
                MessageBox.Show("REVISE EL DNI", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //VALIDACION DE COMBOBOXS
            else if (cmbArea.SelectedIndex == -1)
            {
                isError = true;
                MessageBox.Show("DEBES SELECCIONAR UN AREA", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (cmbPerfil.SelectedIndex == -1)
            {
                isError = true;
                MessageBox.Show("DEBES SELECCIONAR UN PERFIL", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (cmbEstado.SelectedIndex == -1)
            {
                isError = true;
                MessageBox.Show("DEBES SELECCIONAR UN ESTADO", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return isError;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Cursor.Current = Cursors.Default;
                return;
            }

            string dni = txtDni.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string usuario = txtUsuario.Text.Trim();
            string claveUsuario = txtClaveUsuario.Text.Trim();
            string email = txtEmail.Text.Trim();
            int idArea = Convert.ToInt32(cmbArea.SelectedValue);
            int idPerfil = Convert.ToInt32(cmbPerfil.SelectedValue);
            int idEstado = Convert.ToInt32(cmbEstado.SelectedValue);

            if (MessageBox.Show("Estas seguro que deseas guardar este proceso", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                int resultado = usuarioDA.InsertarNuevoUsuario(dni, nombre, usuario, claveUsuario, email, idArea, idPerfil, idEstado); //orUpdate
                if (resultado == 0)
                {
                    MessageBox.Show("Ocurrió un error al guardar el proceso", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Se realizó el proceso con éxito", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tablaUsuarios = usuarioDA.ListUsers();
                    dgvUsuario.DataSource = tablaUsuarios;
                    estadoComponentes(TipoVista.Inicial);
                }
            }
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int posY = 0;
        int posX = 0;

        private void pnlConfguracionUsuario_MouseMove(object sender, MouseEventArgs e)
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

        private void dgvUsuario_Click(object sender, EventArgs e)
        {
            int fila;// = vistaUsuario.GetFocusedDataSourceRowIndex();
            vistaUsuario.ClearColumnsFilter();
            for (fila = 0; fila < vistaUsuario.RowCount; fila++)
                if (vistaUsuario.IsRowSelected(fila) == true)
                {
                    txtDni.Text = vistaUsuario.GetRowCellValue(fila, "Dni").ToString();
                    txtNombre.Text = vistaUsuario.GetRowCellValue(fila, "Nombre").ToString();
                    txtUsuario.Text = vistaUsuario.GetRowCellValue(fila, "User").ToString();
                    txtClaveUsuario.Text = vistaUsuario.GetRowCellValue(fila, "ClaveUsuario").ToString();
                    txtEmail.Text = vistaUsuario.GetRowCellValue(fila, "Email").ToString();

                    cmbArea.SelectedValue = int.Parse(vistaUsuario.GetRowCellValue(fila, "IdArea").ToString());
                    cmbEstado.SelectedValue = int.Parse(vistaUsuario.GetRowCellValue(fila, "Estado").ToString());
                    cmbPerfil.SelectedValue = int.Parse(vistaUsuario.GetRowCellValue(fila, "IdPerfil").ToString());
                    break;
                }
        }

    }
}
