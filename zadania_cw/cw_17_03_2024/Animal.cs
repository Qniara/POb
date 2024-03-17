using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_17_03_2024
{
    enum Kind
    {
        cat,
        dog,
        fish,
        horse,
        human
    }
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Kind Kind { get; set; }
    }

}
