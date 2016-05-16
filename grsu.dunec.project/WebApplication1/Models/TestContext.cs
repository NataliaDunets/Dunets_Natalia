using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class TestContext : DbContext
    {
        public DbSet<TestClass> TestClass1 { get; set; }

    }
}