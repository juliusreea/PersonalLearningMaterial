using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class CardFunctionality
    {
        public bool InputCheck(Card card, List<Card> cards)
        {
            var cardExists = true;
            cards.Where(x => x.Id == card.Id);
            return true;
        }
    }
}
