using System;
using ATM.Extensions;
namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CardRepository cardRepository = new CardRepository();
            cardRepository.Cards.Add(new Card("user1", 100, 1222));
            cardRepository.Cards.Add(new Card("user2", 1000, 3131));
            cardRepository.Cards.Add(new Card("user16", 2100, 2222));
            cardRepository.Cards.Add(new Card("user3", 3100, 4343));
            cardRepository.Cards.Add(new Card("user8", 1500, 5252));
            cardRepository.Cards.Add(new Card("user9", 1600, 6161));
            cardRepository.Cards.Add(new Card("user12", 6100, 2211));
            cardRepository.Cards.Add(new Card("user", 900, 1616));

            foreach (Card card in cardRepository.Cards)
            {
                card.ToString().Printer();
            }
            FileWriteService fileWriteService = new FileWriteService();
            fileWriteService.WriteToFile(cardRepository);
            string path = @"C:\Users\Dell\source\repos\PersonalLearningMaterial\ATM\cardinfo.csv";
            var cards = fileWriteService.LoadFromFileText<Card>(path);

        }
    }
}
