using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PDiddysPizzeria.Models;


namespace PDiddysPizzeria.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: www.pdiddyspizza.com/

        public ActionResult Index()
        {
            var myPizza = new PizzaModel();

            myPizza.Name = "Cheese Lovers";
            myPizza.Size = new Size{Id = 2, Name = "Medium", NumberOfSlices = 8};
            myPizza.Toppings = new List<string>();
            myPizza.Toppings.Add("Cheddar");
            myPizza.Toppings.Add("Feta");
            return View(myPizza);
        }

        //
        // GET: www.pdiddyspizza/Details/5

        public ActionResult Details(int id)
        {
          
            return View();
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Home/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
