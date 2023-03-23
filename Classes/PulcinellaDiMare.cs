using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Classes
{
    public class PulcinellaDiMare : Animale, INuotante, IVolante
    {
        public void Nuota()
        {
            Console.WriteLine("Sto nuotando!!!");
        }
        public void Vola()
        {
            Console.WriteLine("Sto volando!!!");
        }
        public override void Mangia()
        {
            Console.WriteLine("Pesci");
        }

        public override void Verso()
        {
            Console.WriteLine("...");
        }
    }
}
