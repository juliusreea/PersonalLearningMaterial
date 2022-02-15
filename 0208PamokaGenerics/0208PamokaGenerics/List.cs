using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0208PamokaGenerics
{
    internal class MyList<T>
    {
        private T[] MyArray { get; set; }
        private int Index = 0;
        private int Size = 0;

        public MyList()
        {
            //MyArray = new T[];
        }


    }
}
