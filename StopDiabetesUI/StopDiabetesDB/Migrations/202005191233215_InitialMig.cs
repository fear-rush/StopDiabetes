namespace StopDiabetesDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Laporan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nama = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        Kritik = c.String(nullable: false, maxLength: 200),
                        Tanggal = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Laporan");
        }
    }
}
