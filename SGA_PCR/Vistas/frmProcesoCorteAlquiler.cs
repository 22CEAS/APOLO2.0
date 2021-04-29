using AccesoDatos;
using DevComponents.DotNetBar.SuperGrid;
using DevExpress.XtraEditors.Repository;
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
using Excel = Microsoft.Office.Interop.Excel;

namespace Apolo
{
    public partial class frmProcesoCorteAlquiler : Form
    {
        public enum TipoVista { Inicial, Nuevo, Modificar, Guardar, Vista, Limpiar, Duplicar, Anular }
        DataTable tablaCliente;
        DataTable tablaLaptops;
        ClienteDA clienteDA;
        AlquilerDA alquilerDA;
        CorteAlquilerDA corteDA;
        BindingList<CorteAlquiler> renovaciones;
        CorteAlquiler renovacionTemp;
        int IdCliente;
        String DocumentoReferencia;
        String NumeroDniRuc;

        private int idUsuario;
        private string nombreUsuario = "CEAS";
        private string email = "carlos.arango@leasein.pe";
        private string motivoCambio = "CAMBIO RAZÓN SOCIAL";
        private string motivoDevolucion = "DEVOLUCIÓN";
        private string motivoVenta = "VENTA";
        private int maxNumDias = 7;
        
        public frmProcesoCorteAlquiler()
        {
            InitializeComponent();
            Inicializado();
            estadoComponentes(TipoVista.Inicial);
        }

        public frmProcesoCorteAlquiler(int idUsuario, string nombreUsuario, string email)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.email = email;
            Inicializado();
            estadoComponentes(TipoVista.Inicial);
        }

        public void Inicializado()
        {

            clienteDA = new ClienteDA();
            alquilerDA = new AlquilerDA();
            corteDA = new CorteAlquilerDA();
            renovaciones = new BindingList<CorteAlquiler>();

            renovacionTemp = new CorteAlquiler();

            tablaCliente = clienteDA.ListarClientes();
            cmbCliente.DataSource = tablaCliente;
            cmbCliente.DisplayMember = "nombre_razonSocial";
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.SelectedIndex = 0;
            int i = cmbCliente.SelectedIndex;

            int idCliente = Convert.ToInt32(tablaCliente.Rows[i]["idCliente"].ToString());
            txtNroDocumento.Text = tablaCliente.Rows[i]["nroDocumento"].ToString();

            //tablaLaptops = corteDA.ListarLaptopsClientesEstadoAlquilado(idCliente);

            ObtenerDatosRenovacion();
            vistaEquipos.OptionsBehavior.AutoPopulateColumns = false;
            vistaEquipos.OptionsSelection.MultiSelect = true;

            //dgvEquiposSeleccionados.ForceInitialize();
            RepositoryItemComboBox cmbMotivo = new RepositoryItemComboBox();
            cmbMotivo.Items.AddRange(new string[] { motivoCambio, motivoDevolucion, motivoVenta });
            dgvEquiposSeleccionados.RepositoryItems.Add(cmbMotivo);
            vistaEquipos.Columns[5].ColumnEdit = cmbMotivo;
        }

        public void ObtenerDatosRenovacion()
        {

            IdCliente = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
            string aux1 = "";
            aux1 = txtReferencia.Text;
            DocumentoReferencia = aux1.Trim();
            string aux2 = "";
            aux2 = txtNroDocumento.Text;
            NumeroDniRuc = aux2.Trim();

        }
        
