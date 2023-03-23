using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Classes
{
    public class Aquila : Animale, IVolante
    {
        public void FaiVolare(IVolante animale)
        {
            Console.WriteLine("Sto volando!!!");
        }
        public override void Mangia()
        {
            Console.WriteLine("Carne");
        }

        public override void Verso()
        {
            Console.WriteLine("Stride");
        }
    }
}
