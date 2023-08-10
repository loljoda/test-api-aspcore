using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestAPI.Models;

namespace TestAPI.Data
{
    public class TestAPIContext : DbContext
    {
        public TestAPIContext (DbContextOptions<TestAPIContext> options)
            : base(options)
        {
        }

        public DbSet<TestAPI.Models.Test> Test { get; set; } = default!;
    }
}