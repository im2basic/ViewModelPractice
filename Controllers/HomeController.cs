using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModel.Models;

namespace ViewModel.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            MyModel Message = new MyModel ()
            {
                Message = "hOW DOES mICROSOFT wORD DEAL WITH THE cAPS lOCK KEY?"
            };
            return View(Message);
        }

        [HttpGet("/num")]
        public IActionResult Num()
        {
            
            int [] numbers =  new int [] 
            {
                1,2,3,4
            };
            
            return View(numbers);
        }

        [HttpGet("/list")]
        public IActionResult List()
        {
            MyModel aperson = new MyModel();
            aperson.FirstName = "sally";
            aperson.LastName= "Sanderson";
            MyModel anotherperson = new MyModel();
            anotherperson.FirstName = "terrence";
            anotherperson.LastName= "williams";
            MyModel withperson = new MyModel();
            withperson.FirstName = "Zion";
            withperson.LastName= "Spartan";
            List<MyModel>Anisong=new List<MyModel>()
            {
                aperson,anotherperson,withperson
            };
            return View ("List", Anisong);
        }

        [HttpGet("/user")]
        public IActionResult Users()
        {
            MyModel Moose = new MyModel();
            Moose.FirstName = "Moose";
            Moose.LastName="Phillips";
            return View("Users", Moose);
        }

    }
}
