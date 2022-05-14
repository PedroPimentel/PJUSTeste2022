using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ViaCepAPI.Models.Entities
{
    public class Address
    {
        [Key]
        public Guid AddressId { get; set; }
        public string Cep { get; set; }
        public string District { get; set; }
        public string Complement { get; set; }
        public string Ddd { get; set; }
        public string Gia { get; set; }
        public string Uf { get; set; }
        public string Ibge { get; set; }
        public string Locality { get; set; }
        public string PublicPlace { get; set; }
        public string Siafi { get; set; }
        public DateTime Date { get; set; }

    }
}
