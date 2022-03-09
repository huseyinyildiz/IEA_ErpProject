namespace IEA_ErpProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblKonsinyeGonderimler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CariTur = c.String(maxLength: 15),
                        CariAdi = c.String(maxLength: 200),
                        CariId = c.Int(nullable: false),
                        GonderimTarih = c.DateTime(nullable: false),
                        Aciklama = c.String(maxLength: 250),
                        UrunId = c.Int(nullable: false),
                        Adet = c.Int(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                        CreatedUser = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedUser = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblStokDurums", t => t.UrunId, cascadeDelete: true)
                .Index(t => t.UrunId);
            
            CreateTable(
                "dbo.tblStokDurums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Barkod = c.String(),
                        UrunKodu = c.String(),
                        LotSeriNo = c.String(),
                        StokAdet = c.Int(),
                        RafAdet = c.Int(),
                        KonsinyeAdet = c.Int(),
                        SubeAdet = c.Int(),
                        UrunHareketAdet = c.Int(),
                        SutKodu = c.String(),
                        BransNo = c.String(),
                        Uts = c.Boolean(),
                        UTarih = c.DateTime(),
                        SKTarih = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 10),
                        Username = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblKonsinyeGonderimler", "UrunId", "dbo.tblStokDurums");
            DropIndex("dbo.tblKonsinyeGonderimler", new[] { "UrunId" });
            DropTable("dbo.tblUsers");
            DropTable("dbo.tblStokDurums");
            DropTable("dbo.tblKonsinyeGonderimler");
        }
    }
}
