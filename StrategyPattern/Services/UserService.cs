using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrategyPattern.Services
{
    public static class UserService
    {
       
        /// <summary>
        /// Mock User Service to return a customer type based on the user id
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public static StrategyPattern.Enumerations.EventEnumerations.CustomerType GetCustomerTypeFromID(int customerID)
        {
            switch(customerID)
            {
                case 1:
                    return Enumerations.EventEnumerations.CustomerType.Standard;
                case 2:
                    return Enumerations.EventEnumerations.CustomerType.Student;
                case 3:
                    return Enumerations.EventEnumerations.CustomerType.NotForProfit;
                case 4:
                    return Enumerations.EventEnumerations.CustomerType.Group;
                default:
                    return Enumerations.EventEnumerations.CustomerType.Standard;
            }
            
        }

    }
}