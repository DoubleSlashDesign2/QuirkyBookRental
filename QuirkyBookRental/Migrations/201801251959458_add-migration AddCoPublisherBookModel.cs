namespace QuirkyBookRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationAddCoPublisherBookModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "CoPublisher", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "CoPublisher");
        }
    }
}
