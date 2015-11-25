using StrategyPattern.Contracts;
using StrategyPattern.Models;
using StrategyPattern.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
 


namespace StrategyPattern.Controllers
{
    //using the strategy pattern, we can switch algorithms at runtime and alter an object's behavior

    /// <summary>
    /// The strategy pattern allows you to define a group of algorithms and programmatically switch them out for solving business problems.
    /// Because our solutions (concrete strategies) implement the same strategy interface, each one follows the same format while the underlying implementation details are different.
    /// By taking advantage of this fact, we can dynamically apply our algorithms to serve our business needs while the implementation details are abstracted away. 
    /// The selection process is typically done using a Factory pattern. 
    /// 
    /// Being able to identify when to use the strategy pattern can be challenging. Sometimes an area to consisder is a switch statement - these conditions can grow and grow and each time you need to make additional changes, 
    /// you need to modify the same code file to add more logic/conditions.  I've seen code where there were hundreds of lines of code that
    /// involved 5-10 cases in a switch statement, and this one class needed to be maintained every time we wanted to add an update. If you see these areas and sense they are going to grow,
    /// it might be a good idea to think about how a design pattern (potentially the strategy pattern) can make the code more extensible.
    /// 
    /// So why is this a big deal? A huge part of software development is code maintenance. With the Strategy Pattern in place, you just have to add a new algorithm (strategy) 
    /// instead of modifying your code. This stays in line with the Open / Closed principle, which states that entities should be open for extension 
    /// but closed for modification (don't have to necessarily modify your existing code to add more functionality). 

    /// The downside - Once you have a hammer, everything looks like a nail. Always avoid adding this just to make things complex and stylish. It should have a real value-add. Be pragmatic. If you have a small series of switch statements and it
    /// gets repeated once, you could probably get away with something in a service layer to handle the common functionality. 
    /// 
    /// Let's consider an example:
    /// We have a business case where users of our API need to provide a document number and we would like to validate each one accordingly.
    /// 
    /// In each country, you can have a variety of national documents to provide, but let's say each one uses only one (perhaps their equivalent of a social security number).
    /// In Spain, you could have a DNI number, and in the US, you can have a social. Let's say the validation logic for each of these is complex enough where it warrants its own algorithm (not just a simple regex)
    /// 
    /// A quick approach could be to just have some if..then or switch statements to determine who you are, and take the appropriate action. But as the complexity of validating increases, potentially, or we need to
    /// add on even more countries, this could become more difficult to manage.
    /// 
    /// Based on this potential risk in the application, we can utilize the strategy pattern to select the type of validation algorithm to use when validating a number in a cleaner and more maintaniable way.
    /// 
    /// Another example, which is covered in this code, is for applying discounts based on the type of user you are.
    /// If you're a student, you get a 10% discount, if you're a non profit, you get a 15% discount, and if you're buying in a group (bulk), you get a 20% discount to the original cost.
    /// 
    /// 
    /// </summary>

    public class EventController : ApiController
    {
        //Constructor dependency injection: used often when there is a critical dependency on something
        readonly IEventRepository _eventRepository;

        //NInject swaps IEventRepository with FakeEventRepository
        public EventController(IEventRepository eventRepository)
        {
            this._eventRepository = eventRepository;
        }

        // GET: api/Event?customerID=1
        public IEnumerable<Event> Get(int customerID)
        {            
            return _eventRepository.GetEvents(UserService.GetCustomerTypeFromID(customerID));
        }

        
       
    }
}
