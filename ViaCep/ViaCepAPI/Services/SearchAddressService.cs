using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using ViaCepAPI.Models.Entities;
using ViaCepAPI.Repositores;
using ViaCepAPI.ViewModels;

namespace ViaCepAPI.Services
{
    public class SearchAddressService : ISearchAddressService
    {
        private readonly IAddressRepository _addressRepository;

        public SearchAddressService()
        {

        }
        public SearchAddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }
        public AddressViewModel GetAddress(string cep)
        {
            var URL = new UriBuilder(string.Concat("https://viacep.com.br/ws/", cep, "/json"));
            var queryString = HttpUtility.ParseQueryString(string.Empty);
            URL.Query = queryString.ToString();

            var client = new WebClient();

            var responseRequest = client.DownloadString(URL.ToString());
            var response = JsonConvert.DeserializeObject<AddressViewModel>(responseRequest);

            if (string.IsNullOrEmpty(response.erro))
            {
                _addressRepository.Add(new Address
                {
                    AddressId = Guid.NewGuid(),
                    Cep = response.Cep,
                    Complement = response.Complemento,
                    Ddd = response.Ddd,
                    District = response.Bairro,
                    Gia = response.Gia == "" ? null : response.Gia,
                    Ibge = response.Ibge,
                    Locality = response.Localidade,
                    PublicPlace = response.Logradouro,
                    Siafi = response.Siafi == "" ? null : response.Siafi,
                    Uf = response.Siafi,
                    Date = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time"))
                });
            }

            return response;
        }
    }
}
