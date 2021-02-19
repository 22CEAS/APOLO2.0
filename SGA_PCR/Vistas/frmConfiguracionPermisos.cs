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

namespace Apolo
{
    public partial class frmConfiguracionPermisos : Form
    {

        DataTable tablaUsuario;
        DataTable tablaModulosPrincipales;
        DataTable tablaSubmodulos;
        DataTable tablaPermisosUsuario;

        Usuario usuario;
        UsuarioDA usuarioDA;

        ModulosPrincipales ModulosPrincipales;
        ModulosPrincipalesDA ModulosPrincipalesDA;

        Submodulo Submodulo;
        SubmoduloDA SubmoduloDA;

        Accesos_usuarios accesos_usuarios;
        AccesosUsuarioDA accesosusuariosda;

        public frmConfiguracionPermisos()
        {
            InitializeComponent();
            Inicializado();
        }

        public void Inicializado()
        {
            usuarioDA = new UsuarioDA();
            usuario = new Usuario();
            SubmoduloDA = new SubmoduloDA();
            Submodulo = new Submodulo();

            ModulosPrincipalesDA = new ModulosPrincipalesDA();
            ModulosPrincipales = new ModulosPrincipales();

            accesosusuariosda = new AccesosUsuarioDA();
            accesos_usuarios = new Accesos_usuarios();

            //COMBO BOX LISTADO DE USUARIOS
            tablaUsuario = usuarioDA.ListarUsuarios();
            cmbUsuarios.DataSource = tablaUsuario;
            cmbUsuarios.DisplayMember = "nombre";
            cmbUsuarios.ValueMember = "idUsuario";

            //COMBO BOX LISTADO DE MODULOS PRINCIALES
            
            tablaModulosPrincipales = ModulosPrincipalesDA.ListarModulosPrincipales();
            cmbModulosPrincipales.DataSource = tablaModulosPrincipales;
            cmbModulosPrincipales.DisplayMember = "descripcionModuloP";
            cmbModulosPrincipales.ValueMember = "idModuloP";

            vistaPermisos.OptionsBehavior.AutoPopulateColumns = false;
            vistaPermisos.OptionsSelection.MultiSelect = true;
            vistaSubModulo.OptionsBehavior.AutoPopulateColumns = false;
            vistaSubModulo.OptionsSelection.MultiSelect = true;

            actualizarTablas();
        }
        
        private void btnAgregarPermiso_Click(object sender, EventArgs e)
        {
            int fila;
            int resultado=0;
            vistaSubModulo.ClearColumnsFilter();
            for (fila = 0; fila < vistaSubModulo.RowCount; fila++)
                if (vistaSubModulo.IsRowSelected(fila) == true)
                {
                    string idSubmodulo = vistaSubModulo.GetRowCellValue(fila, "idSubmodulo").ToString();
                    int i = cmbUsuarios.SelectedIndex;
                    int idUsuario = Convert.ToInt32(tablaUsuario.Rows[i]["idUsuario"].ToString());
                    //int idUsuario = Convert.ToInt32(cmbUsuarios.SelectedValue);
                    resultado = accesosusuariosda.GuardarPermisoNuevo(idSubmodulo, idUsuario);
                    //break;
                }

            if (resultado == 0)
                MessageBox.Show("Ocurrió un error en el proceso", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Proceso realizado exitosamente", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK);

            actualizarTablas();

        }

        private void btnAgregarPermisos_Click(object sender, EventArgs e)
        {
            int filas = tablaSubmodulos.Rows.Count;
            int i = cmbUsuarios.SelectedIndex;
            int idUsuario = Convert.ToInt32(tablaUsuario.Rows[i]["idUsuario"].ToString());
            //int idUsuario = Convert.ToInt32(cmbUsuarios.SelectedValue);

            for (i = 0; i < filas; i++)
            {
                //string idSubmodulo = ((GridCell)(dgvSubmodulos.PrimaryGrid.GetCell(i, 0))).Value.ToString();
                string idSubmodulo = vistaSubModulo.GetRowCellValue(i, "idSubmodulo").ToString();
                int resultado = accesosusuariosda.GuardarPermisoNuevo(idSubmodulo, idUsuario);
            }

            MessageBox.Show("Proceso realizado exitosamente", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK);

            actualizarTablas();

        }

        private void btnQuitarPermiso_Click(object sender, EventArgs e)
        {
            int fila;
            vistaPermisos.ClearColumnsFilter();
            int resultado = 0;

            for (fila = 0; fila < vistaPermisos.RowCount; fila++)
                if (vistaPermisos.IsRowSelected(fila) == true)
                {
                    string idSubmodulo = vistaPermisos.GetRowCellValue(fila, "idSubmodulo").ToString();
                    int i = cmbUsuarios.SelectedIndex;
                    int idUsuario = Convert.ToInt32(tablaUsuario.Rows[i]["idUsuario"].ToString());
                    //int idUsuario = Convert.ToInt32(cmbUsuarios.SelectedValue);
                    resultado = accesosusuariosda.EliminarPermiso(idSubmodulo, idUsuario);
                    //break;
                }

            if (resultado == 0)
                MessageBox.Show("Ocurrió un error en el proceso", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Proceso realizado exitosamente", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK);

            actualizarTablas();
        }

        private void btnQuitarPermisos_Click(object sender, EventArgs e)
        {
            int filas = tablaPermisosUsuario.Rows.Count;
            int i = cmbUsuarios.SelectedIndex;
            int idUsuario = Convert.ToInt32(tablaUsuario.Rows[i]["idUsuario"].ToString());
            //idUsuario = Convert.ToInt32(cmbUsuarios.SelectedValue);

            for (i = 0; i < filas; i++)
            {
                //string idSubmodulo = ((GridCell)(dgvPermisosUsuario.PrimaryGrid.GetCell(i, 1))).Value.ToString();
                string idSubmodulo = vistaPermisos.GetRowCellValue(i, "idSubmodulo").ToString();
                int resultado = accesosusuariosda.EliminarPermiso(idSubmodulo, idUsuario);
            }

            MessageBox.Show("Proceso realizado exitosamente", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK);

            actualizarTablas();
        }

        private void actualizarTablas()
        {
            int idUsuario, idModuloP;

            int i = cmbUsuarios.SelectedIndex;
            int j = cmbModulosPrincipales.SelectedIndex;
            if (i!=-1 && j != -1)
            {
                idUsuario = Convert.ToInt32(tablaUsuario.Rows[i]["idUsuario"].ToString());
                idModuloP = Convert.ToInt32(tablaModulosPrincipales.Rows[j]["idModuloP"].ToString());

                tablaSubmodulos = SubmoduloDA.ListarSubmodulosPermisos(idModuloP, idUsuario);
                dgvSubModulo.DataSource = tablaSubmodulos;

                tablaPermisosUsuario = SubmoduloDA.ListarPermisosUsuario(idModuloP, idUsuario);
                dgvPermisos.DataSource = tablaPermisosUsuario;

            }

        }

        private void cmbModulosPrincipales_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idModuloP = cmbModulosPrincipales.SelectedIndex;
            if (idModuloP!=-1)
                actualizarTablas();
        }

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idUsuario = cmbUsuarios.SelectedIndex;
            if (idUsuario != -1)
                actualizarTablas();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int posY = 0;
        int posX = 0;

        private void pnlPermisos_MouseMove(object sender, MouseEventArgs e)
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
