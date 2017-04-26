namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhoneNumberToApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DrivingLicense", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.AspNetUsers", "PhoneNb", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.AspNetUsers", "DribingLicense");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "DribingLicense", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.AspNetUsers", "PhoneNb");
            DropColumn("dbo.AspNetUsers", "DrivingLicense");
        }
    }
}
