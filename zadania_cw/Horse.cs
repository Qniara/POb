using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cw_do_lekcji_03_02_2024
{
    internal class Horse
    {
        enum sex
        {
            mare,
            stallion,
            gelding
        }
        public string name { get; set; }
        public int age { get; set; }
        private sex sex2 { get; set; }      
        public string breed { get; set; }
        public void SetName(string Name)
        {
            name = Name;
        }
    }
}
