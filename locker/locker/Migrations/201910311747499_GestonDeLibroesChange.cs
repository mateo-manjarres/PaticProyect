namespace locker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GestonDeLibroesChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GestionDeLibro", "IDusuario", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.GestionDeLibro", "IDusuario");
        }
    }
}
