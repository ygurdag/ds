namespace WebApplication7.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HarcamaContext : DbContext
    {
        public HarcamaContext()
            : base("name=DB1Context")
        {
        }
        public virtual DbSet<Islem> islemler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
