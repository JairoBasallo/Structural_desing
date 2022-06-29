using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Desing.Wall.Entidades
{
    internal class Material
    {
        public float f_m { get; set; }

        public float f_y { get; set; }

        public Material(float F_m, float F_y) => (f_m, f_y) = (F_m, F_y);
    }
}
