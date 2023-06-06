using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio
{
    internal class Aula
    {
        public Alumno alumno1 { get; set; }
        public Alumno alumno2 { get; set; }
        public Alumno alumno3 { get; set; }
        public Alumno alumno4 { get; set; }

        public Aula(Alumno a1, Alumno a2, Alumno a3, Alumno a4)
        {
            this.alumno1 = a1;
            this.alumno2 = a2;
            this.alumno3 = a3;
            this.alumno4 = a4;
        }
    }
}
