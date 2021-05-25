using System;
using Entities.Abstract;

namespace Entities.Concretes
{
    public class AmericanExpress:IBank
    {
        private string _cardNumber;

        public string CardNumber
        {
            get => "AmericanExpress: "+_cardNumber;
            set
            {
                int cardSecondDigit = value[1] - '0';
                if (value.Length != 15) throw new Exception("Card number length must be equals 15!");
                if (value[0] != '3') throw new Exception("Card number must starts with 3!");
                if (cardSecondDigit != 4 && cardSecondDigit != 7) 
                    throw new Exception("Card number's second digit must be equals 4 or 7!");
                _cardNumber = value;
            }
        }
        public string CardOwner { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}