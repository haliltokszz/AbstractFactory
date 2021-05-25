using Business.AbstractFactory;
using Entities.Abstract;
using Entities.Concretes;

namespace Business.ConcreteFactories
{
    public class VisaFactory:IBankAbstractFactory
    {
        public IBank CreateCreditCard()
        {
            return new Visa();
        }
    }
}