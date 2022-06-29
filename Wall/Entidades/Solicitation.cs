using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Desing.Wall.Entidades
{
    public class Solicitations
    {
        public List<Combination> solicitations { get; set; }

        public Solicitations(List<Combination> sol) => solicitations = sol;

    }
}
