using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WpfApp2879789797898798798798797897.BD
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Point> Point { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
        public virtual DbSet<OrderComposition> OrderComposition { get; set; }
        public virtual DbSet<Placement> Placement { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturer>()
                .HasMany(e => e.Product)
                .WithOptional(e => e.Manufacturer)
                .HasForeignKey(e => e.manufacturer2);

            modelBuilder.Entity<Order>()
                .HasOptional(e => e.OrderComposition)
                .WithRequired(e => e.Order);

            modelBuilder.Entity<Point>()
                .HasMany(e => e.Order)
                .WithOptional(e => e.Point)
                .HasForeignKey(e => e.ID_item);

            modelBuilder.Entity<Product>()
                .Property(e => e.article_number)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.unit)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Placement)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.article_number)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Placement1)
                .WithRequired(e => e.Product1)
                .HasForeignKey(e => e.article_number)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Provider>()
                .HasMany(e => e.Product)
                .WithOptional(e => e.Provider)
                .HasForeignKey(e => e.provider2);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.role1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Order)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.ID_client);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.Placement)
                .WithRequired(e => e.Warehouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderComposition>()
                .Property(e => e.article_number)
                .IsFixedLength();

            modelBuilder.Entity<Placement>()
                .Property(e => e.article_number)
                .IsFixedLength();
        }
    }
}
