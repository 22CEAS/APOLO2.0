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
    public partial class frmProcesoDevolucionAgregarProducto : Form
    {
        public enum TipoVista { Inicial, Nuevo, Modificar, Guardar, Vista, Limpiar, Duplicar, Anular }
        DataTable tablaLaptops;
        DevolucionDetalle detalle;
        BindingList<DevolucionDetalle> detalles;
        DevolucionDA devolucionDA;
        private int idUsuario;
        private string nombreUsuario = "CEAS";


        public frmProcesoDevolucionAgregarProducto(int idCliente)
        {
            InitializeComponent();
            Inicializado(idCliente);
            //estadoComponentes(TipoVista.Inicial);
        }

        public frmProcesoDevolucionAgregarProducto(int idUsuario, string nombreUsuario, int idCliente)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado(idCliente);
            //estadoComponentes(TipoVista.Inicial);
        }

        public void Inicializado(int idCliente)
        {

            devolucionDA = new DevolucionDA();
            //laptop = new LC();
            detalles = new BindingList<DevolucionDetalle>();
            tablaLaptops = devolucionDA.ListarLaptopsClientesEstadoAlquilado(idCliente);

            tablaLaptops.Columns.Add("Seleccionar", typeof(bool));
            tablaLaptops.Columns.Add("Observacion", typeof(string));
            tablaLaptops.Columns.Add("PagaraCliente", typeof(int));
            tablaLaptops.Columns.Add("EquipoDanado", typeof(int));
            for (int h = 0; h < tablaLaptops.Rows.Count; h++)
            {
                tablaLaptops.Rows[h]["Seleccionar"] = false;
                tablaLaptops.Rows[h]["Observacion"] = "";
                tablaLaptops.Rows[h]["PagaraCliente"] = 0;
                tablaLaptops.Rows[h]["EquipoDanado"] = 0;
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
                    detalle = new DevolucionDetalle();
                    detalle.IdLC = int.Parse(vistaEquipos.GetRowCellValue(i, "IdLC").ToString());
                    detalle.CodigoLC = vistaEquipos.GetRowCellValue(i, "Codigo").ToString();
                    detalle.MarcaLC = vistaEquipos.GetRowCellValue(i, "MarcaLC").ToString();
                    detalle.ModeloLC = vistaEquipos.GetRowCellValue(i, "NombreModeloLC").ToString();

                    detalle.IdSalidaDetalle = int.Parse(vistaEquipos.GetRowCellValue(i, "IdSalidaDetalle").ToString());
                    detalle.IdSucursal = int.Parse(vistaEquipos.GetRowCellValue(i, "IdSucursal").ToString());



                    detalle.Observacion = vistaEquipos.GetRowCellValue(i, "Observacion").ToString();
                    detalle.Cobrar = int.Parse(vistaEquipos.GetRowCellValue(i, "PagaraCliente").ToString());
                    int aux= int.Parse(vistaEquipos.GetRowCellValue(i, "EquipoDanado").ToString());
                    detalle.Danado = aux;
                    detalle.EstadoLC = (aux == 1) ? 3 : 2;



                    detalles.Add(detalle);
                    flag = true;
                }
            }
            return flag;
        }

        public BindingList<DevolucionDetalle> DETALLES { get => detalles; set => detalles = value; }

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
                    miDataTable.Columns.Add("codigoEquipo");
                    miDataTable.Columns.Add("observacion");
                    miDataTable.Columns.Add("pagaraCliente");
                    miDataTable.Columns.Add("equipoDanado");

                    path = openFileDialog.FileName;
                    SLDocument sl = new SLDocument(path);

                    int iRow = 2;
                    while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                    {
                        DataRow Renglon = miDataTable.NewRow();
                        Renglon["codigoEquipo"] = sl.GetCellValueAsString(iRow, 1);
                        Renglon["observacion"] = sl.GetCellValueAsString(iRow, 2);
                        Renglon["pagaraCliente"] = sl.GetCellValueAsInt32(iRow, 3);
                        Renglon["equipoDanado"] = sl.GetCellValueAsInt32(iRow, 4);
                        iRow++;
                        miDataTable.Rows.Add(Renglon);
                    }

                    int filasExcel = miDataTable.Rows.Count;
                    for (int i = 0; i < filasExcel; i++)
                    {
                        string codigo = miDataTable.Rows[i]["codigoEquipo"].ToString();
                        vistaEquipos.ClearColumnsFilter();
                        int filasDgv = vistaEquipos.RowCount;
                        for (int j = 0; j < filasDgv; j++)
                        {
                            if (codigo == vistaEquipos.GetRowCellValue(j, "Codigo").ToString())
                            {
                                string observacion = miDataTable.Rows[i]["observacion"].ToString();
                                int pagaraCliente = int.Parse(miDataTable.Rows[i]["pagaraCliente"].ToString());
                                int equipoDanado = int.Parse(miDataTable.Rows[i]["equipoDanado"].ToString());
                                vistaEquipos.SetRowCellValue(j, "Seleccionar", true);
                                vistaEquipos.SetRowCellValue(j, "Observacion", observacion);
                                vistaEquipos.SetRowCellValue(j, "PagaraCliente", pagaraCliente);
                                vistaEquipos.SetRowCellValue(j, "EquipoDanado", equipoDanado);
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

    }
}
