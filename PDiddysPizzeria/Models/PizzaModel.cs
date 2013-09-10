using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDiddysPizzeria.Models
{
  public class PizzaModel
  {
    public int id { get; set; }
    public string Name { get; set; }
    public Size Size { get; set; }
    public List<string> Toppings { get; set; } 
  }
}