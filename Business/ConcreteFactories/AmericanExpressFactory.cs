using Business.AbstractFactory;
using Entities.Abstract;
using Entities.Concretes;

namespace Business.ConcreteFactories
{
    public class AmericanExpressFactory:IBankAbstractFactory
    {
        public IBank CreateCreditCard()
        {
            return new AmericanExpress();
        }
    }
}