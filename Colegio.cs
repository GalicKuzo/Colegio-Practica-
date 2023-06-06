using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio
{
    internal class Colegio
    {
        public Aula aula1 { get; set; }
        public Aula aula2 { get; set; }
        public Aula aula3 { get; set; }

        public Colegio(Aula a1, Aula a2, Aula a3)
        {
            aula1 = a1;
            aula2 = a2;
            aula3 = a3;
        }

    }
}