        public bool ValidarDatos()
        {
            bool error = false;

            if (cmbCliente.SelectedValue == null)
            {
                MessageBox.Show("No se puede grabar una Corte de Alquiler si no\nha seleccionado un cliente correcto.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return true;
            }

            //if (txtReferencia.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("No se puede grabar esta Devolución\nnecesita ingresar un documento de referencia.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
            //                MessageBoxIcon.Error);
            //  return true;
            //}

            if (renovaciones.Count == 0)
            {
                MessageBox.Show("No se puede grabar si no hay ninguna laptop.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return true;
            }

            foreach (CorteAlquiler rev in renovaciones)
            {
                if (rev.FechaIniContrato > rev.FechaFinContrato)
                {
                    MessageBox.Show("No se puede grabar si hay una fecha Final de Plazo de Alquiler menor a la fecha inicial", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    return true;
                }

                if (rev.DescripcionMotivoCorte!=motivoCambio && rev.DescripcionMotivoCorte != motivoDevolucion && rev.DescripcionMotivoCorte != motivoVenta)
                {
                    MessageBox.Show("No se puede grabar el corte de alquiler si no se ha elegido un motivo", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    return true;
                }

                TimeSpan tSpan = rev.FechaRecojo - rev.FechaFinContrato;
                int numDiasTrans = tSpan.Days;
                if (rev.DescripcionMotivoCorte==motivoDevolucion && numDiasTrans > this.maxNumDias)
                {
                    MessageBox.Show("Hay un salto de " + numDiasTrans + " entre la fecha de recojo y la fecha fin de alquiler", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    return true;
                }
                if (rev.DescripcionMotivoCorte == motivoDevolucion && 
                    (rev.PersonaContacto.Trim().Length==0 || rev.Direccion.Trim().Length == 0
                     || rev.Telefono.Trim().Length == 0))
                {
                    MessageBox.Show("No se puede grabar porque uno de los campos obligatorios falta ser llenado", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    return true;
                }
            }

            return error;
        }

        public void estadoComponentes(TipoVista estado)
        {
            switch (estado)
            {
                case TipoVista.Inicial:
                    cmbCliente.Enabled = false;
                    txtReferencia.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    dgvEquiposSeleccionados.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    btnBorrar.Enabled = false;
                    limpiarComponentes();
                    renovaciones = new BindingList<CorteAlquiler>();
                    break;
                case TipoVista.Nuevo:
                    cmbCliente.Enabled = true;
                    txtReferencia.Enabled = true;
                    txtNroDocumento.Enabled = true;
                    dgvEquiposSeleccionados.Enabled = true;
                    btnAgregarProducto.Enabled = true;
                    btnNuevo.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnGrabar.Enabled = true;
                    btnBorrar.Enabled = true;
                    limpiarComponentes();
                    renovaciones = new BindingList<CorteAlquiler>();
                    ObtenerDatosRenovacion();
                    break;
                case TipoVista.Guardar:
                    cmbCliente.Enabled = false;
                    txtReferencia.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    dgvEquiposSeleccionados.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    btnBorrar.Enabled = false;
                    break;
                case TipoVista.Modificar:
                    cmbCliente.Enabled = true;
                    txtReferencia.Enabled = true;
                    txtNroDocumento.Enabled = true;
                    dgvEquiposSeleccionados.Enabled = true;
                    btnAgregarProducto.Enabled = true;
                    btnNuevo.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnGrabar.Enabled = true;
                    btnBorrar.Enabled = true;
                    break;
                case TipoVista.Vista:
                    cmbCliente.Enabled = false;
                    txtReferencia.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    dgvEquiposSeleccionados.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    btnBorrar.Enabled = false;
                    renovaciones = new BindingList<CorteAlquiler>();
                    break;
                case TipoVista.Limpiar:
                    cmbCliente.Enabled = false;
                    txtReferencia.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    dgvEquiposSeleccionados.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    btnBorrar.Enabled = false;
                    limpiarComponentes();
                    renovaciones = new BindingList<CorteAlquiler>();
                    break;
                case TipoVista.Duplicar:
                    cmbCliente.Enabled = false;
                    txtReferencia.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    dgvEquiposSeleccionados.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    btnBorrar.Enabled = false;
                    limpiarComponentes();
                    renovaciones = new BindingList<CorteAlquiler>();
                    break;
                case TipoVista.Anular:
                    cmbCliente.Enabled = false;
                    txtReferencia.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    dgvEquiposSeleccionados.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    btnBorrar.Enabled = false;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtReferencia.Text = "";
            cmbCliente.SelectedIndex = 0;
            dgvEquiposSeleccionados.DataSource = null;
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

            int i = cmbCliente.SelectedIndex;
            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                renovaciones = new BindingList<CorteAlquiler>();
                IdCliente = Convert.ToInt32(tablaCliente.Rows[i]["idCliente"].ToString());
                txtNroDocumento.Text = tablaCliente.Rows[i]["nroDocumento"].ToString();
                tablaLaptops = null;
                dgvEquiposSeleccionados.DataSource = null;
            }
            else
            {
                txtNroDocumento.Text = "";
            }

        }

        public void LlenarDatosDevolucion()
        {
            txtNroDocumento.Text = NumeroDniRuc;
            txtReferencia.Text = DocumentoReferencia;
            cmbCliente.SelectedValue = IdCliente;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(TipoVista.Nuevo);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            
            ObtenerDatosRenovacion();

            if (ValidarDatos())
            {
                return;
            }

            if (MessageBox.Show("Estas seguro que deseas guardar este proceso de Corte de Alquiler", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                int error = 0;
                error = corteDA.InsertarRenovaciones(renovaciones, this.nombreUsuario, DocumentoReferencia, IdCliente);

                if (error == 0)
                {
                    MessageBox.Show("Hubo error en el registro, comunicarse con tu soporte", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                //bool exists = renovaciones.Any(x => x.DescripcionMotivoCorte.Equals(motivoDevolucion));
                //if (exists)
                //{
                //    enviarCorreo();
                //}
                enviarCorreo();
                MessageBox.Show("Se guardó el proceso", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                estadoComponentes(TipoVista.Guardar);
            }

        }

        public void EnviarCodigo(string correo, string body, out string codigo, out int idUsuario)
        {

            idUsuario = 1;
            codigo = "123456";

            /*-------------------------MENSAJE DE CORREO----------------------*/

            //Creamos un nuevo Objeto de mensaje
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            //Direccion de correo electronico a la que queremos enviar el mensaje
            mmsg.To.Add("operacionesleasein@gmail.com");
            //mmsg.To.Add(correo);
            mmsg.CC.Add(this.email);
            mmsg.CC.Add("comercialleasein@gmail.com");
            //mmsg.CC.Add(this.email);

            //Nota: La propiedad To es una colección que permite enviar el mensaje a más de un destinatario

            //Asunto
            int i = cmbCliente.SelectedIndex;
            string razonSocial = tablaCliente.Rows[i]["nombre_razonSocial"].ToString();
            mmsg.Subject = "Corte de Alquiler " + razonSocial;
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

            //Direccion de correo electronico que queremos que reciba una copia del mensaje
            //mmsg.Bcc.Add("lucet.lp2@gmail.com"); //Opcional

            //Cuerpo del Mensaje
            mmsg.Body = body;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true; //Si no queremos que se envíe como HTML

            //Correo electronico desde la que enviamos el mensaje
            mmsg.From = new System.Net.Mail.MailAddress("apolo.leasein@gmail.com");

            /*-------------------------CLIENTE DE CORREO----------------------*/

            //Creamos un objeto de cliente de correo
            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

            //Hay que crear las credenciales del correo emisor
            cliente.UseDefaultCredentials = false;
            cliente.Credentials =
                new System.Net.NetworkCredential("apolo.leasein@gmail.com", "Apolo2021");
            //https://www.google.com/settings/security/lesssecureapps
            //Lo siguiente es obligatorio si enviamos el mensaje desde Gmail

            cliente.Port = 587;
            cliente.EnableSsl = true;


            cliente.Host = "smtp.gmail.com"; //Para Gmail "smtp.gmail.com";

            cliente.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;

            /*-------------------------ENVIO DE CORREO----------------------*/

            try
            {
                //Enviamos el mensaje      
                cliente.Send(mmsg);
                return;
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                MessageBox.Show(ex.Message);
                //Aquí gestionamos los errores al intentar enviar el correo
                return;

            }
        }

        private void enviarCorreo()
        {
            int i = cmbCliente.SelectedIndex;
            string razonSocial = tablaCliente.Rows[i]["nombre_razonSocial"].ToString();
            string ruc = tablaCliente.Rows[i]["nroDocumento"].ToString();

            int idUsuario;
            string codigo;
            string body = @"<html>
                            <head>
                            <style>
                            table {
                              width:75%;
                            }
                            table, th, td {
                              border: 1px solid black;
                              border-collapse: collapse;
                            }
                            th, td {
                              padding: 15px;
                              text-align: center;
                            }
                            #t01 tr:nth-child(even) {
                              background-color: #eee;
                            }
                            #t01 tr:nth-child(odd) {
                             background-color: #fff;
                            }
                            #t01 th {
                              background-color: orange;
                              color: white;
                            }
                            </style>
                            </head>
                            <body>

                        <h3>Buenas estimad@,</h3></br>
                        <h3>A continuación se detalla la información sobre el corte de los equipos.</h3></br>
                        <h3>Cliente: "
                        + razonSocial +
                        @"</h3></br>
                        <h3>RUC: "
                        + ruc +
                        @"</h3></br>
                        <table id='t01'>
                          <tr>
                            <th>Código Equipo</th>
                            <th>Tipo Equipo</th>
                            <th>Motivo Corte</th>
                            <th>Fecha Corte</th>
                            <th>Fecha Sugerida de Recojo</th>
                            <th>Dirección de Recojo</th>
                            <th>Persona de Contacto</th>
                            <th>Celular</th>
                            <th>Comentario</th>
                          </tr>
                        ";
            string cadena = "";
            foreach (CorteAlquiler renovacion in renovaciones)
            {
                //if (renovacion.DescripcionMotivoCorte == motivoDevolucion)
                //{
                    cadena += "<tr>";
                    cadena += "<td>" + renovacion.CodigoLC + "</td>";
                    cadena += "<td>" + "LAPTOP" + "</td>";
                    cadena += "<td>" + renovacion.DescripcionMotivoCorte + "</td>";
                    cadena += "<td>" + renovacion.FechaFinContrato.ToShortDateString() + "</td>";
                    if (renovacion.DescripcionMotivoCorte == motivoDevolucion)
                    {
                        cadena += "<td>" + renovacion.FechaRecojo.ToShortDateString() + "</td>";
                        cadena += "<td>" + renovacion.Direccion + "</td>";
                        cadena += "<td>" + renovacion.PersonaContacto + "</td>";
                        cadena += "<td>" + renovacion.Telefono + "</td>";
                    }
                    else
                    {
                        cadena += "<td>" + "" + "</td>";
                        cadena += "<td>" + "" + "</td>";
                        cadena += "<td>" + "" + "</td>";
                        cadena += "<td>" + "" + "</td>";
                    }
                    cadena += "<td>" + renovacion.Observacion + "</td>";
                    cadena += "</tr>";
                //}
            }
            cadena += @"</table> 
                        </ body > 
                        </ html > ";
            body += cadena;
            EnviarCodigo("carlos.arango@leasein.pe", body, out codigo, out idUsuario);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas cancelar el proceso", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                estadoComponentes(TipoVista.Limpiar);
                renovaciones = new BindingList<CorteAlquiler>();
                dgvEquiposSeleccionados.DataSource = null;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue == null)
            {
                MessageBox.Show("No se puede agregar productos\n si no se ha seleccionado un cliente correcto.", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return;
            }

            using (frmProcesoCorteAlquilerAgregarProducto frm = new frmProcesoCorteAlquilerAgregarProducto(IdCliente))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    BindingList<CorteAlquiler> auxiliares = new BindingList<CorteAlquiler>();
                    foreach (CorteAlquiler aux in renovaciones)
                    {
                        auxiliares.Add(aux);
                    }

                    foreach (CorteAlquiler detalleTraido in frm.DETALLES)
                    {
                        CorteAlquiler dp = new CorteAlquiler();
                        dp.IdLC = detalleTraido.IdLC;
                        bool exists = auxiliares.Any(x => x.IdLC.Equals(dp.IdLC));
                        if (!(exists))
                        {
                            auxiliares.Add(detalleTraido);
                        }
                    }
                    renovaciones = auxiliares;
                }
            }

            dgvEquiposSeleccionados.DataSource = renovaciones;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro deseas Eliminar esta laptop de tu detalle", "◄ AVISO | LEASEIN ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                bool error;
                vistaEquipos.ClearColumnsFilter();

                int equipoID = -1;
                int h = 0;
                for (h = 0; h < vistaEquipos.RowCount; h++)
                    if (vistaEquipos.IsRowSelected(h) == true)
                    {
                        equipoID = int.Parse(vistaEquipos.GetRowCellValue(h, "IdLC").ToString());
                        break;
                    }

                if (equipoID != -1)
                {
                    renovacionTemp.IdLC = equipoID;

                    int indiceLC = 0;
                    foreach (CorteAlquiler detalle in renovaciones)
                    {
                        if (detalle.IdLC == renovacionTemp.IdLC)
                        {
                            break;
                        }
                        indiceLC++;
                    }
                    renovaciones.RemoveAt(indiceLC);
                    dgvEquiposSeleccionados.DataSource = renovaciones;
                }
            }
        }
        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        int posY = 0;
        int posX = 0;

        private void pnlCA_MouseMove(object sender, MouseEventArgs e)
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
        
        private void vistaEquipos_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.N))
            {
                string aux = vistaEquipos.GetFocusedValue().ToString();
                Clipboard.SetText(aux);
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
                    miDataTable.Columns.Add("CodigoLC");
                    miDataTable.Columns.Add("PersonaContacto");
                    miDataTable.Columns.Add("Direccion");
                    miDataTable.Columns.Add("Telefono");
                    miDataTable.Columns.Add("Observacion");
                    miDataTable.Columns.Add("FechaRecojo");
                    miDataTable.Columns.Add("DescripcionMotivoCorte");

                    path = openFileDialog.FileName;
                    SLDocument sl = new SLDocument(path);

                    int iRow = 2;
                    while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                    {
                        DataRow Renglon = miDataTable.NewRow();
                        Renglon["CodigoLC"] = sl.GetCellValueAsString(iRow, 1);
                        Renglon["PersonaContacto"] = sl.GetCellValueAsString(iRow, 2);
                        Renglon["Direccion"] = sl.GetCellValueAsString(iRow, 3);
                        Renglon["Telefono"] = sl.GetCellValueAsString(iRow, 4);
                        Renglon["Observacion"] = sl.GetCellValueAsString(iRow, 5);
                        Renglon["FechaRecojo"] = sl.GetCellValueAsDateTime(iRow, 6);
                        Renglon["DescripcionMotivoCorte"] = sl.GetCellValueAsString(iRow, 7);
                        iRow++;
                        miDataTable.Rows.Add(Renglon);
                    }

                    int filasExcel = miDataTable.Rows.Count;
                    for (int i = 0; i < filasExcel; i++)
                    {
                        string codigo = miDataTable.Rows[i]["CodigoLC"].ToString();
                        vistaEquipos.ClearColumnsFilter();
                        int filasDgv = vistaEquipos.RowCount;
                        for (int j = 0; j < filasDgv; j++)
                        {
                            if (codigo == vistaEquipos.GetRowCellValue(j, "CodigoLC").ToString())
                            {
                                string PersonaContacto = miDataTable.Rows[i]["PersonaContacto"].ToString();
                                string Direccion = miDataTable.Rows[i]["Direccion"].ToString();
                                string Telefono = miDataTable.Rows[i]["Telefono"].ToString();
                                string Observacion = miDataTable.Rows[i]["Observacion"].ToString();
                                string FechaRecojo = miDataTable.Rows[i]["FechaRecojo"].ToString();
                                string DescripcionMotivoCorte = miDataTable.Rows[i]["DescripcionMotivoCorte"].ToString();
                                vistaEquipos.SetRowCellValue(j, "PersonaContacto", PersonaContacto);
                                vistaEquipos.SetRowCellValue(j, "Direccion", Direccion);
                                vistaEquipos.SetRowCellValue(j, "Telefono", Telefono);
                                vistaEquipos.SetRowCellValue(j, "Observacion", Observacion);
                                vistaEquipos.SetRowCellValue(j, "DescripcionMotivoCorte", DescripcionMotivoCorte);
                                if (FechaRecojo != "1/01/1900 00:00:00" && EsFecha(FechaRecojo))
                                    vistaEquipos.SetRowCellValue(j, "FechaRecojo", FechaRecojo);
                                break;
                            }
                        }
                    }
                }
                MessageBox.Show("Se terminó de subir el excel", "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        public static Boolean EsFecha(String fecha)
        {
            try
            {
                DateTime.Parse(fecha);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
