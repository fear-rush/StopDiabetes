namespace StopDiabetesDbLibrary
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SdContext : DbContext
    {
        public SdContext()
            : base("StopDiabetes")
        {
        }

        public virtual DbSet<Laporan> Laporan { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
