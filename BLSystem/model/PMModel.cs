namespace BLSystem
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PMModel : DbContext
    {
        public PMModel()
            : base("name=pmmodelcn") //PM2005
        {
        }
        public virtual DbSet<AddressBook> AddressBooks { get; set; }
        public virtual DbSet<AddressBookType> AddressBookTypes { get; set; }
        public virtual DbSet<CompanyMaster> CompanyMasters { get; set; }
        public virtual DbSet<ExcludeSupplier> ExcludeSuppliers { get; set; }
        public virtual DbSet<FactoryMaster> FactoryMasters { get; set; }
        public virtual DbSet<FiscalPeriod> FiscalPeriods { get; set; }
        public virtual DbSet<PaymentDetail> PaymentDetails { get; set; }
        public virtual DbSet<PaymentMaster> PaymentMasters { get; set; }
        public virtual DbSet<PriceList> PriceLists { get; set; }
        public virtual DbSet<PriceListType> PriceListTypes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<RouteMaster> RouteMasters { get; set; }
        public virtual DbSet<RouteQty> RouteQties { get; set; }
        public virtual DbSet<SupplierLedger> SupplierLedgers { get; set; }
        public virtual DbSet<SupplierMaster> SupplierMasters { get; set; }
        public virtual DbSet<TeamMaster> TeamMasters { get; set; }
        public virtual DbSet<WorkCenterMaster> WorkCenterMasters { get; set; }
        public virtual DbSet<Collection_tbl> Collection_tbl { get; set; }
        public virtual DbSet<Main_Reg> Main_Reg { get; set; }
        public virtual DbSet<ViewPartnerLedger> ViewPartnerLedgers { get; set; }

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
                .HasMany(e => e.PaymentMasters)
                .WithOptional(e => e.AddressBook)
                .HasForeignKey(e => e.AddressId);

            modelBuilder.Entity<AddressBook>()
                .HasMany(e => e.PriceLists)
                .WithOptional(e => e.AddressBook)
                .HasForeignKey(e => e.PartnerId);

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

            modelBuilder.Entity<PaymentMaster>()
                .Property(e => e.RefNo)
                .IsFixedLength();

            modelBuilder.Entity<PaymentMaster>()
                .Property(e => e.Remarks)
                .IsFixedLength();

            modelBuilder.Entity<PaymentMaster>()
                .HasMany(e => e.PaymentDetails)
                .WithOptional(e => e.PaymentMaster)
                .HasForeignKey(e => e.PaymentId);

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

            modelBuilder.Entity<RouteMaster>()
                .Property(e => e.trRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<RouteMaster>()
                .Property(e => e.blRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<RouteMaster>()
                .Property(e => e.newBlRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<RouteMaster>()
                .Property(e => e.Incentive)
                .HasPrecision(19, 4);

            modelBuilder.Entity<RouteMaster>()
                .Property(e => e.blRateSL)
                .HasPrecision(19, 4);

            modelBuilder.Entity<RouteMaster>()
                .Property(e => e.newBlRateSL)
                .HasPrecision(19, 4);

            modelBuilder.Entity<RouteMaster>()
                .Property(e => e.Target)
                .HasPrecision(19, 4);

            modelBuilder.Entity<RouteMaster>()
                .Property(e => e.DdRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<RouteMaster>()
                .Property(e => e.ExtraRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<RouteQty>()
                .HasMany(e => e.SupplierLedgers)
                .WithOptional(e => e.RouteQty)
                .HasForeignKey(e => e.ExtraId);

            modelBuilder.Entity<SupplierLedger>()
                .Property(e => e.Ref01)
                .IsFixedLength();

            modelBuilder.Entity<SupplierLedger>()
                .Property(e => e.Ref02)
                .IsFixedLength();

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
                .HasMany(e => e.RouteQties)
                .WithOptional(e => e.SupplierMaster)
                .HasForeignKey(e => e.SupplierID);

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

            modelBuilder.Entity<Collection_tbl>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Collection_tbl>()
                .Property(e => e.trRate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.WelfareBAL)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.SavingRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.SavingAMT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.AddRate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.xAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.GrosKG)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.DdRate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.DdKG)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.TotKg)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.TotKgSL)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.blRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.blRateSL)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.trRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.TempGross)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.Gross)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.GrossSL)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.AddPay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.AddRange)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.IncRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.prCoins)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.LMB)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.FertLMB)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.Transport)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.Tea)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.Fertilizer)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.CashAdv)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.FunaralRegFee)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.Funaral)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.Loan)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.LoanInterest)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.OtherDeduction)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.Stamp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.TotalDeduction)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.tempBal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.crCoins)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.FertNMB)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.NMB)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.LoanBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.CouponPrv)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.CouponNext)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.xBal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.xDebt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.xCoins)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.LoanArreares)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.AdvPayTMP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.AdvRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.SavingBAL)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.SavingSupplier)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.SavingFactory)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.SavingPAID)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Main_Reg>()
                .Property(e => e.savingPrvCoin)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ViewPartnerLedger>()
                .Property(e => e.ProductName)
                .IsFixedLength();

            modelBuilder.Entity<ViewPartnerLedger>()
                .Property(e => e.TransactionType)
                .IsFixedLength();

            modelBuilder.Entity<ViewPartnerLedger>()
                .Property(e => e.Ref01)
                .IsFixedLength();

            modelBuilder.Entity<ViewPartnerLedger>()
                .Property(e => e.Ref02)
                .IsFixedLength();

            modelBuilder.Entity<ViewPartnerLedger>()
                .Property(e => e.AddressName)
                .IsFixedLength();

        }
    }
}
