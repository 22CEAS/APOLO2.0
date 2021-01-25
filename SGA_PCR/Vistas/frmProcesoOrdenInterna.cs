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
    public partial class frmProcesoOrdenInterna : Form
    {
        DataTable tablaCliente;
        ClienteDA clienteDA;
        private int idUsuario;
        private string nombreUsuario = "CEAS";
        BindingList<Renovacion> ordenInterna;
        int idCliente = 0;

        public frmProcesoOrdenInterna()
        {
            InitializeComponent();
            Inicializado();
        }

        public frmProcesoOrdenInterna(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();

        }
        public void Inicializado()
        {

            clienteDA = new ClienteDA();


            tablaCliente = clienteDA.ListarClientes();
            cmbCliente.DataSource = tablaCliente;
            cmbCliente.DisplayMember = "nombre_razonSocial";
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.SelectedIndex = 0;
            int i = cmbCliente.SelectedIndex;

            idCliente = Convert.ToInt32(tablaCliente.Rows[i]["idCliente"].ToString());
            txtNroDocumento.Text = tablaCliente.Rows[i]["nroDocumento"].ToString();

        }

       

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue == null)
            {
                MessageBox.Show("No se puede agregar productos\n si no se ha seleccionado un cliente correcto.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return;
            }

            using (frmProcesoOIAgregarProducto frm = new frmProcesoOIAgregarProducto(idCliente))    
            {
                
                
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    
                    BindingList<Renovacion> auxiliares = new BindingList<Renovacion>();
                    foreach (Renovacion aux in ordenInterna)
                    {
                        auxiliares.Add(aux);
                    }

                    foreach (Renovacion detalleTraido in frm.DETALLES)
                    {  
                        Renovacion dp = new Renovacion();
                        dp.IdLC = detalleTraido.IdLC;
                        bool exists = auxiliares.Any(x => x.IdLC.Equals(dp.IdLC));
                        if (!(exists))
                        {
                            auxiliares.Add(detalleTraido);
                        }
                    }
                    ordenInterna = auxiliares;
                    
                }

            }

                
                dgvLaptopsSeleccionados.DataSource = ordenInterna;
                
            }


        private void frmProcesoOrdenInterna_Load(object sender, EventArgs e)
        {

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmbCliente.SelectedIndex;
            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                ordenInterna = new BindingList<Renovacion>();
                idCliente = Convert.ToInt32(tablaCliente.Rows[i]["idCliente"].ToString());
                txtNroDocumento.Text = tablaCliente.Rows[i]["nroDocumento"].ToString();

            }
            else
            {
                txtNroDocumento.Text = "";
            }
        }
    }
}
