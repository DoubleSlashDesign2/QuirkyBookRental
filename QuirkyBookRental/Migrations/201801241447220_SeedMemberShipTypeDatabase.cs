namespace QuirkyBookRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedMemberShipTypeDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [dbo].[MembershipTypes](Name,SignUpFee,ChargeRateOneMonth,ChargeRateSixMonths) VALUES('Pay Per Rental',0,25,50 ) ");
            Sql("INSERT INTO [dbo].[MembershipTypes](Name,SignUpFee,ChargeRateOneMonth,ChargeRateSixMonths) VALUES('Member',150,10,20 ) ");
            Sql("INSERT INTO [dbo].[MembershipTypes](Name,SignUpFee,ChargeRateOneMonth,ChargeRateSixMonths) VALUES('SuperAdmin',0,0,0 ) ");


        }

        public override void Down()
        {
        }
    }
}
