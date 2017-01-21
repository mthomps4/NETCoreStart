using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NETCoreLook.Views.Home
{
    public class HelloWorld : Controller
    {
        // GET: /Hellow World/
        public IActionResult Index()
        {
            return View();
        }

        //GET: /HelloWorld/Welcome/ 
        public IActionResult Welcome(string name)
        {
            ViewData["Welcome"] = "Hello " + name; 
            return View(); 
        }
    }
}
