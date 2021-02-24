using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CorteAlquiler
    {
        private int idSalida;
        private int idSalidaDetalle;
        private string guiaSalida;
        private int idSucursal;
        private int idLC;
        private string codigoLC;
        private string marcaLC;
        private string modeloLC;
        private DateTime fechaIniContrato;
        private DateTime fechaFinContrato;
        private DateTime fechaIniContratoAntiguo;
        private DateTime fechaFinContratoAntiguo;
        private string observacion;
        private string _numFactura;

        private bool seleccion;
        private string codigo;
        private string codigoAntiguo;
        private string nombreModeloLC;
        private DateTime _fecIniContrato;
        private DateTime _fecFinContrato;

        private string RucCliente;
        private int idCliente;

        private int idMotivoCorte;
        private String descripcionMotivoCorte;
        private string personaContacto;
        private string direccion;
        private string telefono;
        private DateTime fechaRecojo;



        public CorteAlquiler()
        {
            DescripcionMotivoCorte = "";
            PersonaContacto = "";
            Direccion = "";
            Telefono = "";
            Observacion = "";
        }

        public int IdSalidaDetalle { get => idSalidaDetalle; set => idSalidaDetalle = value; }
        public int IdSucursal { get => idSucursal; set => idSucursal = value; }
        public int IdLC { get => idLC; set => idLC = value; }
        public string CodigoLC { get => codigoLC; set => codigoLC = value; }
        public string MarcaLC { get => marcaLC; set => marcaLC = value; }
        public string ModeloLC { get => modeloLC; set => modeloLC = value; }
        public DateTime FechaIniContrato { get => fechaIniContrato; set => fechaIniContrato = value; }
        public DateTime FechaFinContrato { get => fechaFinContrato; set => fechaFinContrato = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public string GuiaSalida { get => guiaSalida; set => guiaSalida = value; }
        public int IdSalida { get => idSalida; set => idSalida = value; }
        public DateTime FechaIniContratoAntiguo { get => fechaIniContratoAntiguo; set => fechaIniContratoAntiguo = value; }
        public DateTime FechaFinContratoAntiguo { get => fechaFinContratoAntiguo; set => fechaFinContratoAntiguo = value; }

        public bool Seleccion { get => seleccion; set => seleccion = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string CodigoAntiguo { get => codigoAntiguo; set => codigoAntiguo = value; }
        public string NombreModeloLC { get => nombreModeloLC; set => nombreModeloLC = value; }
        public DateTime fecIniContrato { get => _fecIniContrato; set => _fecIniContrato = value; }
        public DateTime fecFinContrato { get => _fecFinContrato; set => _fecFinContrato = value; }
        public string RucCliente1 { get => RucCliente; set => RucCliente = value; }
        public string NumFactura { get => _numFactura; set => _numFactura = value; }

        public int IdMotivoCorte { get => idMotivoCorte; set => idMotivoCorte = value; }
        public string DescripcionMotivoCorte { get => descripcionMotivoCorte; set => descripcionMotivoCorte = value; }
        public string PersonaContacto { get => personaContacto; set => personaContacto = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public DateTime FechaRecojo { get => fechaRecojo; set => fechaRecojo = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
    }
}
