using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpreadsheetLight;
using AccesoDatos;

namespace Apolo
{
    public partial class frmProcesoTarifa : Form
    {
        BindingList<Factura> facturas;
        FacturaDA facturaDA;
        TarifaDA tarifaDA;
        DataTable buscarV;
        private int idUsuario;
        private string nombreUsuario = "CEAS";
        public frmProcesoTarifa()
        {
            InitializeComponent();
            Inicializado();
        }


        public frmProcesoTarifa(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
        }


        public void Inicializado()
        {
            //dgvFacturas.PrimaryGrid.AutoGenerateColumns = false;
            facturas = new BindingList<Factura>();
            facturaDA = new FacturaDA();
            tarifaDA= new TarifaDA();
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
                    miDataTable.Columns.Add("Moneda");
                    miDataTable.Columns.Add("Costo");
                    miDataTable.Columns.Add("IdSalidaDet");
                    miDataTable.Columns.Add("IdSalida");
                    miDataTable.Columns.Add("GuiaSalida");
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
                        Renglon["Moneda"] = sl.GetCellValueAsString(iRow, 4);
                        Renglon["Costo"] = sl.GetCellValueAsString(iRow, 5);
                        Renglon["IdSalidaDet"] = "";
                        Renglon["IdSalida"] = "";
                        Renglon["GuiaSalida"] = "";
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

            if (filas <= 0)
            {
                MessageBox.Show("Primero debe ingresar data");
                return;
            }

            string RucCliente = "";
            string CodigoEquipo = "";
            double Tarifa = 0;
            string Moneda = "";
            double Costo = 0;
            int IdSalidaDet = 0;
            int IdSalida = 0;
            string GuiaSalida = "";

            for (int i = 0; i < filas; i++)
            {
                if ((vistaTarifas.GetRowCellValue(i, "Observacion").ToString()) == "")
                {
                    MessageBox.Show("Primero debe validar");
                    return;
                }

                if ((vistaTarifas.GetRowCellValue(i, "IdSalidaDet").ToString()) == "")
                {
                    continue;
                }
                if ((vistaTarifas.GetRowCellValue(i, "IdSalida").ToString()) == "")
                {
                    continue;
                }
                if ((vistaTarifas.GetRowCellValue(i, "GuiaSalida").ToString()) == "")
                {
                    continue;
                }
                if ((vistaTarifas.GetRowCellValue(i, "Moneda").ToString()) != "SOLES" && (vistaTarifas.GetRowCellValue(i, "Moneda").ToString()) != "DOLARES")
                {
                    vistaTarifas.SetRowCellValue(i, "Observacion", "Ingrese una Moneda Correcta");
                    continue;
                }

                RucCliente = (vistaTarifas.GetRowCellValue(i, "RucCliente").ToString());
                CodigoEquipo = (vistaTarifas.GetRowCellValue(i, "CodigoEquipo").ToString());
                Tarifa = double.Parse((vistaTarifas.GetRowCellValue(i, "Tarifa").ToString()));
                Moneda = (vistaTarifas.GetRowCellValue(i, "Moneda").ToString());
                Costo = double.Parse((vistaTarifas.GetRowCellValue(i, "Costo").ToString()));
                IdSalidaDet = int.Parse((vistaTarifas.GetRowCellValue(i, "IdSalidaDet").ToString()));
                IdSalida = int.Parse((vistaTarifas.GetRowCellValue(i, "IdSalida").ToString()));
                GuiaSalida = (vistaTarifas.GetRowCellValue(i, "GuiaSalida").ToString());

                


                //PROCEDURE PARA RELACIONAR KAMS DE FORMA MASIVA

                int resultado = tarifaDA.SubirTarifas(RucCliente, CodigoEquipo, Tarifa, IdSalidaDet, IdSalida, GuiaSalida,Moneda,this.nombreUsuario,Costo);


                //ERRORES
                if (resultado == -1)
                {
                    //vistaTarifas.SetRowCellValue(i, "Observacion", "HUBO UN ERROR");
                }
                else
                {
                    vistaTarifas.SetRowCellValue(i, "Observacion", "Se guardó correctamente");
                }
            }
            MessageBox.Show("SE COMPLETÓ LA OPERACION | REVISÉ LAS OBSERVACIONES");
            return;



        }

        private void btnBuscarV_Click(object sender, EventArgs e)
        {
            vistaTarifas.ClearColumnsFilter();
            if (vistaTarifas.RowCount == 0)
            {
                MessageBox.Show("SUBA DATA");
                return;
            }

            buscarV = facturaDA.BuscarV();
            vistaTarifas.ClearColumnsFilter();
            int filas = vistaTarifas.RowCount;

            for(int i=0;i<filas;i++)
            {
                String concatCodSis = (vistaTarifas.GetRowCellValue(i, "RucCliente").ToString()) + "-" + (vistaTarifas.GetRowCellValue(i, "CodigoEquipo").ToString());
                for (int x = 0; x < buscarV.Rows.Count; x++)
                {
                    string concatenado = buscarV.Rows[x]["concatenado"].ToString();

                    if (concatCodSis == concatenado)
                    {
                        vistaTarifas.SetRowCellValue(i, "GuiaSalida", buscarV.Rows[x]["guiaSalida"].ToString());
                        vistaTarifas.SetRowCellValue(i, "IdSalidaDet", buscarV.Rows[x]["idSalidaDet"].ToString());
                        vistaTarifas.SetRowCellValue(i, "IdSalida", buscarV.Rows[x]["idSalida"].ToString());
                        vistaTarifas.SetRowCellValue(i, "Observacion","Todo Ok");
                        break;
                    }
                    else
                    {
                        vistaTarifas.SetRowCellValue(i, "GuiaSalida", "");
                        vistaTarifas.SetRowCellValue(i, "IdSalidaDet", "");
                        vistaTarifas.SetRowCellValue(i, "IdSalida", "");
                        vistaTarifas.SetRowCellValue(i, "Observacion", "REGISTRO NO ENCONTRADO");
                    }
                }
            }

            
            MessageBox.Show("Se realizó la busquedad", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int posY = 0;
        int posX = 0;
        private void pnlTarifas_MouseMove(object sender, MouseEventArgs e)
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

        private void lblTarifas_MouseMove(object sender, MouseEventArgs e)
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
