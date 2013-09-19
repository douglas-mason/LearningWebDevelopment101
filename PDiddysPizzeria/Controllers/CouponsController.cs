using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PDiddysPizzeria.Services;

namespace PDiddysPizzeria.Controllers
{
    public class CouponsController : Controller
    {
        //
        // GET: /Coupons/

        public ActionResult Index()
        {
          var customerOrderService = new CustomerOrderService();
          var customerName = customerOrderService.GetCustomerName(lastName: "Mason");
          var model = customerOrderService.GetCustomerOrderItems(5);
            return View();
        }

        //
        // GET: /Coupons/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Coupons/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Coupons/Create

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
        // GET: /Coupons/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Coupons/Edit/5

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
        // GET: /Coupons/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Coupons/Delete/5

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
