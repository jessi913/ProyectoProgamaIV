namespace ProyectoProgramcionIV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate_CondicionPag : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CondicionPag",
                c => new
                    {
                        CondicionPagoId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(nullable: false, maxLength: 50),
                        Estado = c.Boolean(nullable: false),
                        Dias = c.Int(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CondicionPagoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CondicionPag");
        }
    }
}
