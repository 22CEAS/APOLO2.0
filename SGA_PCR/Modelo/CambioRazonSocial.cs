using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CambioRazonSocial
    {
        private int idSucursal;
        private int idCliente;
        private int idSalida;
        private int idSalidaDetalle;
        private string guiaSalida;
        private int idEquipo;
        private string codigo;
        private string marca;
        private string modelo;
        private string observacion;
        private bool seleccion;

        public CambioRazonSocial()
        {}

        public int IdSucursal { get => idSucursal; set => idSucursal = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdSalida { get => idSalida; set => idSalida = value; }
        public int IdSalidaDetalle { get => idSalidaDetalle; set => idSalidaDetalle = value; }
        public string GuiaSalida { get => guiaSalida; set => guiaSalida = value; }
        public int IdEquipo { get => idEquipo; set => idEquipo = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public bool Seleccion { get => seleccion; set => seleccion = value; }
    }
}
