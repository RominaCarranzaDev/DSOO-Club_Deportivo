using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Club_Deportivo.Entidades
{
    internal class E_Socio : E_Cliente
    {
        public int NroSocio { get; set; }

        public DateOnly FechaInscripcion { get; set; }
    }
}
