namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insertGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Type) VALUES ('Action')");
            Sql("INSERT INTO Genres (Type) VALUES ('Comedy')");
            Sql("INSERT INTO Genres (Type) VALUES ('Drama')");
            Sql("INSERT INTO Genres (Type) VALUES ('Sci-Fi')");
            Sql("INSERT INTO Genres (Type) VALUES ('Thriler')");
        }
        
        public override void Down()
        {
        }
    }
}
