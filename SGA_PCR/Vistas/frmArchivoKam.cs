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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apolo
{
    public partial class frmArchivoKam : Form
    {
        
        DataTable tablaKAM;
        ClienteDA clienteDA;
        Cliente relacion;
        BindingList<Cliente> relaciones;
        BindingList<Cliente> auxiliares;
        private int idUsuario;
        private string nombreUsuario = "CEAS";


        public frmArchivoKam()
        {
            InitializeComponent();
            Inicializado();

        }

        public frmArchivoKam(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
        }

        public void InicializarRelacionClienteKam()
        {
            clienteDA = new ClienteDA();
            relaciones = new BindingList<Cliente>();

            tablaKAM = clienteDA.ListarClientesKAM();
            auxiliares = new BindingList<Cliente>();
            int rec = 0;
            while (rec < tablaKAM.Rows.Count)
            {
                Cliente auxiliar = new Cliente();
                auxiliar.Nombre_razonSocial = tablaKAM.Rows[rec]["nombre_razonSocial"].ToString();
                auxiliar.KAM1 = tablaKAM.Rows[rec]["nombre"].ToString();
                auxiliares.Add(auxiliar);
                rec++;
            }

            dgvClienteKam.DataSource = auxiliares;
            vista.OptionsBehavior.AutoPopulateColumns = false;
            vista.OptionsSelection.MultiSelect = true;
        }

        public void Inicializado()
        {

            InicializarRelacionClienteKam();


            clienteDA = new ClienteDA();
            tablaKAM = clienteDA.ListarKams();
            cmbKAM.DataSource = tablaKAM;
            cmbKAM.DisplayMember = "nombre";
            cmbKAM.ValueMember = "idUsuario";

        }

        private void btnSeleccionarFilas_Click(object sender, EventArgs e)
        {
            int filas = vista.RowCount;
            for (int i = 0; i < filas; i++)
            {
                vista.SetRowCellValue(i, "Seleccionar", true);
            }
        }

        private void btnDeseleccionarFilas_Click(object sender, EventArgs e)
        {
            int filas = vista.RowCount;
            for (int i = 0; i < filas; i++)
            {
                vista.SetRowCellValue(i, "Seleccionar", false);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int filas = vista.RowCount;
            int cantidadSeleccionado = 0;
            int idKam = Convert.ToInt32(cmbKAM.SelectedValue);
            


            for (int i = 0; i < filas; i++)
            {
                bool aux = bool.Parse(vista.GetRowCellValue(i, "Seleccionar").ToString());

                if (aux)
                {
                    cantidadSeleccionado++;
                    string cliente = (vista.GetRowCellValue(i, "Nombre_razonSocial").ToString());
                    //! AQUI CORRER PROCEDURE PARA ACTUALIZAR RELACION DE CLIENTE-KAM
                    int resultado = clienteDA.RelacionKAM(cliente,idKam);
                }

            }
            InicializarRelacionClienteKam();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int posY = 0;
        int posX = 0;
        private void pnlK_MouseMove(object sender, MouseEventArgs e)
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

        private void frmArchivoKam_Load(object sender, EventArgs e)
        {

        }

        private void btnCambiarForma_Click(object sender, EventArgs e)
        {
            if (btnCambiarForma.Text == "MASIVO") //CAMBIAR A MASIVO
            {
                label1.Visible = false;
                cmbKAM.Visible = false;
                btnSeleccionarFilas.Visible = false;
                btnDeseleccionarFilas.Visible = false;
                dgvClienteKam.Visible = false;
                btnGrabar.Visible = false;
                btnCambiarForma.Text = "MANUAL";
                btnCargarData.Visible = true;
                btnRelacionKAMmas.Visible = true;
                dgvKAMmas.Visible = true;
            }
            else
            {
                label1.Visible = true;
                cmbKAM.Visible = true;
                btnSeleccionarFilas.Visible = true;
                btnDeseleccionarFilas.Visible = true;
                dgvClienteKam.Visible = true;
                btnGrabar.Visible = true;
                btnCambiarForma.Text = "MASIVO";
                btnCargarData.Visible = false;
                btnRelacionKAMmas.Visible = false;
                dgvKAMmas.Visible = false;

            }
        }

        private void btnCargarData_Click(object sender, EventArgs e)
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
                    miDataTable.Columns.Add("rucCliente");
                    miDataTable.Columns.Add("razonSocialCliente");
                    miDataTable.Columns.Add("dniKam");
                    miDataTable.Columns.Add("nombreKam");
                    miDataTable.Columns.Add("obs");

                    path = openFileDialog.FileName;
                    SLDocument sl = new SLDocument(path);

                    int iRow = 2;
                    while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                    {
                        DataRow Renglon = miDataTable.NewRow();
                        Renglon["rucCliente"] = sl.GetCellValueAsString(iRow, 1);
                        Renglon["razonSocialCliente"] = sl.GetCellValueAsString(iRow, 2);
                        Renglon["dniKam"] = sl.GetCellValueAsString(iRow, 3);
                        Renglon["nombreKam"] = sl.GetCellValueAsString(iRow, 4);
                        Renglon["obs"] = "";
                        iRow++;
                        miDataTable.Rows.Add(Renglon);
                    }

                    dgvKAMmas.DataSource = miDataTable;
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void btnRelacionKAMmas_Click(object sender, EventArgs e)
        {
            vistaKAMmas.ClearColumnsFilter();
            int filas = vistaKAMmas.RowCount;

            string RucCliente="";
            string razonSocialCliente = "";
            string DniKam = "";
            string NombreKam = "";

            for (int i = 0; i < filas; i++)
            {
                RucCliente = (vistaKAMmas.GetRowCellValue(i, "rucCliente").ToString());
                razonSocialCliente = (vistaKAMmas.GetRowCellValue(i, "razonSocialCliente").ToString());
                DniKam = (vistaKAMmas.GetRowCellValue(i, "dniKam").ToString());
                NombreKam = (vistaKAMmas.GetRowCellValue(i, "nombreKam").ToString());

                //PROCEDURE PARA RELACIONAR KAMS DE FORMA MASIVA
                int resultado = clienteDA.RelacionKAMmasivo(RucCliente, razonSocialCliente, DniKam, NombreKam);

                
                //ERRORES
                if (resultado == -1)
                {
                    vistaKAMmas.SetRowCellValue(i, "obs","HUBO UN ERROR");
                }
                else if (resultado == 3)
                {
                    vistaKAMmas.SetRowCellValue(i, "obs", "EL CLIENTE NO EXISTE");
                }
                else if (resultado == 5)
                {
                    vistaKAMmas.SetRowCellValue(i, "obs", "EL KAM NO EXISTE");
                }
                else 
                {
                    vistaKAMmas.SetRowCellValue(i, "obs", "Todo ok");
                }
            }
            MessageBox.Show("SE COMPLETÓ LA OPERACION | REVISÉ LAS OBSERVACIONES");
            return;

        

        }
    }
}
