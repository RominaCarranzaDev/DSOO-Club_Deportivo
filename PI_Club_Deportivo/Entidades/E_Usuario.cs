using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PI_Club_Deportivo.Entidades
{
    internal class E_Usuario
    {
        public string? Nombre { get; set; }
        public string? Pass { get; set; }
        public string? Rol { get; set; }
        public string? Username { get; set; }
        public bool Estado { get; set; }

    }
}
