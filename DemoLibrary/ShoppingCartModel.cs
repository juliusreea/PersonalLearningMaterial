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

        public decimal GenerateTotal(MentionDiscount mentionDiscount,
            Func<List<ProductModel>, decimal,decimal> calculateDiscounterTotal,
            Action<List<ProductModel>> displayItemsInCart,
            Action<string> mentionsDiscounting)
        {
            var subTotal = List.Sum(x=>x.Price);

            var sortedList = List.OrderBy(x => x.Price).ToList();
            displayItemsInCart(sortedList);

            mentionDiscount(subTotal);

            mentionsDiscounting("we are applying discount");

            return calculateDiscounterTotal(List,subTotal);
        }
        
    }
}
