using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace AccesoDatos
{
    public class DBManager
    {
        //string conex = "User Id=custom;password=h1808;server=" + servidor + ";database=" + basedatos + ";Convert Zero Datetime=True;persist security info=True;use procedure bodies=False;Connection Timeout=9000000 ; pooling=true; Max Pool Size=900000";

        //public static string cadena = "server=quilla.lab.inf.pucp.edu.pe; user=inf282g2; password=UInag9; database=inf282g2; SslMode=None";

        //public static string cadena = "server=localhost; user=root; password=; database=bd_leasein; SslMode=None;Connect Timeout=tiempo00";

        //public static MySqlConnection conexion = null;

        public static string servidor = ConfigurationManager.AppSettings["ServidorMySql"].ToString();
        public static string basedatos = ConfigurationManager.AppSettings["BaseDatosMySql"].ToString();

        //public static string cadena = "server="+ servidor + "; user=root; password=; database="+ basedatos + "; SslMode=None;Connect Timeout=9000";
        //public static string cadena = "server=" + "localhost" + "; user=root; password=root; database=" + "bd_leasein" + "; SslMode=None;Connect Timeout=9000";
        public static string cadena = "server=" + "209.45.53.41" + "; user=root; password=root; database=" + "bd_leasein" + "; SslMode=None;Connect Timeout=9000";

        public int tiempo =5000;
        public MySqlConnection conexion = null;
        public MySqlCommand cmd = null;
        private MySqlDataAdapter adaptador = null;
        private DataTable tabla = null;
        private MySqlDataReader leer = null;

        public bool EjecutarProcedure(MySqlParameter[] parametrosEntrada, string nombProcedimiento)
        {
            try
            {
                conexion = new MySqlConnection(cadena);
                conexion.Open();
                cmd = new MySqlCommand(nombProcedimiento, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = tiempo;
                cmd.Parameters.AddRange(parametrosEntrada);
                cmd.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            finally
            {
                conexion.Dispose();
                cmd.Dispose();
            }
        }

        public void EjecutarProcedureConDatosDevueltos(MySqlParameter[] parametrosEntrada, string nombProcedimiento,
            int index, int n, out string[] datosSalida, int m)
        {
            datosSalida = null;
            if (m == 0) return; //Cantidad de datos a devolver
            try
            {
                conexion = new MySqlConnection(cadena);
                conexion.Open();
                cmd = new MySqlCommand(nombProcedimiento, conexion);
                cmd.CommandTimeout = tiempo;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parametrosEntrada);
                for (int i = index; i < n; i++)
                {
                    cmd.Parameters[parametrosEntrada[i].ParameterName].Direction = ParameterDirection.Output;
                }
                cmd.ExecuteNonQuery();
                conexion.Close();
                datosSalida = new string[m];
                for (int i = 0, j = index; j < n; i++, j++)
                {
                    datosSalida[i] = parametrosEntrada[j].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            finally
            {
                conexion.Dispose();
                cmd.Dispose();
            }
        }

        public bool EjecutarProcedureDatosSalida(ref MySqlParameter[] parametros, string nombProcedimiento,
            int index)
        {
            int n = parametros.Length;
            if (index < 0) return false; //Cantidad de datos a devolver
            try
            {
                conexion = new MySqlConnection(cadena);
                conexion.Open();
                cmd = new MySqlCommand(nombProcedimiento, conexion);
                cmd.CommandTimeout = tiempo;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parametros);
                for (int i = index; i < n; i++)
                {
                    cmd.Parameters[parametros[i].ParameterName].Direction = ParameterDirection.Output;
                }
                cmd.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            finally
            {
                conexion.Dispose();
                cmd.Dispose();
            }
        }

        public DataTable MostrarTablaDatos(string comando) //SELECT * FROM TABLA
        {
            try
            {
                //conexion = new MySqlConnection(cadena);
                //conexion.Open();
                //tabla = new DataTable();
                //adaptador = new MySqlDataAdapter(comando, conexion);
                //adaptador.Fill(tabla);
                //conexion.Close();
                //return tabla;
                conexion = new MySqlConnection(cadena);
                conexion.Open();
                cmd = new MySqlCommand(comando, conexion);
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = tiempo;
                //cmd.ExecuteReader();  
                tabla = new DataTable();
                adaptador = new MySqlDataAdapter(cmd);
                adaptador.Fill(tabla);
                conexion.Close();
                return tabla;
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                MessageBox.Show(ex.Message, "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return null;
            }
            finally
            {
                conexion.Dispose();
                //adaptador.Dispose();
            }
        }

        public MySqlDataReader MostrarInformacion(string datos)
        {
            try
            {
                conexion = new MySqlConnection(cadena);
                conexion.Open();
                cmd = new MySqlCommand(datos, conexion);
                cmd.CommandTimeout = tiempo;
                leer = cmd.ExecuteReader();
                //conexion.Close();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return null;
            }
            finally
            {
                //conexion.Dispose();
                //cmd.Dispose();
            }
        }

        public DataTable MostrarTablaDatos(MySqlParameter[] parametrosEntrada, string nombProcedimiento)
        {
            try
            {
                conexion = new MySqlConnection(cadena);
                conexion.Open();
                cmd = new MySqlCommand(nombProcedimiento, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                if (parametrosEntrada != null)
                    cmd.Parameters.AddRange(parametrosEntrada);
                cmd.CommandTimeout = tiempo;
                cmd.ExecuteNonQuery();
                tabla = new DataTable();
                adaptador = new MySqlDataAdapter(cmd);
                adaptador.Fill(tabla);
                conexion.Close();
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return tabla;
            }
            finally
            {
                conexion.Dispose();
                cmd.Dispose();
                adaptador.Dispose();
            }
        }
        public bool EjecutarNonQuery(string sql)
        {
            try
            {
                conexion = new MySqlConnection(cadena);
                conexion.Open();
                cmd = new MySqlCommand(sql, conexion);
                cmd.CommandTimeout = tiempo;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "◄ AVISO | LEASEIN ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            finally
            {
            }
        }
    }
}
