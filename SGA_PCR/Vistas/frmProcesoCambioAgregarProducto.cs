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
    public partial class frmProcesoCambioAgregarProducto : Form
    {
        public enum TipoVista { Inicial, Nuevo, Modificar, Guardar, Vista, Limpiar, Duplicar, Anular }
        DataTable tablaLaptops;
        LC laptop;
        AlquilerDA alquilerDA;
        private int idUsuario;
        private string nombreUsuario = "CEAS";

        public frmProcesoCambioAgregarProducto()
        {
            InitializeComponent();
            Inicializado();
        }

        public frmProcesoCambioAgregarProducto(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
        }

        public void Inicializado()
        {
            alquilerDA = new AlquilerDA();

            tablaLaptops = alquilerDA.ListarLaptopsAlmacenSinMemoriaDisco();

            tablaLaptops.Columns.Add("Seleccionar", typeof(bool));
            for (int h = 0; h < tablaLaptops.Rows.Count; h++)
            {
                tablaLaptops.Rows[h]["Seleccionar"] = false;
            }

            vistaEquipos.OptionsBehavior.AutoPopulateColumns = false;
            vistaEquipos.OptionsSelection.MultiSelect = true;
            dgvEquipos.DataSource = tablaLaptops;
        }

        public int llenarListaLaptops()
        {
            vistaEquipos.ClearColumnsFilter();

            int flag = 0;
            int filas = vistaEquipos.RowCount;
            for (int i = 0; i < filas; i++)
            {
                bool aux2 = bool.Parse(vistaEquipos.GetRowCellValue(i, "Seleccionar").ToString());
                if (aux2)
                {
                    laptop = new LC();
                    laptop.IdLC = int.Parse(vistaEquipos.GetRowCellValue(i, "idLC").ToString());
                    laptop.Codigo = vistaEquipos.GetRowCellValue(i, "codigo").ToString();
                    laptop.Modelo.NombreMarca = vistaEquipos.GetRowCellValue(i, "marcaLC").ToString();
                    laptop.Modelo.NombreModelo = vistaEquipos.GetRowCellValue(i, "nombreModeloLC").ToString();
                    laptop.TamanoPantalla = Double.Parse(vistaEquipos.GetRowCellValue(i, "tamanoPantalla").ToString());
                    laptop.Procesador.Modelo.NombreModelo = vistaEquipos.GetRowCellValue(i, "tipoProcesador").ToString();
                    laptop.Procesador.Generacion = int.Parse(vistaEquipos.GetRowCellValue(i, "generacionProcesador").ToString());
                    laptop.Video.IdVideo = int.Parse(vistaEquipos.GetRowCellValue(i, "idVideo").ToString());
                    laptop.Video.Modelo.NombreModelo = vistaEquipos.GetRowCellValue(i, "nombreModeloVideo").ToString();
                    laptop.Video.Capacidad = int.Parse(vistaEquipos.GetRowCellValue(i, "capacidadVideo").ToString());
                    laptop.Procesador.IdProcesador = int.Parse(vistaEquipos.GetRowCellValue(i, "idProcesador").ToString());
                    flag++;
                }
            }
            return flag;
        }

        public LC LAPTOP { get => laptop; set => laptop = value; }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int cant = llenarListaLaptops();
            if (cant == 1)//Si entra es porque se ha seleccionado almenos solo
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                if (cant == 0) MessageBox.Show("Tiene que seleccionar una laptop", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (cant > 0) MessageBox.Show("No puedes seleccionar más de una laptop", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
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
