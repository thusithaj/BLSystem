namespace BLSystem
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PMModel : DbContext
    {
        public PMModel()
            : base("name=pmmodelcn")
        {
        }

        public virtual DbSet<AddressBook> AddressBooks { get; set; }
        public virtual DbSet<AddressBookType> AddressBookTypes { get; set; }
        public virtual DbSet<CompanyMaster> CompanyMasters { get; set; }
        public virtual DbSet<FactoryMaster> FactoryMasters { get; set; }
        public virtual DbSet<PriceList> PriceLists { get; set; }
        public virtual DbSet<PriceListType> PriceListTypes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<RouteQty> RouteQties { get; set; }
        public virtual DbSet<SupplierLedger> SupplierLedgers { get; set; }
        public virtual DbSet<SupplierMaster> SupplierMasters { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TeamMaster> TeamMasters { get; set; }
        public virtual DbSet<WorkCenterMaster> WorkCenterMasters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddressBook>()
                .Property(e => e.AddressName)
                .IsFixedLength();

            modelBuilder.Entity<AddressBook>()
                .Property(e => e.AddressLine01)
                .IsFixedLength();

            modelBuilder.Entity<AddressBook>()
                .Property(e => e.AddressLine02)
                .IsFixedLength();

            modelBuilder.Entity<AddressBook>()
                .Property(e => e.City)
                .IsFixedLength();

            modelBuilder.Entity<AddressBook>()
                .Property(e => e.TP01)
                .IsFixedLength();

            modelBuilder.Entity<AddressBook>()
                .Property(e => e.TP02)
                .IsFixedLength();

            modelBuilder.Entity<AddressBook>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<AddressBook>()
                .HasMany(e => e.SupplierLedgers)
                .WithRequired(e => e.AddressBook)
                .HasForeignKey(e => e.RouteId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AddressBook>()
                .HasMany(e => e.SupplierLedgers1)
                .WithOptional(e => e.AddressBook1)
                .HasForeignKey(e => e.RelatedFactory);

            modelBuilder.Entity<AddressBook>()
                .HasMany(e => e.SupplierMasters)
                .WithOptional(e => e.AddressBook)
                .HasForeignKey(e => e.AddressBookId);

            modelBuilder.Entity<AddressBook>()
                .HasMany(e => e.SupplierMasters1)
                .WithOptional(e => e.AddressBook1)
                .HasForeignKey(e => e.RouteId);

            modelBuilder.Entity<AddressBookType>()
                .Property(e => e.BookTypeName)
                .IsFixedLength();

            modelBuilder.Entity<AddressBookType>()
                .Property(e => e.Category01)
                .IsFixedLength();

            modelBuilder.Entity<AddressBookType>()
                .Property(e => e.Category02)
                .IsFixedLength();

            modelBuilder.Entity<AddressBookType>()
                .Property(e => e.Category03)
                .IsFixedLength();

            modelBuilder.Entity<AddressBookType>()
                .Property(e => e.Category04)
                .IsFixedLength();

            modelBuilder.Entity<AddressBookType>()
                .Property(e => e.Category05)
                .IsFixedLength();

            modelBuilder.Entity<AddressBookType>()
                .HasMany(e => e.AddressBooks)
                .WithOptional(e => e.AddressBookType)
                .HasForeignKey(e => e.AddressType);

            modelBuilder.Entity<CompanyMaster>()
                .Property(e => e.CompanyName)
                .IsFixedLength();

            modelBuilder.Entity<CompanyMaster>()
                .HasMany(e => e.AddressBookTypes)
                .WithOptional(e => e.CompanyMaster)
                .HasForeignKey(e => e.CompanyId);

            modelBuilder.Entity<CompanyMaster>()
                .HasMany(e => e.FactoryMasters)
                .WithOptional(e => e.CompanyMaster)
                .HasForeignKey(e => e.CompanyId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FactoryMaster>()
                .Property(e => e.FactoryName)
                .IsFixedLength();

            modelBuilder.Entity<FactoryMaster>()
                .HasMany(e => e.AddressBooks)
                .WithOptional(e => e.FactoryMaster)
                .HasForeignKey(e => e.FactoryId);

            modelBuilder.Entity<FactoryMaster>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.FactoryMaster)
                .HasForeignKey(e => e.FactoryId);

            modelBuilder.Entity<FactoryMaster>()
                .HasMany(e => e.SupplierMasters)
                .WithOptional(e => e.FactoryMaster)
                .HasForeignKey(e => e.FactoryId);

            modelBuilder.Entity<FactoryMaster>()
                .HasMany(e => e.WorkCenterMasters)
                .WithOptional(e => e.FactoryMaster)
                .HasForeignKey(e => e.FactoryId);

            modelBuilder.Entity<PriceList>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PriceListType>()
                .Property(e => e.ListTypeName)
                .IsFixedLength();

            modelBuilder.Entity<PriceListType>()
                .HasMany(e => e.PriceLists)
                .WithOptional(e => e.PriceListType1)
                .HasForeignKey(e => e.PriceListType);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductName)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.TransactionType)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.UOM1)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.UOM2)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Conversion)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.SupplierLedgers)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RouteQty>()
                .HasMany(e => e.SupplierLedgers)
                .WithOptional(e => e.RouteQty)
                .HasForeignKey(e => e.ExtraId);

            modelBuilder.Entity<SupplierMaster>()
                .Property(e => e.WelfareId)
                .IsFixedLength();

            modelBuilder.Entity<SupplierMaster>()
                .Property(e => e.PayMode)
                .IsFixedLength();

            modelBuilder.Entity<SupplierMaster>()
                .Property(e => e.BankAccount)
                .IsFixedLength();

            modelBuilder.Entity<SupplierMaster>()
                .HasMany(e => e.SupplierLedgers)
                .WithRequired(e => e.SupplierMaster)
                .HasForeignKey(e => e.SupplierId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TeamMaster>()
                .Property(e => e.TeamName)
                .IsFixedLength();

            modelBuilder.Entity<WorkCenterMaster>()
                .Property(e => e.WorkSection)
                .IsFixedLength();

            modelBuilder.Entity<WorkCenterMaster>()
                .HasMany(e => e.TeamMasters)
                .WithOptional(e => e.WorkCenterMaster)
                .HasForeignKey(e => e.WorkCenterid);
        }
    }
}
