namespace ProyectoProgramcionIV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate_GrupoDescuento : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GrupoDescuento",
                c => new
                    {
                        GrupodescuentoId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(nullable: false, maxLength: 50),
                        Estado = c.Boolean(nullable: false),
                        Porcentaje = c.Int(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.GrupodescuentoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GrupoDescuento");
        }
    }
}
