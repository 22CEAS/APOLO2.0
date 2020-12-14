using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Tablet
    {
        private int idTablet;
        private string codigo;
        private Modelo modelo;
        private double tamanoPantalla;
        private int idProcesador;
        private string procesador;
        private int idSO;
        private string sistema;
        private int idRAM;
        private int ram;
        private int idROM;
        private int rom;
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

        public Tablet()
        {
            this.Modelo = new Modelo();
            this.Observacion = "";

        }

        public int IdTablet { get => idTablet; set => idTablet = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public Modelo Modelo { get => modelo; set => modelo = value; }
        public double TamanoPantalla { get => tamanoPantalla; set => tamanoPantalla = value; }
        public int IdProcesador { get => idProcesador; set => idProcesador = value; }
        public string Procesador { get => procesador; set => procesador = value; }
        public int IdSO { get => idSO; set => idSO = value; }
        public string Sistema { get => sistema; set => sistema = value; }
        public int IdRAM { get => idRAM; set => idRAM = value; }
        public int Ram { get => ram; set => ram = value; }
        public int IdROM { get => idROM; set => idROM = value; }
        public int Rom { get => rom; set => rom = value; }
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
        public int IdMarcaTablet { get => Modelo.IdMarca; set => Modelo.IdMarca = value; }
        public string MarcaTablet { get => Modelo.NombreMarca; set => Modelo.NombreMarca = value; }
        public int IdModeloTablet { get => Modelo.IdModelo; set => Modelo.IdModelo = value; }
        public string NombreModeloTablet { get => Modelo.NombreModelo; set => Modelo.NombreModelo = value; }
    }
}
