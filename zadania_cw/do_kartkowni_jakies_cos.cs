using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_do_kart_dupa_pupa_kupa
{
    class Person
    {
        public int age { get; set; }
        public string name { get; set; }
        public void SetName(string Name)
        {
            name = Name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person FreddieMercury= new Person();
            FreddieMercury.age = 45;
            FreddieMercury.SetName("Freddie");
            //Console.WriteLine(FreddieMercury.name);
            //I'm just a musical prostitute my dear
        }
    }
}
