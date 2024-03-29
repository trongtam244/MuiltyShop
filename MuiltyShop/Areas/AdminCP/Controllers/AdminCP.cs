﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MuiltyShop.Models;

namespace MuiltyShop.Areas.AdminCP.Controllers
{
    [Area("AdminCP")]
    [Authorize(Roles = RoleName.Administrator)]
    public class AdminCP : Controller
    {
        [Route("/admincp/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
