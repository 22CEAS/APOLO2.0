﻿using Modelo;
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
    public class CambioRazonSocialDA
    {
        DBManager objManager;
        MySqlParameter[] parametrosEntrada = null;

        public CambioRazonSocialDA()
        {
            objManager = new DBManager();
        }

        public DataTable ListarLaptopsClientesEstadoAlquilado(int idCliente)
        {
            return objManager.MostrarTablaDatos("Select * From vista_equipos_en_alquiler where IdCliente=" + idCliente + " ;");
        }


        public int InsertarCambioRazonSocial(BindingList<CambioRazonSocial> cambios, int IdClienteActual, int IdClienteNuevo, int IdClienteSucursal, string NumeroDniRucActual, string NumeroDniRucNuevo, string usuario)
        {
            bool error = false;

            //foreach (CambioRazonSocial cambio in cambios)
            //{
            //    parametrosEntrada = new MySqlParameter[8];
            //    parametrosEntrada[0] = new MySqlParameter("@_idSalidaDet", MySqlDbType.Int32);
            //    parametrosEntrada[1] = new MySqlParameter("@_fecIniContrato", MySqlDbType.DateTime);
            //    parametrosEntrada[2] = new MySqlParameter("@_fecFinContrato", MySqlDbType.DateTime);
            //    parametrosEntrada[3] = new MySqlParameter("@_idSalidaTipo", MySqlDbType.Int32);
            //    parametrosEntrada[4] = new MySqlParameter("@_nombreSalidaTipo", MySqlDbType.VarChar, 255);
            //    parametrosEntrada[5] = new MySqlParameter("@_documentoRenovacion", MySqlDbType.VarChar, 255);
            //    parametrosEntrada[6] = new MySqlParameter("@_usuario_mod", MySqlDbType.VarChar, 100);
            //    parametrosEntrada[7] = new MySqlParameter("@_corteAlquiler", MySqlDbType.Int32);

            //    parametrosEntrada[0].Value = renovacion.IdSalidaDetalle;
            //    parametrosEntrada[1].Value = renovacion.FechaIniContrato;
            //    parametrosEntrada[2].Value = renovacion.FechaFinContrato;
            //    parametrosEntrada[3].Value = idSalidaTipo;
            //    parametrosEntrada[4].Value = nombreSalidaTipo;
            //    parametrosEntrada[5].Value = documentoReferencia;
            //    parametrosEntrada[6].Value = usuario;
            //    parametrosEntrada[7].Value = 1;//corteAlquiler 1 significa que ya se pidio el corte de alquiler y ya no se renovará automaticamente más la fecha
            //    bool okey = objManager.EjecutarProcedure(parametrosEntrada, "update_salida_det_corte_alquiler");
            //    if (!okey) return 0;


            //    parametrosEntrada = new MySqlParameter[13];
            //    parametrosEntrada[0] = new MySqlParameter("@_idSalida", MySqlDbType.Int32);
            //    parametrosEntrada[1] = new MySqlParameter("@_idSalidaDet", MySqlDbType.Int32);
            //    parametrosEntrada[2] = new MySqlParameter("@_idLC", MySqlDbType.Int32);
            //    parametrosEntrada[3] = new MySqlParameter("@_guiaSalida", MySqlDbType.VarChar, 255);
            //    parametrosEntrada[4] = new MySqlParameter("@_fecIniContratoAnt", MySqlDbType.Date);
            //    parametrosEntrada[5] = new MySqlParameter("@_fecFinContratoAnt", MySqlDbType.Date);
            //    parametrosEntrada[6] = new MySqlParameter("@_fecIniContratoNew", MySqlDbType.Date);
            //    parametrosEntrada[7] = new MySqlParameter("@_fecFinContratoNew", MySqlDbType.Date);
            //    parametrosEntrada[8] = new MySqlParameter("@_idSalidaTipo", MySqlDbType.Int32);
            //    parametrosEntrada[9] = new MySqlParameter("@_nombreSalidaTipo", MySqlDbType.VarChar, 255);
            //    parametrosEntrada[10] = new MySqlParameter("@_documentoSalidaTipo", MySqlDbType.VarChar, 255);
            //    parametrosEntrada[11] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 100);
            //    parametrosEntrada[12] = new MySqlParameter("@_idRenovacion", MySqlDbType.Int32);

            //    parametrosEntrada[0].Value = renovacion.IdSalida;
            //    parametrosEntrada[1].Value = renovacion.IdSalidaDetalle;
            //    parametrosEntrada[2].Value = renovacion.IdLC;
            //    parametrosEntrada[3].Value = renovacion.GuiaSalida;
            //    parametrosEntrada[4].Value = renovacion.FechaIniContratoAntiguo;
            //    parametrosEntrada[5].Value = renovacion.FechaFinContratoAntiguo;
            //    parametrosEntrada[6].Value = renovacion.FechaIniContrato;
            //    parametrosEntrada[7].Value = renovacion.FechaFinContrato;
            //    parametrosEntrada[8].Value = idSalidaTipo;
            //    parametrosEntrada[9].Value = nombreSalidaTipo;
            //    parametrosEntrada[10].Value = documentoReferencia;
            //    parametrosEntrada[11].Value = usuario;

            //    string[] datosSalida = new string[1];
            //    objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_log_renovaciones",
            //        12, 13, out datosSalida, 1);

            //    if (datosSalida != null)
            //    {
            //        int idSalidaDet = Convert.ToInt32(datosSalida[0]);
            //        error = true;
            //    }
            //    else
            //    {
            //        return 0;
            //    }

            //}

            return 1;

        }
    }
}