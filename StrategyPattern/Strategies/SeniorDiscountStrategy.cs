using StrategyPattern.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrategyPattern.Strategies
{
    public class SeniorDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal price)
        {
            //Applies a 10% Senior Discount
            return price * 0.10M;
        }
    }
}