using CarPark.User.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CarPark.User.Controllers
{
    public class UserController : Controller
    {
        private readonly IStringLocalizer<UserController> _localizer;

        public UserController(IStringLocalizer<UserController> localizer)
        {
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            //var cultureInfo = CultureInfo.GetCultureInfo("ar-SA");
            //Thread.CurrentThread.CurrentCulture = cultureInfo;
            //Thread.CurrentThread.CurrentUICulture = cultureInfo;
            var nameSurnameValue = _localizer["NameSurname"];
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserCreateRequestModel request)
        {
            return View(request);
        }


    }
}
