using StrategyPattern.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using StrategyPattern.Contracts;
using StrategyPattern.Strategy;
using StrategyPattern.Attributes;


namespace StrategyPattern.Factory
{
    public static class DiscountFactory
    {
        /// <summary>
        /// Retrieves a discount strategy associated to the customer type
        /// </summary>
        /// <param name="customerType">Based on the type of customer, return the appropriate discount strategy</param>
        /// <returns>the appropriate discount strategy</returns>
            public static IDiscountStrategy GetDiscountStrategyForCustomerType(StrategyPattern.Enumerations.EventEnumerations.CustomerType customerType)
            {
                //Retrieve the enumeration's attributes specified in Enumerations/EventEnumerations.cs
                FieldInfo field = customerType.GetType().GetField(customerType.ToString());
                object[] attribs = field.GetCustomAttributes(typeof(DiscountTypeAttribute), false);

                //If no attribute was specified, then return the normal price by default
                if (attribs.Length == 0)
                    return new NullDiscountStrategy();
                                
                return Activator.CreateInstance((attribs[0] as DiscountTypeAttribute).DiscountStrategy) as IDiscountStrategy;
            }
    }
}