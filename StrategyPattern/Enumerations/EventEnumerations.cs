using StrategyPattern.Attributes;
using StrategyPattern.Contracts;
using StrategyPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrategyPattern.Enumerations
{
    public static class EventEnumerations
    {
        public enum CustomerType
        {
            [DiscountTypeAttribute(typeof(NullDiscountStrategy))]
            Standard,
            [DiscountTypeAttribute(typeof(StudentDiscountStrategy))]
            Student,
            [DiscountTypeAttribute(typeof(NotForProfitDiscountStrategy))]
            NotForProfit,
            [DiscountTypeAttribute(typeof(GroupDiscountStrategy))]
            Group            
        }
    }

    
}