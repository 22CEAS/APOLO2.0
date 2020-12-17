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

namespace Apolo
{
    public partial class frmProcesoAlquilerAgregarProducto : Form
    {
        public enum TipoVista { Inicial, Nuevo, Modificar, Guardar, Vista, Limpiar, Duplicar, Anular }
        DataTable tablaLaptops;
        LC laptop;
        BindingList<LC> laptops;
        AlquilerDA alquilerDA;
        private int idUsuario;
        private string nombreUsuario = "CEAS";


        public frmProcesoAlquilerAgregarProducto()
        {
            InitializeComponent();
            Inicializado();
        }

        public frmProcesoAlquilerAgregarProducto(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
        }

        public void Inicializado()
        {
            alquilerDA = new AlquilerDA();

            laptops = new BindingList<LC>();
            tablaLaptops = alquilerDA.ListarLaptopsAlmacenSinMemoriaDisco();

            tablaLaptops.Columns.Add("Seleccionar", typeof(bool));
            for (int h = 0; h < tablaLaptops.Rows.Count; h++)
            {
                tablaLaptops.Rows[h]["Seleccionar"] = false;
            }

            dgvEquipos.DataSource = tablaLaptops;
            vistaEquipos.OptionsBehavior.AutoPopulateColumns = false;
            vistaEquipos.OptionsSelection.MultiSelect = true;
        }

        public bool llenarListaLaptops()
        {
            vistaEquipos.ClearColumnsFilter();

            bool flag = false;

            for (int i = 0; i < vistaEquipos.RowCount; i++)
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
                    laptops.Add(laptop);
                    flag = true;
                }
            }
            return flag;
        }

        public BindingList<LC> LAPTOPS { get => laptops; set => laptops = value; }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (llenarListaLaptops())//Si entra es porque se ha seleccionado almenos solo
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnSubirSeries_Click(object sender, EventArgs e)
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
                    miDataTable.Columns.Add("CODIGO_LC");

                    path = openFileDialog.FileName;
                    SLDocument sl = new SLDocument(path);

                    int iRow = 2;
                    while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                    {
                        DataRow Renglon = miDataTable.NewRow();
                        Renglon["CODIGO_LC"] = sl.GetCellValueAsString(iRow, 1);
                        iRow++;
                        miDataTable.Rows.Add(Renglon);
                    }

                    int filasExcel = miDataTable.Rows.Count;
                    for (int i = 0; i < filasExcel; i++)
                    {
                        string codigo = miDataTable.Rows[i]["CODIGO_LC"].ToString();
                        vistaEquipos.ClearColumnsFilter();
                        int filasDgv = vistaEquipos.RowCount;
                        for (int j = 0; j < filasDgv; j++)
                        {
                            if (codigo == vistaEquipos.GetRowCellValue(j, "codigo").ToString())
                            {
                                vistaEquipos.SetRowCellValue(j, "Seleccionar", true);
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
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
