﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Factura
    {
        private int idFactura;
        private int idSalida;
        private DateTime fechaPago;
        private string tipoPago;
        private string codigoLC;
        private string descripcion;
        private int idLC;
        private DateTime fechaIniPago;
        private DateTime fechaFinPago;
        private string rucDni;
        private string razonSocial;
        private string numeroOC;
        private string numeroDocRef;
        private string numeroFactura;
        private Double totalSoles;
        private Double totalDolares;
        private Double tipoCambio;
        private Double ventaSoles;
        private string proveedor;
        private Double costoSoles;
        private Double costoDolares;
        private Double costoTotalSolesSinIGV;
        private Double utilidadSoles;
        private Double utilidadDolares;
        private Double utilidadTotalSolesSinIGV;
        private string observacionXLevantar;
        private string guiaSalida;
        private string codigo;
        private bool seleccionar;
        private string nroNotaCredito;
        
        private DateTime fechaIniPagoAntiguo;
        private DateTime fechaFinPagoAntiguo;
        private Double totalSolesAntiguo;
        private Double totalDolaresAntiguo;
        private Double costoSolesAntiguo;
        private Double costoDolaresAntiguo;

        private int cantidadEquipos;
        private int error;
        private int tipoFacturaTransito;//0 Factura Normal 1 FacturaTransito
        private int idFacturaTransito;

        public Factura()
        {
            this.TipoFacturaTransito = 0;
        }

        public int IdFactura { get => idFactura; set => idFactura = value; }
        public DateTime FechaPago { get => fechaPago; set => fechaPago = value; }
        public string TipoPago { get => tipoPago; set => tipoPago = value; }
        public string CodigoLC { get => codigoLC; set => codigoLC = value; }
        public DateTime FechaIniPago { get => fechaIniPago; set => fechaIniPago = value; }
        public DateTime FechaFinPago { get => fechaFinPago; set => fechaFinPago = value; }
        public string RucDni { get => rucDni; set => rucDni = value; }
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public string NumeroOC { get => numeroOC; set => numeroOC = value; }
        public string NumeroDocRef { get => numeroDocRef; set => numeroDocRef = value; }
        public string NumeroFactura { get => numeroFactura; set => numeroFactura = value; }
        public double TotalSoles { get => totalSoles; set => totalSoles = value; }
        public double TotalDolares { get => totalDolares; set => totalDolares = value; }
        public double TipoCambio { get => tipoCambio; set => tipoCambio = value; }
        public double VentaSoles { get => ventaSoles; set => ventaSoles = value; }
        public double CostoSoles { get => costoSoles; set => costoSoles = value; }
        public double CostoDolares { get => costoDolares; set => costoDolares = value; }
        public double CostoTotalSolesSinIGV { get => costoTotalSolesSinIGV; set => costoTotalSolesSinIGV = value; }
        public double UtilidadSoles { get => utilidadSoles; set => utilidadSoles = value; }
        public double UtilidadDolares { get => utilidadDolares; set => utilidadDolares = value; }
        public double UtilidadTotalSolesSinIGV { get => utilidadTotalSolesSinIGV; set => utilidadTotalSolesSinIGV = value; }
        public int IdSalida { get => idSalida; set => idSalida = value; }
        public string ObservacionXLevantar { get => observacionXLevantar; set => observacionXLevantar = value; }
        public int IdLC { get => idLC; set => idLC = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
        public string GuiaSalida { get => guiaSalida; set => guiaSalida = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public bool Seleccionar { get => seleccionar; set => seleccionar = value; }

        public string NroNotaCredito { get => nroNotaCredito; set => nroNotaCredito = value; }
        public DateTime FechaIniPagoAntiguo { get => fechaIniPagoAntiguo; set => fechaIniPagoAntiguo = value; }
        public DateTime FechaFinPagoAntiguo { get => fechaFinPagoAntiguo; set => fechaFinPagoAntiguo = value; }
        public double TotalSolesAntiguo { get => totalSolesAntiguo; set => totalSolesAntiguo = value; }
        public double TotalDolaresAntiguo { get => totalDolaresAntiguo; set => totalDolaresAntiguo = value; }
        public double CostoSolesAntiguo { get => costoSolesAntiguo; set => costoSolesAntiguo = value; }
        public double CostoDolaresAntiguo { get => costoDolaresAntiguo; set => costoDolaresAntiguo = value; }

        public int CantidadEquipos { get => cantidadEquipos; set => cantidadEquipos = value; }
        public int Error { get => error; set => error = value; }
        public int TipoFacturaTransito { get => tipoFacturaTransito; set => tipoFacturaTransito = value; }
        public int IdFacturaTransito { get => idFacturaTransito; set => idFacturaTransito = value; }
    }
}
