using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrategyPattern.Contracts
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal price);
    }
}