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
    public partial class frmProcesoFacturaTransito : Form
    {
        BindingList<Factura> facturas;
        FacturaDA facturaDA;
        DataTable cuadroVencimiento;
        DataTable equiposDisponiblesPreAlquiler;
        DataTable facturasTransito;
        DataTable buscarV;
        DataTable equiposFacturaTransito;

        private int idUsuario;
        private string nombreUsuario = "CEAS";
        private int maxNumDias = 3;
        private int minNumDias = -1;

        public frmProcesoFacturaTransito()
        {
            InitializeComponent();
            Inicializado();
        }

        public frmProcesoFacturaTransito(int idUsuario, string nombreUsuario)
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


            facturasTransito = facturaDA.BuscarFacturasTransitoActivas();

            cmbFactura.DataSource = facturasTransito;
            cmbFactura.DisplayMember = "numFacturaTransito";
            cmbFactura.SelectedIndex = -1;

            vistaCodigo.OptionsBehavior.AutoPopulateColumns = false;
            vistaCodigo.OptionsSelection.MultiSelect = true;
        }

        private void Validar(int flag)
        {
            cuadroVencimiento = facturaDA.ListarCV();
            equiposDisponiblesPreAlquiler = facturaDA.ListarEquiposDisponiblesPreAlquiler();
            facturasTransito = facturaDA.ListarFacturasTransito();

            foreach (Factura f in facturas)
            {
                //MessageBox.Show(f.FechaIniPago.ToShortDateString());
                if (f.Error == 0)
                {
                    f.ObservacionXLevantar = "Esta laptop no se encuentra en el CV, o el código de la laptop o guia no coincide con ninguna del CV.";

                    if (f.FechaIniPago <= f.FechaFinPago)
                    {
                        if (f.NumeroFactura.Trim().Length != 0)
                        {
                            String concatCodActCV = "", facturaCV = "", guiaSalidaCV = "";
                            String concatCodAntCV = "", facturaAntCV = "", guiaSalidaAntCV = "";
                            DateTime fecFinFacCV;
                            DateTime fecFinFacAntCV;
                            DateTime fecIniContrato, fecFinContrato;
                            String codigoActCV = "";
                            int idLcAntigua = 0, idLcActual = 0;
                            int IdSalidaDetActual = 0, IdSalidaDetAntigua = 0;
                            String concatCodSis = f.RucDni + "-" + f.CodigoLC;

                            String codigoEquipo = "";
                            String numFacturaTransito = "";

                            for (int i = 0; i < cuadroVencimiento.Rows.Count; i++)
                            {
                                concatCodActCV = cuadroVencimiento.Rows[i]["concatCodActCV"].ToString();
                                codigoActCV = cuadroVencimiento.Rows[i]["codigo"].ToString();
                                facturaCV = cuadroVencimiento.Rows[i]["numFactura"].ToString();
                                guiaSalidaCV = cuadroVencimiento.Rows[i]["guiaActual"].ToString();
                                fecFinFacCV = DateTime.Parse(cuadroVencimiento.Rows[i]["fecFinPago"].ToString());
                                idLcActual = int.Parse(cuadroVencimiento.Rows[i]["IdLCActual"].ToString());
                                fecIniContrato = DateTime.Parse(cuadroVencimiento.Rows[i]["fecIniContrato"].ToString());
                                fecIniContrato = DateTime.Parse(fecIniContrato.ToShortDateString());
                                fecFinContrato = DateTime.Parse(cuadroVencimiento.Rows[i]["fecFinContrato"].ToString());
                                fecFinContrato = DateTime.Parse(fecFinContrato.ToShortDateString());

                                concatCodAntCV = cuadroVencimiento.Rows[i]["concatCodAntCV"].ToString();
                                facturaAntCV = cuadroVencimiento.Rows[i]["numFacturaAntigua"].ToString();
                                guiaSalidaAntCV = cuadroVencimiento.Rows[i]["guiaAntigua"].ToString();
                                fecFinFacAntCV = DateTime.Parse(cuadroVencimiento.Rows[i]["fecFinPagoAntigua"].ToString());
                                string aux = cuadroVencimiento.Rows[i]["IdLCAntigua"].ToString();
                                idLcAntigua = aux.Length == 0 ? 0 : int.Parse(cuadroVencimiento.Rows[i]["IdLCAntigua"].ToString());
                                IdSalidaDetActual = int.Parse(cuadroVencimiento.Rows[i]["IdSalidaDetActual"].ToString());
                                IdSalidaDetAntigua = int.Parse(cuadroVencimiento.Rows[i]["IdSalidaDetAntigua"].ToString());

                                if ((concatCodSis == concatCodActCV && f.NumeroDocRef == guiaSalidaCV))
                                {
                                    if (facturaCV != f.NumeroFactura)
                                    {
                                        if (facturaCV.Length == 0)//es su primer ingreso
                                        {
                                            TimeSpan tSpan = f.FechaIniPago - fecIniContrato;
                                            int numDiasTrans = tSpan.Days;

                                            if (numDiasTrans > this.maxNumDias || numDiasTrans < this.minNumDias)
                                            {
                                                f.ObservacionXLevantar = "Esta factura tiene errores en la fecha. Hay un Salto de fechas de " + numDiasTrans + " dias entre la fecha Inicio del Plazo de Alquiler y la fecha inicial de la factura.";
                                                break;
                                            }
                                            else
                                            {
                                                if (flag == 2)//2 es grabar
                                                {
                                                    facturaDA.InsertarFactura(f, this.nombreUsuario, idLcActual, idLcAntigua, codigoActCV);
                                                    f.ObservacionXLevantar = "Se grabo correctamente la factura.";
                                                    //if (fecFinContrato < f.FechaFinPago)
                                                    if (fecFinContrato != f.FechaFinPago)//&& tipoContrato==Palabra
                                                    {
                                                        facturaDA.ActualizarPlazoFinal(f, this.nombreUsuario, IdSalidaDetActual, IdSalidaDetAntigua);
                                                        f.ObservacionXLevantar = f.ObservacionXLevantar + " Se actualizó el Plazo";
                                                    }

                                                }
                                                else
                                                {
                                                    f.ObservacionXLevantar = "Todo Bien, es la primera factura, no hay factura anterior.";
                                                    if (fecFinContrato < f.FechaFinPago)
                                                    {
                                                        f.ObservacionXLevantar = f.ObservacionXLevantar + " Se actualizará el Plazo";
                                                    }
                                                }

                                                break;
                                            }
                                        }
                                        if (fecFinFacCV < f.FechaIniPago)
                                        {
                                            TimeSpan tSpan = f.FechaIniPago - fecFinFacCV;
                                            int numDiasTrans = tSpan.Days;
                                            if (numDiasTrans != 1)
                                            {
                                                f.ObservacionXLevantar = "Esta factura tiene errores en la fecha. Hay un Salto de fechas de " + numDiasTrans + " dias.";
                                                break;
                                            }
                                            else
                                            {
                                                if (flag == 2)//2 es grabar
                                                {
                                                    facturaDA.InsertarFactura(f, this.nombreUsuario, idLcActual, idLcAntigua, codigoActCV);
                                                    f.ObservacionXLevantar = "Se grabo correctamente la factura.";
                                                    if (fecFinContrato < f.FechaFinPago)
                                                    {
                                                        facturaDA.ActualizarPlazoFinal(f, this.nombreUsuario, IdSalidaDetActual, IdSalidaDetAntigua);
                                                        f.ObservacionXLevantar = f.ObservacionXLevantar + " Se actualizó el Plazo";
                                                    }
                                                }
                                                else
                                                {
                                                    f.ObservacionXLevantar = "Todo Bien.";
                                                    if (fecFinContrato < f.FechaFinPago)
                                                    {
                                                        f.ObservacionXLevantar = f.ObservacionXLevantar + " Se actualizará el Plazo";
                                                    }
                                                }

                                                break;
                                            }
                                        }
                                        else
                                        {
                                            f.ObservacionXLevantar = "Error en la fechas, la fecha final de la ultima factura pagada es mayor o igual a la fecha inicio de esta nueva factura";
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        f.ObservacionXLevantar = "Esta factura ya esta registrada";
                                        break;
                                    }
                                }
                            }

                        }
                        else
                            f.ObservacionXLevantar = "Error en la factura, el número de la factura está vacio";
                    }
                    else
                        f.ObservacionXLevantar = "Error en las fechas, la fecha final de la factura de Sisgeco es menor a la fecha inicial de la factura de Sisgeco";

                }

            }

            dgvEquiposCodigos.DataSource = facturas;
            vistaCodigo.OptionsBehavior.AutoPopulateColumns = false;
            vistaCodigo.OptionsSelection.MultiSelect = true;
            vistaCodigo.RefreshData();
        }

        private void ValidarDatos() 
        {
            cuadroVencimiento = facturaDA.ListarCV();
            facturasTransito = facturaDA.ListarFacturasTransito();

            int IdFacturaTransito = 0;
            double TotalSoles = 0;
            double TotalDolares = 0;
            double CostoSoles = 0;
            double CostoDolares = 0;
            double Cantidad = 0;

            int rec = 0;
            while (rec < equiposFacturaTransito.Rows.Count)
            {
                string CodigoLC = equiposFacturaTransito.Rows[rec]["codigoEquipo"].ToString();
                if (CodigoLC == "001")
                {
                    IdFacturaTransito = Convert.ToInt32(equiposFacturaTransito.Rows[rec]["idFacturaTransito"].ToString());
                    TotalSoles = Convert.ToDouble(equiposFacturaTransito.Rows[rec]["totalSoles"].ToString());
                    TotalDolares = Convert.ToDouble(equiposFacturaTransito.Rows[rec]["totalDolares"].ToString());
                    CostoSoles = Convert.ToDouble(equiposFacturaTransito.Rows[rec]["costoSoles"].ToString());
                    CostoDolares = Convert.ToDouble(equiposFacturaTransito.Rows[rec]["costoDolares"].ToString());
                    Cantidad = Convert.ToInt32(equiposFacturaTransito.Rows[rec]["cantidadEquipos"].ToString());
                    break;
                }
                rec++;
            }

            double sumTotalSoles = 0;
            double sumTotalDolares = 0;
            double sumCostoSoles = 0;
            double sumCostoDolares = 0;

            int FlagError = 0;
            int FlagErrorMontos = 0;
            int FlagSeEncontro = 0;

            foreach (Factura f in facturas)
            {
                if (f.IdFacturaTransito == IdFacturaTransito)
                {
                    f.ObservacionXLevantar = "";

                    sumTotalSoles += f.TotalSoles;
                    sumTotalDolares += f.TotalDolares;
                    sumCostoSoles += f.CostoSoles;
                    sumCostoDolares += f.CostoDolares;

                    if (f.FechaIniPago <= f.FechaFinPago)
                    {
                        if (f.NumeroFactura.Trim().Length != 0)
                        {
                            String concatCodActCV = "", facturaCV = "", guiaSalidaCV = "";
                            String concatCodAntCV = "", guiaSalidaAntCV = "";
                            DateTime fecFinFacCV;
                            DateTime fecIniContrato, fecFinContrato;
                            String codigoActCV = "";
                            String concatCodSis = f.RucDni + "-" + f.CodigoLC;

                            FlagSeEncontro = 0;
                            for (int i = 0; i < cuadroVencimiento.Rows.Count; i++)
                            {
                                concatCodActCV = cuadroVencimiento.Rows[i]["concatCodActCV"].ToString();
                                codigoActCV = cuadroVencimiento.Rows[i]["codigo"].ToString();
                                facturaCV = cuadroVencimiento.Rows[i]["numFactura"].ToString();
                                guiaSalidaCV = cuadroVencimiento.Rows[i]["guiaActual"].ToString();
                                fecFinFacCV = DateTime.Parse(cuadroVencimiento.Rows[i]["fecFinPago"].ToString());
                                fecIniContrato = DateTime.Parse(cuadroVencimiento.Rows[i]["fecIniContrato"].ToString());
                                fecIniContrato = DateTime.Parse(fecIniContrato.ToShortDateString());
                                fecFinContrato = DateTime.Parse(cuadroVencimiento.Rows[i]["fecFinContrato"].ToString());
                                fecFinContrato = DateTime.Parse(fecFinContrato.ToShortDateString());

                                concatCodAntCV = cuadroVencimiento.Rows[i]["concatCodAntCV"].ToString();
                                guiaSalidaAntCV = cuadroVencimiento.Rows[i]["guiaAntigua"].ToString();

                                if ((concatCodSis == concatCodActCV && f.NumeroDocRef == guiaSalidaCV))
                                {
                                    FlagSeEncontro = 1; 

                                    if (facturaCV != f.NumeroFactura)
                                    {
                                        if (facturaCV.Length == 0)//es su primer ingreso
                                        {
                                            TimeSpan tSpan = f.FechaIniPago - fecIniContrato;
                                            int numDiasTrans = tSpan.Days;

                                            if (numDiasTrans > this.maxNumDias || numDiasTrans < this.minNumDias)
                                            {
                                                f.ObservacionXLevantar = "Esta factura tiene errores en la fecha. Hay un Salto de fechas de " + numDiasTrans + " dias entre la fecha Inicio del Plazo de Alquiler y la fecha inicial de la factura.";
                                                FlagError = 1;
                                            }
                                            break;
                                        }
                                        if (fecFinFacCV < f.FechaIniPago)
                                        {
                                            TimeSpan tSpan = f.FechaIniPago - fecFinFacCV;
                                            int numDiasTrans = tSpan.Days;
                                            if (numDiasTrans != 1)
                                            {
                                                f.ObservacionXLevantar = "Esta factura tiene errores en la fecha. Hay un Salto de fechas de " + numDiasTrans + " dias.";
                                                FlagError = 1;
                                            }
                                            break;
                                        }
                                        else
                                        {
                                            f.ObservacionXLevantar = "Error en la fechas, la fecha final de la ultima factura pagada es mayor o igual a la fecha inicio de esta nueva factura";
                                            FlagError = 1;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        f.ObservacionXLevantar = "Esta factura ya esta registrada";
                                        FlagError = 1;
                                        break;
                                    }
                                }
                            }

                            if (FlagSeEncontro == 0)
                            {
                                f.ObservacionXLevantar = "Esta laptop no se encuentra en el CV, o el código de la laptop o guia no coincide con ninguna del CV.";
                                FlagError = 1;
                            }
                        }
                        else
                        {
                            f.ObservacionXLevantar = "Error en la factura, el número de la factura está vacio";
                            FlagError = 1;
                        }
                    }
                    else
                    {
                        f.ObservacionXLevantar = "Error en las fechas, la fecha final de la factura de Sisgeco es menor a la fecha inicial de la factura de Sisgeco";
                        FlagError = 1;
                    }
                }
            }

            if (TotalSoles!=sumTotalSoles || TotalDolares != sumTotalDolares 
                || CostoSoles != sumCostoSoles || CostoDolares != sumCostoDolares)
                FlagErrorMontos = 1;

            if(FlagError==1 || FlagErrorMontos == 1)
                foreach (Factura f in facturas)
                {
                    if (f.IdFacturaTransito == IdFacturaTransito)
                    {
                        f.Error = 1;
                        if(FlagErrorMontos == 1)
                            f.ObservacionXLevantar += " Hay un error en uno de los montos, no coincide con el monto de la factura";
                    }
                }
            else
                foreach (Factura f in facturas)
                {
                    if (f.IdFacturaTransito == IdFacturaTransito)
                    {
                        f.Error = 0;
                        f.ObservacionXLevantar = "";
                    }
                }
        }

        public bool GrabarFactura()
        {
            ValidarDatos();
            Validar(2);
            
            MessageBox.Show("Se guardó las listas de facturas", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            
            return true;
        }

        private async void btnGrabar_Click(object sender, EventArgs e)
        {
            if (facturas.Count > 0)
            {
                if (MessageBox.Show("Estas seguro que desea Guardar las facturas", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    giftCarga.Enabled = true;
                    giftCarga.Visible = true;
                    //facturaDA.InsertarFacturas(facturas, this.nombreUsuario);
                    Task<bool> task = new Task<bool>(GrabarFactura);
                    task.Start();
                    giftCarga.Image = Image.FromFile(@".\progress.gif");
                    giftCarga.SizeMode = PictureBoxSizeMode.StretchImage;
                    btnGrabar.Enabled = false;
                    btnValidar.Enabled = false;
                    btnBuscarV.Enabled = false;
                    bool resultado = await task; //MIENTRAS CARGA
                    giftCarga.Enabled = false;
                    giftCarga.Visible = false;
                    btnGrabar.Enabled = true;
                    btnValidar.Enabled = true;
                    btnBuscarV.Enabled = true;

                    facturasTransito = facturaDA.BuscarFacturasTransitoActivas();
                    cmbFactura.DataSource = facturasTransito;
                    cmbFactura.DisplayMember = "numFacturaTransito";
                    cmbFactura.SelectedIndex = -1;
                }
            }
        }

        public bool ValidarFactura()
        {
            ValidarDatos();
            Validar(1);
            MessageBox.Show("Se terminó la validación", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return true;
        }

        private async void btnValidar_Click(object sender, EventArgs e)
        {
            if (facturas.Count > 0)
            {
                if (MessageBox.Show("Estas seguro que desea Validar las facturas", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {

                    giftCarga.Enabled = true;
                    giftCarga.Visible = true;
                    Task<bool> task = new Task<bool>(ValidarFactura);
                    task.Start();
                    giftCarga.Image = Image.FromFile(@".\progress.gif");
                    giftCarga.SizeMode = PictureBoxSizeMode.StretchImage;
                    
                    btnGrabar.Enabled = false;
                    btnValidar.Enabled = false;
                    btnBuscarV.Enabled = false;

                    bool resultado = await task; //MIENTRAS CARGA

                    giftCarga.Enabled = false;
                    giftCarga.Visible = false;
                    
                    btnGrabar.Enabled = true;
                    btnValidar.Enabled = true;
                    btnBuscarV.Enabled = true;
                }

            }


        }

        public bool BuscarV()
        {
            buscarV = facturaDA.BuscarV();
            foreach (Factura f in facturas)
            {
                String concatCodSis = f.RucDni + "-" + f.CodigoLC;
                for (int i = 0; i < buscarV.Rows.Count; i++)
                {
                    string concatenado = buscarV.Rows[i]["concatenado"].ToString();

                    if (concatCodSis == concatenado)
                    {
                        f.NumeroDocRef = buscarV.Rows[i]["guiaSalida"].ToString();
                        break;
                    }
                }
            }

            dgvEquiposCodigos.DataSource = facturas;
            vistaCodigo.OptionsBehavior.AutoPopulateColumns = false;
            vistaCodigo.OptionsSelection.MultiSelect = true;
            vistaCodigo.RefreshData();

            MessageBox.Show("Se realizó la busquedad", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return true;
        }

        private async void btnBuscarV_Click(object sender, EventArgs e)
        {

            if (facturas.Count > 0)
            {
                if (MessageBox.Show("Estas seguro que desea realizar el Buscar V en estas facturas", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    giftCarga.Enabled = true;
                    giftCarga.Visible = true;
                    Task<bool> task = new Task<bool>(BuscarV);
                    task.Start();
                    giftCarga.Image = Image.FromFile(@".\progress.gif");
                    giftCarga.SizeMode = PictureBoxSizeMode.StretchImage;
                    
                    btnGrabar.Enabled = false;
                    btnValidar.Enabled = false;
                    btnBuscarV.Enabled = false;

                    bool resultado = await task; //MIENTRAS CARGA

                    giftCarga.Enabled = false;
                    giftCarga.Visible = false;
                    
                    btnGrabar.Enabled = true;
                    btnValidar.Enabled = true;
                    btnBuscarV.Enabled = true;
                }
            }
        }

        private void frmProcesoFacturaTransito_Load(object sender, EventArgs e)
        {
            giftCarga.Enabled = false;
            giftCarga.Visible = false;
        }

        private void cmbFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aux = cmbFactura.SelectedIndex;
            if (aux != -1)
            {
                string numFactura = facturasTransito.Rows[aux]["numFacturaTransito"].ToString();
                equiposFacturaTransito = facturaDA.CargarEquiposFacturaConCodigo(numFactura);

                facturas = new BindingList<Factura>();
                int rec = 0;
                while (rec < equiposFacturaTransito.Rows.Count)
                {
                    Factura fact = new Factura();
                    fact.IdFacturaTransito = Convert.ToInt32(equiposFacturaTransito.Rows[rec]["idFacturaTransito"].ToString());

                    fact.CodigoLC = equiposFacturaTransito.Rows[rec]["codigoEquipo"].ToString();
                    fact.FechaPago = Convert.ToDateTime(equiposFacturaTransito.Rows[rec]["fecEmisiom"].ToString());
                    fact.FechaIniPago = (equiposFacturaTransito.Rows[rec]["fecIniPago"] is DBNull) ? Convert.ToDateTime("1/01/1900 00:00:00") : Convert.ToDateTime(equiposFacturaTransito.Rows[rec]["fecIniPago"].ToString());
                    fact.FechaFinPago = (equiposFacturaTransito.Rows[rec]["fecFinPago"] is DBNull) ? Convert.ToDateTime("1/01/1900 00:00:00") : Convert.ToDateTime(equiposFacturaTransito.Rows[rec]["fecFinPago"].ToString());
                    fact.RucDni = equiposFacturaTransito.Rows[rec]["ruc"].ToString();
                    fact.RazonSocial = equiposFacturaTransito.Rows[rec]["razonSocial"].ToString();
                    fact.NumeroOC = equiposFacturaTransito.Rows[rec]["numeroOC"].ToString();
                    fact.NumeroDocRef = equiposFacturaTransito.Rows[rec]["guiaSalida"].ToString();
                    fact.NumeroFactura = equiposFacturaTransito.Rows[rec]["numFacturaTransito"].ToString();
                    fact.TotalSoles = Convert.ToDouble(equiposFacturaTransito.Rows[rec]["totalSoles"].ToString());
                    fact.TotalDolares = Convert.ToDouble(equiposFacturaTransito.Rows[rec]["totalDolares"].ToString());
                    fact.CostoSoles = Convert.ToDouble(equiposFacturaTransito.Rows[rec]["costoSoles"].ToString());
                    fact.CostoDolares = Convert.ToDouble(equiposFacturaTransito.Rows[rec]["costoDolares"].ToString());
                    fact.CantidadEquipos = Convert.ToInt32(equiposFacturaTransito.Rows[rec]["cantidadEquipos"].ToString());

                    fact.TipoFacturaTransito = 1;

                    rec++;
                    facturas.Add(fact);
                }

                equiposFacturaTransito = facturaDA.CargarEquiposFacturaConCodigoGenerico(numFactura);

                if (equiposFacturaTransito.Rows.Count > 0)
                {
                    int auxCantidad = Convert.ToInt32(equiposFacturaTransito.Rows[0]["cantidadEquipos"].ToString());
                    rec = 0;
                    while (rec < auxCantidad)
                    {
                        Factura fact = new Factura();
                        fact.IdFacturaTransito = Convert.ToInt32(equiposFacturaTransito.Rows[0]["idFacturaTransito"].ToString());

                        fact.CodigoLC = "";
                        fact.FechaPago = Convert.ToDateTime(equiposFacturaTransito.Rows[0]["fecEmisiom"].ToString());
                        fact.FechaIniPago = (equiposFacturaTransito.Rows[0]["fecIniPago"] is DBNull) ? Convert.ToDateTime("1/01/1900 00:00:00") : Convert.ToDateTime(equiposFacturaTransito.Rows[0]["fecIniPago"].ToString());
                        fact.FechaFinPago = (equiposFacturaTransito.Rows[0]["fecFinPago"] is DBNull) ? Convert.ToDateTime("1/01/1900 00:00:00") : Convert.ToDateTime(equiposFacturaTransito.Rows[0]["fecFinPago"].ToString());
                        fact.RucDni = equiposFacturaTransito.Rows[0]["ruc"].ToString();
                        fact.RazonSocial = equiposFacturaTransito.Rows[0]["razonSocial"].ToString();
                        fact.NumeroOC = equiposFacturaTransito.Rows[0]["numeroOC"].ToString();
                        fact.NumeroDocRef = equiposFacturaTransito.Rows[0]["guiaSalida"].ToString();
                        fact.NumeroFactura = equiposFacturaTransito.Rows[0]["numFacturaTransito"].ToString();
                        fact.TotalSoles = Convert.ToDouble(equiposFacturaTransito.Rows[0]["totalSoles"].ToString()) / auxCantidad;
                        fact.TotalDolares = Convert.ToDouble(equiposFacturaTransito.Rows[0]["totalDolares"].ToString()) / auxCantidad;
                        fact.CostoSoles = Convert.ToDouble(equiposFacturaTransito.Rows[0]["costoSoles"].ToString()) / auxCantidad;
                        fact.CostoDolares = Convert.ToDouble(equiposFacturaTransito.Rows[0]["costoDolares"].ToString()) / auxCantidad;
                        fact.CantidadEquipos = 1;

                        fact.TipoFacturaTransito = 1;

                        rec++;
                        facturas.Add(fact);
                    }
                }

                dgvEquiposCodigos.DataSource = facturas;
                vistaCodigo.OptionsBehavior.AutoPopulateColumns = false;
                vistaCodigo.OptionsSelection.MultiSelect = true;
                vistaCodigo.RefreshData();

            }
            else
            {
                dgvEquiposCodigos.DataSource = null;
                facturas = new BindingList<Factura>();
            }

        }
    }
}
