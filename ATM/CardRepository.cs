using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class CardRepository
    {
        public List<Card> Cards { get; set; }

        public CardRepository()
        {
            Cards = new List<Card>();
        }
    }
}
