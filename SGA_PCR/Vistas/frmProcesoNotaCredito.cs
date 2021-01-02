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
    public partial class frmProcesoNotaCredito : Form
    {
        public enum TipoVista { Inicial, Nuevo, Modificar, Guardar, Vista, Limpiar, Duplicar, Anular }
        DataTable tablaLaptopsIngreso;
        DataTable tablaLaptopsSalida;
        DataTable tablaEstadosIngreso;
        DataTable tablaEstadosSalida;

        LC artTemp;

        //Factura factura;
        BindingList<Factura> facturas;
        FacturaDA facturaDA;

        DataTable tablaFacturas;
        DataTable tablaEquipos;

        private int idUsuario;
        private string nombreUsuario = "CEAS";


        public frmProcesoNotaCredito()
        {
            InitializeComponent();
            Inicializado();
            estadoComponentes(TipoVista.Inicial);
        }
        
        public frmProcesoNotaCredito(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
            estadoComponentes(TipoVista.Inicial);
        }
        
        public void Inicializado()
        {
            facturaDA = new FacturaDA();
            facturas = new BindingList<Factura>();

            tablaFacturas = facturaDA.BuscarFacturasActivas();

            cmbFactura.DataSource = tablaLaptopsIngreso;
            cmbFactura.DisplayMember = "numFactura";
            cmbFactura.SelectedIndex = -1;

            vistaFacturas.OptionsBehavior.AutoPopulateColumns = false;
            vistaFacturas.OptionsSelection.MultiSelect = true;

        }
        
        public void estadoComponentes(TipoVista estado)
        {
            switch (estado)
            {
                case TipoVista.Inicial:
                    dgvFacturas.Enabled = false;
                    cmbFactura.Enabled = false;
                    txtReferencia.Enabled = false;
                    txtObservación.Enabled = false;
                    btnSeleccionarFilas.Enabled = false;
                    btnDeseleccionarFilas.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    limpiarComponentes();
                    facturas = new BindingList<Factura>();
                    break;
                case TipoVista.Nuevo:
                    dgvFacturas.Enabled = true;
                    cmbFactura.Enabled = true;
                    txtReferencia.Enabled = true;
                    txtObservación.Enabled = true;
                    btnSeleccionarFilas.Enabled = true;
                    btnDeseleccionarFilas.Enabled = true;
                    btnNuevo.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnGrabar.Enabled = true;
                    limpiarComponentes();
                    facturas = new BindingList<Factura>();
                    //ObtenerDatosRenovacion();
                    break;
                case TipoVista.Guardar:
                    dgvFacturas.Enabled = false;
                    cmbFactura.Enabled = false;
                    txtReferencia.Enabled = false;
                    txtObservación.Enabled = false;
                    btnSeleccionarFilas.Enabled = false;
                    btnDeseleccionarFilas.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    break;
                case TipoVista.Modificar:
                    dgvFacturas.Enabled = true;
                    cmbFactura.Enabled = true;
                    txtReferencia.Enabled = true;
                    txtObservación.Enabled = true;
                    btnSeleccionarFilas.Enabled = true;
                    btnDeseleccionarFilas.Enabled = true;
                    btnNuevo.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnGrabar.Enabled = true;
                    break;
                case TipoVista.Vista:
                    dgvFacturas.Enabled = false;
                    cmbFactura.Enabled = false;
                    txtReferencia.Enabled = false;
                    txtObservación.Enabled = false;
                    btnSeleccionarFilas.Enabled = false;
                    btnDeseleccionarFilas.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    facturas = new BindingList<Factura>();
                    break;
                case TipoVista.Limpiar:
                    dgvFacturas.Enabled = false;
                    cmbFactura.Enabled = false;
                    txtReferencia.Enabled = false;
                    txtObservación.Enabled = false;
                    btnSeleccionarFilas.Enabled = false;
                    btnDeseleccionarFilas.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    limpiarComponentes();
                    facturas = new BindingList<Factura>();
                    break;
                case TipoVista.Duplicar:
                    dgvFacturas.Enabled = false;
                    cmbFactura.Enabled = false;
                    txtReferencia.Enabled = false;
                    txtObservación.Enabled = false;
                    btnSeleccionarFilas.Enabled = false;
                    btnDeseleccionarFilas.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    limpiarComponentes();
                    facturas = new BindingList<Factura>();
                    break;
                case TipoVista.Anular:
                    dgvFacturas.Enabled = false;
                    cmbFactura.Enabled = false;
                    txtReferencia.Enabled = false;
                    txtObservación.Enabled = false;
                    btnSeleccionarFilas.Enabled = false;
                    btnDeseleccionarFilas.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            tablaFacturas.Rows.Clear();

            tablaFacturas = facturaDA.BuscarFacturasActivas();

            cmbFactura.DataSource = tablaFacturas;
            cmbFactura.DisplayMember = "numFactura";
            cmbFactura.SelectedIndex = -1;
            
            txtReferencia.Text = "";
            txtObservación.Text = "";
            facturas = new BindingList<Factura>();
        }

        public bool validarDatos()
        {
            if (cmbFactura.SelectedValue == null)
            {
                MessageBox.Show("No se puede realizar el proceso\n si no se ha seleccionado una factura correcta.", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            string aux = "";
            aux = txtReferencia.Text;
            aux = aux.Trim();
            if (aux.Length == 0)
            {
                MessageBox.Show("No se puede realizar el proceso\n si no se a escrito el documento de la Nota de Crédito.", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            aux = "";
            aux = txtObservación.Text;
            aux = aux.Trim();
            if (aux.Length == 0)
            {
                MessageBox.Show("No se puede realizar el proceso\n si no se a escrito una observación.", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }


            bool flag = true;
            vistaFacturas.ClearColumnsFilter();
            for (int i = 0; i < vistaFacturas.RowCount; i++)
            {
                bool aux2 = bool.Parse(vistaFacturas.GetRowCellValue(i, "Seleccionar").ToString());
                if (aux2)
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                MessageBox.Show("No se puede realizar el proceso\n si no se ha seleccionado al menos una laptop.", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void ObtenerDatos()
        {
            string aux = "";
            aux = txtReferencia.Text;
            aux = aux.Trim();
            aux = aux.ToUpper();
            string aux2 = "";
            aux2 = txtObservación.Text;
            aux2 = aux2.Trim();
            aux2 = aux2.ToUpper();
            facturas = new BindingList<Factura>();
            vistaFacturas.ClearColumnsFilter();
            for (int i = 0; i < vistaFacturas.RowCount; i++)
            {
                bool aux3 = bool.Parse(vistaFacturas.GetRowCellValue(i, "Seleccionar").ToString());
                if (aux3)
                {
                    Factura factura = new Factura();
                    factura.IdFactura = int.Parse(vistaFacturas.GetRowCellValue(i, "idFactura").ToString());
                    factura.IdSalida = int.Parse(vistaFacturas.GetRowCellValue(i, "idSalida").ToString());
                    factura.IdLC = int.Parse(vistaFacturas.GetRowCellValue(i, "idLC").ToString());
                    factura.GuiaSalida = vistaFacturas.GetRowCellValue(i, "guiaSalida").ToString();
                    factura.Codigo = vistaFacturas.GetRowCellValue(i, "codigoLC").ToString();
                    factura.RucDni = vistaFacturas.GetRowCellValue(i, "ruc").ToString();
                    factura.NumeroFactura = vistaFacturas.GetRowCellValue(i, "numFactura").ToString();
                    factura.FechaIniPago = DateTime.Parse(vistaFacturas.GetRowCellValue(i, "fecIniPago").ToString());
                    factura.FechaFinPago = DateTime.Parse(vistaFacturas.GetRowCellValue(i, "fecFinPago").ToString());
                    factura.TotalSoles = Double.Parse(vistaFacturas.GetRowCellValue(i, "totalSoles").ToString());
                    factura.TotalDolares = Double.Parse(vistaFacturas.GetRowCellValue(i, "totalDolares").ToString());
                    factura.CostoSoles = Double.Parse(vistaFacturas.GetRowCellValue(i, "costoSoles").ToString());
                    factura.CostoDolares = Double.Parse(vistaFacturas.GetRowCellValue(i, "costoDolares").ToString());

                    factura.FechaIniPagoAntiguo = DateTime.Parse(vistaFacturas.GetRowCellValue(i, "fecIniPagoAntiguo").ToString());
                    factura.FechaFinPagoAntiguo = DateTime.Parse(vistaFacturas.GetRowCellValue(i, "fecFinPagoAntiguo").ToString());
                    factura.TotalSolesAntiguo = Double.Parse(vistaFacturas.GetRowCellValue(i, "totalSolesAntiguo").ToString());
                    factura.TotalDolaresAntiguo = Double.Parse(vistaFacturas.GetRowCellValue(i, "totalDolaresAntiguo").ToString());
                    factura.CostoSolesAntiguo = Double.Parse(vistaFacturas.GetRowCellValue(i, "costoSolesAntiguo").ToString());
                    factura.CostoDolaresAntiguo = Double.Parse(vistaFacturas.GetRowCellValue(i, "costoDolaresAntiguo").ToString());

                    factura.NroNotaCredito = aux;
                    factura.ObservacionXLevantar = aux2;
                    facturas.Add(factura);
                }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (validarDatos())
            {
                ObtenerDatos();
                if (MessageBox.Show("Estas seguro que deseas Guardar este proceso", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    int error = 0;
                    error = facturaDA.RegistrarNC(facturas, this.nombreUsuario);

                    if (error == 0)
                    {
                        MessageBox.Show("Hubo error en el registro, comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }

                    MessageBox.Show("Se registró la nota de crédito", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    estadoComponentes(TipoVista.Guardar);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(TipoVista.Nuevo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas cancelar el proceso", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                estadoComponentes(TipoVista.Limpiar);
        }

        private void cmbFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aux = cmbFactura.SelectedIndex;
            if (aux != -1)
            {
                string numFactura = tablaFacturas.Rows[aux]["numFactura"].ToString();
                tablaEquipos = facturaDA.CargarEquiposFactura(numFactura);

                tablaEquipos.Columns.Add("Seleccionar", typeof(bool));
                for (int h = 0; h < tablaEquipos.Rows.Count; h++)
                    tablaEquipos.Rows[h]["Seleccionar"] = false;

                dgvFacturas.DataSource = tablaEquipos;
            }
            else
            {
                dgvFacturas.DataSource = null;
            }
        }

        private void btnSeleccionarFilas_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < vistaFacturas.RowCount; i++)
                vistaFacturas.SetRowCellValue(i, "Seleccionar", true);
        }

        private void btnDeseleccionarFilas_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < vistaFacturas.RowCount; i++)
                vistaFacturas.SetRowCellValue(i, "Seleccionar", false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int posY = 0;
        int posX = 0;
        private void pnlNC_MouseMove(object sender, MouseEventArgs e)
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
