namespace ZakupowyProjekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nazwaMigracji : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DbModels", "DateModified", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DbModels", "DateModified");
        }
    }
}
