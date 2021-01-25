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
    public partial class frmProcesoOIAgregarProducto : Form
    {
        DataTable tablaLaptops;
        Renovacion detalle;
        BindingList<Renovacion> detalles;
        BindingList<Renovacion> auxiliares;
        RenovacionDA renovacionDA;
        private int idUsuario;
        private string nombreUsuario = "CEAS";

        public frmProcesoOIAgregarProducto(int idCliente)
        {
            InitializeComponent();
            Inicializado(idCliente);
        }

        public frmProcesoOIAgregarProducto(int idUsuario, string nombreUsuario, int idCliente)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado(idCliente);
        }

        public void Inicializado(int idCliente)
        {

            renovacionDA = new RenovacionDA();
            detalles = new BindingList<Renovacion>();

            tablaLaptops = renovacionDA.ListarLaptopsClientesEstadoAlquilado(idCliente);
            auxiliares = new BindingList<Renovacion>();
            int rec = 0;
            while (rec < tablaLaptops.Rows.Count)
            {
                Renovacion auxiliar = new Renovacion();
                auxiliar.IdSalida = Convert.ToInt32(tablaLaptops.Rows[rec]["IdSalida"].ToString());
                auxiliar.GuiaSalida = tablaLaptops.Rows[rec]["GuiaSalida"].ToString();
                auxiliar.IdLC = Convert.ToInt32(tablaLaptops.Rows[rec]["IdLC"].ToString());
                auxiliar.Codigo = tablaLaptops.Rows[rec]["Codigo"].ToString();
                auxiliar.CodigoAntiguo = tablaLaptops.Rows[rec]["CodigoAntiguo"].ToString();
                auxiliar.MarcaLC = tablaLaptops.Rows[rec]["MarcaLC"].ToString();
                auxiliar.NombreModeloLC = tablaLaptops.Rows[rec]["NombreModeloLC"].ToString();
                auxiliar.IdSalidaDetalle = Convert.ToInt32(tablaLaptops.Rows[rec]["IdSalidaDetalle"].ToString());
                auxiliar.IdSucursal = Convert.ToInt32(tablaLaptops.Rows[rec]["IdSucursal"].ToString());
                auxiliar.fecIniContrato = Convert.ToDateTime(tablaLaptops.Rows[rec]["fecIniContrato"].ToString());
                auxiliar.fecFinContrato = Convert.ToDateTime(tablaLaptops.Rows[rec]["fecFinContrato"].ToString());
                auxiliar.FechaIniContratoAntiguo = Convert.ToDateTime(tablaLaptops.Rows[rec]["fecIniContrato"].ToString());
                auxiliar.FechaFinContratoAntiguo = Convert.ToDateTime(tablaLaptops.Rows[rec]["fecFinContrato"].ToString());

                auxiliares.Add(auxiliar);
                rec++;
            }

            dgvRenovacionProductos.DataSource = auxiliares;
            vista.OptionsBehavior.AutoPopulateColumns = true;
            vista.OptionsSelection.MultiSelect = true;

        }



        private void frmProcesoOIAgregarProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (llenarListaLaptops())//Si entra es porque se ha seleccionado almenos solo
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        public bool llenarListaLaptops()
        {
            bool flag = false;
            int filas = tablaLaptops.Rows.Count;
            vista.ClearColumnsFilter();
            for (int i = 0; i < filas; i++)
            {
                bool aux2 = bool.Parse(vista.GetRowCellValue(i, "Seleccion").ToString());
                if (aux2)
                {
                    detalle = new Renovacion();
                    detalle.IdSalida = int.Parse(vista.GetRowCellValue(i, "IdSalida").ToString());
                    detalle.GuiaSalida = vista.GetRowCellValue(i, "GuiaSalida").ToString();
                    detalle.IdLC = int.Parse(vista.GetRowCellValue(i, "IdLC").ToString());
                    detalle.CodigoLC = vista.GetRowCellValue(i, "Codigo").ToString();
                    detalle.MarcaLC = vista.GetRowCellValue(i, "MarcaLC").ToString();
                    detalle.ModeloLC = vista.GetRowCellValue(i, "NombreModeloLC").ToString();
                    detalle.IdSalidaDetalle = int.Parse(vista.GetRowCellValue(i, "IdSalidaDetalle").ToString());
                    detalle.IdSucursal = int.Parse(vista.GetRowCellValue(i, "IdSucursal").ToString());
                    detalle.FechaIniContrato = DateTime.Parse(vista.GetRowCellValue(i, "fecIniContrato").ToString());
                    detalle.FechaFinContrato = DateTime.Parse(vista.GetRowCellValue(i, "fecFinContrato").ToString());
                    detalle.FechaIniContratoAntiguo = DateTime.Parse(vista.GetRowCellValue(i, "FechaIniContratoAntiguo").ToString());
                    detalle.FechaFinContratoAntiguo = DateTime.Parse(vista.GetRowCellValue(i, "FechaFinContratoAntiguo").ToString());
                    detalles.Add(detalle);
                    flag = true;
                }
            }
            return flag;
        }

    }

}
