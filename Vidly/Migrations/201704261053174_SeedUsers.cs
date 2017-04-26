namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'626121d2-7a19-4dba-9f62-02b61d8c1efa', N'guest@vidly.com', 0, N'AJUbARacnXUVIPN9sH5IG3cM2nMymhtDDRygH59vOtoo+FWJIR6f5st58lzD3TFi6w==', N'de933aef-2a00-4889-911b-e2d38d545605', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd0a28078-2af7-496f-9055-60da30b7d9df', N'admin@vidly.com', 0, N'AJLMhg9aRcNDfVlvgI+b9oAHV7Asy0BY5n84BJt/uPtPfUYoUGaEAJjS3bL6St+f+Q==', N'02755709-c34e-4c71-8f4d-ebc42a2494db', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bdf91744-cde6-415b-a4e7-4e3dc1fa5092', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd0a28078-2af7-496f-9055-60da30b7d9df', N'bdf91744-cde6-415b-a4e7-4e3dc1fa5092')

");
        }
        
        public override void Down()
        {
        }
    }
}
