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
    public partial class frmProcesoIngresoProyector : Form
    {
        DataTable tablaMarca;
        DataTable tablaModelo;
        DataTable tablaTipo;
        DataTable tablaCaracteristica;
        DataTable tablaResolucion;
        DataTable tablaLuminen;

        IngresoDetalleProyector detalle;

        IngresoDA ingresoDA;
        Proyector proyector;
        Boolean permitir = true;

        private int idUsuario;
        private string nombreUsuario = "CEAS";

        private int proyectorIdCategoria = 6;
        private int ecramIdCategoria = 7;
        private string proyectorTipo = "PROYECTOR_TIPO";
        private string ecramTipo = "ECRAM_TIPO";
        private string proyectorResolucion = "PROYECTOR_RESOLUCION";
        private string proyectorLuminen = "PROYECTOR_LUMINEN";

        public frmProcesoIngresoProyector(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
        }

        public frmProcesoIngresoProyector(int idUsuario, string nombreUsuario,IngresoDetalleProyector detalleTraido)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
            ObtenerListaProyectores(detalleTraido);
        }

        public void Inicializado()
        {
            ingresoDA = new IngresoDA();
            proyector = new Proyector();
            detalle = new IngresoDetalleProyector();

            txtCantidad.Text = "1";

            tablaTipo = ingresoDA.ListarProyectorEcramTipo();
            cmbTipo.DataSource = tablaTipo;
            cmbTipo.DisplayMember = "descripcion";
            cmbTipo.ValueMember = "idAuxiliar";
            cmbTipo.SelectedIndex = -1;

            txtPantalla.Enabled = false;
            btnAgregarProyectorResolucion.Enabled = false;
            btnAgregarProyectorLuminen.Enabled = false;
            cmbResolucion.Enabled = false;
            cmbLuminen.Enabled = false;
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

        private void txtPantalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = solonumeros2(Convert.ToInt32(e.KeyChar));
        }

        public bool solonumeros2(int code)
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (llenarListaProyectores())
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
            int j = cmbTipo.SelectedIndex;
            int idCategoria = Convert.ToInt32(tablaTipo.Rows[j]["idAuxiliar"].ToString());

            int i = cmbMarca.SelectedIndex;
            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                int idMarca = Convert.ToInt32(tablaMarca.Rows[i]["idMarca"].ToString());
                tablaModelo = (idCategoria == 6) ? ingresoDA.ListarProyectorModelos(idMarca) : ingresoDA.ListarEcramModelos(idMarca);
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

        public void ObtenerListaProyectores(IngresoDetalleProyector detalleTraido)
        {
            cmbTipo.SelectedValue = detalleTraido.ProyectorIdTipoEquipoProyector;
            cmbMarca.SelectedValue = detalleTraido.ProyectorIdMarca;
            cmbModelo.SelectedValue = detalleTraido.ProyectorIdModelo;
            cmbCaracteristica.SelectedValue = detalleTraido.ProyectorIdCaracteristica;
            proyector = detalleTraido.Proyector;
            //txtPartNumber.Text = proyector.PartNumber;
            chbGarantia.Checked = (proyector.Garantia == 1) ? true : false;
            txtPantalla.Text = (detalleTraido.ProyectorIdTipoEquipoProyector==6)?"":proyector.TamanoProyector.ToString();
            txtPrecio.Text = detalleTraido.Precio.ToString();
            txtCantidad.Text = detalleTraido.Cantidad.ToString();

            if (detalleTraido.ProyectorIdTipoEquipoProyector == 6)
            {
                cmbResolucion.SelectedValue = detalleTraido.ProyectorIdResolucion;
                cmbLuminen.SelectedValue = detalleTraido.ProyectorIdLuminen;
            }


            foreach (String serie in detalleTraido.Series)
            {
                DataGridViewRow row = (DataGridViewRow)dgvSerieFabrica.Rows[0].Clone();
                row.Cells[1].Value = serie;
                dgvSerieFabrica.Rows.Add(row);
            }

        }

        public bool llenarListaProyectores()
        {
            bool flag = false;
            proyector = new Proyector();


            int j = cmbMarca.SelectedIndex;
            proyector.Modelo.IdMarca = Convert.ToInt32(cmbMarca.SelectedValue.ToString());
            proyector.Modelo.NombreMarca = tablaMarca.Rows[j]["nombre"].ToString();

            j = cmbModelo.SelectedIndex;
            proyector.Modelo.IdModelo = Convert.ToInt32(cmbModelo.SelectedValue.ToString());
            proyector.Modelo.NombreModelo = tablaModelo.Rows[j]["nombre"].ToString();

            j = cmbTipo.SelectedIndex;
            proyector.IdTipoEquipoProyector = Convert.ToInt32(cmbTipo.SelectedValue.ToString());
            proyector.NombreTipoEquipoProyector = tablaTipo.Rows[j]["descripcion"].ToString();

            j = cmbCaracteristica.SelectedIndex;
            proyector.IdCaracteristica = Convert.ToInt32(cmbCaracteristica.SelectedValue.ToString());
            proyector.Caracteristica = tablaCaracteristica.Rows[j]["descripcion"].ToString();


            //proyector.PartNumber = txtPartNumber.Text;
            proyector.Garantia = (chbGarantia.Checked) ? 1 : 0;


            int h = cmbTipo.SelectedIndex;
            if (h >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                int idCategoria = Convert.ToInt32(tablaTipo.Rows[h]["idAuxiliar"].ToString());
                proyector.TamanoProyector = (idCategoria == 7) ? Double.Parse(txtPantalla.Text) : 0;
                if (idCategoria == 6)
                {
                    j = cmbLuminen.SelectedIndex;
                    proyector.IdLuminen = Convert.ToInt32(cmbLuminen.SelectedValue.ToString());
                    
                    j = cmbResolucion.SelectedIndex;
                    proyector.IdResolucion = Convert.ToInt32(cmbResolucion.SelectedValue.ToString());
                }
                
            }

            detalle.Proyector = proyector;
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
            if (cmbCaracteristica.SelectedValue == null || cmbCaracteristica.SelectedIndex == -1)
            {
                MessageBox.Show("No se puede grabar si no\nha seleccionado una caracteristica correcto.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
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

            int h = cmbTipo.SelectedIndex;
            if (h >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                int idCategoria = Convert.ToInt32(tablaTipo.Rows[h]["idAuxiliar"].ToString());
                if (idCategoria == 7)
                {
                    string pantalla = txtPantalla.Text;
                    pantalla = pantalla.Trim();
                    if (!(pantalla.Length > 0))
                    {
                        MessageBox.Show("Ingrese un tamaño válido", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return false;
                    }
                }
                if (idCategoria == 6)
                {
                    if (cmbLuminen.SelectedValue == null || cmbLuminen.SelectedIndex == -1)
                    {
                        MessageBox.Show("No se puede grabar si no\nha seleccionado un Luminen correcto.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                        return false;
                    }
                    if (cmbResolucion.SelectedValue == null || cmbResolucion.SelectedIndex == -1)
                    {
                        MessageBox.Show("No se puede grabar si no\nha seleccionado una Resolución correcta.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                        return false;
                    }
                }
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

        public IngresoDetalleProyector DETALLE { get => detalle; set => detalle = value; }

        private void btnAgregarProyectorMarca_Click(object sender, EventArgs e)
        {
            int h = cmbTipo.SelectedIndex;
            if (h >= 0)
            {
                int idCategoria = Convert.ToInt32(tablaTipo.Rows[h]["idAuxiliar"].ToString());
                //tablaMarca = (idCategoria == 6) ? ingresoDA.ListarProyectorMarcas() : ingresoDA.ListarEcramMarcas();

                frmArchivoMarca frmBP = new frmArchivoMarca(this.idUsuario, this.nombreUsuario, idCategoria);
                if (frmBP.ShowDialog() == DialogResult.OK)
                {
                }

                tablaMarca = (idCategoria == 6) ? ingresoDA.ListarProyectorMarcas() : ingresoDA.ListarEcramMarcas();
                cmbMarca.DataSource = tablaMarca;
                cmbMarca.DisplayMember = "nombre";
                cmbMarca.ValueMember = "idMarca";
                cmbMarca.SelectedIndex = -1;
                //int i = cmbMarca.SelectedIndex;

                //if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
                //{
                //    int idMarca = Convert.ToInt32(cmbMarca.SelectedValue.ToString());
                //    tablaModelo = ingresoDA.ListarProyectorModelos(idMarca);
                //    cmbModelo.DataSource = tablaModelo;
                //    cmbModelo.DisplayMember = "nombre";
                //    cmbModelo.ValueMember = "idModelo";
                //    cmbModelo.SelectedIndex = -1;
                //}
            }

        }

        private void btnAgregarProyectorModelo_Click(object sender, EventArgs e)
        {

            int h = cmbTipo.SelectedIndex;
            if (h >= 0)
            {
                int idCategoria = Convert.ToInt32(tablaTipo.Rows[h]["idAuxiliar"].ToString());
                //tablaMarca = (idCategoria == 6) ? ingresoDA.ListarProyectorMarcas() : ingresoDA.ListarEcramMarcas();


                frmArchivoModelo frmBP = new frmArchivoModelo(this.idUsuario, this.nombreUsuario, idCategoria);
                if (frmBP.ShowDialog() == DialogResult.OK)
                {
                }

                tablaMarca = (idCategoria == 6) ? ingresoDA.ListarProyectorMarcas() : ingresoDA.ListarEcramMarcas();
                cmbMarca.DataSource = tablaMarca;
                cmbMarca.DisplayMember = "nombre";
                cmbMarca.ValueMember = "idMarca";
                cmbMarca.SelectedIndex = -1;
                //int i = cmbMarca.SelectedIndex;

                //if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
                //{
                //    int idMarca = Convert.ToInt32(cmbMarca.SelectedValue.ToString());
                //    tablaModelo = ingresoDA.ListarProyectorModelos(idMarca);
                //    cmbModelo.DataSource = tablaModelo;
                //    cmbModelo.DisplayMember = "nombre";
                //    cmbModelo.ValueMember = "idModelo";
                //    cmbModelo.SelectedIndex = -1;
                //}
            }

            
        }

        private void btnAgregarProyectorCaracteristica_Click(object sender, EventArgs e)
        {
            int h = cmbTipo.SelectedIndex;
            if (h >= 0)
            {
                int idCategoria = Convert.ToInt32(tablaTipo.Rows[h]["idAuxiliar"].ToString());
                string caracteristica = (idCategoria == 6) ? this.proyectorTipo : this.ecramTipo;

                frmArchivoAuxiliar frmBP = new frmArchivoAuxiliar(this.idUsuario, this.nombreUsuario, caracteristica);
                if (frmBP.ShowDialog() == DialogResult.OK)
                {
                }
                tablaCaracteristica = (idCategoria == 6) ? ingresoDA.ListarProyectorTipo() : ingresoDA.ListarEcramTipo();
                cmbCaracteristica.DataSource = (tablaCaracteristica.Rows.Count > 0) ? tablaCaracteristica : null;
                cmbCaracteristica.DisplayMember = "descripcion";
                cmbCaracteristica.ValueMember = "idAuxiliar";
                cmbCaracteristica.SelectedIndex = -1;

            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmbTipo.SelectedIndex;
            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                int idCategoria = Convert.ToInt32(tablaTipo.Rows[i]["idAuxiliar"].ToString());
                tablaMarca = (idCategoria == 6) ? ingresoDA.ListarProyectorMarcas() : ingresoDA.ListarEcramMarcas();
                cmbMarca.DataSource = (tablaMarca.Rows.Count > 0) ? tablaMarca : null;
                cmbMarca.DisplayMember = "nombre";
                cmbMarca.ValueMember = "idMarca";
                cmbMarca.SelectedIndex = (tablaMarca.Rows.Count > 0) ? -1 : -1;

                if (idCategoria == 6)
                {
                    tablaResolucion = (idCategoria == 6) ? ingresoDA.ListarProyectorResolucion() : null;
                    cmbResolucion.DataSource = (tablaResolucion.Rows.Count > 0) ? tablaResolucion : null;
                    cmbResolucion.DisplayMember = "descripcion";
                    cmbResolucion.ValueMember = "idAuxiliar";
                    cmbResolucion.SelectedIndex = (tablaResolucion.Rows.Count > 0) ? -1 : -1;
                    cmbResolucion.Enabled = (idCategoria == 6) ? true : false;

                    tablaLuminen = (idCategoria == 6) ? ingresoDA.ListarProyectorLuminen() : null;
                    cmbLuminen.DataSource = (tablaLuminen.Rows.Count > 0) ? tablaLuminen : null;
                    cmbLuminen.DisplayMember = "descripcion";
                    cmbLuminen.ValueMember = "idAuxiliar";
                    cmbLuminen.SelectedIndex = (tablaLuminen.Rows.Count > 0) ? -1 : -1;
                    cmbLuminen.Enabled = (idCategoria == 6) ? true : false;

                    btnAgregarProyectorResolucion.Enabled = true;
                    btnAgregarProyectorLuminen.Enabled = true;
                    cmbResolucion.Enabled = true;
                    cmbLuminen.Enabled = true;
                }
                else
                {
                    tablaResolucion = null;
                    cmbResolucion.DataSource = null;
                    tablaLuminen = null;
                    cmbLuminen.DataSource = null;

                    btnAgregarProyectorResolucion.Enabled = false;
                    btnAgregarProyectorLuminen.Enabled = false;
                    cmbResolucion.Enabled = false;
                    cmbLuminen.Enabled = false;
                }



                tablaCaracteristica = (idCategoria == 6) ? ingresoDA.ListarProyectorTipo() : ingresoDA.ListarEcramTipo();
                cmbCaracteristica.DataSource = (tablaCaracteristica.Rows.Count > 0) ? tablaCaracteristica : null;
                cmbCaracteristica.DisplayMember = "descripcion";
                cmbCaracteristica.ValueMember = "idAuxiliar";
                cmbCaracteristica.SelectedIndex = (tablaCaracteristica.Rows.Count > 0) ? -1 : -1;


                txtPantalla.Enabled = (idCategoria == 6) ? false : true;

            }
            else if (i == -1)
            {
                cmbMarca.DataSource =  null;
                cmbModelo.DataSource = null;
                cmbCaracteristica.DataSource = null;
                cmbResolucion.DataSource = null;
                cmbLuminen.DataSource = null;
                txtPantalla.Enabled = false;
            }
        }

        private void btnAgregarProyectorResolucion_Click(object sender, EventArgs e)
        {
            int h = cmbTipo.SelectedIndex;
            if (h >= 0)
            {

                frmArchivoAuxiliar frmBP = new frmArchivoAuxiliar(this.idUsuario, this.nombreUsuario, this.proyectorResolucion);
                if (frmBP.ShowDialog() == DialogResult.OK)
                {
                }
                tablaResolucion = ingresoDA.ListarProyectorResolucion();
                cmbResolucion.DataSource = (tablaResolucion.Rows.Count > 0) ? tablaResolucion : null;
                cmbResolucion.DisplayMember = "descripcion";
                cmbResolucion.ValueMember = "idAuxiliar";
                cmbResolucion.SelectedIndex = -1;

            }
        }

        private void btnAgregarProyectorLuminen_Click(object sender, EventArgs e)
        {
            int h = cmbTipo.SelectedIndex;
            if (h >= 0)
            {

                frmArchivoAuxiliar frmBP = new frmArchivoAuxiliar(this.idUsuario, this.nombreUsuario, this.proyectorLuminen);
                if (frmBP.ShowDialog() == DialogResult.OK)
                {
                }
                tablaLuminen = ingresoDA.ListarProyectorLuminen();
                cmbLuminen.DataSource = (tablaLuminen.Rows.Count > 0) ? tablaLuminen : null;
                cmbLuminen.DisplayMember = "descripcion";
                cmbLuminen.ValueMember = "idAuxiliar";
                cmbLuminen.SelectedIndex = -1;

            }
        }
    }
}
