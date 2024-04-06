namespace ProyectoProgramcionIV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate_UnidadMedida : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UnidadMedida",
                c => new
                    {
                        UnidadmedidaId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(nullable: false, maxLength: 50),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UnidadmedidaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UnidadMedida");
        }
    }
}
