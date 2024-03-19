using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace cw_19_03_2024
{
    enum StatusSamochodu
    {
        nowy,
        uzywany,
        zabytkowy
    }
    internal class Samochod
    {
        private string Marka {  get; set; }
        private string Model { get; set; }
        private int RokProdukcji { get; set; }
        private double PojemnoscSilnika { get; set; }
        private bool CzyDiesel { get; set; }
        private DateTime DataZakupu { get; set; }
        private StatusSamochodu StatusSamochodu { get; set; }
        public Samochod()
        {
            Marka = "Nienzana";
            Model = "Nieznany";
            RokProdukcji = 0;
            PojemnoscSilnika = 0;
            CzyDiesel = false;
        }
        public Samochod(string marka, string model, int rokProdukcji)
        {
            Marka = marka;
            Model = model;
            RokProdukcji = rokProdukcji;
        }
        public Samochod(string marka, string model, int rokProdukcji, double pojemnoscSilnika) : this(marka, model, rokProdukcji)
        {
            PojemnoscSilnika = pojemnoscSilnika;
        }
        public Samochod(string marka, string model, int rokProdukcji, double pojemnoscSilnika, bool czyDiesel) : this(marka, model, rokProdukcji, pojemnoscSilnika)
        {
            PojemnoscSilnika = pojemnoscSilnika;
        }
        public Samochod(string marka, string model, int rokProdukcji, double pojemnoscSilnika, bool czyDiesel, DateTime datazakupu, StatusSamochodu statusSamochodu) : this(marka, model, rokProdukcji, pojemnoscSilnika, czyDiesel)
        {
            DataZakupu = datazakupu;
            StatusSamochodu = statusSamochodu;
        }
        public void ShowInformation()
        {
            Console.WriteLine("Marka: " + Marka);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Rok produkcji: " + RokProdukcji);
            Console.WriteLine("Pojemnosc silnika: " + PojemnoscSilnika);
            if (CzyDiesel == true) Console.WriteLine("Samochod jest dieslem.");
            else Console.WriteLine("Samochod nie jest dieslem.");
            Console.WriteLine("Data zakupu: " + DataZakupu.ToShortDateString());
            Console.WriteLine("Status samochodu: " + StatusSamochodu);
        }
        public int ObliczWiekSamochodu()
        {
            int x = DateTime.Now.Year;
            return x - RokProdukcji;
        }
    }
}
