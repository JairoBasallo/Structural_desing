using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Desing.Wall.Entidades
{
    public class Axial_Solicitation
    {
        public float axial_top { get; set; }
        public float axial_bottom { get; set; }

        public Axial_Solicitation(float axial__top, float axial__bottom) => (axial_top, axial_bottom) = (axial__top, axial__bottom);
    }
}
