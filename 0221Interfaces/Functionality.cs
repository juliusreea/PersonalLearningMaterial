using System;

namespace _0221Interfaces.Funtionality
{
    public static class Functionality
    {

        //Sukurkite interface’ą pavadinimų IVehicle su metodais Drive ir Refuel(grąžinimo 
        //tipą galit pasirinkti patys ir tai kaip jį implementuosit, galite daryti ir su void)
        //Tada sukurkite klasę Car, kuri implementuos šį interface’ą ir taip pat turės properties string Model ir int Fuel.
        //Implementuokite reikalingus metodus, Drive() metodas turi patikrinti ar degalai nėra pasibaigę, jeigu ne, važiuoti galima. 
        //Refuel metodas turi patikrinti ar kiekis, kuriuo norima papildyti nėra minusinis(galite padaryti ir maksimalų degalų bako dydį, 
        //bet pagalvokite, kaip tą funkcionalumą pernaudosite)

        public static void Printer(this string input)
        {
            Console.WriteLine(input);
        }
        public static void Printer(this bool input, string infoMessage)
        {
            Console.WriteLine($"{infoMessage}, {input}");
        }
    }
}