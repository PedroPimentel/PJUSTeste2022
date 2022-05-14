using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViaCepAPI.Services;

namespace TestViaCep
{
    [TestFixture]
    public class SearchAddress
    {
        private ISearchAddressService _searchAddressService;

        public SearchAddress()
        {
            _searchAddressService = new SearchAddressService();
        }

        [SetUp]
        public void SetUp(ISearchAddressService searchAddressService)
        {
            //_searchAddressService = searchAddressService;
            _searchAddressService = new SearchAddressService();
        }

        [Test]
        public void SearchNotReturnNullEvenIfCepIsNull()
        {
            var result = _searchAddressService.GetAddress("31035460");

            Assert.IsNotNull(result);
        }
    }
}
