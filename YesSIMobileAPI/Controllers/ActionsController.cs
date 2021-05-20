using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YesSIMobileAPI.Controllers
{
    public class ActionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
