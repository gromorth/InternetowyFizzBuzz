using InternetowyFizzBuzz.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetowyFizzBuzz.Data
{
    public class FizzContex : DbContext
    {
        public FizzContex(DbContextOptions options) : base(options) { }

        public DbSet<FizzBuzz> FizzBuzz { get; set; }

        public DbSet<Container> Container { get; set; }
    }
}
