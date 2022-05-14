using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ViaCepView.Controllers
{
    public class SearchAddressController : Controller
    {
        private readonly string _apiAddress;
        public SearchAddressController(IConfiguration configuration)
        {
            _apiAddress = configuration.GetSection("ApiAddress").Value;
        }
        public IActionResult Index()
        {
            ViewBag.baseAddressApi = _apiAddress;
            return View();
        }
    }
}
