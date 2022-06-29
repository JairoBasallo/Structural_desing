using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Desing.Wall.Entidades
{
    public class Geometry_element
    {
        public float Weight { get; set; }

        public float Height { get; set; }

        public float Lenght { get; set; }

        public Geometry_element(float weight, float height, float lenght) => (Weight, Height, Lenght) = (weight, height, lenght);
        public Geometry_element(float weight, float lenght) => (Weight, Lenght) = (weight, lenght);

        public Geometry_element() { }


    }
}
