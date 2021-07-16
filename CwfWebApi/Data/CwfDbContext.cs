using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CwfWebApi.Models;

    public class CwfDbContext : DbContext
    {
        public CwfDbContext (DbContextOptions<CwfDbContext> options)
            : base(options)
        {
        }

    public DbSet<CwfWebApi.Models.User> Users { get; set; }
    public DbSet<CwfWebApi.Models.Customer> Customers { get; set; }
    public DbSet<CwfWebApi.Models.Payment> Payments { get; set; }
    public DbSet<CwfWebApi.Models.Invoice> Invoices { get; set; }
    public DbSet<CwfWebApi.Models.Load> Loads { get; set; }
    public DbSet<CwfWebApi.Models.Request> Requests { get; set; }

    public int MyProperty { get; set; }




}
