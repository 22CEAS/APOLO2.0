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
using Excel = Microsoft.Office.Interop.Excel;

namespace Apolo
{
    public partial class frmReporteAlquiler : Form
    {

        DataTable tablaAlquiler;
        ReporteDA reporteDA;
        private int idUsuario;
        private string nombreUsuario = "CEAS";


        public frmReporteAlquiler()
        {
            InitializeComponent();
            Inicializado();
        }

        public frmReporteAlquiler(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
        }

        public void Inicializado()
        {
            CargarData();
        }

        public void CargarData()
        {
            try
            {
                reporteDA = new ReporteDA();
                tablaAlquiler = reporteDA.ListarReporteAlquileres();

                dgvAlquiler.DataSource = tablaAlquiler;
                vistaAlquiler.OptionsBehavior.AutoPopulateColumns = false;
                vistaAlquiler.OptionsSelection.MultiSelect = true;
                dgvAlquiler.Refresh();
                
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message); OMITIMOS EL MENSAJE
            }
        }

        private void frmReporteAlquiler_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int posY = 0;
        int posX = 0;
        private void pnlAlquileres_MouseMove(object sender, MouseEventArgs e)
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
