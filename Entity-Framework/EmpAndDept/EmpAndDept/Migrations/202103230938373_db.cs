namespace EmpAndDept.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dept",
                c => new
                    {
                        Deptid = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.Deptid);
            
            CreateTable(
                "dbo.Emps",
                c => new
                    {
                        EmpId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Salary = c.Double(nullable: false),
                        dept_Deptid = c.Int(),
                    })
                .PrimaryKey(t => t.EmpId)
                .ForeignKey("dbo.Dept", t => t.dept_Deptid)
                .Index(t => t.dept_Deptid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Emps", "dept_Deptid", "dbo.Dept");
            DropIndex("dbo.Emps", new[] { "dept_Deptid" });
            DropTable("dbo.Emps");
            DropTable("dbo.Dept");
        }
    }
}
