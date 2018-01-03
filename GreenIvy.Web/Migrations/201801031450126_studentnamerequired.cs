namespace GreenIvy.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class studentnamerequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "FirstName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "FirstName", c => c.String());
        }
    }
}
