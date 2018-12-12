using System;
using System.Web.Mvc;

using static HelloWorld.Models.GreetingModels;

namespace HelloWorld.Controllers
{
    public class GreetingController : Controller
    {
        Greeting myGreeting = new Greeting();
        Greeting nameGreeting = new Greeting();

        // GET: Default

        public ActionResult Index(String id)
        {
            // Get greeting from Model and pass on to View via ViewData
            ViewData["Greeting"] = myGreeting.getGreeting(id);
            // Invoke the View
            return View();
        }

        public ActionResult SayHello(String id)
        {
            // Get greeting from Model and pass on to View via ViewData
            ViewData["Hello"] = nameGreeting.getNameGreeting(id);
            // Invoke the View
            return View();
        }
    }
}
