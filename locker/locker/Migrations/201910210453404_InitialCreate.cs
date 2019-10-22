namespace locker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacto",
                c => new
                    {
                        ContactoID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Fechanac = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Fechareg = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        genero = c.Int(),
                        sugerencias = c.String(),
                        ip = c.String(),
                    })
                .PrimaryKey(t => t.ContactoID);
            
            CreateTable(
                "dbo.GestionDeLibro",
                c => new
                    {
                        GestionDeLibroID = c.Int(nullable: false, identity: true),
                        NombreLibro = c.String(),
                        Estado = c.String(),
                        Autor = c.String(),
                        Introduccion = c.String(),
                        Genero = c.String(),
                        Editorial = c.String(),
                        PaginaActual = c.Int(nullable: false),
                        Arboles = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GestionDeLibroID);
            
            CreateTable(
                "dbo.Login",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Email);
            
            CreateTable(
                "dbo.Registrousuario",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        User = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 100),
                        ConfirmPassword = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Registrousuario");
            DropTable("dbo.Login");
            DropTable("dbo.GestionDeLibro");
            DropTable("dbo.Contacto");
        }
    }
}
