using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Registration.Models;

namespace Registration.Controllers
{
    public class RegisterController : Controller
    {

        // GET: Register/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(RegisterViewModel user)
        {
            return RedirectToAction("Create", "Register");
        }
    }
}