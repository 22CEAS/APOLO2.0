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
    public partial class frmCargaMasivaTarifas : Form
    {
        public frmCargaMasivaTarifas()
        {
            InitializeComponent();
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
                    miDataTable.Columns.Add("RucCliente");
                    miDataTable.Columns.Add("CodigoEquipo");
                    miDataTable.Columns.Add("Tarifa");
                    miDataTable.Columns.Add("Observacion");

                    path = openFileDialog.FileName;
                    SLDocument sl = new SLDocument(path);

                    int iRow = 2;
                    while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                    {
                        DataRow Renglon = miDataTable.NewRow();
                        Renglon["RucCliente"] = sl.GetCellValueAsString(iRow, 1);
                        Renglon["CodigoEquipo"] = sl.GetCellValueAsString(iRow, 2);
                        Renglon["Tarifa"] = sl.GetCellValueAsDouble(iRow, 3);
                        Renglon["Observacion"] = "";
                        iRow++;
                        miDataTable.Rows.Add(Renglon);
                    }

                    dgvTarifas.DataSource = miDataTable;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnSubirGuias_Click(object sender, EventArgs e)
        {
            vistaTarifas.ClearColumnsFilter();
            int filas = vistaTarifas.RowCount;

            string RucCliente = "";
            string CodigoEquipo = "";
            double Tarifa = 0.0;

            for (int i = 0; i < filas; i++)
            {
                RucCliente = (vistaTarifas.GetRowCellValue(i, "RucCliente").ToString());
                CodigoEquipo = (vistaTarifas.GetRowCellValue(i, "CodigoEquipo").ToString());
                Tarifa = double.Parse((vistaTarifas.GetRowCellValue(i, "Tarifa").ToString()));

                MessageBox.Show(RucCliente);
                MessageBox.Show(CodigoEquipo);
                MessageBox.Show(Tarifa.ToString());

                //PROCEDURE PARA RELACIONAR KAMS DE FORMA MASIVA
                int resultado = 1;
                //int resultado = clienteDA.RelacionKAMmasivo(RucCliente, razonSocialCliente, DniKam, NombreKam);


                //ERRORES
                if (resultado == -1)
                {
                    vistaTarifas.SetRowCellValue(i, "Observacion", "HUBO UN ERROR");
                }
                else if (resultado == 3)
                {
                    vistaTarifas.SetRowCellValue(i, "vistaTarifas", "EL CLIENTE NO EXISTE");
                }
                else if (resultado == 5)
                {
                    vistaTarifas.SetRowCellValue(i, "vistaTarifas", "LA LAPTOP NO EXISTE");
                }
                else
                {
                    vistaTarifas.SetRowCellValue(i, "vistaTarifas", "Todo ok");
                }
            }
            MessageBox.Show("SE COMPLETÓ LA OPERACION | REVISÉ LAS OBSERVACIONES");
            return;
        }
    }
}
