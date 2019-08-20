using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models {
    public class MyDBContext : DbContext {

        public DbSet<Product> Products { get; set; }// the "Products" will be the table name in SQL

        public DbSet<Customer> Customers { get; set; }// the "Customers" will be the table name in SQL



    }
}
