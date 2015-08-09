using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    public class HelloWorldController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
       
        // GET: /HelloWorld/ 


        //initial value of the tutorial
        //public string Index()
        //{
        //    return "This is my <b>default</b> action...";
        //}

        // 
        // GET: /HelloWorld/Welcome/ 

        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //} 

        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        //}

        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
    }
}