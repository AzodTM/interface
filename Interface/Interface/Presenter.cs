using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Presenter
    {
        public List<Zoo.Animal> Animals { get; }

        public Presenter()
        {
            Animals = new List<Zoo.Animal>();
        }

        public void AddBird()
        {
            Animals.Add(new Zoo.Bird());
        }

        public void AddFish()
        {
            Animals.Add(new Zoo.Fish());
        }

        public void AddReptilia()
        {
            Animals.Add(new Zoo.Reptilia());
        }

    }
}
