using System;
using Entities.Abstract;

namespace Entities.Concretes
{
    public class Visa:IBank
    {
        private string _cardNumber;

        public string CardNumber
        {
            get => "Visa: "+_cardNumber;
            set
            {
                if (value.Length != 13 && value.Length != 16) 
                    throw new Exception("Card number length must be equals 13 or 16!");
                if (value[0] != '4') throw new Exception("Card number must starts with 4!");
                _cardNumber = value;
            }
        }
        public string CardOwner { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}