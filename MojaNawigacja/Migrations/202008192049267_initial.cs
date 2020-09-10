namespace MojaNawigacja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adresy",
                c => new
                    {
                        IdTrasy = c.Int(nullable: false, identity: true),
                        MiejsceWyjazdu = c.String(),
                        MiejsceDocelowe = c.String(),
                        DataDodania = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdTrasy);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Adresy");
        }
    }
}
