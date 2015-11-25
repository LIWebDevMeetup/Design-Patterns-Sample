using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrategyPattern.Models
{
    public class Event
    {
        public int ID { get; set; }
        public Price TicketPrice { get; set; }
        public string Name { get; set; }
        public Location Location { get; set; }
        public DateTime Date { get; set; }
    }
}