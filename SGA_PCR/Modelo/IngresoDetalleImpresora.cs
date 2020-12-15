using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class IngresoDetalleImpresora
    {
        private long idIngresoDetalleImpresora;
        private Impresora impresora;
        private BindingList<String> series;
        private int cantidad;
        private double precio;
        private string caracteristica;
        private string observacion;
        private int estado;


        public IngresoDetalleImpresora()
        {
            this.Observacion = "";
            this.Caracteristica = "";
            this.Series = new BindingList<string>();
            this.Impresora = new Impresora();
            this.Estado = 1;
        }

        public long IdIngresoDetalleImpresora { get => idIngresoDetalleImpresora; set => idIngresoDetalleImpresora = value; }
        public Impresora Impresora { get => impresora; set => impresora = value; }
        public BindingList<string> Series { get => series; set => series = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Caracteristica { get => caracteristica; set => caracteristica = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public int Estado { get => estado; set => estado = value; }


        public int ImpresoraIdMarca { get => Impresora.IdMarcaImpresora; set => Impresora.IdMarcaImpresora = value; }
        public string ImpresoraMarca { get => Impresora.MarcaImpresora; set => Impresora.MarcaImpresora = value; }
        public int ImpresoraIdModelo { get => Impresora.IdModeloImpresora; set => Impresora.IdModeloImpresora = value; }
        public string ImpresoraNombreModelo { get => Impresora.NombreModeloImpresora; set => Impresora.NombreModeloImpresora = value; }

        public int ImpresoraIdTipo { get => Impresora.IdTipo; set => Impresora.IdTipo = value; }
        public string ImpresoraTipo { get => Impresora.Tipo; set => Impresora.Tipo = value; }

        public int ImpresoraMultifuncional { get => Impresora.Multifuncional; set => Impresora.Multifuncional = value; }
    }
}
