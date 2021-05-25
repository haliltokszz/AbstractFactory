using System;

namespace Entities.Abstract
{
    public interface IBank
    {
        public string CardNumber { get; set; }
        public string CardOwner { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}