using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CorteAlquilerDA
    {
        DBManager objManager;
        MySqlParameter[] parametrosEntrada = null;
        private int idSalidaTipo=4;
        private string nombreSalidaTipo= "CORTE ALQUILER";

        private string motivoCambio = "CAMBIO RAZÓN SOCIAL";
        private string motivoDevolucion = "DEVOLUCIÓN";
        private string motivoVenta = "VENTA";

        public CorteAlquilerDA()
        {
            objManager = new DBManager();
        }

        public DataTable ObtenerArea(int idUsuario)
        {
            return objManager.MostrarTablaDatos("Select * From usuario where idUsuario=" + idUsuario + " ;");
        }

        public DataTable ListarLaptopsClientesEstadoAlquilado(int idCliente)
        {
            return objManager.MostrarTablaDatos("Select * From vista_laptops_detalle_alquiler_plazo_alquiler where idCliente=" + idCliente + " ;");
        }


        public DataTable ListarSalidasTipo()
        {
            return objManager.MostrarTablaDatos("Select * From vista_salida_tipo ;");
        }

        public int InsertarRenovaciones(BindingList<CorteAlquiler> renovaciones, string usuario, string documentoReferencia, int IdCliente)
        {
            bool error = false;

            foreach (CorteAlquiler renovacion in renovaciones)
            {
                parametrosEntrada = new MySqlParameter[8];
                parametrosEntrada[0] = new MySqlParameter("@_idSalidaDet", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_fecIniContrato", MySqlDbType.DateTime);
                parametrosEntrada[2] = new MySqlParameter("@_fecFinContrato", MySqlDbType.DateTime);
                parametrosEntrada[3] = new MySqlParameter("@_idSalidaTipo", MySqlDbType.Int32);
                parametrosEntrada[4] = new MySqlParameter("@_nombreSalidaTipo", MySqlDbType.VarChar, 255);
                parametrosEntrada[5] = new MySqlParameter("@_documentoRenovacion", MySqlDbType.VarChar, 255);
                parametrosEntrada[6] = new MySqlParameter("@_usuario_mod", MySqlDbType.VarChar, 100);
                parametrosEntrada[7] = new MySqlParameter("@_corteAlquiler", MySqlDbType.Int32);

                parametrosEntrada[0].Value = renovacion.IdSalidaDetalle;
                parametrosEntrada[1].Value = renovacion.FechaIniContrato;
                parametrosEntrada[2].Value = renovacion.FechaFinContrato;
                parametrosEntrada[3].Value = idSalidaTipo;
                parametrosEntrada[4].Value = nombreSalidaTipo;
                parametrosEntrada[5].Value = documentoReferencia;
                parametrosEntrada[6].Value = usuario;
                parametrosEntrada[7].Value = 1;//corteAlquiler 1 significa que ya se pidio el corte de alquiler y ya no se renovará automaticamente más la fecha
                bool okey = objManager.EjecutarProcedure(parametrosEntrada, "update_salida_det_corte_alquiler");
                if (!okey) return 0;


                parametrosEntrada = new MySqlParameter[13];
                parametrosEntrada[0] = new MySqlParameter("@_idSalida", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_idSalidaDet", MySqlDbType.Int32);
                parametrosEntrada[2] = new MySqlParameter("@_idLC", MySqlDbType.Int32);
                parametrosEntrada[3] = new MySqlParameter("@_guiaSalida", MySqlDbType.VarChar, 255);
                parametrosEntrada[4] = new MySqlParameter("@_fecIniContratoAnt", MySqlDbType.Date);
                parametrosEntrada[5] = new MySqlParameter("@_fecFinContratoAnt", MySqlDbType.Date);
                parametrosEntrada[6] = new MySqlParameter("@_fecIniContratoNew", MySqlDbType.Date);
                parametrosEntrada[7] = new MySqlParameter("@_fecFinContratoNew", MySqlDbType.Date);
                parametrosEntrada[8] = new MySqlParameter("@_idSalidaTipo", MySqlDbType.Int32);
                parametrosEntrada[9] = new MySqlParameter("@_nombreSalidaTipo", MySqlDbType.VarChar, 255);
                parametrosEntrada[10] = new MySqlParameter("@_documentoSalidaTipo", MySqlDbType.VarChar, 255);
                parametrosEntrada[11] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 100);
                parametrosEntrada[12] = new MySqlParameter("@_idRenovacion", MySqlDbType.Int32);

                parametrosEntrada[0].Value = renovacion.IdSalida;
                parametrosEntrada[1].Value = renovacion.IdSalidaDetalle;
                parametrosEntrada[2].Value = renovacion.IdLC;
                parametrosEntrada[3].Value = renovacion.GuiaSalida;
                parametrosEntrada[4].Value = renovacion.FechaIniContratoAntiguo;
                parametrosEntrada[5].Value = renovacion.FechaFinContratoAntiguo;
                parametrosEntrada[6].Value = renovacion.FechaIniContrato;
                parametrosEntrada[7].Value = renovacion.FechaFinContrato;
                parametrosEntrada[8].Value = idSalidaTipo;
                parametrosEntrada[9].Value = nombreSalidaTipo;
                parametrosEntrada[10].Value = documentoReferencia;
                parametrosEntrada[11].Value = usuario;

                string[] datosSalida = new string[1];
                objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_log_renovaciones",
                    12, 13, out datosSalida, 1);

                if (datosSalida != null)
                {
                    int idSalidaDet = Convert.ToInt32(datosSalida[0]);
                    error = true;
                }
                else
                {
                    return 0;
                }



                parametrosEntrada = new MySqlParameter[21];
                parametrosEntrada[0] = new MySqlParameter("@_idSalida", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_idSalidaDet", MySqlDbType.Int32);
                parametrosEntrada[2] = new MySqlParameter("@_idTipoEquipo", MySqlDbType.Int32);
                parametrosEntrada[3] = new MySqlParameter("@_idEquipo", MySqlDbType.Int32);
                parametrosEntrada[4] = new MySqlParameter("@_idCliente", MySqlDbType.Int32);
                parametrosEntrada[5] = new MySqlParameter("@_codigoEquipo", MySqlDbType.VarChar, 255);
                parametrosEntrada[6] = new MySqlParameter("@_codigoEquipoAntiguo", MySqlDbType.VarChar, 255);
                parametrosEntrada[7] = new MySqlParameter("@_guiaSalida", MySqlDbType.VarChar, 255);
                parametrosEntrada[8] = new MySqlParameter("@_fecIniContratoAnt", MySqlDbType.Date);
                parametrosEntrada[9] = new MySqlParameter("@_fecFinContratoAnt", MySqlDbType.Date);
                parametrosEntrada[10] = new MySqlParameter("@_fecIniContratoNew", MySqlDbType.Date);
                parametrosEntrada[11] = new MySqlParameter("@_fecFinContratoNew", MySqlDbType.Date);
                parametrosEntrada[12] = new MySqlParameter("@_documentoReferencia", MySqlDbType.VarChar, 500);
                parametrosEntrada[13] = new MySqlParameter("@_motivoCorte", MySqlDbType.VarChar, 255);
                parametrosEntrada[14] = new MySqlParameter("@_fecRecojo", MySqlDbType.Date);
                parametrosEntrada[15] = new MySqlParameter("@_direccionRecojo", MySqlDbType.VarChar, 1000);
                parametrosEntrada[16] = new MySqlParameter("@_personaContacto", MySqlDbType.VarChar, 500);
                parametrosEntrada[17] = new MySqlParameter("@_telefono", MySqlDbType.VarChar, 255);
                parametrosEntrada[18] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 3000);
                parametrosEntrada[19] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 100);
                parametrosEntrada[20] = new MySqlParameter("@_idCorteAlquiler", MySqlDbType.Int32);

                parametrosEntrada[0].Value = renovacion.IdSalida;
                parametrosEntrada[1].Value = renovacion.IdSalidaDetalle;
                parametrosEntrada[2].Value = 1;
                parametrosEntrada[3].Value = renovacion.IdLC;
                parametrosEntrada[4].Value = IdCliente;
                parametrosEntrada[5].Value = renovacion.CodigoLC;
                parametrosEntrada[6].Value = renovacion.CodigoAntiguo;
                parametrosEntrada[7].Value = renovacion.GuiaSalida;
                parametrosEntrada[8].Value = renovacion.FechaIniContratoAntiguo;
                parametrosEntrada[9].Value = renovacion.FechaFinContratoAntiguo;
                parametrosEntrada[10].Value = renovacion.FechaIniContrato;
                parametrosEntrada[11].Value = renovacion.FechaFinContrato;
                parametrosEntrada[12].Value = documentoReferencia;
                parametrosEntrada[13].Value = renovacion.DescripcionMotivoCorte;
                if (renovacion.DescripcionMotivoCorte == motivoDevolucion)
                {
                    parametrosEntrada[14].Value = renovacion.FechaRecojo;
                    parametrosEntrada[15].Value = renovacion.Direccion;
                    parametrosEntrada[16].Value = renovacion.PersonaContacto;
                    parametrosEntrada[17].Value = renovacion.Telefono;
                }
                else
                {
                    parametrosEntrada[14].Value = null;
                    parametrosEntrada[15].Value = null;
                    parametrosEntrada[16].Value = null;
                    parametrosEntrada[17].Value = null;
                }
                parametrosEntrada[18].Value = renovacion.Observacion;
                parametrosEntrada[19].Value = usuario;

                datosSalida = new string[1];
                objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_corte_alquiler",
                    20, 21, out datosSalida, 1);

                if (datosSalida != null)
                {
                    int idSalidaDet = Convert.ToInt32(datosSalida[0]);
                    error = true;
                }
                else
                {
                    return 0;
                }
            }

            return 1;

        }


        public int ActualizarFechaFinContrato(BindingList<CorteAlquiler> cortes)
        {
            int resultado = 0; // 1: bien 0:mal
            foreach (CorteAlquiler corte in cortes)
            {
                parametrosEntrada = new MySqlParameter[4];
                parametrosEntrada[0] = new MySqlParameter("@_IdSalidaDet", MySqlDbType.VarChar, 255);
                parametrosEntrada[1] = new MySqlParameter("@_Codigo", MySqlDbType.VarChar, 255);
                parametrosEntrada[2] = new MySqlParameter("@_Ruc", MySqlDbType.VarChar, 255);
                parametrosEntrada[3] = new MySqlParameter("@_GuiaSalida", MySqlDbType.VarChar, 255);

                parametrosEntrada[0].Value = corte.IdSalidaDetalle;
                parametrosEntrada[1].Value = corte.CodigoLC;
                parametrosEntrada[2].Value = corte.RucCliente1;
                parametrosEntrada[3].Value = corte.GuiaSalida;
                
                bool okey = objManager.EjecutarProcedure(parametrosEntrada, "TEST_ACTUALIZAR_FECHAFINCONTRATO");

                if (okey)
                {
                    resultado = 1;
                }
            }

            return resultado;

        }


        public int AnularCorte(int idCorte, string usuario)
        {
            int resultado = 0; // 1: bien 0:mal
            parametrosEntrada = new MySqlParameter[3];
            parametrosEntrada[0] = new MySqlParameter("@_idCorteAlquiler", MySqlDbType.Int32);
            parametrosEntrada[1] = new MySqlParameter("@_estado", MySqlDbType.Int32);
            parametrosEntrada[2] = new MySqlParameter("@_usuario_mod", MySqlDbType.VarChar, 255);

            parametrosEntrada[0].Value = idCorte;
            parametrosEntrada[1].Value = 0;
            parametrosEntrada[2].Value = usuario;

            bool okey = objManager.EjecutarProcedure(parametrosEntrada, "cancel_corte_alquiler");

            if (okey)
            {
                resultado = 1;
            }

            return resultado;

        }
    }
}
