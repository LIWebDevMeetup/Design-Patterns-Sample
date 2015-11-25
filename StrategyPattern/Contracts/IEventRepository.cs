using StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrategyPattern.Contracts
{
    public interface IEventRepository 
    {
        IEnumerable<Event> GetEvents(StrategyPattern.Enumerations.EventEnumerations.CustomerType customerType);
    }
}