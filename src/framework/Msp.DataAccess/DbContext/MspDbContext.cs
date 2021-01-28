namespace Msp.Entity.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Msp.Infrastructure;

    public partial class MspDbContext : DbContext
    {
        public MspDbContext()
            : base( "initial catalog=" + AppMain.SqlConnection.Database + ";data source=" + AppMain.SqlConnection.Server +  (AppMain.LocalConnect == false ?  ";user id=" + AppMain.SqlConnection.UserId + ";password=" + AppMain.SqlConnection.Password : ";"))
        {
        }

        public MspDbContext(string connectionString) : base(connectionString)
        {
        }

        public virtual DbSet<Cashiers> cashiers { get; set; }
        public virtual DbSet<Categories> categories { get; set; }
        public virtual DbSet<Customers> customers { get; set; }
        public virtual DbSet<Cayments> payments { get; set; }
        public virtual DbSet<Products> products { get; set; }
        public virtual DbSet<ProductMark> ProductMark { get; set; }
        public virtual DbSet<ProductGroup> ProductGroup { get; set; }
        public virtual DbSet<ProductMovement> ProductMovement { get; set; }
        public virtual DbSet<Users> users { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Parameters> Parameters { get; set; }
        public virtual DbSet<ProgramsControl> ProgramsControl { get; set; }
        public virtual DbSet<ApplicationServer> ApplicationServer { get; set; }
        public virtual DbSet<Units> Units { get; set; }
        public virtual DbSet<SaleOwner> SaleOwner { get; set; }
        public virtual DbSet<SaleTrans> SaleTrans { get; set; }
        public virtual DbSet<SpeedSaleProduct> SpeedSaleProduct { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<CTransactions> CurrentTransactions { get; set; }
        public virtual DbSet<Depots> Depot { get; set; }
        public virtual DbSet<BankEntry> BankEntry { get; set; }
        public virtual DbSet<Banks> Banks { get; set; }
        public virtual DbSet<OrderManagement> OrderManagement { get; set; }
        public virtual DbSet<FormLayouts> FormLayouts { get; set; }
        public virtual DbSet<InvoiceOwner> InvoiceOwner { get; set; }
        public virtual DbSet<InvoiceTrans> InvoiceTrans { get; set; }
        public virtual DbSet<ExchangeRate> ExchangeRate { get; set; }
        public virtual DbSet<CurrencyType> CurrencyType { get; set; }
        public virtual DbSet<OrderOwner> OrderOwner { get; set; }
        public virtual DbSet<OrderTrans> OrderTrans { get; set; }
        public virtual DbSet<CashPayGroupDef> CashPayGroupDef { get; set; }
        public virtual DbSet<SecRights> SecRights { get; set; }
        public virtual DbSet<OpenFormRights> OpenFormRights { get; set; }
        public virtual DbSet<Logs> LOGS { get; set; }
        public virtual DbSet<CaseDefinition> CaseDefinition { get; set; }
        public virtual DbSet<CaseMovement> CaseMovement { get; set; }
        public virtual DbSet<ProductBarCode> ProductBarCode { get; set; }
        public virtual DbSet<DailyOwner> DailyOwner { get; set; }
        public virtual DbSet<DailyTrans> DailyTrans { get; set; }
        public virtual DbSet<SaleBarcodCreate> SaleBarcodCreate { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Categories>()
            //    .HasMany(e => e.products)
            //    .WithOptional(e => e.categories)
            //    .HasForeignKey(e => e.PCategoryId);

            //modelBuilder.Entity<Users>()
            //    .Property(e => e.note)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Users>()
            //    .HasMany(e => e.cashiers)
            //    .WithOptional(e => e.users)
            //    .HasForeignKey(e => e.userId);
        }
    }
}
