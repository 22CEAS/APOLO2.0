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
    public partial class frmProcesoIngresoImpresora : Form
    {
        DataTable tablaMarca;
        DataTable tablaModelo;
        DataTable tablaDestino;
        DataTable tablaTipo;

        IngresoDetalleImpresora detalle;

        IngresoDA ingresoDA;
        Impresora impresora;
        Boolean permitir = true;

        private int idUsuario;
        private string nombreUsuario = "CEAS";

        private int impresoraIdCategoria = 5;
        private string impresoraTipo = "IMPRESORA_TIPO";

        public frmProcesoIngresoImpresora(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
        }

        public frmProcesoIngresoImpresora(int idUsuario, string nombreUsuario, IngresoDetalleImpresora detalleTraido)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
            ObtenerListaImpresoras(detalleTraido);
        }

        public void Inicializado()
        {
            ingresoDA = new IngresoDA();
            impresora = new Impresora();
            detalle = new IngresoDetalleImpresora();

            txtCantidad.Text = "1";

            tablaMarca = ingresoDA.ListarImpresoraMarcas();
            cmbMarca.DataSource = tablaMarca;
            cmbMarca.DisplayMember = "nombre";
            cmbMarca.ValueMember = "idMarca";
            cmbMarca.SelectedIndex = -1;
            int i = cmbMarca.SelectedIndex;

            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                int idMarca = Convert.ToInt32(cmbMarca.SelectedValue.ToString());
                tablaModelo = ingresoDA.ListarImpresoraModelos(idMarca);
                cmbModelo.DataSource = tablaModelo;
                cmbModelo.DisplayMember = "nombre";
                cmbModelo.ValueMember = "idModelo";
                cmbModelo.SelectedIndex = -1;
            }

            tablaTipo = ingresoDA.ListarImpresoraTipo();
            cmbTipo.DataSource = tablaTipo;
            cmbTipo.DisplayMember = "descripcion";
            cmbTipo.ValueMember = "idAuxiliar";
            cmbTipo.SelectedIndex = -1;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            string myStr = txtCantidad.Text;
            myStr = myStr.TrimStart('0');
            txtCantidad.Text = myStr.Length > 0 ? myStr : "1";
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = solonumeros(Convert.ToInt32(e.KeyChar));
        }
        
        public bool solonumeros(int code)
        {
            bool resultado;
            if (code == 46 && txtPrecio.Text.Contains("."))//se evalua si es punto y si es punto se rebiza si ya existe en el textbox
                resultado = true;
            else if ((((code >= 48) && (code <= 57)) || (code == 8) || code == 46)) //se evaluan las teclas validas
                resultado = false;
            else if (!permitir)
                resultado = permitir;
            else
                resultado = true;
            return resultado;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (llenarListaImpresoras())
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmbMarca.SelectedIndex;
            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                int idMarca = Convert.ToInt32(tablaMarca.Rows[i]["idMarca"].ToString());
                tablaModelo = ingresoDA.ListarImpresoraModelos(idMarca);
                cmbModelo.DataSource = (tablaModelo.Rows.Count > 0) ? tablaModelo : null;
                cmbModelo.DisplayMember = "nombre";
                cmbModelo.ValueMember = "idModelo";
                cmbModelo.SelectedIndex = (tablaModelo.Rows.Count > 0) ? -1 : -1;
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
                    miDataTable.Columns.Add("serie");

                    path = openFileDialog.FileName;
                    SLDocument sl = new SLDocument(path);

                    int iRow = 2;
                    while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                    {
                        DataRow Renglon = miDataTable.NewRow();
                        Renglon["serie"] = sl.GetCellValueAsString(iRow, 1);
                        iRow++;
                        miDataTable.Rows.Add(Renglon);
                    }

                    dgvSerieFabrica.DataSource = miDataTable;
                    dgvSerieFabrica.AutoGenerateColumns = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }


        }
        
        public void ObtenerListaImpresoras(IngresoDetalleImpresora detalleTraido)
        {
            cmbMarca.SelectedValue = detalleTraido.ImpresoraIdMarca;
            cmbModelo.SelectedValue = detalleTraido.ImpresoraIdModelo;
            cmbTipo.SelectedValue = detalleTraido.ImpresoraIdTipo;
            impresora = detalleTraido.Impresora;
            chbGarantia.Checked = (impresora.Garantia == 1) ? true : false;
            chbMultifuncional.Checked = (impresora.Multifuncional == 1) ? true : false;
            txtPartNumber.Text = impresora.PartNumber;
            txtPrecio.Text = detalleTraido.Precio.ToString();
            txtCantidad.Text = detalleTraido.Cantidad.ToString();

            foreach (String serie in detalleTraido.Series)
            {
                DataGridViewRow row = (DataGridViewRow)dgvSerieFabrica.Rows[0].Clone();
                row.Cells[1].Value = serie;
                dgvSerieFabrica.Rows.Add(row);
            }

        }

        public bool llenarListaImpresoras()
        {
            bool flag = false;
            impresora = new Impresora();


            int j = cmbMarca.SelectedIndex;
            impresora.Modelo.IdMarca = Convert.ToInt32(cmbMarca.SelectedValue.ToString());
            impresora.Modelo.NombreMarca = tablaMarca.Rows[j]["nombre"].ToString();

            j = cmbModelo.SelectedIndex;
            impresora.Modelo.IdModelo = Convert.ToInt32(cmbModelo.SelectedValue.ToString());
            impresora.Modelo.NombreModelo = tablaModelo.Rows[j]["nombre"].ToString();

            j = cmbTipo.SelectedIndex;
            impresora.IdTipo = Convert.ToInt32(cmbTipo.SelectedValue.ToString());
            impresora.Tipo = tablaTipo.Rows[j]["descripcion"].ToString();


            impresora.PartNumber = txtPartNumber.Text;
            impresora.Garantia = (chbGarantia.Checked) ? 1 : 0;
            impresora.Multifuncional = (chbMultifuncional.Checked) ? 1 : 0;
            detalle.Impresora = impresora;
            detalle.Precio = Double.Parse(txtPrecio.Text);
            detalle.Cantidad = Convert.ToInt32(txtCantidad.Text);
            detalle.Series = null;
            BindingList<String> series = new BindingList<String>();

            for (int i = 0; i < dgvSerieFabrica.Rows.Count; i++)
            {
                if (!dgvSerieFabrica.Rows[i].IsNewRow)
                {
                    if (dgvSerieFabrica.Rows[i].Cells[1].Value != null)
                    {
                        String serie = dgvSerieFabrica.Rows[i].Cells[1].Value.ToString();
                        series.Add(serie);
                    }
                }
            }
            detalle.Series = series;

            flag = true;

            return flag;
        }

        public bool validarDatos()
        {
            //==============================================================================================
            if (cmbMarca.SelectedValue == null || cmbMarca.SelectedIndex == -1)
            {
                MessageBox.Show("No se puede grabar si no\nha seleccionado una marca correcta.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return false;
            }

            //==============================================================================================
            if (cmbModelo.SelectedValue == null || cmbModelo.SelectedIndex == -1)
            {
                MessageBox.Show("No se puede grabar si no\nha seleccionado un modelo correcto.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return false;
            }

            //==============================================================================================
            if (cmbTipo.SelectedValue == null || cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("No se puede grabar si no\nha seleccionado un tipo correcto.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return false;
            }

            //==============================================================================================
            string precio = txtPrecio.Text;
            precio = precio.Trim();
            if (!(precio.Length > 0))
            {
                MessageBox.Show("Ingrese un precio válido", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }

            //==============================================================================================
            string cantidad = txtCantidad.Text;
            cantidad = cantidad.Trim();
            if (!(cantidad.Length > 0))
            {
                MessageBox.Show("Ingrese una cantidad válida", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }

            //==============================================================================================

            string partNumber = txtPartNumber.Text;
            partNumber = partNumber.Trim();
            if (!(partNumber.Length > 0))
            {
                MessageBox.Show("Ingrese un part number", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }

            //==============================================================================================

            for (int i = 0; i < dgvSerieFabrica.Rows.Count; i++)
            {
                if (dgvSerieFabrica.Rows[i].Cells[1].Value == null)
                {
                    if (!dgvSerieFabrica.Rows[i].IsNewRow)
                    {
                        dgvSerieFabrica.Rows.Remove(dgvSerieFabrica.Rows[i]);
                        i = -1;
                    }
                }
            }

            int aux = int.Parse(txtCantidad.Text);
            int filasDgv = dgvSerieFabrica.Rows.Count - 1;

            if (filasDgv < aux)
            {
                MessageBox.Show("Falta ingresar " + (aux - filasDgv) + " filas para las series de fábrica", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (filasDgv > aux)
            {
                MessageBox.Show("Hay " + (filasDgv - aux) + " filas de más para las series de fábrica", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            //==============================================================================================

            return true;
        }

        public IngresoDetalleImpresora DETALLE { get => detalle; set => detalle = value; }

        private void btnAgregarImpresoraMarca_Click(object sender, EventArgs e)
        {
            frmArchivoMarca frmBP = new frmArchivoMarca(this.idUsuario, this.nombreUsuario, this.impresoraIdCategoria);
            if (frmBP.ShowDialog() == DialogResult.OK)
            {
            }

            tablaMarca = ingresoDA.ListarImpresoraMarcas();
            cmbMarca.DataSource = tablaMarca;
            cmbMarca.DisplayMember = "nombre";
            cmbMarca.ValueMember = "idMarca";
            cmbMarca.SelectedIndex = -1;
            int i = cmbMarca.SelectedIndex;

            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                int idMarca = Convert.ToInt32(cmbMarca.SelectedValue.ToString());
                tablaModelo = ingresoDA.ListarImpresoraModelos(idMarca);
                cmbModelo.DataSource = tablaModelo;
                cmbModelo.DisplayMember = "nombre";
                cmbModelo.ValueMember = "idModelo";
                cmbModelo.SelectedIndex = -1;
            }
        }

        private void btnAgregarImpresoraModelo_Click(object sender, EventArgs e)
        {
            frmArchivoModelo frmBP = new frmArchivoModelo(this.idUsuario, this.nombreUsuario, this.impresoraIdCategoria);
            if (frmBP.ShowDialog() == DialogResult.OK)
            {
            }

            tablaMarca = ingresoDA.ListarImpresoraMarcas();
            cmbMarca.DataSource = tablaMarca;
            cmbMarca.DisplayMember = "nombre";
            cmbMarca.ValueMember = "idMarca";
            cmbMarca.SelectedIndex = -1;
            int i = cmbMarca.SelectedIndex;

            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                int idMarca = Convert.ToInt32(cmbMarca.SelectedValue.ToString());
                tablaModelo = ingresoDA.ListarImpresoraModelos(idMarca);
                cmbModelo.DataSource = tablaModelo;
                cmbModelo.DisplayMember = "nombre";
                cmbModelo.ValueMember = "idModelo";
                cmbModelo.SelectedIndex = -1;
            }

        }

        private void btnAgregarImpresoraTipo_Click(object sender, EventArgs e)
        {
            frmArchivoAuxiliar frmBP = new frmArchivoAuxiliar(this.idUsuario, this.nombreUsuario, this.impresoraTipo);
            if (frmBP.ShowDialog() == DialogResult.OK)
            {
            }
            tablaTipo = ingresoDA.ListarImpresoraTipo();
            cmbTipo.DataSource = tablaTipo;
            cmbTipo.DisplayMember = "descripcion";
            cmbTipo.ValueMember = "idAuxiliar";
            cmbTipo.SelectedIndex = -1;
        }
    }
}
