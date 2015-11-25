using StrategyPattern.Contracts;
using StrategyPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrategyPattern.Models
{
    public class Price
    {
        //Setter dependency injection: used often when there is a "soft" dependency or when you have something instantiated to a default (in our case NullDiscount)
        IDiscountStrategy _discountStrategy;
        public decimal Cost { get;set; }
        public decimal DiscountedCost { get; set; }

        /// <summary>
        /// When you instantiate a price class, it defaults to doing nothing (returning the same cost).
        /// </summary>
        public Price()
        {
            _discountStrategy = new NullDiscountStrategy();
        }

        /// <summary>
        /// Swaps out and recalculates the cost of a given Price through the applied discount algorithm
        /// </summary>
        /// <param name="discountStrategy"></param>
        public void SetAndApplyDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
            this.DiscountedCost = _discountStrategy.ApplyDiscount(this.Cost);
        }


    }
}