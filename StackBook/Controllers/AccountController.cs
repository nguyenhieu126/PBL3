﻿using Microsoft.AspNetCore.Mvc;

namespace StackBook.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Signin()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
