namespace Repostory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        cellPhoneNumber = c.Int(nullable: false),
                        IDNumber = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.Boolean(nullable: false),
                        GraduateInstitutions = c.String(),
                        HomeAddress = c.String(),
                        HobbiesAndInterests = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Staffs");
        }
    }
}
