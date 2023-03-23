using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IVolante
{
    public void Vola();
}

public interface INuotante
{
    public void Nuota();
}

public abstract class Animale
{
    public void Dormi()
    {
        Console.WriteLine("Zzz");
    }

    public abstract void Verso();

    public abstract void Mangia();
}

