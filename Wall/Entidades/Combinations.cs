using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Desing.Wall.Entidades
{
    public class Combination
    {
        public string Combination_name { get; set; }
        public string axial_top { get; set; }
        public string axial_bot { get; set; }
        public string shear_top { get; set; }
        public string shear_bot { get; set; }
        public string moment_top { get; set; }
        public string moment_bot { get; set; }

        public Combination(String combination_name, string axial_t, string axial_b, string shear_t, string shear_b, string moment_t, string moment_b) =>
            (Combination_name, axial_top, axial_bot, shear_top, shear_bot, moment_top, moment_bot) = (combination_name, axial_t, axial_b, shear_t, shear_b, moment_t, moment_b);
        
    }
}
