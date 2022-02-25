namespace Repostory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altertable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Staffs", "Age", c => c.Int());
            AlterColumn("dbo.Staffs", "Gender", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Staffs", "Gender", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Staffs", "Age", c => c.Int(nullable: false));
        }
    }
}
