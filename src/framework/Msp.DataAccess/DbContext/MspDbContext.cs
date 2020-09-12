namespace Msp.Entity.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MspDbContext : DbContext
    {
        public MspDbContext()
            : base("name=Model1")
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>()
                .HasMany(e => e.products)
                .WithOptional(e => e.categories)
                .HasForeignKey(e => e.categoryId);

            modelBuilder.Entity<Users>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.cashiers)
                .WithOptional(e => e.users)
                .HasForeignKey(e => e.userId);
        }
    }
}
