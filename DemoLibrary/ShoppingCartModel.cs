using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class ShoppingCartModel
    {
        public delegate void MentionDiscount(decimal subTotal);

        public List<ProductModel> List = new List<ProductModel>();

        public decimal GenerateTotal(MentionDiscount mentionDiscount)
        {
            var subTotal = List.Sum(x=>x.Price);

            mentionDiscount(subTotal);

            if(subTotal > 100)
            {
                return subTotal * 0.8M;
            }
            else if (subTotal > 50)
            {
                return subTotal * 0.85M;
            }
            else if (subTotal > 20)
            {
                return subTotal * 0.9M;
            }
            else
            {
                return subTotal;
            }
            return subTotal;
        }
    }
}
