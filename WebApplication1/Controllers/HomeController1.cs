using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework1;
using System.IO;

namespace WebApplication1.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            List<Vote> voteList = Vote.readData();
            return View(voteList);
        }
    }
}
