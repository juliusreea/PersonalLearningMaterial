using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _0222Interface
{
    internal interface IWriteableToFile<T, T2>
    {
        public void WriteToFile(T fileName);

    }
}
