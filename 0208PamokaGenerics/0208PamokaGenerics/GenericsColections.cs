using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0208PamokaGenerics
{
    internal class GenericsColections<T>
    {
        //Sukurkite generic klasę su type T Read Only sąrašu(kintamieji priskiriami inicializuojant ir jų keisti nebegalima). Sąrašas reikšmių inicializuoti sąrašui turi ateiti per konstruktorių.
        //Turi būti funkcijos:
        //Atspausdinti sąrašą
        //Funkcija, kuri grąžina sąrašą konvertuotą į masyvą;
        //Funkcija, kuri suranda ir grąžina VIENĄ atitkmenį sąraše.Jeigu rado daugiau ar mažiau negu vieną turi mesti mesti klaidą;
        //Funkcija, kuri suranda ir grąžina vieną atitikmenį sąraše, BET jeigu jo neranda, grąžina default’inę to duomenų tipo reikšmę.Jeigu randa daugiau NEGU 1 tada meta klaidą;
        //Funkcija kuri patikrina ar egzistuoja nurodytos reikšmės kintamasis sąraše ir grąžina bool tipo reikšmę atitinkančią paieškos rezultatą;
        private readonly List<T> List;

        public GenericsColections(List<T> list)
        {
            List = list;
        }
        public void PrintList()
        {
            foreach (T item in List)
            {
                Console.Write($"{item},");
            }
        }
        public T[] ListConverter(List<T> list)
        {
            return list.ToArray();
        }

        public T FindValue(T value, List<T> list)
        {
            //int counter = 0;
            //foreach (T item in list)
            //{
            //    if (value.Equals(item))
            //        counter++;
            //}
            //if (counter == 0)
            //    throw new ArgumentException(nameof(value) + "item dont exist");

            //else if (counter == 1)
            //    return value;

            //else
            //    throw new ArgumentException(nameof(value) + "found more than one");
            T foundValue = list.Single<T>(s => s.Equals(value));
            return foundValue;
        }
        public T FindValue2(T value, List<T> list)
        {

            return list.SingleOrDefault(s => s.Equals(value));
        }
        public bool CheckIfValueExists(T value, List<T> list)
        {
            bool contains = list.Contains(value);
            return contains;
        }



    }
}
 