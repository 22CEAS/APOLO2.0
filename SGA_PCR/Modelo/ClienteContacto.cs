using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ClienteContacto
    {
        private int idContacto;
        private int idCliente;
        private int idTipoContacto;
        private string tipoContacto;
        private string nombre;
        private string email;
        private string telefono;
        private string anexo;
        private string cargo;
        private string observacion;
        private int estado;
        private string nombreEstado;

        public ClienteContacto()
        {
            TipoContacto = "";
            Nombre = "";
            Email = "";
            Telefono = "";
            Anexo = "";
            Cargo = "";
            Observacion = "";
            Estado = 1;
        }
        public int IdContacto { get => idContacto; set => idContacto = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdTipoContacto { get => idTipoContacto; set => idTipoContacto = value; }
        public string TipoContacto { get => tipoContacto; set => tipoContacto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Anexo { get => anexo; set => anexo = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public int Estado { get => estado; set => estado = value; }
        public string NombreEstado { get => nombreEstado; set => nombreEstado = value; }
    }
}
