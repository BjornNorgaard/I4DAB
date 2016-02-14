namespace CodeFirstNewDatabaseSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SmallChanges : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "OrganizationId", "dbo.Organizations");
            DropIndex("dbo.Users", new[] { "OrganizationId" });
            RenameColumn(table: "dbo.Users", name: "OrganizationId", newName: "Organization_OrganizationId");
            AlterColumn("dbo.Users", "Organization_OrganizationId", c => c.Int());
            CreateIndex("dbo.Users", "Organization_OrganizationId");
            AddForeignKey("dbo.Users", "Organization_OrganizationId", "dbo.Organizations", "OrganizationId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Organization_OrganizationId", "dbo.Organizations");
            DropIndex("dbo.Users", new[] { "Organization_OrganizationId" });
            AlterColumn("dbo.Users", "Organization_OrganizationId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Users", name: "Organization_OrganizationId", newName: "OrganizationId");
            CreateIndex("dbo.Users", "OrganizationId");
            AddForeignKey("dbo.Users", "OrganizationId", "dbo.Organizations", "OrganizationId", cascadeDelete: true);
        }
    }
}
