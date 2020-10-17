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
            : base("initial catalog=" + AppMain.SqlConnection.Database
            + ";data source=" + AppMain.SqlConnection.Server
            + ";user id=" + AppMain.SqlConnection.UserId
            + ";password=" + AppMain.SqlConnection.Password )
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
        public virtual DbSet<BankEntry> BankEntries { get; set; }


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
