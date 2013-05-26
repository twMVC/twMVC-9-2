using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Demo1() { return View(); }
        public ActionResult Demo2() { return View(); }
        public ActionResult Demo3() { return View(); }
        public ActionResult Demo4() { return View(); }
        public ActionResult Demo5() { return View(); }
        public ActionResult Demo6() { return View(); }


        public ActionResult Final()
        {
            return View();
        }

    }
}
