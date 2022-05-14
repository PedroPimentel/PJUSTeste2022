using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViaCepAPI.Models.Contexts;
using ViaCepAPI.Models.Entities;

namespace ViaCepAPI.Repositores
{
    public class AddressRepository : IAddressRepository
    {
        private readonly ViaCepContext _context;

        public AddressRepository(ViaCepContext context)
        {
            _context = context;
        }
        public void Add(Address address)
        {
            _context.TbAddress.Add(address);
            _context.SaveChanges();
        }
    }
}
