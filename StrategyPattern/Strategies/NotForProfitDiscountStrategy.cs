using StrategyPattern.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrategyPattern.Strategy
{
    public class NotForProfitDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal price)
        {
            //Applies a 15% Not For Profit Discount
            return price * 0.85M;
        }
    }
}