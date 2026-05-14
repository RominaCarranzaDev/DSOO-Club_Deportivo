using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Club_Deportivo.Entidades
{
    internal class E_Cliente
    {
        public int IdCliente { get; set; }

        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public TipoDoc TipoDoc { get; set; }
        public string? Dni { get; set; }

        public string? Direccion { get; set; }
        public string? Tel { get; set; }
        public string? Email { get; set; }

        public DateOnly FechaNac { get; set; }

        public bool Estado { get; set; }
        public bool AptoFisico { get; set; }

        public bool EsSocio { get; set; }
    }

    public enum TipoDoc
    {
        dni,
        pasaporte,
        lc
    }
}
