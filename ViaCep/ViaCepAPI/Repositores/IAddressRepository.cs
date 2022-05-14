using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViaCepAPI.Models.Entities;

namespace ViaCepAPI.Repositores
{
    public interface IAddressRepository
    {
        void Add(Address address);
    }
}
