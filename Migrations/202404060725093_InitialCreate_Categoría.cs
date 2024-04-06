﻿namespace ProyectoProgramcionIV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate_Categoría : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoría",
                c => new
                    {
                        CategoriaId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(nullable: false, maxLength: 50),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CategoriaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Categoría");
        }
    }
}
