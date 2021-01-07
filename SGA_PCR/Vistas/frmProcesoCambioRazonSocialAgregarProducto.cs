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
    public partial class frmProcesoCambioRazonSocialAgregarProducto : Form
    {
        DataTable tablaEquipos;
        CambioRazonSocial detalle;
        BindingList<CambioRazonSocial> detalles;
        CambioRazonSocialDA cambioRazonSocialDA;

        private int idUsuario;
        private string nombreUsuario = "CEAS";

        public frmProcesoCambioRazonSocialAgregarProducto(int idCliente)
        {
            InitializeComponent();
            Inicializado(idCliente);
        }

        public frmProcesoCambioRazonSocialAgregarProducto(int idUsuario, string nombreUsuario, int idCliente)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado(idCliente);
        }

        public void Inicializado(int idCliente)
        {
            cambioRazonSocialDA = new CambioRazonSocialDA();
            detalles = new BindingList<CambioRazonSocial>();

            tablaEquipos = cambioRazonSocialDA.ListarLaptopsClientesEstadoAlquilado(idCliente);
            tablaEquipos.Columns.Add("Seleccion", typeof(bool));
            for (int h = 0; h < tablaEquipos.Rows.Count; h++)
            {
                tablaEquipos.Rows[h]["Seleccion"] = false;
            }
            dgvEquipos.DataSource = tablaEquipos;
            vista.OptionsBehavior.AutoPopulateColumns = false;
            vista.OptionsSelection.MultiSelect = true;

        }

        public bool llenarListaEquipos()
        {
            bool flag = false;
            int filas = tablaEquipos.Rows.Count;
            vista.ClearColumnsFilter();
            for (int i = 0; i < filas; i++)
            {
                bool aux2 = bool.Parse(vista.GetRowCellValue(i, "Seleccion").ToString());
                if (aux2)
                {
                    detalle = new CambioRazonSocial();
                    detalle.IdSalida = int.Parse(vista.GetRowCellValue(i, "IdSalida").ToString());
                    detalle.IdSucursal = int.Parse(vista.GetRowCellValue(i, "IdSucursal").ToString());
                    detalle.IdSalidaDetalle = int.Parse(vista.GetRowCellValue(i, "IdSalidaDetalle").ToString());
                    detalle.GuiaSalida = vista.GetRowCellValue(i, "GuiaSalida").ToString();
                    detalle.IdEquipo = int.Parse(vista.GetRowCellValue(i, "IdEquipo").ToString());
                    detalle.Codigo = vista.GetRowCellValue(i, "CodigoEquipo").ToString();
                    detalle.Marca = vista.GetRowCellValue(i, "Marca").ToString();
                    detalle.Modelo = vista.GetRowCellValue(i, "Modelo").ToString();
                    detalles.Add(detalle);
                    flag = true;
                }
            }
            return flag;
        }
        public BindingList<CambioRazonSocial> DETALLES { get => detalles; set => detalles = value; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (llenarListaEquipos())//Si entra es porque se ha seleccionado almenos solo
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void btnSeleccionarFilas_Click(object sender, EventArgs e)
        {
            int filas = vista.RowCount;
            for (int i = 0; i < filas; i++)
            {
                vista.SetRowCellValue(i, "Seleccion", true);
            }
        }

        private void btnDeseleccionarFilas_Click(object sender, EventArgs e)
        {
            int filas = vista.RowCount;
            for (int i = 0; i < filas; i++)
            {
                vista.SetRowCellValue(i, "Seleccion", false);
            }
        }

    }
}
