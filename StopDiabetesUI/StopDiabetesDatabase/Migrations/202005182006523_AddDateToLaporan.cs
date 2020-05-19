namespace StopDiabetesDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateToLaporan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Laporan", "Tanggal", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Laporan", "Tanggal");
        }
    }
}
