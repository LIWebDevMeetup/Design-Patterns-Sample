using StrategyPattern.Contracts;
using StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrategyPattern.Extensions
{
    public static class EventExtensions
    {
        public static IEnumerable<Event> ApplyDiscount(this IEnumerable<Event> events, IDiscountStrategy discountStrategy)
        {
            foreach (Event e in events)
                e.TicketPrice.SetAndApplyDiscountStrategy(discountStrategy);
            return events;
        }

        

    }
}