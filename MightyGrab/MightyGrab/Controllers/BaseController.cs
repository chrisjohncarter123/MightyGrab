using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MightyGrab.Models;

namespace MightyGrab.Controllers
{
    public class BaseController : Controller
    {

        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View(new BaseGrabModel());
        }

        public IActionResult View()
        {
            return View(new BaseGrabModel());
        }
    }
}