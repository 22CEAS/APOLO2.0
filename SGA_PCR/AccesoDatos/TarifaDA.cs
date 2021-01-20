﻿using System;
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
    public class TarifaDA
    {
        DBManager objManager;
        MySqlParameter[] parametrosEntrada = null;

        public TarifaDA()
        {
            objManager = new DBManager();
        }


        public int SubirTarifas(string ruc,string codigo,double tarifa,int idSalidaDet, int idSalida,string guia)
        {

            parametrosEntrada = new MySqlParameter[6];
            parametrosEntrada[0] = new MySqlParameter("@_ruc", MySqlDbType.VarChar, 200);
            parametrosEntrada[1] = new MySqlParameter("@_codigo", MySqlDbType.VarChar, 200);
            parametrosEntrada[2] = new MySqlParameter("@_tarifa", MySqlDbType.Double);
            parametrosEntrada[3] = new MySqlParameter("@_idSalidaDet", MySqlDbType.Int32);
            parametrosEntrada[4] = new MySqlParameter("@_idSalida", MySqlDbType.Int32);
            parametrosEntrada[5] = new MySqlParameter("@_guia", MySqlDbType.VarChar, 200);

            parametrosEntrada[0].Value = ruc;
            parametrosEntrada[1].Value = codigo;
            parametrosEntrada[2].Value = tarifa;
            parametrosEntrada[3].Value = idSalidaDet;
            parametrosEntrada[4].Value = idSalida;
            parametrosEntrada[5].Value = guia;


            bool aux = objManager.EjecutarProcedure(parametrosEntrada, "insertTarifas");
            return ((aux) ? 1 : -1);

        }

    }
}
