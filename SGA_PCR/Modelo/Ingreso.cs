using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Ingreso
    {
        private int idIngreso;
        private int idSede;
        private string tipoSede;
        private int idTipoIngreso;//Compra o arrendamiento
        private string tipoIngreso;
        private int idMonedaTipo;
        private string monedaTipo;
        private int idProveedor;
        private string ruc;
        private string razonSocial;
        private string factura;
        private string guia;
        private DateTime fechaIngreso;
        private Double montoCambio;
        private Double total;
        private string observacion;
        private int estado;
        private Usuario usuarioRegistro;
        private BindingList<IngresoDetalle> detalles;
        private BindingList<Memoria> memorias;
        private BindingList<Licencia> licencias;
        private BindingList<DiscoDuro> discos;
        private BindingList<IngresoDetalleTablet> detallesTablets;
        private BindingList<IngresoDetalleMonitor> detallesMonitores;
        private BindingList<IngresoDetalleImpresora> detallesImpresoras;
        private BindingList<IngresoDetalleProyector> detallesProyectores;

        public Ingreso()
        {
            UsuarioRegistro = new Usuario();
            Observacion = "";
            Estado = 1;
            Memorias = new BindingList<Memoria>();
            Detalles = new BindingList<IngresoDetalle>();
            Licencias = new BindingList<Licencia>();
            Discos = new BindingList<DiscoDuro>();
            DetallesTablets = new BindingList<IngresoDetalleTablet>();
            DetallesMonitores = new BindingList<IngresoDetalleMonitor>();
            DetallesImpresoras = new BindingList<IngresoDetalleImpresora>();
            DetallesProyectores = new BindingList<IngresoDetalleProyector>();
        }


        public Ingreso(BindingList<IngresoDetalle> det)
        {
            this.Detalles = det;
        }
        public int IdIngreso { get => idIngreso; set => idIngreso = value; }
        public int IdTipoIngreso { get => idTipoIngreso; set => idTipoIngreso = value; }
        public string TipoIngreso { get => tipoIngreso; set => tipoIngreso = value; }
        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public string Ruc { get => ruc; set => ruc = value; }
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public string Factura { get => factura; set => factura = value; }
        public string Guia { get => guia; set => guia = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public int Estado { get => estado; set => estado = value; }
        public Usuario UsuarioRegistro { get => usuarioRegistro; set => usuarioRegistro = value; }
        public BindingList<IngresoDetalle> Detalles { get => detalles; set => detalles = value; }
        public BindingList<Memoria> Memorias { get => memorias; set => memorias = value; }
        public BindingList<Licencia> Licencias { get => licencias; set => licencias = value; }
        public BindingList<DiscoDuro> Discos { get => discos; set => discos = value; }
        public double Total { get => total; set => total = value; }
        public int IdMonedaTipo { get => idMonedaTipo; set => idMonedaTipo = value; }
        public string MonedaTipo { get => monedaTipo; set => monedaTipo = value; }
        public double MontoCambio { get => montoCambio; set => montoCambio = value; }
        public BindingList<IngresoDetalleTablet> DetallesTablets { get => detallesTablets; set => detallesTablets = value; }
        public BindingList<IngresoDetalleMonitor> DetallesMonitores { get => detallesMonitores; set => detallesMonitores = value; }
        public BindingList<IngresoDetalleImpresora> DetallesImpresoras { get => detallesImpresoras; set => detallesImpresoras = value; }
        public BindingList<IngresoDetalleProyector> DetallesProyectores { get => detallesProyectores; set => detallesProyectores = value; }
        public int IdSede { get => idSede; set => idSede = value; }
        public string TipoSede { get => tipoSede; set => tipoSede = value; }
    }
}
