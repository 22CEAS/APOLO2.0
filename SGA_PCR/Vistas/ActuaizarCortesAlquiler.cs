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
    public partial class ActuaizarCortesAlquiler : Form
    {
        CorteAlquiler corteAlquiler;
        BindingList<CorteAlquiler> cortes;
        CorteAlquilerDA caDA;


        public ActuaizarCortesAlquiler()
        {
            InitializeComponent();
            Inicializado();
        }


        public void Inicializado()
        {
            cortes = new BindingList<CorteAlquiler>();
            caDA = new CorteAlquilerDA();
        }

        private void btnEditar_Click(object sender, EventArgs e)
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
                    miDataTable.Columns.Add("IdSalidaDet");
                    miDataTable.Columns.Add("Codigo");
                    miDataTable.Columns.Add("Ruc");
                    miDataTable.Columns.Add("GuiaSalida");

                    path = openFileDialog.FileName;
                    SLDocument sl = new SLDocument(path);

                    int iRow = 2;
                    while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                    {
                        DataRow Renglon = miDataTable.NewRow();
                        Renglon["IdSalidaDet"] = sl.GetCellValueAsString(iRow, 1);
                        Renglon["Codigo"] = sl.GetCellValueAsString(iRow, 2);
                        Renglon["Ruc"] = sl.GetCellValueAsString(iRow, 3);
                        Renglon["GuiaSalida"] = sl.GetCellValueAsString(iRow, 4);
                        iRow++;
                        miDataTable.Rows.Add(Renglon);
                    }

                    dgvCA.DataSource = miDataTable;
                    dgvCA.AutoGenerateColumns = false;

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (dgvCA.RowCount == 0)
            {
                MessageBox.Show("No hay data en la tabla");
            }
            else
            {
                if (ObtenerInfo())
                {
                    if (MessageBox.Show("Estas seguro que deseas ACTUALIZAR la fechas de fin de contrato para estos registros?", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        int Actualizar = 0;                        
                        Actualizar = caDA.ActualizarFechaFinContrato(cortes);

                        if (Actualizar == 0)
                        { 
                            MessageBox.Show("Hubo error en Registrar la ACTUALIZACIÓN, comunicarse con tu soporte", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            return;
                        }
                        MessageBox.Show("Se guardó la ACTUALIZACIÓN", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        dgvCA.DataSource = null;

                     
                    }
                }
            }
        }

        private bool ObtenerInfo()
        {
            bool flag = false;

            int cantidadElmentos = dgvCA.RowCount;
            int fila = 0;

            foreach (DataGridViewRow row in dgvCA.Rows)
            {
                
                corteAlquiler = new CorteAlquiler();

                corteAlquiler.IdSalidaDetalle = int.Parse(dgvCA.Rows[fila].Cells["IdSalidaDet"].Value.ToString());
                corteAlquiler.CodigoLC = dgvCA.Rows[fila].Cells["Codigo"].Value.ToString();
                corteAlquiler.RucCliente1 = dgvCA.Rows[fila].Cells["Ruc"].Value.ToString();
                corteAlquiler.GuiaSalida = dgvCA.Rows[fila].Cells["GuiaSalida"].Value.ToString();

                /*
                MessageBox.Show(corteAlquiler.IdSalidaDetalle.ToString());
                MessageBox.Show(corteAlquiler.CodigoLC.ToString());
                MessageBox.Show(corteAlquiler.RucCliente1.ToString());
                MessageBox.Show(corteAlquiler.GuiaSalida.ToString());
                */

                cortes.Add(corteAlquiler);

                flag = true;
                fila++;
                if (fila == cantidadElmentos)
                {
                    break;        
                }
            }
            
            return flag;
        }
    }
}
