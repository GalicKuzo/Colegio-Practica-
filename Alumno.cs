using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio
{
    internal class Alumno
    {
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public Alumno(string nombres, string apellidos)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
        }
        

    }
}
