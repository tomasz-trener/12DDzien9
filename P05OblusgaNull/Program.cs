using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05OblusgaNull
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Czlowiek c = new Czlowiek();
            string s = c.Samochod?.Marka;

            int? r = c.Samochod?.RokProdukcji;


            if (c.Samochod != null)
            {
                r = c.Samochod.RokProdukcji;
            }
        }
    }
}
