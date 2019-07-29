using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MightyGrab.Models;
using MightyGrab.Views.Base;

namespace MightyGrab.Controllers
{
    public class BaseController : Controller
    {
        
        
        public IActionResult Index()
        {
            IndexModel m = new IndexModel();
            return View(m);
        }

        public IActionResult Create()
        {
            return View(new BaseGrabModel());
        }

    }
}