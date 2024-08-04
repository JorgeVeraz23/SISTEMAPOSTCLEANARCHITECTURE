using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<CrudEntity> Cruds { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission > RolePermissions { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Product > Products { get; set; }
        public DbSet<ProductTagRelation > ProductTagsRelation { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Configuracion de la relacion de muchos a muchos entre Roles y Permission
            modelBuilder.Entity<RolePermission>()
                .HasKey(rp => new { rp.RoleId, rp.PermissionID });

            modelBuilder.Entity<RolePermission>()
                .HasOne(rp => rp.Role)
                .WithMany(r => r.RolePermissions)
                .HasForeignKey(rp => rp.RoleId);

            modelBuilder.Entity<RolePermission>()
                .HasOne(rp => rp.Permission)
                .WithMany(r => r.RolePermissions)
                .HasForeignKey(rp => rp.PermissionID);


            //Configuracion de la relacion entre PaymenthMethod y Payment
            modelBuilder.Entity<Payment>()
                .HasOne(rp => rp.PaymentMethod)
                .WithMany(pm => pm.Payments)
                .HasForeignKey(p => p.PaymentMethodID);

            //Configuracion de la relacion de muchos a muchos entre Product y Tag
            modelBuilder.Entity<ProductTagRelation>()
                .HasKey(ptr => new {ptr.ProductID, ptr.TagID});

            modelBuilder.Entity<ProductTagRelation>()
                .HasOne(ptr => ptr.Product)
                .WithMany(p => p.ProductTagRelations)
                .HasForeignKey(ptr => ptr.ProductID);

            modelBuilder.Entity<ProductTagRelation>()
                .HasOne(ptr => ptr.Tag)
                .WithMany(t => t.ProductTagRelations)
                .HasForeignKey(ptr => ptr.TagID);



        }

        

    }
}
