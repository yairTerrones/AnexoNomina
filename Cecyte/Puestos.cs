using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cecyte
{
    public class Puestos
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Denominacion { get; set; }
        public string Zona { get; set; }
        public string NivelSalarial { get; set; }
        public int Plazas { get; set; }
        public int Horas { get; set; }
        public decimal DiferencialSueldo { get; set; }
        public decimal CostoColectivo { get; set; }
        public decimal CostoPeriodo { get; set; }
        public string Tipo { get; set; }
        public string Ejercicio { get; set; }
    }
}
