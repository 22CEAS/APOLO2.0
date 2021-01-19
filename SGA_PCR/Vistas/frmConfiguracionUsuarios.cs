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
        DataTable auxiliar;

        Area area;
        AreaDA areaDA;

        Perfil perfil;
        PerfilDA perfilDA;

        Estados estados;
        EstadosDA estadosDA;

        Usuario usuario;
        UsuarioDA usuarioDA;

        
        BindingList<Usuario> usu;



        public frmConfiguracionUsuarios()
        {
            InitializeComponent();
            estadoComponentes(TipoVista.Inicial);
            Inicializando();
        }


        public void Inicializando()
        {
            areaDA = new AreaDA();
            area = new Area();

            perfilDA = new PerfilDA();
            perfil = new Perfil();

            estadosDA = new EstadosDA();
            estados = new Estados();

            usuarioDA = new UsuarioDA();
            usuario = new Usuario();

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

            llenadoTablaUsuarios();
        }

        public void llenadoTablaUsuarios()
        {
          

            ///////////////////////////////////////////////////////////////////////////////////////////////

            auxiliar = usuarioDA.ListarUsuario();
            usu = new BindingList<Usuario>();
            int rec = 0;
            while (rec < auxiliar.Rows.Count)
            {
                Usuario usuario= new Usuario();
                usuario.IdUsuario = int.Parse(auxiliar.Rows[rec]["idUsuario"].ToString());
                usuario.Dni = auxiliar.Rows[rec]["dni"].ToString();
                usuario.Nombre = auxiliar.Rows[rec]["nombre"].ToString();
                usuario.User = auxiliar.Rows[rec]["usuario"].ToString();
                usuario.IdPerfil = int.Parse(auxiliar.Rows[rec]["perfil"].ToString());
                usuario.NombrePerfil1 = auxiliar.Rows[rec]["descripcionPerfil"].ToString();
                usuario.Email = auxiliar.Rows[rec]["email"].ToString();
                usuario.Estado = int.Parse(auxiliar.Rows[rec]["estado"].ToString());
                usuario.NombreEstado1 = auxiliar.Rows[rec]["descripcionEstado"].ToString();
                usuario.IdArea = int.Parse(auxiliar.Rows[rec]["idArea"].ToString());
                usuario.NombreArea1 = auxiliar.Rows[rec]["descripcionArea"].ToString();
                usu.Add(usuario);
                rec++;
            }

            dgvUsu.DataSource = usu;
            vistaUsu.OptionsBehavior.AutoPopulateColumns = false;
            vistaUsu.OptionsSelection.MultiSelect = true;

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

                    dgvUsu.Enabled = true;
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
                    dgvUsu.Enabled = false;
                    break;
                case TipoVista.Guardar: //ya esta listo
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = true;
                    dgvUsu.Enabled = false;
                    break;
                case TipoVista.Modificar://ya esta //Inicializado(idUsuario, nombreUsuario);
                    btnNuevo.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnGrabar.Enabled = true;
                    btnEditar.Enabled = false;
                    dgvUsu.Enabled = false;

                    txtDni.Enabled = false;
                    txtNombre.Enabled = true;
                    txtUsuario.Enabled = false;
                    txtClaveUsuario.Enabled = true;
                    txtEmail.Enabled = true;
                    cmbArea.Enabled = true;
                    cmbEstado.Enabled = true;
                    cmbPerfil.Enabled = true;
                    dgvUsu.Enabled = false;
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
                    dgvUsu.Enabled = true;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmConfiguracionUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(TipoVista.Nuevo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seguro?");
            estadoComponentes(TipoVista.Cancelar);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Trim().Length == 8 && validacionSoloNumeros(txtDni.Text.Trim()) == true) //VALIDACION DNI
            {
                if (txtNombre.Text.Trim().Length > 0 && validacionSoloLetras(txtNombre.Text.Trim()) == true)
                {
                    if (txtUsuario.Text.Trim().Length > 0)
                    {
                        if (txtClaveUsuario.Text.Trim().Length > 4)
                        {
                            if (txtEmail.Text.Trim().Length > 0 && validacionCorreoLeasein(txtEmail.Text.Trim()) == true)
                            {
                                //VALIDACION DE COMBOBOXS
                                if (cmbArea.SelectedIndex != -1)
                                {
                                    if (cmbPerfil.SelectedIndex != -1)
                                    {
                                        if (cmbEstado.SelectedIndex != -1)
                                        {
                                            //INSERTAR CON PROCEDURE -> RECUPERAMOS LOS ELEMENTOS

                                            string dni = txtDni.Text.Trim();
                                            string nombre = txtNombre.Text.Trim();
                                            string usuario = txtUsuario.Text.Trim();
                                            string claveUsuario = txtClaveUsuario.Text.Trim();
                                            string email = txtEmail.Text.Trim();
                                            int idArea = Convert.ToInt32(cmbArea.SelectedValue);
                                            int idPerfil = Convert.ToInt32(cmbPerfil.SelectedValue);
                                            int idEstado = Convert.ToInt32(cmbEstado.SelectedValue);


                                            int resultado = usuarioDA.InsertarNuevoUsuario(dni, nombre, usuario, claveUsuario, email, idArea, idPerfil, idEstado); //orUpdate
                                            if (resultado == 0)
                                            {
                                                MessageBox.Show("OCURRIO UN ERROR AL GUARDAR/MODIFICAR EL NUEVO USUARIO");
                                            }
                                            else
                                            {

                                                MessageBox.Show("NUEVO USUARIO GUARDADO/MODIFICADO CORRECTAMENTE");
                                                llenadoTablaUsuarios(); //ACTUALIZA LA TABLA
                                                limpiar_componentes();
                                                estadoComponentes(TipoVista.Inicial);

                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("DEBES SELECCIONAR UN ESTADO", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("DEBES SELECCIONAR UN PERFIL", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("DEBES SELECCIONAR UN AREA", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("REVISE EL CORREO", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("LA CONTRASEÑA DEBE TENER UNA LONGITUD MINIMA DE 5", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("REVISE EL USUARIO", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("REVISE EL NOMBRE", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("REVISE EL DNI", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

    

        private void dgvUsu_Click(object sender, EventArgs e)
        {

            int fila = vistaUsu.GetFocusedDataSourceRowIndex();

            txtDni.Text = vistaUsu.GetRowCellValue(fila, "Dni").ToString();
            txtNombre.Text = vistaUsu.GetRowCellValue(fila, "Nombre").ToString();
            txtUsuario.Text = vistaUsu.GetRowCellValue(fila, "User").ToString();
            txtClaveUsuario.Text = vistaUsu.GetRowCellValue(fila, "Dni").ToString();
            txtEmail.Text = vistaUsu.GetRowCellValue(fila, "Email").ToString();
            
            cmbArea.SelectedIndex = int.Parse(vistaUsu.GetRowCellValue(fila, "IdArea").ToString())-1;
            cmbEstado.SelectedIndex = int.Parse(vistaUsu.GetRowCellValue(fila, "Estado").ToString());
            cmbPerfil.SelectedIndex = int.Parse(vistaUsu.GetRowCellValue(fila, "IdPerfil").ToString())-1;
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estadoComponentes(TipoVista.Modificar);
        }
    }
}
