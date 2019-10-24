using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Zoo
{
    class Bird : Animal, IAnamalDo
    {
        public Bird() : base()
        {
            voise = "Kar Kar";
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
