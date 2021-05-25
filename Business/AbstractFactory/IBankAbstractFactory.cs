using Entities.Abstract;

namespace Business.AbstractFactory
{
    public interface IBankAbstractFactory
    {
        IBank CreateCreditCard();
    }
}