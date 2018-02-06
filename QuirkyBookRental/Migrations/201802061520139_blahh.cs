namespace QuirkyBookRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blahh : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "MembershipTypeId", c => c.Int(nullable: false));
            DropColumn("dbo.AspNetUsers", "MembershipID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "MembershipID", c => c.Int(nullable: false));
            DropColumn("dbo.AspNetUsers", "MembershipTypeId");
        }
    }
}
