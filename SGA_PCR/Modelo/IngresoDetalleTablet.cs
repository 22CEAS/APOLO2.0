using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class IngresoDetalleTablet
    {
        private long idIngresoDetalleTablet;
        private Tablet tablet;
        private BindingList<String> series;
        private int cantidad;
        private double precio;
        private string caracteristica;
        private string observacion;
        private int estado;

        public IngresoDetalleTablet()
        {
            this.Observacion = "";
            this.Caracteristica = "";
            this.Series = new BindingList<string>();
            this.Tablet = new Tablet();
            this.Estado = 1;
        }

        public long IdIngresoDetalleTablet { get => idIngresoDetalleTablet; set => idIngresoDetalleTablet = value; }
        public Tablet Tablet { get => tablet; set => tablet = value; }
        public BindingList<string> Series { get => series; set => series = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Caracteristica { get => caracteristica; set => caracteristica = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public int Estado { get => estado; set => estado = value; }


        public int TabletIdMarca { get => Tablet.IdMarcaTablet; set => Tablet.IdMarcaTablet = value; }
        public string TabletMarca { get => Tablet.MarcaTablet; set => Tablet.MarcaTablet = value; }
        public int TabletIdModelo { get => Tablet.IdModeloTablet; set => Tablet.IdModeloTablet = value; }
        public string TabletNombreModelo { get => Tablet.NombreModeloTablet; set => Tablet.NombreModeloTablet = value; }

        public double TabletTamanoPantalla { get => Tablet.TamanoPantalla; set => Tablet.TamanoPantalla = value; }
        public int TabletIdProcesador { get => Tablet.IdProcesador; set => Tablet.IdProcesador = value; }
        public string TabletProcesador { get => Tablet.Procesador; set => Tablet.Procesador = value; }
        public int TabletIdSO { get => Tablet.IdSO; set => Tablet.IdSO = value; }
        public string TabletSistema { get => Tablet.Sistema; set => Tablet.Sistema = value; }
        public int TabletIdRAM { get => Tablet.IdRAM; set => Tablet.IdRAM = value; }
        public int TabletRam { get => Tablet.Ram; set => Tablet.Ram = value; }
        public int TabletIdROM { get => Tablet.IdROM; set => Tablet.IdROM = value; }
        public int TabletRom { get => Tablet.Rom; set => Tablet.Rom = value; }

    }
}
