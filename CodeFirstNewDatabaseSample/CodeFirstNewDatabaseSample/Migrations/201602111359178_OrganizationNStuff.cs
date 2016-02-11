namespace CodeFirstNewDatabaseSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrganizationNStuff : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Organizations", "Name", c => c.String());
            DropColumn("dbo.Organizations", "OrganizationName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Organizations", "OrganizationName", c => c.String());
            DropColumn("dbo.Organizations", "Name");
        }
    }
}
