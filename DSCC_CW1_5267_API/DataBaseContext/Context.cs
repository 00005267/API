using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.SqlServer;
using DSCC_CW1_5267_API.Models;

namespace DSCC_CW1_5267_API.DataBaseContext
{
    public class Context : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public Context(DbContextOptions<Context> options) : base(options) { Database.EnsureCreated(); }

    }
}
