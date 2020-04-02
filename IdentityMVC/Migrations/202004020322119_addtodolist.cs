namespace IdentityMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtodolist : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_M_Todolist",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        IsCompleted = c.Boolean(nullable: false),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TB_T_Todolist",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        IsCompleted = c.Boolean(nullable: false),
                        ApplicationUserId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.TB_M_Todolist");
        }
    }
}
