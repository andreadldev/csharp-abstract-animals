using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Classes
{
    public class Passerotto : Animale, IVolante
    {
        public void Vola()
        {
            Console.WriteLine("Sto volando!!!");
        }
        public override void Mangia()
        {
            Console.WriteLine("Bruchi");
        }

        public override void Verso()
        {
            Console.WriteLine("Cinguetta");
        }
    }
}
