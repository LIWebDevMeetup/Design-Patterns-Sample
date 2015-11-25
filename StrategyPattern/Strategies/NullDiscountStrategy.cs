using StrategyPattern.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrategyPattern.Strategy
{
    /// <summary>
    /// This is our Null Object design pattern, and for the purposes of our strategy pattern replacing a 'switch' statement, it also serves as our 'default' case.
    /// 'default case' would be our equivalent in our enumeration as:
    /// [DiscountTypeAttribute(typeof(NullDiscountStrategy))] Standard
    /// 
    /// null object would be in our constructor in Price class
    ///    public Price() {  _discountStrategy = new NullDiscountStrategy();  }
    ///    The benefit of the null strategy pattern is it's predictable (we always know it will do nothing, or in our case return the same price).
    /// </summary>
    public class NullDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal price)
        {
            return price;
        }
    }
}