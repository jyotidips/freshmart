﻿using FreshMart.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace FreshMart.Database
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Agent> Agents { get; set; }
        public DbSet<AgentOrder> AgentOrders { get; set; }

        public DbSet<District> Districts { get; set; }
        public DbSet<Division> Divisions { get; set; }


        public DbSet<Customer> Customers { get; set; }

        public DbSet<SellerRequest> SellerRequests { get; set; }


        public DbSet<Document> Documents { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            //builder.Entity<ProductOrder>().HasKey(t => new { t.ProductId, t.OrderId });

            //builder.Entity<ProductOrder>().HasOne(pt => pt.Product).WithMany(p => p.ProductOrders).HasForeignKey(pt => pt.ProductId);
            //builder.Entity<ProductOrder>().HasOne(pt => pt.Order).WithMany(p => p.ProductOrders).HasForeignKey(pt => pt.OrderId);

        }

    }
}