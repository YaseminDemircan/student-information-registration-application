namespace Student_Profil.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class student1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "FullName", c => c.String(maxLength: 255));
            AlterColumn("dbo.Students", "Birthday", c => c.String(maxLength: 15));
            AlterColumn("dbo.Students", "Email", c => c.String(maxLength: 255));
            AlterColumn("dbo.Students", "Adres", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Adres", c => c.String());
            AlterColumn("dbo.Students", "Email", c => c.String());
            AlterColumn("dbo.Students", "Birthday", c => c.String());
            AlterColumn("dbo.Students", "FullName", c => c.String());
        }
    }
}
