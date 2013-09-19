using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDiddysPizzeria.Services
{
  public class CustomerOrderService
  {
    public CustomerOrderService()
    {
      
    }

    public string GetCustomerOrderItems(int itemId, int customerId)
    {
      // get customer from database
      return "Pizza";
    }

    public string GetCustomerOrderItems(int itemId)
    {
      return GetCustomerOrderItems().SingleOrDefault();
    }

    public List<string> GetCustomerOrderItems()
    {
      return new List<string>();
    }

    public string GetCustomerName(int customerId = 1, string lastName = "Diddy")
    {
      var customerLastName = lastName;
      // Go to database use customerId
      return "Paul";
    }
  }
}