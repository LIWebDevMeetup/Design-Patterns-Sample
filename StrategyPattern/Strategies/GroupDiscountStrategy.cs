using StrategyPattern.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrategyPattern.Strategy
{
    public class GroupDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal price)
        {
            //Applies a 20% Group Discount
            return price * 0.80M;
        }
    }
}