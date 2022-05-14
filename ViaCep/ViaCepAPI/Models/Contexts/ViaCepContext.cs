using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViaCepAPI.Models.Entities;

namespace ViaCepAPI.Models.Contexts
{
    public class ViaCepContext : DbContext, IViaCepContext
    {
        public ViaCepContext(DbContextOptions<ViaCepContext> options) : base(options) { }

        public DbSet<Address> TbAddress{ get; set; }
    }
}
