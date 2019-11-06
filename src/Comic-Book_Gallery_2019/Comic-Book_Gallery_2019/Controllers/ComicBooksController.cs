using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Comic_Book_Gallery_2019.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
           if(DateTime.Today.DayOfWeek== DayOfWeek.Sunday)
            {
                return new RedirectResult("/");
            }
            return Content( $"Hello again from the controller, ad today is : {DateTime.Today.} ");
        }
    }
}