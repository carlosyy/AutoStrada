using AutoStrada.ENT;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoStrada.DAL
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(ent =>
            {
                ent.HasKey(e => e.CodeProduct);
                ent.Property(e => e.CodeProduct).ValueGeneratedOnAdd();
                ent.ToTable("Product");
                ent.HasData(new Product
                {
                    CodeProduct = 1,
                    CodeSupplier = 1,
                    DateFabrication = System.DateTime.Now,
                    DateValidity = System.DateTime.Now.AddYears(1),
                    Description = "Aceite de bacalao",
                    State = true
                });
                ent.HasData(new Product
                {
                    CodeProduct = 2,
                    CodeSupplier = 1,
                    DateFabrication = System.DateTime.Now,
                    DateValidity = System.DateTime.Now.AddYears(1),
                    Description = "jabon de cocina",
                    State = true
                });
                ent.HasData(new Product
                {
                    CodeProduct = 3,
                    CodeSupplier = 1,
                    DateFabrication = System.DateTime.Now,
                    DateValidity = System.DateTime.Now.AddYears(1),
                    Description = "Leche Pasteurizada Entera",
                    State = true
                });
                ent.HasData(new Product
                {
                    CodeProduct = 4,
                    CodeSupplier = 1,
                    DateFabrication = System.DateTime.Now,
                    DateValidity = System.DateTime.Now.AddYears(1),
                    Description = "Azúcar Blanca",
                    State = true
                });
                ent.HasData(new Product
                {
                    CodeProduct = 5,
                    CodeSupplier = 1,
                    DateFabrication = System.DateTime.Now,
                    DateValidity = System.DateTime.Now.AddYears(1),
                    Description = "Atún en Lata",
                    State = true
                });
                ent.HasData(new Product
                {
                    CodeProduct = 6,
                    CodeSupplier = 1,
                    DateFabrication = System.DateTime.Now,
                    DateValidity = System.DateTime.Now.AddYears(1),
                    Description = "Crema de cebolla",
                    State = true
                });
                ent.HasData(new Product
                {
                    CodeProduct = 7,
                    CodeSupplier = 1,
                    DateFabrication = System.DateTime.Now,
                    DateValidity = System.DateTime.Now.AddYears(1),
                    Description = "Espinacas precocidas",
                    State = true
                });
                ent.HasData(new Product
                {
                    CodeProduct = 8,
                    CodeSupplier = 1,
                    DateFabrication = System.DateTime.Now,
                    DateValidity = System.DateTime.Now.AddYears(1),
                    Description = "Guantes eterna",
                    State = true
                });
                ent.HasData(new Product
                {
                    CodeProduct = 9,
                    CodeSupplier = 1,
                    DateFabrication = System.DateTime.Now,
                    DateValidity = System.DateTime.Now.AddYears(1),
                    Description = "Esponjilla Brillamas",
                    State = true
                });
                ent.HasData(new Product
                {
                    CodeProduct = 10,
                    CodeSupplier = 1,
                    DateFabrication = System.DateTime.Now,
                    DateValidity = System.DateTime.Now.AddYears(1),
                    Description = "Lustrador de botas",
                    State = true
                });
                ent.HasData(new Product
                {
                    CodeProduct = 11,
                    CodeSupplier = 1,
                    DateFabrication = System.DateTime.Now,
                    DateValidity = System.DateTime.Now.AddYears(1),
                    Description = "Bolsas Resellables",
                    State = true
                });
                ent.HasData(new Product
                {
                    CodeProduct = 12,
                    CodeSupplier = 1,
                    DateFabrication = System.DateTime.Now,
                    DateValidity = System.DateTime.Now.AddYears(1),
                    Description = "Papel Absorvente",
                    State = true
                });
            });

            modelBuilder.Entity<Supplier>(ent =>
            {
                ent.HasKey(e => e.CodeSupplier);
                ent.ToTable("Supplier");

                ent.HasData(new Supplier
                {
                    CodeSupplier = 1,
                    DescriptionSupplier = "Superbodega del rincon",
                    TelephoneSupplier = "3123061932",
                    Status = true
                });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);



    }
}
