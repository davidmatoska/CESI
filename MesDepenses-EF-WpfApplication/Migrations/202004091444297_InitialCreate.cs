namespace Hotel_EF_WpfApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Depenses",
                c => new
                    {
                        DepenseID = c.Int(nullable: false, identity: true),
                        Montant = c.Int(nullable: false),
                        Type_Depense = c.Int(nullable: false),
                        Personne_PersonneID = c.Int(),
                    })
                .PrimaryKey(t => t.DepenseID)
                .ForeignKey("dbo.Personnes", t => t.Personne_PersonneID)
                .Index(t => t.Personne_PersonneID);
            
            CreateTable(
                "dbo.Personnes",
                c => new
                    {
                        PersonneID = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                    })
                .PrimaryKey(t => t.PersonneID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Depenses", "Personne_PersonneID", "dbo.Personnes");
            DropIndex("dbo.Depenses", new[] { "Personne_PersonneID" });
            DropTable("dbo.Personnes");
            DropTable("dbo.Depenses");
        }
    }
}
