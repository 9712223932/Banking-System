using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Controllers;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class BankingSystemController : Controller
    {
        public ActionResult Create()
        {
            return View( new CustomerInformation());
        }

        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        public ActionResult Index()
        {
           using (BankingSystemEntities1 db = new BankingSystemEntities1())
            {
                List<CustomerInformation> CustomerInformationList = (from data in db.CustomerInformations
                                                                     select data).ToList();
                return View(CustomerInformationList);
            }
        }
    }
}