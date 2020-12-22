using AccesoDatos;
using DevComponents.DotNetBar.SuperGrid;
using DevExpress.Export;
using DevExpress.Printing.ExportHelpers;
using DevExpress.XtraPrinting;
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
    public partial class frmProcesoRelacionarGuia : Form
    {
        DataTable tablaFactuas;
        ReporteDA reporteDA;
        private int idUsuario;
        private string nombreUsuario = "CEAS";

        public frmProcesoRelacionarGuia()
        {
            InitializeComponent();
            Inicializado();
        }

        public frmProcesoRelacionarGuia(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
        }


        public void Inicializado()
        {
            //
        }

        private void frmProcesoRelacionarGuia_Load(object sender, EventArgs e)
        {

            reporteDA = new ReporteDA();
            tablaFactuas = reporteDA.ListarFacturas();

            dgvFacturas.DataSource = tablaFactuas;
            vistaFacturas.OptionsBehavior.AutoPopulateColumns = false;
            vistaFacturas.OptionsSelection.MultiSelect = true;
            
        }


    }
}
