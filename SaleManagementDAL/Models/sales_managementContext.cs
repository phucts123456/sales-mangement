using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SaleManagementDAL.Models
{
    public partial class sales_managementContext : DbContext
    {
        public sales_managementContext()
        {
        }

        public sales_managementContext(DbContextOptions<sales_managementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Material> Materials { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("User Id=root;Password=050101;Host=localhost;Database=sales_management;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customers");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employees");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.Sex).HasMaxLength(50);
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.ToTable("materials");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaterialName).HasMaxLength(50);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders");

                entity.HasIndex(e => e.CustomerId, "CustomerID");

                entity.HasIndex(e => e.EmployeeId, "EmployeeID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.Total).HasPrecision(10);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orders_ibfk_2");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orders_ibfk_1");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ProductId })
                    .HasName("PRIMARY");

                entity.ToTable("order_details");

                entity.HasIndex(e => e.ProductId, "ProductID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Discount).HasPrecision(10);

                entity.Property(e => e.RetailPrice).HasPrecision(10);

                entity.Property(e => e.Total).HasPrecision(10);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("order_details_ibfk_1");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("order_details_ibfk_2");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("products");

                entity.HasIndex(e => e.MaterialId, "fk_MaterialID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.CostOfGood).HasPrecision(10);

                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.Note).HasMaxLength(50);

                entity.Property(e => e.ProductName).HasMaxLength(4);

                entity.Property(e => e.RetailPrice).HasPrecision(10);

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_MaterialID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
