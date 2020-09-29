namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Name,Id, SignUpFee, DurationInMonths, DiscountRate) VALUES ('Pay as You Go',1, 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Name,Id, SignUpFee, DurationInMonths, DiscountRate) VALUES ('Monthly',2, 30, 1, 10)");
            Sql("INSERT INTO MembershipTypes (Name,Id, SignUpFee, DurationInMonths, DiscountRate) VALUES ('Quarterly',3, 90, 3, 15)");
            Sql("INSERT INTO MembershipTypes (Name,Id, SignUpFee, DurationInMonths, DiscountRate) VALUES ('Annual',4, 300, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
