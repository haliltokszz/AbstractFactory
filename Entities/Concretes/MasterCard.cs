using System;
using Entities.Abstract;

namespace Entities.Concretes
{
    public class MasterCard: IBank
    {
        private string _cardNumber;

        public string CardNumber
        {
            get => "MasterCard: "+_cardNumber;
            set
            {
                int cardSecondDigit = value[1] - '0';
                if (value.Length != 16) throw new Exception("Card number length must be equals 16!");
                if (value[0] != '5') throw new Exception("Card number must starts with 5!");
                if (cardSecondDigit <= 1 || cardSecondDigit >= 5) 
                    throw new Exception("Card number's second digit must be between 1 and 5!");
                _cardNumber = value;
            }
        }

        public string CardOwner { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}