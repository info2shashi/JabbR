namespace JabbR.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoomImages : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RoomImages",
                c => new
                    {
                        Key = c.Int(nullable: false, identity: true),
                        UserKey = c.Int(nullable: false),
                        RoomKey = c.Int(nullable: false),
                        ImageName = c.String(),
                        ImageSource = c.String(),
                        BigImageSource = c.String(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.Key)
                .ForeignKey("dbo.ChatRooms", t => t.RoomKey, cascadeDelete: true)
                .ForeignKey("dbo.ChatUsers", t => t.UserKey, cascadeDelete: true)
                .Index(t => t.RoomKey)
                .Index(t => t.UserKey);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoomImages", "UserKey", "dbo.ChatUsers");
            DropForeignKey("dbo.RoomImages", "RoomKey", "dbo.ChatRooms");
            DropIndex("dbo.RoomImages", new[] { "UserKey" });
            DropIndex("dbo.RoomImages", new[] { "RoomKey" });
            DropTable("dbo.RoomImages");
        }
    }
}
