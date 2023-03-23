using csharp_abstract_animals.Classes;
using System;
void FaiVolare(IVolante animale)
{
    animale.Vola();
}

void FaiNuotare(INuotante animale)
{
    animale.Nuota();
}