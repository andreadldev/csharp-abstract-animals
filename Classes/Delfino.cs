using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Classes
{
    public class Delfino : Animale, INuotante
    {
        public void Nuota()
        {
            Console.WriteLine("Sto nuotando!!!");
        }
        public override void Mangia()
        {
            Console.WriteLine("Pesci");
        }

        public override void Verso()
        {
            Console.WriteLine("Fischia");
        }
    }
}
