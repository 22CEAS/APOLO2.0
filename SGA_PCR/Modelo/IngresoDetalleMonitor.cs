using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class IngresoDetalleMonitor
    {
        private long idIngresoDetalleMonitor;
        private Monitor monitor;
        private BindingList<String> series;
        private int cantidad;
        private double precio;
        private string caracteristica;
        private string observacion;
        private int estado;


        public IngresoDetalleMonitor()
        {
            this.Observacion = "";
            this.Caracteristica = "";
            this.Series = new BindingList<string>();
            this.Monitor = new Monitor();
            this.Estado = 1;
        }

        public long IdIngresoDetalleMonitor { get => idIngresoDetalleMonitor; set => idIngresoDetalleMonitor = value; }
        public Monitor Monitor { get => monitor; set => monitor = value; }
        public BindingList<string> Series { get => series; set => series = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Caracteristica { get => caracteristica; set => caracteristica = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public int Estado { get => estado; set => estado = value; }



        public int MonitorIdMarca { get => Monitor.IdMarcaMonitor; set => Monitor.IdMarcaMonitor = value; }
        public string MonitorMarca { get => Monitor.MarcaMonitor; set => Monitor.MarcaMonitor = value; }
        public int MonitorIdModelo { get => Monitor.IdModeloMonitor; set => Monitor.IdModeloMonitor = value; }
        public string MonitorNombreModelo { get => Monitor.NombreModeloMonitor; set => Monitor.NombreModeloMonitor = value; }

        public double MonitorTamanoPantalla { get => Monitor.TamanoPantalla; set => Monitor.TamanoPantalla = value; }
        public int MonitorIdTipo { get => Monitor.IdTipo; set => Monitor.IdTipo = value; }
        public string MonitorTipo { get => Monitor.Tipo; set => Monitor.Tipo = value; }

        public int MonitorHdmi { get => Monitor.Hdmi; set => Monitor.Hdmi = value; }
        public int MonitorVga { get => Monitor.Vga; set => Monitor.Vga = value; }
        public int MonitorDisplayPort { get => Monitor.DisplayPort; set => Monitor.DisplayPort = value; }
    }
}
