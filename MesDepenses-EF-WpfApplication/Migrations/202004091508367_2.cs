namespace Hotel_EF_WpfApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Depenses", "Type_Depense", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Depenses", "Type_Depense", c => c.Int(nullable: false));
        }
    }
}
