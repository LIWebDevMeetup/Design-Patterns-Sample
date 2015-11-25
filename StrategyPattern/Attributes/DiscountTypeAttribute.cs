using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrategyPattern.Attributes
{
    public class DiscountTypeAttribute : Attribute
    {
        public Type DiscountStrategy { get; set; }

        public DiscountTypeAttribute(Type discountStrategy)
        {
            DiscountStrategy = discountStrategy;
        }

    }

}