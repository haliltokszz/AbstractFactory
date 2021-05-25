using System;
using Business.AbstractFactory;
using Business.FactoryProducer;
using Entities.Abstract;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            IBankAbstractFactory visaCardFactory = BankFactoryProducer.getFactory("4123456789012");
            IBank visaCard = visaCardFactory.CreateCreditCard();
            visaCard.CardNumber = "4123456789012";
            Console.WriteLine(visaCard.CardNumber);
            
            IBankAbstractFactory masterCardFactory = BankFactoryProducer.getFactory("5223456789012345");
            IBank masterCard = masterCardFactory.CreateCreditCard();
            masterCard.CardNumber = "5223456789012345";
            Console.WriteLine(masterCard.CardNumber);
            
            IBankAbstractFactory americanExpressFactory = BankFactoryProducer.getFactory("372345678901234");
            IBank americanExpress = americanExpressFactory.CreateCreditCard();
            americanExpress.CardNumber = "372345678901234";
            Console.WriteLine(americanExpress.CardNumber);
        }
    }
}