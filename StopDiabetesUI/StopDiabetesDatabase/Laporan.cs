namespace StopDiabetesDatabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Laporan")]
    public partial class Laporan
    {
        public int Id { get; set; }
        public DateTime? Tanggal { get; set; }

        [Required]
        [StringLength(100)]
        public string Nama { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(200)]
        public string Kritik { get; set; }
    }
}
