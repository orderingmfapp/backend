using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OrderingAppMFBackend.Models;

public partial class OrderingAppContext : DbContext
{
    public OrderingAppContext()
    {
    }

    public OrderingAppContext(DbContextOptions<OrderingAppContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ItemsOption> ItemsOptions { get; set; }

    public virtual DbSet<MenuAvailableOption> MenuAvailableOptions { get; set; }

    public virtual DbSet<MenuItem> MenuItems { get; set; }

    public virtual DbSet<MenuItemsCategory> MenuItemsCategories { get; set; }

    public virtual DbSet<MenuItemsImage> MenuItemsImages { get; set; }

    public virtual DbSet<MenuOption> MenuOptions { get; set; }

    public virtual DbSet<MenuOptionsImage> MenuOptionsImages { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Promotion> Promotions { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Session> Sessions { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:mssql-orderingapp-server.database.windows.net,1433;Initial Catalog=OrderingAppDB;User ID=sqladmin;Password=Password123;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ItemsOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("items_options_pk");

            entity.ToTable("items_options");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MenuItemsId).HasColumnName("menu_items_id");
            entity.Property(e => e.MenuOptionsId).HasColumnName("menu_options_id");
        });

        modelBuilder.Entity<MenuAvailableOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("menu_available_options_pk");

            entity.ToTable("menu_available_options");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MenuItemsId).HasColumnName("menu_items_id");
            entity.Property(e => e.OptionName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("optionName");
            entity.Property(e => e.Tag)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tag");
        });

        modelBuilder.Entity<MenuItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("menu_items_pk");

            entity.ToTable("menu_items");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.DescriptionEn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("description_en");
            entity.Property(e => e.DescriptionPl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("description_pl");
            entity.Property(e => e.MenuItemsCategoriesId).HasColumnName("menu_items_categories_id");
            entity.Property(e => e.NameEn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("name_en");
            entity.Property(e => e.NamePl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("name_pl");
            entity.Property(e => e.OnStock).HasColumnName("on_stock");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("price");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<MenuItemsCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("menu_items_categories_pk");

            entity.ToTable("menu_items_categories");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NameEn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name_en");
            entity.Property(e => e.NamePl)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name_pl");
        });

        modelBuilder.Entity<MenuItemsImage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("menu_items_images_pk");

            entity.ToTable("menu_items_images");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddedAt)
                .HasColumnType("datetime")
                .HasColumnName("added_at");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("image_url");
            entity.Property(e => e.MenuItemsId).HasColumnName("menu_items_id");
        });

        modelBuilder.Entity<MenuOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("menu_options_pk");

            entity.ToTable("menu_options");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("price");
        });

        modelBuilder.Entity<MenuOptionsImage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("menu_options_image_pk");

            entity.ToTable("menu_options_image");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("image_url");
            entity.Property(e => e.MenuOptionsId).HasColumnName("menu_options_id");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("orders_pk");

            entity.ToTable("orders");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Note)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.OrderPrice)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("order_price");
            entity.Property(e => e.SessionId).HasColumnName("Session_id");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("order_items_pk");

            entity.ToTable("order_items");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CalculatedPrice)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("calculated_price");
            entity.Property(e => e.MenuItemsId).HasColumnName("menu_items_id");
            entity.Property(e => e.Note)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.OrdersId).HasColumnName("orders_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Promotion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("promotions_pk");

            entity.ToTable("promotions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateEnd)
                .HasColumnType("datetime")
                .HasColumnName("date_end");
            entity.Property(e => e.DateStart)
                .HasColumnType("datetime")
                .HasColumnName("date_start");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("discount");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MaxNumberOfUsages).HasColumnName("max_number_of_usages");
            entity.Property(e => e.PromoCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("promo_code");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pk");

            entity.ToTable("roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Session>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sessions_pk");

            entity.ToTable("sessions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.MenuOptionsId).HasColumnName("menu_options_id");
            entity.Property(e => e.NumberOfClients).HasColumnName("number_of_clients");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("payment_method");
            entity.Property(e => e.PromotionsId).HasColumnName("promotions_id");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.TableNumber).HasColumnName("table_number");
            entity.Property(e => e.TimeToExpire)
                .HasPrecision(0)
                .HasColumnName("time_to_expire");
            entity.Property(e => e.TotalSessionPrice)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("total_session_price");
            entity.Property(e => e.UserId).HasColumnName("User_id");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pk");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Login)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("login");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.RoleId).HasColumnName("Role_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
