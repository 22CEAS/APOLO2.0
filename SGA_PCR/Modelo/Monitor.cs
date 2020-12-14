using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Monitor
    {
        private int idMonitor;
        private string codigo;
        private Modelo modelo;
        private double tamanoPantalla;
        private int idTipo;
        private string tipo;
        private int cantidad;
        private double precio;
        private string partNumber;
        private string serieFabrica;
        private int garantia;
        private DateTime fecInicioSeguro;
        private DateTime fecFinSeguro;
        private string ubicacion;
        private string observacion;
        private int estado;
        private string estadoNombre;
        private string cliente;
        private string rucCliente;

        public Monitor()
        {
            this.Modelo = new Modelo();
            this.Observacion = "";
        }

        public int IdMonitor { get => idMonitor; set => idMonitor = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public Modelo Modelo { get => modelo; set => modelo = value; }
        public double TamanoPantalla { get => tamanoPantalla; set => tamanoPantalla = value; }
        public int IdTipo { get => idTipo; set => idTipo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
        public string PartNumber { get => partNumber; set => partNumber = value; }
        public string SerieFabrica { get => serieFabrica; set => serieFabrica = value; }
        public int Garantia { get => garantia; set => garantia = value; }
        public DateTime FecInicioSeguro { get => fecInicioSeguro; set => fecInicioSeguro = value; }
        public DateTime FecFinSeguro { get => fecFinSeguro; set => fecFinSeguro = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public int Estado { get => estado; set => estado = value; }
        public string EstadoNombre { get => estadoNombre; set => estadoNombre = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string RucCliente { get => rucCliente; set => rucCliente = value; }

        public int IdMarcaMonitor { get => Modelo.IdMarca; set => Modelo.IdMarca = value; }
        public string MarcaMonitor { get => Modelo.NombreMarca; set => Modelo.NombreMarca = value; }
        public int IdModeloMonitor { get => Modelo.IdModelo; set => Modelo.IdModelo = value; }
        public string NombreModeloMonitor { get => Modelo.NombreModelo; set => Modelo.NombreModelo = value; }
    }
}
