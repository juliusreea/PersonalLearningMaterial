using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.Extensions;
namespace ATM
{
    internal class Card
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }
        public decimal Balance { get; private set; }

        public int PinCode { get; private set; }
        public List<string> Tags { get; private set; }

        public Card(string name, decimal balance, int pinCode)
        {
            Id = Guid.NewGuid();
            Name = name;
            Balance = balance;
            PinCode = pinCode;
        }
        public override string ToString()
        {
            return $"{Id},{Name},{Balance}";
        }
    }
}
