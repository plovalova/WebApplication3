using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}