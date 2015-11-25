using StrategyPattern.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrategyPattern.Strategy
{
    public class StudentDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal price)
        {
            //Applies a 10% Student Discount
            return price * 0.90M;
        }
    }
}