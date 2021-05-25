using System;
using Business.AbstractFactory;
using Business.ConcreteFactories;

namespace Business.FactoryProducer
{
    public class BankFactoryProducer
    {
        public static IBankAbstractFactory getFactory(string cardNumber)
        {
            int cardSecondDigit = cardNumber[1] - '0'; //convert char to int
            if ((cardNumber.Length == 13 || cardNumber.Length == 16)  && cardNumber[0] == '4')
            {
                return new VisaFactory();
            }
            else if (cardNumber.Length == 15 && cardNumber[0] == '3' && 
                (cardSecondDigit == 4 || cardSecondDigit == 7) )
            {
                return new AmericanExpressFactory();
            }
            else if (cardNumber.Length == 16 && cardNumber[0] == '5' &&
                     (cardSecondDigit >= 1 && cardSecondDigit <= 5) )
            {
                return new MasterCardFactory();
            }
            else
            {
                throw new Exception("Card number did not match any bank!");
            }
        }
    }
}