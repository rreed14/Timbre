namespace Timbre.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        AlbumID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ArtistID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AlbumID)
                .ForeignKey("dbo.Artists", t => t.ArtistID, cascadeDelete: true)
                .Index(t => t.ArtistID);
            
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        ArtistID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ArtistID);
            
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        SongID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Album = c.String(),
                        Artist = c.String(),
                        TrackNumber = c.Int(nullable: false),
                        Genre = c.String(),
                        SubGenre = c.String(),
                        Comments = c.String(),
                        IsInstrumental = c.Boolean(nullable: false),
                        IsScore = c.Boolean(nullable: false),
                        Length = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SongID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Albums", "ArtistID", "dbo.Artists");
            DropIndex("dbo.Albums", new[] { "ArtistID" });
            DropTable("dbo.Users");
            DropTable("dbo.Songs");
            DropTable("dbo.Artists");
            DropTable("dbo.Albums");
        }
    }
}
