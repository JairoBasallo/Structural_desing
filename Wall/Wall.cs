using Structural_Desing.Wall.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Desing.Wall
{
    public class Wall_1
    {
        public string Wall_id { get; set; }
        public Geometry_element geometry_element { get; set; }

        public Solicitations solicitations { get; set; }


        //public Material material { get; private set; }

        public Wall_1(String wall, Geometry_element geometry__element, Solicitations sol) => (Wall_id, geometry_element, solicitations) = (wall, geometry__element, sol);
        public Wall_1(String wall, Geometry_element geometry__element) => (Wall_id, geometry_element) = (wall, geometry__element);

    }
}
