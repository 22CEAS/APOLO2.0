using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class FacturaDA
    {
        DBManager objManager;
        MySqlParameter[] parametrosEntrada = null;

        public FacturaDA()
        {
            objManager = new DBManager();
        }

        public DataTable ListarCV()
        {
            return objManager.MostrarTablaDatos("Select * from vista_factura_CV ;");
        }

        public DataTable ListarEquiposDisponiblesPreAlquiler()
        {
            return objManager.MostrarTablaDatos("Select * from vista_equipos_disponible_preAlquiler ;");
        }

        public DataTable ListarFacturasTransito()
        {
            return objManager.MostrarTablaDatos("Select * from factura_transito where estado=1 ;");
        }

        public DataTable BuscarFacturasTransitoActivas()
        {
            return objManager.MostrarTablaDatos("Select DISTINCT numFacturaTransito from factura_transito where estado=1 ;");
        }

        public DataTable CargarEquiposFacturaConCodigo(string numFactura)
        {
            return objManager.MostrarTablaDatos("Select * from vista_equipos_por_factura_codigo where numFacturaTransito='" + numFactura + "' ; ");
        }

        public DataTable CargarEquiposFacturaConCodigoGenerico(string numFactura)
        {
            return objManager.MostrarTablaDatos("Select * from vista_equipos_por_factura_generico where numFacturaTransito='" + numFactura + "' ; ");
        }

        public DataTable BuscarV()
        {
            return objManager.MostrarTablaDatos("Select * from vista_buscarV ;");
        }

        public DataTable BuscarFacturasActivas()
        {
            return objManager.MostrarTablaDatos("Select * from vista_facturas_activas ;");
        }

        public DataTable CargarEquiposFactura(string numFactura)
        {
            return objManager.MostrarTablaDatos("Select * from vista_equipos_por_factura where numFactura='" + numFactura + "' ; " );
        }

        public int InsertarFacturas(BindingList<Factura> facturas, string usuario)
        {

            foreach (Factura factura in facturas)
            {
                MySqlDataReader reader;
                string sql = "";
                sql = "SELECT DISTINCT s.idSalida FROM salida s INNER JOIN salida_det d ON s.idSalida = d.idSalida WHERE d.guiaSalida = '" + factura.NumeroDocRef + "' ;";
                reader = objManager.MostrarInformacion(sql);

                while (reader.Read())
                {
                    factura.IdSalida = reader.GetInt32("idSalida");
                }

                objManager.conexion.Close();
                objManager.conexion.Dispose();
                objManager.cmd.Dispose();


                parametrosEntrada = new MySqlParameter[12];
                parametrosEntrada[0] = new MySqlParameter("@_idSalida", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_numFactura", MySqlDbType.VarChar, 255);
                parametrosEntrada[2] = new MySqlParameter("@_fecIniPago", MySqlDbType.DateTime);
                parametrosEntrada[3] = new MySqlParameter("@_fecFinPago", MySqlDbType.DateTime);
                parametrosEntrada[4] = new MySqlParameter("@_fecEmisiom", MySqlDbType.DateTime);
                parametrosEntrada[5] = new MySqlParameter("@_ruc", MySqlDbType.VarChar, 11);
                parametrosEntrada[6] = new MySqlParameter("@_codigoLC", MySqlDbType.VarChar, 255);
                parametrosEntrada[7] = new MySqlParameter("@_guiaSalida", MySqlDbType.VarChar, 255);
                parametrosEntrada[8] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 100);
                parametrosEntrada[9] = new MySqlParameter("@_estado", MySqlDbType.Int32);
                parametrosEntrada[10] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 100);
                parametrosEntrada[11] = new MySqlParameter("@_idFactura", MySqlDbType.Int32);

                parametrosEntrada[0].Value = factura.IdSalida;
                parametrosEntrada[1].Value = factura.NumeroFactura;
                parametrosEntrada[2].Value = factura.FechaIniPago;
                parametrosEntrada[3].Value = factura.FechaFinPago;
                parametrosEntrada[4].Value = factura.FechaPago;
                parametrosEntrada[5].Value = factura.RucDni;
                parametrosEntrada[6].Value = factura.CodigoLC;
                parametrosEntrada[7].Value = factura.NumeroDocRef;
                parametrosEntrada[8].Value = "";
                parametrosEntrada[9].Value = 1;
                parametrosEntrada[10].Value = usuario;

                string[] datosSalida = new string[1];

                objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_factura",
                    11, 12, out datosSalida, 1);

                if (datosSalida != null)
                {
                    factura.IdFactura = Convert.ToInt32(datosSalida[0]);
                }

            }

            return 1;
        }

        public int InsertarFactura(Factura factura, string usuario, int idLCAct, int idLCAnt, string codigoActCV)
        {

            MySqlDataReader reader;
            string sql = "";
            sql = "SELECT DISTINCT s.idSalida FROM salida s INNER JOIN salida_det d ON s.idSalida = d.idSalida WHERE d.guiaSalida = '" + factura.NumeroDocRef + "' and d.idLC in ( " + idLCAct + " , " + idLCAnt + " )" + " ;";
            reader = objManager.MostrarInformacion(sql);

            while (reader.Read())
            {
                factura.IdSalida = reader.GetInt32("idSalida");
            }

            objManager.conexion.Close();
            objManager.conexion.Dispose();
            objManager.cmd.Dispose();


            parametrosEntrada = new MySqlParameter[17];
            parametrosEntrada[0] = new MySqlParameter("@_idSalida", MySqlDbType.Int32);
            parametrosEntrada[1] = new MySqlParameter("@_numFactura", MySqlDbType.VarChar, 255);
            parametrosEntrada[2] = new MySqlParameter("@_fecIniPago", MySqlDbType.DateTime);
            parametrosEntrada[3] = new MySqlParameter("@_fecFinPago", MySqlDbType.DateTime);
            parametrosEntrada[4] = new MySqlParameter("@_fecEmisiom", MySqlDbType.DateTime);
            parametrosEntrada[5] = new MySqlParameter("@_ruc", MySqlDbType.VarChar, 11);
            parametrosEntrada[6] = new MySqlParameter("@_codigoLC", MySqlDbType.VarChar, 255);
            parametrosEntrada[7] = new MySqlParameter("@_guiaSalida", MySqlDbType.VarChar, 255);
            parametrosEntrada[8] = new MySqlParameter("@_totalSoles", MySqlDbType.Double);
            parametrosEntrada[9] = new MySqlParameter("@_totalDolares", MySqlDbType.Double);
            parametrosEntrada[10] = new MySqlParameter("@_costoSoles", MySqlDbType.Double);
            parametrosEntrada[11] = new MySqlParameter("@_costoDolares", MySqlDbType.Double);
            parametrosEntrada[12] = new MySqlParameter("@_tipoCambio", MySqlDbType.Double);
            parametrosEntrada[13] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 100);
            parametrosEntrada[14] = new MySqlParameter("@_estado", MySqlDbType.Int32);
            parametrosEntrada[15] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 100);
            parametrosEntrada[16] = new MySqlParameter("@_idFactura", MySqlDbType.Int32);

            parametrosEntrada[0].Value = factura.IdSalida;
            parametrosEntrada[1].Value = factura.NumeroFactura;
            parametrosEntrada[2].Value = factura.FechaIniPago;
            parametrosEntrada[3].Value = factura.FechaFinPago;
            parametrosEntrada[4].Value = factura.FechaPago;
            parametrosEntrada[5].Value = factura.RucDni;
            parametrosEntrada[6].Value = factura.CodigoLC;
            parametrosEntrada[7].Value = factura.NumeroDocRef;
            parametrosEntrada[8].Value = factura.TotalSoles;
            parametrosEntrada[9].Value = factura.TotalDolares;
            parametrosEntrada[10].Value = factura.CostoSoles;
            parametrosEntrada[11].Value = factura.CostoDolares;
            parametrosEntrada[12].Value = factura.TipoCambio;
            parametrosEntrada[13].Value = "";
            parametrosEntrada[14].Value = 1;
            parametrosEntrada[15].Value = usuario;

            string[] datosSalida = new string[1];

            objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_factura",
                16, 17, out datosSalida, 1);

            if (datosSalida != null)
            {
                factura.IdFactura = Convert.ToInt32(datosSalida[0]);
            }

            sql = "Select * from laptop_cpu where codigo='" + factura.CodigoLC + "' ;";
            reader = objManager.MostrarInformacion(sql);

            while (reader.Read())
            {
                factura.IdLC = reader.GetInt32("idLC");
            }

            objManager.conexion.Close();
            objManager.conexion.Dispose();
            objManager.cmd.Dispose();


            parametrosEntrada = new MySqlParameter[2];
            parametrosEntrada[0] = new MySqlParameter("@_idSalida", MySqlDbType.Int32);
            parametrosEntrada[1] = new MySqlParameter("@_idLC", MySqlDbType.Int32);

            parametrosEntrada[0].Value = factura.IdSalida;
            parametrosEntrada[1].Value = idLCAct;

            bool okey = objManager.EjecutarProcedure(parametrosEntrada, "delete_cuota");

            parametrosEntrada = new MySqlParameter[2];
            parametrosEntrada[0] = new MySqlParameter("@_idSalida", MySqlDbType.Int32);
            parametrosEntrada[1] = new MySqlParameter("@_idLC", MySqlDbType.Int32);

            parametrosEntrada[0].Value = factura.IdSalida;
            parametrosEntrada[1].Value = idLCAnt;

            okey = objManager.EjecutarProcedure(parametrosEntrada, "delete_cuota");


            parametrosEntrada = new MySqlParameter[17];
            parametrosEntrada[0] = new MySqlParameter("@_idFactura", MySqlDbType.Int32);
            parametrosEntrada[1] = new MySqlParameter("@_idSalida", MySqlDbType.Int32);
            parametrosEntrada[2] = new MySqlParameter("@_idLC", MySqlDbType.Int32);
            parametrosEntrada[3] = new MySqlParameter("@_numFactura", MySqlDbType.VarChar, 255);
            parametrosEntrada[4] = new MySqlParameter("@_fecInicioPago", MySqlDbType.DateTime);
            parametrosEntrada[5] = new MySqlParameter("@_fecFinPago", MySqlDbType.DateTime);
            parametrosEntrada[6] = new MySqlParameter("@_fecEmisiom", MySqlDbType.DateTime);
            parametrosEntrada[7] = new MySqlParameter("@_ruc", MySqlDbType.VarChar, 11);
            parametrosEntrada[8] = new MySqlParameter("@_codigoLC", MySqlDbType.VarChar, 255);
            parametrosEntrada[9] = new MySqlParameter("@_guiaSalida", MySqlDbType.VarChar, 255);
            parametrosEntrada[10] = new MySqlParameter("@_totalSoles", MySqlDbType.Double);
            parametrosEntrada[11] = new MySqlParameter("@_totalDolares", MySqlDbType.Double);
            parametrosEntrada[12] = new MySqlParameter("@_costoSoles", MySqlDbType.Double);
            parametrosEntrada[13] = new MySqlParameter("@_costoDolares", MySqlDbType.Double);
            parametrosEntrada[14] = new MySqlParameter("@_tipoCambio", MySqlDbType.Double);
            parametrosEntrada[15] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 100);
            parametrosEntrada[16] = new MySqlParameter("@_estado", MySqlDbType.Int32);

            parametrosEntrada[0].Value = factura.IdFactura;
            parametrosEntrada[1].Value = factura.IdSalida;
            parametrosEntrada[2].Value = idLCAct;
            parametrosEntrada[3].Value = factura.NumeroFactura;
            parametrosEntrada[4].Value = factura.FechaIniPago;
            parametrosEntrada[5].Value = factura.FechaFinPago;
            parametrosEntrada[6].Value = factura.FechaPago;
            parametrosEntrada[7].Value = factura.RucDni;
            parametrosEntrada[8].Value = codigoActCV;
            parametrosEntrada[9].Value = factura.NumeroDocRef;
            parametrosEntrada[10].Value = factura.TotalSoles;
            parametrosEntrada[11].Value = factura.TotalDolares;
            parametrosEntrada[12].Value = factura.CostoSoles;
            parametrosEntrada[13].Value = factura.CostoDolares;
            parametrosEntrada[14].Value = factura.TipoCambio;
            parametrosEntrada[15].Value = "";
            parametrosEntrada[16].Value = 1;

            okey = objManager.EjecutarProcedure(parametrosEntrada, "insert_cuota");


            //Esto se usa en sí en el modulo de facturas en transito
            if (factura.TipoFacturaTransito == 1)
            {
                parametrosEntrada = new MySqlParameter[3];
                parametrosEntrada[0] = new MySqlParameter("@_estado", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_idSalida", MySqlDbType.Int32);
                parametrosEntrada[2] = new MySqlParameter("@_idFacturaTransito", MySqlDbType.Int32);

                parametrosEntrada[0].Value = 14;
                parametrosEntrada[1].Value = factura.IdSalida;
                parametrosEntrada[2].Value = factura.IdFacturaTransito;

                objManager.EjecutarProcedure(parametrosEntrada, "update_facturaTransito");


                parametrosEntrada = new MySqlParameter[2];
                parametrosEntrada[0] = new MySqlParameter("@_idFacturaTransito", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_idFactura", MySqlDbType.Int32);

                parametrosEntrada[0].Value = factura.IdFacturaTransito;
                parametrosEntrada[1].Value = factura.IdFactura;

                objManager.EjecutarProcedure(parametrosEntrada, "update_facturaIdFacturaTransito");
            }


            return 1;
        }

        public void ActualizarPlazoFinal(Factura factura, string usuario, int IdSalidaDetActual, int IdSalidaDetAntigua)
        {
            factura.NumeroOC = factura.NumeroOC.Trim();
            factura.NumeroOC = (factura.NumeroOC.Length > 0) ? factura.NumeroOC : "";

            parametrosEntrada = new MySqlParameter[4];
            parametrosEntrada[0] = new MySqlParameter("@_idSalidaDet", MySqlDbType.Int32);
            parametrosEntrada[1] = new MySqlParameter("@_fecFinContrato", MySqlDbType.DateTime);
            parametrosEntrada[2] = new MySqlParameter("@_documentoRenovacion", MySqlDbType.VarChar, 255);
            parametrosEntrada[3] = new MySqlParameter("@_usuario_mod", MySqlDbType.VarChar, 100);

            parametrosEntrada[0].Value = IdSalidaDetActual;
            parametrosEntrada[1].Value = factura.FechaFinPago;
            parametrosEntrada[2].Value = factura.NumeroOC;
            parametrosEntrada[3].Value = usuario;
            bool okey = objManager.EjecutarProcedure(parametrosEntrada, "update_salida_det_fechaFinalPlazo");

            parametrosEntrada = new MySqlParameter[4];
            parametrosEntrada[0] = new MySqlParameter("@_idSalidaDet", MySqlDbType.Int32);
            parametrosEntrada[1] = new MySqlParameter("@_fecFinContrato", MySqlDbType.DateTime);
            parametrosEntrada[2] = new MySqlParameter("@_documentoRenovacion", MySqlDbType.VarChar, 255);
            parametrosEntrada[3] = new MySqlParameter("@_usuario_mod", MySqlDbType.VarChar, 100);

            parametrosEntrada[0].Value = IdSalidaDetAntigua;
            parametrosEntrada[1].Value = factura.FechaFinPago;
            parametrosEntrada[2].Value = factura.NumeroOC;
            parametrosEntrada[3].Value = usuario;
            okey = objManager.EjecutarProcedure(parametrosEntrada, "update_salida_det_fechaFinalPlazo");
        }

        public int RegistrarNC(BindingList<Factura> facturas, string usuario, int accion, DateTime FechaEmision, Double TipoCambio)
        {
            foreach (Factura f in facturas)
            {
                parametrosEntrada = new MySqlParameter[25];
                parametrosEntrada[0] = new MySqlParameter("@_idFactura", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_idSalida", MySqlDbType.Int32);
                parametrosEntrada[2] = new MySqlParameter("@_idTipoEquipo", MySqlDbType.Int32);
                parametrosEntrada[3] = new MySqlParameter("@_idEquipo", MySqlDbType.Int32);
                parametrosEntrada[4] = new MySqlParameter("@_codigo", MySqlDbType.VarChar, 255);
                parametrosEntrada[5] = new MySqlParameter("@_guiaSalida", MySqlDbType.VarChar, 255);
                parametrosEntrada[6] = new MySqlParameter("@_nroNotaCredito", MySqlDbType.VarChar, 255);
                parametrosEntrada[7] = new MySqlParameter("@_numFactura", MySqlDbType.VarChar, 255);
                parametrosEntrada[8] = new MySqlParameter("@_fecIniPagoActual", MySqlDbType.Date);
                parametrosEntrada[9] = new MySqlParameter("@_fecFinPagoActual", MySqlDbType.Date);
                parametrosEntrada[10] = new MySqlParameter("@_totalSolesActual", MySqlDbType.Decimal);
                parametrosEntrada[11] = new MySqlParameter("@_totalDolaresActual", MySqlDbType.Decimal);
                parametrosEntrada[12] = new MySqlParameter("@_costoSolesActual", MySqlDbType.Decimal);
                parametrosEntrada[13] = new MySqlParameter("@_costoDolaresActual", MySqlDbType.Decimal);
                parametrosEntrada[14] = new MySqlParameter("@_fecIniPagoAntiguo", MySqlDbType.Date);
                parametrosEntrada[15] = new MySqlParameter("@_fecFinPagoAntiguo", MySqlDbType.Date);
                parametrosEntrada[16] = new MySqlParameter("@_totalSolesAntiguo", MySqlDbType.Decimal);
                parametrosEntrada[17] = new MySqlParameter("@_totalDolaresAntiguo", MySqlDbType.Decimal);
                parametrosEntrada[18] = new MySqlParameter("@_costoSolesAntiguo", MySqlDbType.Decimal);
                parametrosEntrada[19] = new MySqlParameter("@_costoDolaresAntiguo", MySqlDbType.Decimal);
                parametrosEntrada[20] = new MySqlParameter("@_fecEmisiom", MySqlDbType.Date);
                parametrosEntrada[21] = new MySqlParameter("@_tipoCambio", MySqlDbType.Decimal);
                parametrosEntrada[22] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 1000);
                parametrosEntrada[23] = new MySqlParameter("@_usuario_mod", MySqlDbType.VarChar, 255);
                parametrosEntrada[24] = new MySqlParameter("@_idNotaCredito", MySqlDbType.Int32);

                parametrosEntrada[0].Value = f.IdFactura;
                parametrosEntrada[1].Value = f.IdSalida;
                parametrosEntrada[2].Value = 1;
                parametrosEntrada[3].Value = f.IdLC;
                parametrosEntrada[4].Value = f.Codigo;
                parametrosEntrada[5].Value = f.GuiaSalida;
                parametrosEntrada[6].Value = f.NroNotaCredito;
                parametrosEntrada[7].Value = f.NumeroFactura;
                parametrosEntrada[8].Value = f.FechaIniPago;
                parametrosEntrada[9].Value = f.FechaFinPago;
                parametrosEntrada[10].Value = f.TotalSoles;
                parametrosEntrada[11].Value = f.TotalDolares;
                parametrosEntrada[12].Value = f.CostoSoles;
                parametrosEntrada[13].Value = f.CostoDolares;
                parametrosEntrada[14].Value = f.FechaIniPagoAntiguo;
                parametrosEntrada[15].Value = f.FechaFinPagoAntiguo;
                parametrosEntrada[16].Value = f.TotalSolesAntiguo;
                parametrosEntrada[17].Value = f.TotalDolaresAntiguo;
                parametrosEntrada[18].Value = f.CostoSolesAntiguo;
                parametrosEntrada[19].Value = f.CostoDolaresAntiguo;
                parametrosEntrada[20].Value = FechaEmision;
                parametrosEntrada[21].Value = TipoCambio;
                parametrosEntrada[22].Value = f.ObservacionXLevantar;
                parametrosEntrada[23].Value = usuario;

                string[] datosSalida = new string[1];


                if (accion == 1)//ANULAR
                    objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "anular_factura",
                    24, 25, out datosSalida, 1);
                else if (accion == 2)//MODIFICAR
                    objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "update_factura",
                    24, 25, out datosSalida, 1);


                int idNotaCredito;

                if (datosSalida != null)
                    idNotaCredito = Convert.ToInt32(datosSalida[0]);
                else
                    return 0;
            }

            return 1;
        }

        public int InsertarFacturaTransito(Factura factura, string usuario)
        {

            MySqlDataReader reader;
            string sql = "";
            sql = "SELECT * FROM laptop_cpu  WHERE codigo = '" + factura.CodigoLC + "' ;";
            reader = objManager.MostrarInformacion(sql);

            while (reader.Read())
            {
                factura.IdLC = reader.GetInt32("idLC");
            }

            objManager.conexion.Close();
            objManager.conexion.Dispose();
            objManager.cmd.Dispose();


            parametrosEntrada = new MySqlParameter[21];
            parametrosEntrada[0] = new MySqlParameter("@_idSalida", MySqlDbType.Int32);
            parametrosEntrada[1] = new MySqlParameter("@_numFacturaTransito", MySqlDbType.VarChar, 255);
            parametrosEntrada[2] = new MySqlParameter("@_numeroOC", MySqlDbType.VarChar, 255);
            parametrosEntrada[3] = new MySqlParameter("@_fecIniPago", MySqlDbType.Date);
            parametrosEntrada[4] = new MySqlParameter("@_fecFinPago", MySqlDbType.Date);
            parametrosEntrada[5] = new MySqlParameter("@_fecEmisiom", MySqlDbType.Date);
            parametrosEntrada[6] = new MySqlParameter("@_ruc", MySqlDbType.VarChar, 11);
            parametrosEntrada[7] = new MySqlParameter("@_razonSocial", MySqlDbType.VarChar, 1000);
            parametrosEntrada[8] = new MySqlParameter("@_idEquipo", MySqlDbType.Int32);
            parametrosEntrada[9] = new MySqlParameter("@_codigoEquipo", MySqlDbType.VarChar, 255);
            parametrosEntrada[10] = new MySqlParameter("@_guiaSalida", MySqlDbType.VarChar, 255);
            parametrosEntrada[11] = new MySqlParameter("@_cantidadEquipos", MySqlDbType.Int32);
            parametrosEntrada[12] = new MySqlParameter("@_totalSoles", MySqlDbType.Double);
            parametrosEntrada[13] = new MySqlParameter("@_totalDolares", MySqlDbType.Double);
            parametrosEntrada[14] = new MySqlParameter("@_costoSoles", MySqlDbType.Double);
            parametrosEntrada[15] = new MySqlParameter("@_costoDolares", MySqlDbType.Double);
            parametrosEntrada[16] = new MySqlParameter("@_tipoCambio", MySqlDbType.Double);
            parametrosEntrada[17] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 255);
            parametrosEntrada[18] = new MySqlParameter("@_estado", MySqlDbType.Int32);
            parametrosEntrada[19] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 255);
            parametrosEntrada[20] = new MySqlParameter("@_idFacturaTransito", MySqlDbType.Int32);

            parametrosEntrada[0].Value = factura.IdSalida;
            parametrosEntrada[1].Value = factura.NumeroFactura;
            parametrosEntrada[2].Value = factura.NumeroOC;

            if (factura.FechaIniPago.ToString() == "1/01/1900 00:00:00")
                parametrosEntrada[3].Value = null;
            else
                parametrosEntrada[3].Value = factura.FechaIniPago;

            if (factura.FechaFinPago.ToString() == "1/01/1900 00:00:00")
                parametrosEntrada[4].Value = null;
            else
                parametrosEntrada[4].Value = factura.FechaFinPago;

            parametrosEntrada[5].Value = factura.FechaPago;
            parametrosEntrada[6].Value = factura.RucDni;
            parametrosEntrada[7].Value = factura.RazonSocial;
            parametrosEntrada[8].Value = factura.IdLC;
            parametrosEntrada[9].Value = factura.CodigoLC;
            parametrosEntrada[10].Value = factura.NumeroDocRef;
            parametrosEntrada[11].Value = factura.CantidadEquipos;
            parametrosEntrada[12].Value = factura.TotalSoles;
            parametrosEntrada[13].Value = factura.TotalDolares;
            parametrosEntrada[14].Value = factura.CostoSoles;
            parametrosEntrada[15].Value = factura.CostoDolares;
            parametrosEntrada[16].Value = factura.TipoCambio;
            parametrosEntrada[17].Value = "";
            parametrosEntrada[18].Value = 1;
            parametrosEntrada[19].Value = usuario;

            string[] datosSalida = new string[1];

            objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_facturaTransito",
                20, 21, out datosSalida, 1);

            if (datosSalida != null)
            {
                factura.IdFactura = Convert.ToInt32(datosSalida[0]);
            }

            return 1;
        }



    }
}
