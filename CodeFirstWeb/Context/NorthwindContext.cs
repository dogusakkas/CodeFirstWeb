using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CodeFirstWeb.Entities;

namespace CodeFirstWeb.Context
{
    public class NorthwindContext:DbContext
    {
        public NorthwindContext()
            : base ("NorthwindConnection")
        {

        }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}