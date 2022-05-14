using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViaCepAPI.Services;

namespace ViaCepAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [AllowAnonymous]

    public class SearchAddressController : Controller
    {
        private readonly ISearchAddressService _searchAddressService;

        public SearchAddressController(ISearchAddressService searchAddressService)
        {
            _searchAddressService = searchAddressService;
        }

        [HttpGet]
        [Route("GetAddress/{cep}")]
        [AllowAnonymous]
        public IActionResult GetAddress(string cep)
        {
            return Json(_searchAddressService.GetAddress(cep));
        }
    }
}
