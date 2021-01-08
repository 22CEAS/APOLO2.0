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
    public partial class frmProcesoIngresoTablet : Form
    {
        DataTable tablaMarca;
        DataTable tablaModelo;
        DataTable tablaDestino;
        DataTable tablaProcesador;
        DataTable tablaSO;
        DataTable tablaRAM;
        DataTable tablaROM;

        IngresoDetalleTablet detalle;

        IngresoDA ingresoDA;
        Tablet tablet;
        Boolean permitir = true;

        private int idUsuario;
        private string nombreUsuario = "CEAS";

        private int tabletIdCategoria = 3;
        private string tabletROM = "TABLET_ROM";
        private string tabletRAM = "TABLET_RAM";
        private string tabletSistema = "TABLET_SISTEMA";
        private string tabletProcesador = "TABLET_PROCESADOR";

        public frmProcesoIngresoTablet(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
        }

        public frmProcesoIngresoTablet(int idUsuario, string nombreUsuario,IngresoDetalleTablet detalleTraido)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
            ObtenerListaTablets(detalleTraido);
        }
        
        public void Inicializado()
        {
            ingresoDA = new IngresoDA();
            tablet = new Tablet();
            detalle = new IngresoDetalleTablet();

            txtCantidad.Text = "1";

            tablaMarca = ingresoDA.ListarTabletMarcas();
            cmbMarca.DataSource = tablaMarca;
            cmbMarca.DisplayMember = "nombre";
            cmbMarca.ValueMember = "idMarca";
            cmbMarca.SelectedIndex = -1;
            int i = cmbMarca.SelectedIndex;

            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                int idMarca = Convert.ToInt32(cmbMarca.SelectedValue.ToString());
                tablaModelo = ingresoDA.ListarTabletModelos(idMarca);
                cmbModelo.DataSource = tablaModelo;
                cmbModelo.DisplayMember = "nombre";
                cmbModelo.ValueMember = "idModelo";
                cmbModelo.SelectedIndex = -1;
            }

            tablaProcesador = ingresoDA.ListarTabletProcesadores();
            cmbProcesador.DataSource = tablaProcesador;
            cmbProcesador.DisplayMember = "descripcion";
            cmbProcesador.ValueMember = "idAuxiliar";
            cmbProcesador.SelectedIndex = -1;

            tablaSO = ingresoDA.ListarTabletSistemas();
            cmbSO.DataSource = tablaSO;
            cmbSO.DisplayMember = "descripcion";
            cmbSO.ValueMember = "idAuxiliar";
            cmbSO.SelectedIndex = -1;

            tablaRAM = ingresoDA.ListarTabletRAM();
            cmbRAM.DataSource = tablaRAM;
            cmbRAM.DisplayMember = "descripcion";
            cmbRAM.ValueMember = "idAuxiliar";
            cmbRAM.SelectedIndex = -1;

            tablaROM = ingresoDA.ListarTabletROM();
            cmbROM.DataSource = tablaROM;
            cmbROM.DisplayMember = "descripcion";
            cmbROM.ValueMember = "idAuxiliar";
            cmbROM.SelectedIndex = -1;
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

        private void txtPantalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = solonumeros1(Convert.ToInt32(e.KeyChar));
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = solonumeros2(Convert.ToInt32(e.KeyChar));
        }

        public bool solonumeros1(int code)
        {
            bool resultado;
            if (code == 46 && txtPantalla.Text.Contains("."))//se evalua si es punto y si es punto se rebiza si ya existe en el textbox
                resultado = true;
            else if ((((code >= 48) && (code <= 57)) || (code == 8) || code == 46)) //se evaluan las teclas validas
                resultado = false;
            else if (!permitir)
                resultado = permitir;
            else
                resultado = true;
            return resultado;
        }

        public bool solonumeros2(int code)
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
                if (llenarListaTablets())
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
                tablaModelo = ingresoDA.ListarTabletModelos(idMarca);
                cmbModelo.DataSource = (tablaModelo.Rows.Count > 0) ? tablaModelo : null;
                cmbModelo.DisplayMember = "nombre";
                cmbModelo.ValueMember = "idModelo";
                cmbModelo.SelectedIndex = (tablaModelo.Rows.Count > 0) ? -1 : -1;
            }

        }

        public void ObtenerListaTablets(IngresoDetalleTablet detalleTraido)
        {
            cmbMarca.SelectedValue = detalleTraido.TabletIdMarca;
            cmbModelo.SelectedValue = detalleTraido.TabletIdModelo;
            cmbProcesador.SelectedValue = detalleTraido.TabletIdProcesador;
            cmbSO.SelectedValue = detalleTraido.TabletIdSO;
            cmbRAM.SelectedValue = detalleTraido.TabletIdRAM;
            cmbROM.SelectedValue = detalleTraido.TabletIdROM;
            tablet = detalleTraido.Tablet;
            chbGarantia.Checked = (tablet.Garantia == 1) ? true : false;
            txtPantalla.Text = tablet.TamanoPantalla.ToString();
            txtPrecio.Text = detalleTraido.Precio.ToString();
            txtCantidad.Text = detalleTraido.Cantidad.ToString();

            foreach (String serie in detalleTraido.Series)
            {
                DataGridViewRow row = (DataGridViewRow)dgvSerieFabrica.Rows[0].Clone();
                row.Cells[1].Value = serie;
                dgvSerieFabrica.Rows.Add(row);
            }

        }

        public bool llenarListaTablets()
        {
            bool flag = false;
            tablet = new Tablet();


            int j = cmbMarca.SelectedIndex;
            tablet.Modelo.IdMarca = Convert.ToInt32(cmbMarca.SelectedValue.ToString());
            tablet.Modelo.NombreMarca = tablaMarca.Rows[j]["nombre"].ToString();

            j = cmbModelo.SelectedIndex;
            tablet.Modelo.IdModelo = Convert.ToInt32(cmbModelo.SelectedValue.ToString());
            tablet.Modelo.NombreModelo = tablaModelo.Rows[j]["nombre"].ToString();

            j = cmbProcesador.SelectedIndex;
            tablet.IdProcesador = Convert.ToInt32(cmbProcesador.SelectedValue.ToString());
            tablet.Procesador = tablaProcesador.Rows[j]["descripcion"].ToString();

            j = cmbSO.SelectedIndex;
            tablet.IdSO = Convert.ToInt32(cmbSO.SelectedValue.ToString());
            tablet.Sistema = tablaSO.Rows[j]["descripcion"].ToString();


            
            j = cmbRAM.SelectedIndex;
            tablet.IdRAM = Convert.ToInt32(cmbRAM.SelectedValue.ToString());
            tablet.Ram = Convert.ToInt32(tablaRAM.Rows[j]["descripcion"].ToString());

            j = cmbROM.SelectedIndex;
            tablet.IdROM = Convert.ToInt32(cmbROM.SelectedValue.ToString());
            tablet.Rom = Convert.ToInt32(tablaROM.Rows[j]["descripcion"].ToString());
            

        
            tablet.TamanoPantalla = Double.Parse(txtPantalla.Text);
            tablet.Garantia = (chbGarantia.Checked) ? 1 : 0;
            detalle.Tablet = tablet;
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
            if (cmbMarca.SelectedValue == null || cmbMarca.SelectedIndex==-1)
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
            if (cmbProcesador.SelectedValue == null || cmbProcesador.SelectedIndex == -1)
            {
                MessageBox.Show("No se puede grabar si no\nha seleccionado un procesador correcto.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return false;
            }

            //==============================================================================================
            if (cmbSO.SelectedValue == null || cmbSO.SelectedIndex == -1)
            {
                MessageBox.Show("No se puede grabar si no\nha seleccionado un sistema correcto.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return false;
            }

            //==============================================================================================
            if (cmbRAM.SelectedValue == null || cmbRAM.SelectedIndex == -1)
            {
                MessageBox.Show("No se puede grabar si no\nha seleccionado un RAM correcto.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return false;
            }

            //==============================================================================================
            if (cmbROM.SelectedValue == null || cmbROM.SelectedIndex == -1)
            {
                MessageBox.Show("No se puede grabar si no\nha seleccionado un ROM correcto.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return false;
            }

            //==============================================================================================
            string pantalla = txtPantalla.Text;
            pantalla = pantalla.Trim();
            if (!(pantalla.Length > 0))
            {
                MessageBox.Show("Ingrese un tamaño de pantalla válida", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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

        public IngresoDetalleTablet DETALLE { get => detalle; set => detalle = value; }

        private void btnAgregarTabletMarca_Click(object sender, EventArgs e)
        {
            frmArchivoMarca frmBP = new frmArchivoMarca(this.idUsuario, this.nombreUsuario, this.tabletIdCategoria);
            if (frmBP.ShowDialog() == DialogResult.OK)
            {
            }

            tablaMarca = ingresoDA.ListarTabletMarcas();
            cmbMarca.DataSource = tablaMarca;
            cmbMarca.DisplayMember = "nombre";
            cmbMarca.ValueMember = "idMarca";
            cmbMarca.SelectedIndex = -1;
            int i = cmbMarca.SelectedIndex;

            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                int idMarca = Convert.ToInt32(cmbMarca.SelectedValue.ToString());
                tablaModelo = ingresoDA.ListarTabletModelos(idMarca);
                cmbModelo.DataSource = tablaModelo;
                cmbModelo.DisplayMember = "nombre";
                cmbModelo.ValueMember = "idModelo";
                cmbModelo.SelectedIndex = -1;
            }
        }

        private void btnAgregarTabletModelo_Click(object sender, EventArgs e)
        {
            frmArchivoModelo frmBP = new frmArchivoModelo(this.idUsuario, this.nombreUsuario, this.tabletIdCategoria);
            if (frmBP.ShowDialog() == DialogResult.OK)
            {
            }

            tablaMarca = ingresoDA.ListarTabletMarcas();
            cmbMarca.DataSource = tablaMarca;
            cmbMarca.DisplayMember = "nombre";
            cmbMarca.ValueMember = "idMarca";
            cmbMarca.SelectedIndex = -1;
            int i = cmbMarca.SelectedIndex;

            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                int idMarca = Convert.ToInt32(cmbMarca.SelectedValue.ToString());
                tablaModelo = ingresoDA.ListarTabletModelos(idMarca);
                cmbModelo.DataSource = tablaModelo;
                cmbModelo.DisplayMember = "nombre";
                cmbModelo.ValueMember = "idModelo";
                cmbModelo.SelectedIndex = -1;
            }
        }

        private void btnAgregarTabletProcesador_Click(object sender, EventArgs e)
        {
            frmArchivoAuxiliar frmBP = new frmArchivoAuxiliar(this.idUsuario, this.nombreUsuario, this.tabletProcesador);
            if (frmBP.ShowDialog() == DialogResult.OK)
            {
            }
            tablaProcesador = ingresoDA.ListarTabletProcesadores();
            cmbProcesador.DataSource = tablaProcesador;
            cmbProcesador.DisplayMember = "descripcion";
            cmbProcesador.ValueMember = "idAuxiliar";
            cmbProcesador.SelectedIndex = -1;
        }

        private void btnAgregarTabletSO_Click(object sender, EventArgs e)
        {
            frmArchivoAuxiliar frmBP = new frmArchivoAuxiliar(this.idUsuario, this.nombreUsuario, this.tabletSistema);
            if (frmBP.ShowDialog() == DialogResult.OK)
            {
            }
            tablaSO = ingresoDA.ListarTabletSistemas();
            cmbSO.DataSource = tablaSO;
            cmbSO.DisplayMember = "descripcion";
            cmbSO.ValueMember = "idAuxiliar";
            cmbSO.SelectedIndex = -1;
        }

        private void btnAgregarTabletRAM_Click(object sender, EventArgs e)
        {
            frmArchivoAuxiliar frmBP = new frmArchivoAuxiliar(this.idUsuario, this.nombreUsuario, this.tabletRAM);
            if (frmBP.ShowDialog() == DialogResult.OK)
            {
            }
            tablaRAM = ingresoDA.ListarTabletRAM();
            cmbRAM.DataSource = tablaRAM;
            cmbRAM.DisplayMember = "descripcion";
            cmbRAM.ValueMember = "idAuxiliar";
            cmbRAM.SelectedIndex = -1;
        }

        private void btnAgregarTabletROM_Click(object sender, EventArgs e)
        {
            frmArchivoAuxiliar frmBP = new frmArchivoAuxiliar(this.idUsuario, this.nombreUsuario, this.tabletROM);
            if (frmBP.ShowDialog() == DialogResult.OK)
            {
            }

            tablaROM = ingresoDA.ListarTabletROM();
            cmbROM.DataSource = tablaROM;
            cmbROM.DisplayMember = "descripcion";
            cmbROM.ValueMember = "idAuxiliar";
            cmbROM.SelectedIndex = -1;
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
    }
}
