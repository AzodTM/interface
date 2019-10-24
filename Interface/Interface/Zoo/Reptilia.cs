using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Zoo
{
    class Reptilia :Animal,IAnamalDo
    {
        public Reptilia() : base()
        {
            voise = "Pshhh Pshhh";
        }
        public string Cry()
        {
            return voise;
        }

        public void Move()
        {
            coordinate += 1;
        }
    }
}
