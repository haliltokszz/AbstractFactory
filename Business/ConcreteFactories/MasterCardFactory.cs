using Business.AbstractFactory;
using Entities.Abstract;
using Entities.Concretes;

namespace Business.ConcreteFactories
{
    public class MasterCardFactory:IBankAbstractFactory
    {
        public IBank CreateCreditCard()
        {
            return new MasterCard();
        }
    }
}