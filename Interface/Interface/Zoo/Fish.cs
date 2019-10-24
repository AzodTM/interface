using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Zoo
{
    class Fish : Animal, IAnamalDo
    {
        
        public Fish():base()
        {
            voise = "Bloo Bloo";
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
