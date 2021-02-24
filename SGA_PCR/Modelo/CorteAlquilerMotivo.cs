using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CorteAlquilerMotivo
    {
        private int idMotivoCorte;
        private String descripcionMotivoCorte;
        
        public CorteAlquilerMotivo() { }

        public int IdMotivoCorte { get => idMotivoCorte; set => idMotivoCorte = value; }
        public string DescripcionMotivoCorte { get => descripcionMotivoCorte; set => descripcionMotivoCorte = value; }
    }
}
