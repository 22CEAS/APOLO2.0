﻿using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ClienteDA
    {
        DBManager objManager;
        MySqlParameter[] parametrosEntrada = null;
        public ClienteDA()
        {
            objManager = new DBManager();
        }
        public DataTable ListarClientes()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_maestro_Cliente ;");
        }
        public DataTable ListarClientesKAM()
        {
            return objManager.MostrarTablaDatos("select c.nombre_razonSocial, IF(u.estado=1, u.nombre, '') as nombre from cliente c inner join usuario u on c.idKAM = u.idUsuario ");
        }
        public DataTable ListarKamEncargado(int idCliente)
        {
            return objManager.MostrarTablaDatos($"SELECT u.idUsuario,u.nombre FROM cliente c INNER JOIN usuario u on c.idKAM = u.idUsuario where idCliente = {idCliente}; ");
        }
        public DataTable ListarTipoDocumento()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_documento_tipo ;");
        }
        public DataTable ListarContactoTipo()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_contacto_tipo ;");
        }
        public DataTable ListarKams()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_KAM_activos ;");
        }
        public DataTable ListarSucursalCliente(int idCliente)
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_maestro_Sucursal_Cliente where idCliente="+idCliente+" ;");
        }
        public DataTable ListarContactoCliente(int idCliente)
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_maestro_Contacto_Cliente where IdCliente=" + idCliente + " ;");
        }
        public int GuardarNuevoCliente(Cliente cliente, string usuario)
        {
            parametrosEntrada = new MySqlParameter[9];
            parametrosEntrada[0] = new MySqlParameter("@_tipoDocumento", MySqlDbType.Int32);
            parametrosEntrada[1] = new MySqlParameter("@_nroDocumento", MySqlDbType.VarChar, 20);
            parametrosEntrada[2] = new MySqlParameter("@_nombre_razonSocial", MySqlDbType.VarChar, 255);
            parametrosEntrada[3] = new MySqlParameter("@_telefono", MySqlDbType.VarChar, 20);
            parametrosEntrada[4] = new MySqlParameter("@_email", MySqlDbType.VarChar, 255);
            parametrosEntrada[5] = new MySqlParameter("@_idKAM", MySqlDbType.Int32);
            parametrosEntrada[6] = new MySqlParameter("@_nombreKam", MySqlDbType.VarChar, 255);
            parametrosEntrada[7] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 100);
            parametrosEntrada[8] = new MySqlParameter("@_idCliente", MySqlDbType.Int32);

            parametrosEntrada[0].Value = cliente.TipoDocumento;
            parametrosEntrada[1].Value = cliente.NroDocumento;
            parametrosEntrada[2].Value = cliente.Nombre_razonSocial;
            parametrosEntrada[3].Value = cliente.Telefono;
            parametrosEntrada[4].Value = cliente.Email;
            parametrosEntrada[5].Value = cliente.Kam.IdUsuario;
            parametrosEntrada[6].Value = cliente.Kam.Nombre;
            parametrosEntrada[7].Value = usuario;

            string[] datosSalida = new string[1];

            objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_cliente",
                8, 9, out datosSalida, 1);

            if (datosSalida != null)
            {
                int idCliente = Convert.ToInt32(datosSalida[0]);
                return idCliente;
            }
            return -1;
            
        }
        public int RelacionKAM(string cliente, int idKam)
        {

            parametrosEntrada = new MySqlParameter[2];
            parametrosEntrada[0] = new MySqlParameter("@_Nombre_razonSocial", MySqlDbType.VarChar, 200);
            parametrosEntrada[1] = new MySqlParameter("@_idKam", MySqlDbType.Int32);

            parametrosEntrada[0].Value = cliente;
            parametrosEntrada[1].Value = idKam;


            bool aux = objManager.EjecutarProcedure(parametrosEntrada, "relacion_KAM");
            return ((aux) ? 1 : -1);

        }
        public int RelacionKAMmasivo(string ruc, string razonSocial, string dniKam,string nombreKam)
        {

            //! PRIMERO VERIFICAR QUE EL CLIENTE EXISTE
            parametrosEntrada = new MySqlParameter[2];
            parametrosEntrada[0] = new MySqlParameter("@_rucCliente", MySqlDbType.VarChar, 200);
            parametrosEntrada[1] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);

            parametrosEntrada[0].Value = ruc;
            
            string[] cantidadRucCliente = new string[1];

            objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "VerificarRucCliente",
                1, 2, out cantidadRucCliente, 1);

            if (cantidadRucCliente != null)
            {
                int existeCliente = Convert.ToInt32(cantidadRucCliente[0]);
                if (existeCliente == 1)
                {
                    //TODO OK -> seguir con la verificacion
                }
                else 
                {
                    return 3; //NO EXISTE
                }    
            }

            //! SEGUNDO VERIFICAR QUE EL KAM EXISTE
            parametrosEntrada = new MySqlParameter[2];
            parametrosEntrada[0] = new MySqlParameter("@_dniKam", MySqlDbType.VarChar, 200);
            parametrosEntrada[1] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);

            parametrosEntrada[0].Value = dniKam;

            string[] cantidadKam = new string[1];

            objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "VerificarDniKam",
                1, 2, out cantidadKam, 1);

            if (cantidadKam != null)
            {
                int existeKam = Convert.ToInt32(cantidadKam[0]);
                if (existeKam == 1)
                {
                    //TODO OK -> seguir con la verificacion
                }
                else
                {
                    return 5; //NO EXISTE
                }
            }




            //SI EN CASO EXISTA SE PROCEDE A LA RELACION
            parametrosEntrada = new MySqlParameter[4];
            parametrosEntrada[0] = new MySqlParameter("@_rucCliente", MySqlDbType.VarChar, 200);
            parametrosEntrada[1] = new MySqlParameter("@_razonSocialCliente", MySqlDbType.VarChar, 200);
            parametrosEntrada[2] = new MySqlParameter("@_dniKam", MySqlDbType.VarChar, 200);
            parametrosEntrada[3] = new MySqlParameter("@_nombreKam", MySqlDbType.VarChar, 200);

            parametrosEntrada[0].Value = ruc;
            parametrosEntrada[1].Value = razonSocial;
            parametrosEntrada[2].Value = dniKam;
            parametrosEntrada[3].Value = nombreKam;


            bool aux = objManager.EjecutarProcedure(parametrosEntrada, "relacionarKAMmasivo");
            return ((aux) ? 1 : -1);

        }
        public int ModificarCliente(Cliente cliente, string usuario)
        {
            
            parametrosEntrada = new MySqlParameter[10];
            parametrosEntrada[0] = new MySqlParameter("@_idCliente", MySqlDbType.Int32);
            parametrosEntrada[1] = new MySqlParameter("@_tipoDocumento", MySqlDbType.Int32);
            parametrosEntrada[2] = new MySqlParameter("@_nroDocumento", MySqlDbType.VarChar, 20);
            parametrosEntrada[3] = new MySqlParameter("@_nombre_razonSocial", MySqlDbType.VarChar, 255);
            parametrosEntrada[4] = new MySqlParameter("@_telefono", MySqlDbType.VarChar, 20);
            parametrosEntrada[5] = new MySqlParameter("@_email", MySqlDbType.VarChar, 255);
            parametrosEntrada[6] = new MySqlParameter("@_idKAM", MySqlDbType.Int32);
            parametrosEntrada[7] = new MySqlParameter("@_nombreKam", MySqlDbType.VarChar, 255);
            parametrosEntrada[8] = new MySqlParameter("@_estado", MySqlDbType.Int32);
            parametrosEntrada[9] = new MySqlParameter("@_usuario_mod", MySqlDbType.VarChar, 100);

            parametrosEntrada[0].Value = cliente.IdCliente;
            parametrosEntrada[1].Value = cliente.TipoDocumento;
            parametrosEntrada[2].Value = cliente.NroDocumento;
            parametrosEntrada[3].Value = cliente.Nombre_razonSocial;
            parametrosEntrada[4].Value = cliente.Telefono;
            parametrosEntrada[5].Value = cliente.Email;
            parametrosEntrada[6].Value = cliente.Kam.IdUsuario;
            parametrosEntrada[7].Value = cliente.Kam.Nombre;
            parametrosEntrada[8].Value = cliente.Estado;
            parametrosEntrada[9].Value = usuario;

            bool aux = objManager.EjecutarProcedure(parametrosEntrada, "update_cliente");
            return ((aux) ? 1 : -1);
            
        }
        public int GuardarNuevoSucursal(ClienteSucursal sucursal, string usuario)
        {
            parametrosEntrada = new MySqlParameter[9];
            parametrosEntrada[0] = new MySqlParameter("@_idCliente", MySqlDbType.Int32);
            parametrosEntrada[1] = new MySqlParameter("@_nroDocumento", MySqlDbType.VarChar, 20);
            parametrosEntrada[2] = new MySqlParameter("@_nombreContacto", MySqlDbType.VarChar, 255);
            parametrosEntrada[3] = new MySqlParameter("@_direccion", MySqlDbType.VarChar, 255);
            parametrosEntrada[4] = new MySqlParameter("@_telefono", MySqlDbType.VarChar, 255);
            parametrosEntrada[5] = new MySqlParameter("@_email", MySqlDbType.VarChar, 255);
            parametrosEntrada[6] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 255);
            parametrosEntrada[7] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 100);
            parametrosEntrada[8] = new MySqlParameter("@_idSucursal", MySqlDbType.Int32);

            parametrosEntrada[0].Value = sucursal.IdCliente;
            parametrosEntrada[1].Value = sucursal.NroDocumento;
            parametrosEntrada[2].Value = sucursal.NombreContacto;
            parametrosEntrada[3].Value = sucursal.Direccion;
            parametrosEntrada[4].Value = sucursal.Telefono;
            parametrosEntrada[5].Value = sucursal.Email;
            parametrosEntrada[6].Value = sucursal.Observacion;
            parametrosEntrada[7].Value = usuario;

            string[] datosSalida = new string[1];

            objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_cliente_sucursal",
                8, 9, out datosSalida, 1);

            if (datosSalida != null)
            {
                int idCliente = Convert.ToInt32(datosSalida[0]);
                return idCliente;
            }
            return -1;

        }
        public int ModificarSucursal(ClienteSucursal sucursal, string usuario)
        {

            parametrosEntrada = new MySqlParameter[9];
            parametrosEntrada[0] = new MySqlParameter("@_idSucursal", MySqlDbType.Int32);
            parametrosEntrada[1] = new MySqlParameter("@_nroDocumento", MySqlDbType.VarChar, 20);
            parametrosEntrada[2] = new MySqlParameter("@_nombreContacto", MySqlDbType.VarChar, 255);
            parametrosEntrada[3] = new MySqlParameter("@_direccion", MySqlDbType.VarChar, 255);
            parametrosEntrada[4] = new MySqlParameter("@_telefono", MySqlDbType.VarChar, 255);
            parametrosEntrada[5] = new MySqlParameter("@_email", MySqlDbType.VarChar, 255);
            parametrosEntrada[6] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 255);
            parametrosEntrada[7] = new MySqlParameter("@_estado", MySqlDbType.Int32);
            parametrosEntrada[8] = new MySqlParameter("@_usuario_mod", MySqlDbType.VarChar, 100);

            parametrosEntrada[0].Value = sucursal.IdSucursal;
            parametrosEntrada[1].Value = sucursal.NroDocumento;
            parametrosEntrada[2].Value = sucursal.NombreContacto;
            parametrosEntrada[3].Value = sucursal.Direccion;
            parametrosEntrada[4].Value = sucursal.Telefono;
            parametrosEntrada[5].Value = sucursal.Email;
            parametrosEntrada[6].Value = sucursal.Observacion;
            parametrosEntrada[7].Value = sucursal.Estado;
            parametrosEntrada[8].Value = usuario;

            bool aux = objManager.EjecutarProcedure(parametrosEntrada, "update_cliente_sucursal");
            return ((aux) ? 1 : -1);

        }
        public int GuardarNuevoContacto(ClienteContacto contacto, string usuario)
        {
            parametrosEntrada = new MySqlParameter[10];
            parametrosEntrada[0] = new MySqlParameter("@_idCliente", MySqlDbType.Int32);
            parametrosEntrada[1] = new MySqlParameter("@_idTipoContacto", MySqlDbType.Int32);
            parametrosEntrada[2] = new MySqlParameter("@_nombre", MySqlDbType.VarChar, 1000);
            parametrosEntrada[3] = new MySqlParameter("@_email", MySqlDbType.VarChar, 255);
            parametrosEntrada[4] = new MySqlParameter("@_telefono", MySqlDbType.VarChar, 255);
            parametrosEntrada[5] = new MySqlParameter("@_anexo", MySqlDbType.VarChar, 255);
            parametrosEntrada[6] = new MySqlParameter("@_cargo", MySqlDbType.VarChar, 255);
            parametrosEntrada[7] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 255);
            parametrosEntrada[8] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 100);
            parametrosEntrada[9] = new MySqlParameter("@_idContacto", MySqlDbType.Int32);

            parametrosEntrada[0].Value = contacto.IdCliente;
            parametrosEntrada[1].Value = contacto.IdTipoContacto;
            parametrosEntrada[2].Value = contacto.Nombre;
            parametrosEntrada[3].Value = contacto.Email;
            parametrosEntrada[4].Value = contacto.Telefono;
            parametrosEntrada[5].Value = contacto.Anexo;
            parametrosEntrada[6].Value = contacto.Cargo;
            parametrosEntrada[7].Value = contacto.Observacion;
            parametrosEntrada[8].Value = usuario;

            string[] datosSalida = new string[1];

            objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_cliente_contacto  ",
                9, 10, out datosSalida, 1);

            if (datosSalida != null)
            {
                int idCliente = Convert.ToInt32(datosSalida[0]);
                return idCliente;
            }
            return -1;

        }
        public int ModificarContacto(ClienteContacto contacto, string usuario)
        {

            parametrosEntrada = new MySqlParameter[10];
            parametrosEntrada[0] = new MySqlParameter("@_idContacto", MySqlDbType.Int32);
            parametrosEntrada[1] = new MySqlParameter("@_idTipoContacto", MySqlDbType.Int32);
            parametrosEntrada[2] = new MySqlParameter("@_nombre", MySqlDbType.VarChar, 1000);
            parametrosEntrada[3] = new MySqlParameter("@_email", MySqlDbType.VarChar, 255);
            parametrosEntrada[4] = new MySqlParameter("@_telefono", MySqlDbType.VarChar, 255);
            parametrosEntrada[5] = new MySqlParameter("@_anexo", MySqlDbType.VarChar, 255);
            parametrosEntrada[6] = new MySqlParameter("@_cargo", MySqlDbType.VarChar, 255);
            parametrosEntrada[7] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 255);
            parametrosEntrada[8] = new MySqlParameter("@_estado", MySqlDbType.Int32);
            parametrosEntrada[9] = new MySqlParameter("@_usuario_mod", MySqlDbType.VarChar, 100);

            parametrosEntrada[0].Value = contacto.IdContacto;
            parametrosEntrada[1].Value = contacto.IdTipoContacto;
            parametrosEntrada[2].Value = contacto.Nombre;
            parametrosEntrada[3].Value = contacto.Email;
            parametrosEntrada[4].Value = contacto.Telefono;
            parametrosEntrada[5].Value = contacto.Anexo;
            parametrosEntrada[6].Value = contacto.Cargo;
            parametrosEntrada[7].Value = contacto.Observacion;
            parametrosEntrada[8].Value = contacto.Estado;
            parametrosEntrada[9].Value = usuario;

            bool aux = objManager.EjecutarProcedure(parametrosEntrada, "update_cliente_contacto");
            return ((aux) ? 1 : -1);

        }
    }
}
