namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insertMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SingUpFee, DurationInMonths, DiscountRate, Name) VALUES (1, 0, 0, 0, 'Pay As You Go')");
            Sql("INSERT INTO MembershipTypes (Id, SingUpFee, DurationInMonths, DiscountRate, Name) VALUES (2, 30, 1, 10, 'Monthly')");
            Sql("INSERT INTO MembershipTypes (Id, SingUpFee, DurationInMonths, DiscountRate, Name) VALUES (3, 90, 3, 15, 'Quaterly')");
            Sql("INSERT INTO MembershipTypes (Id, SingUpFee, DurationInMonths, DiscountRate, Name) VALUES (4, 300, 12, 20, 'Annualy')");
        }
        
        public override void Down()
        {
        }
    }
}
