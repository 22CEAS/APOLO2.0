using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class IngresoDetalleProyector
    {
        private long idIngresoDetalleProyector;
        private Proyector proyector;
        private BindingList<String> series;
        private int cantidad;
        private double precio;
        private string caracteristica;
        private string observacion;
        private int estado;


        public IngresoDetalleProyector()
        {
            this.Observacion = "";
            this.Caracteristica = "";
            this.Series = new BindingList<string>();
            this.Proyector = new Proyector();
            this.Estado = 1;
        }


        public long IdIngresoDetalleProyector { get => idIngresoDetalleProyector; set => idIngresoDetalleProyector = value; }
        public Proyector Proyector { get => proyector; set => proyector = value; }
        public BindingList<string> Series { get => series; set => series = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Caracteristica { get => caracteristica; set => caracteristica = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public int Estado { get => estado; set => estado = value; }


        public int ProyectorIdMarca { get => Proyector.IdMarcaProyector; set => Proyector.IdMarcaProyector = value; }
        public string ProyectorMarca { get => Proyector.MarcaProyector; set => Proyector.MarcaProyector = value; }
        public int ProyectorIdModelo { get => Proyector.IdModeloProyector; set => Proyector.IdModeloProyector = value; }
        public string ProyectorNombreModelo { get => Proyector.NombreModeloProyector; set => Proyector.NombreModeloProyector = value; }

        public int ProyectorIdCaracteristica { get => Proyector.IdCaracteristica; set => Proyector.IdCaracteristica = value; }
        public string ProyectorCaracteristica { get => Proyector.Caracteristica; set => Proyector.Caracteristica = value; }

        public int ProyectorIdTipoEquipoProyector { get => Proyector.IdTipoEquipoProyector; set => Proyector.IdTipoEquipoProyector = value; }
        public string ProyectorTipoEquipoProyector { get => Proyector.NombreTipoEquipoProyector; set => Proyector.NombreTipoEquipoProyector = value; }

        public double ProyectorTamano { get => Proyector.TamanoProyector; set => Proyector.TamanoProyector = value; }

    }
}
