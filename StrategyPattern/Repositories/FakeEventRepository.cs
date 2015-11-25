using StrategyPattern.Contracts;
using StrategyPattern.Factory;
using StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StrategyPattern.Extensions;

namespace StrategyPattern.Repositories
{
    public class FakeEventRepository : IEventRepository
    {
        public IEnumerable<Event> GetEvents(StrategyPattern.Enumerations.EventEnumerations.CustomerType customerType)
        {
            //Hydrate list with mock data. Each event has a base price (used for the standard customer type)
            IEnumerable<Event> events = new List<Event>()
            {
               {new Event{ Name = "Symposium on Software Development", Date = new DateTime(2015, 12, 15), TicketPrice = new Price{ Cost = 150}, 
                Location = new Location{ Address1 = "55 test street", Address2="", Name="The Blue Theater", State="NY", Zipcode="11757" }}}, 
               {new Event{ Name = "SQL Injection and XSS Attacks", Date = new DateTime(2016, 1, 21), TicketPrice = new Price{ Cost = 75} , 
                Location = new Location{ Address1 = "55 test street", Address2="", Name="The Blue Theater", State="NY", Zipcode="11757" }}}, 
               {new Event{ Name = "Security in Software Development", Date = new DateTime(2015, 11, 14), TicketPrice = new Price{ Cost = 250}, 
                Location = new Location{ Address1 = "55 test street", Address2="", Name="The Blue Theater", State="NY", Zipcode="11757" }}}
           };

            //Determine which strategy to apply based on the customer type
            IDiscountStrategy discountStrategy = DiscountFactory.GetDiscountStrategyForCustomerType(customerType);

            //Apply the discount selected to each product, and return the discounted collection
            return events.ApplyDiscount(discountStrategy);
        }





    }
}