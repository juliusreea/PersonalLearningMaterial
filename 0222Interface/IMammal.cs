using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0222Interface
{
    internal interface IMammal
    {
        public int MaximumOffspring { get; set; }

        public void GiveBirth();
    }
}
