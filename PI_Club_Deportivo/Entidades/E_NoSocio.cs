using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Club_Deportivo.Entidades
{
    internal class E_NoSocio : E_Cliente
    {
        public DateOnly FechaVisita { get; set; }
    }
}
