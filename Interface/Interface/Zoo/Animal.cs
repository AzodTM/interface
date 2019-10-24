using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Zoo
{
    abstract class Animal
    {
        protected int size;
        protected int coordinate;
        protected string voise;

        public Animal()
        {
            size = 1;
            coordinate = 0;
        }
    }
}
