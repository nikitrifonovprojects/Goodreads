using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Goodreads.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Show()
        {
            return View();
        }
    }
}
