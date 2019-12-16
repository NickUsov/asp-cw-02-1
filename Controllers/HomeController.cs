using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Book book)
        {
            BooksRepositiry repository = new BooksRepositiry();
            repository.Add(book);
            ViewBag.count = BooksRepositiry.Count;
            return View("Thanks");
        }
    }
}