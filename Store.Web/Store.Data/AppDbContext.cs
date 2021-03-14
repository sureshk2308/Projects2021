using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Store.Data.Entity;
using Store.Data.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Data
{
    public class AppDbContext: IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

       //public DbSet<SignUp> SignUps { get; set; }
        public DbSet<TaxMaster> TaxMasters { get; set; }
        public DbSet<Brand> Brands { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryImage> CategoryImages  { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            //modelBuilder.Seed();

            //***   TaxMaster - START

            modelBuilder.Entity<TaxMaster>()
                .HasKey(b => b.TaxId)
                .HasName("PrimaryKey_TaxId");

            //***   TaxMaster - END

            //***   Brand Master - START

            modelBuilder.Entity<Brand>()
                .HasKey(b => b.BrandId)
                .HasName("PrimaryKey_BrandId");

            modelBuilder.Entity<Brand>()
                .Property(b => b.BrandStatus)
                .HasDefaultValue(0);

            modelBuilder.Entity<Brand>()
                .Property(s => s.CreatedDate)
                .HasDefaultValueSql("GETDATE()");

            //***   Brand Master - END

            //***   Category Master - START

            modelBuilder.Entity<Category>()
                .HasKey(b => b.CategoryId)
                .HasName("PrimaryKey_CategoryId");

            //modelBuilder.Entity<Category>()
            //.HasOne(b => b.CategoryImage)
            //.WithOne(i => i.Category)
            //.HasForeignKey<CategoryImage>(b => b.CategoryForienKey);

            modelBuilder.Entity<Category>()
                .Property(b => b.CategoryStatus)
                .HasDefaultValue(0);

            //modelBuilder.Entity<Category>()
            //    .HasOne(p => p.TaxId)
            //    .WithMany(b => b.CategoryList)
            //    .HasForeignKey(p => p.TaxId);

            //modelBuilder.Entity<Category>()
            //   .HasOne(p => p.Brand)
            //   .WithMany(b => b.CategoryList)
            //   .HasForeignKey(p => p.BrandCategoryForienKey);

            //***   Category Master - END

            //***   Product Master - START

            modelBuilder.Entity<Product>()
                .HasKey(b => b.ProductId)
                .HasName("PrimaryKey_ProductId");

            //modelBuilder.Entity<Product>()
            //.HasOne(b => b.ProductImage)
            //.WithOne(i => i.Product)
            //.HasForeignKey<ProductImage>(b => b.ProductForienKey);

            modelBuilder.Entity<Product>()
                .Property(b => b.ProductStatus)
                .HasDefaultValue(0);

            //modelBuilder.Entity<Product>()
            //    .HasOne(p => p.TaxMaster)
            //    .WithMany(b => b.ProductList)
            //    .HasForeignKey(p => p.TaxProductForienKey)
            //    .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Product>()
            //   .HasOne(p => p.Brand)
            //   .WithMany(b => b.ProductList)
            //   .HasForeignKey(p => p.BrandProductForienKey)
            //   .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Product>()
            //  .HasOne(p => p.Category)
            //  .WithMany(b => b.ProductList)
            //  .HasForeignKey(p => p.CategoryProductForienKey)
            //  .OnDelete(DeleteBehavior.NoAction);

            //***   Product Master - END

        }

    }
}
