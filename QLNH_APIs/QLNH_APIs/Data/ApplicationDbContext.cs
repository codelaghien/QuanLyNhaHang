using Microsoft.EntityFrameworkCore;
using QLNH_APIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNH_APIs.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Guest> Guest { get; set; }
        public DbSet<GuestTable> GuestTable { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Unit> Unit { get; set; }
        public DbSet<UnitType> UnitType { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<ItemImage> ItemImage { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Location> Location { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}