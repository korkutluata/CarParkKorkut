using CarPark.User.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CarPark.User.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer<HomeController> _localizer;
        public HomeController(ILogger<HomeController> logger, IStringLocalizer<HomeController> localizer)
        {
            _logger = logger;
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            #region Mongodb baglanti deneme
            //var client = new MongoClient("mongodb+srv://korkut:bobiduman@carparkcluster.t3o0d.mongodb.net/CarParkDB?retryWrites=true&w=majority");
            //var database = client.GetDatabase("CarParkDB");
            //var collection = database.GetCollection<Test>("Test");

            //var test = new Test()
            //{
            //    _Id = ObjectId.GenerateNewId(),
            //    NameSurname = "Mahmut Yıldız",
            //    Age = 28,
            //    AddressList = new List<Address>()
            //    {
            //        new Address
            //        {
            //            Title="Ev Adresim",
            //            Description="4.Levent / İstanbul"
            //        },
            //        new Address
            //        {
            //            Title="Baba Evi",
            //            Description="Etimesgut / Ankara"
            //        }
            //    }
            //};
            //collection.InsertOne(test);
            #endregion

            //var say_Hello_value = _localizer["Say_Hello"];

            //var cultureInfo = CultureInfo.GetCultureInfo("en-US");
            //Thread.CurrentThread.CurrentCulture = cultureInfo;
            //Thread.CurrentThread.CurrentUICulture = cultureInfo;
            
            //var say_Hello_value2 = _localizer["Say_Hello"];


            var customer = new Customer
            {
                Id = 1,
                NameSurname = "Mehmet Fatih Yıldız",
                Age = 26
            };
            _logger.LogError("Customer'da bir hata oluştu {@customer}", customer); // amacımız, customer nesnesini loglamak
            //_logger.LogInformation("Bu ilk logum");
            //_logger.LogError("Bu ilk error logum");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
