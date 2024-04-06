﻿namespace ProyectoProgramcionIV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate_Cliente : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 15),
                        Nombres = c.String(nullable: false, maxLength: 50),
                        Apellidos = c.String(nullable: false, maxLength: 50),
                        GrupoDescuentoId = c.Int(nullable: false),
                        CondicionPagoId = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId)
                .ForeignKey("dbo.CondicionPag", t => t.CondicionPagoId)
                .ForeignKey("dbo.GrupoDescuento", t => t.GrupoDescuentoId)
                .Index(t => t.GrupoDescuentoId)
                .Index(t => t.CondicionPagoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cliente", "GrupoDescuentoId", "dbo.GrupoDescuento");
            DropForeignKey("dbo.Cliente", "CondicionPagoId", "dbo.CondicionPag");
            DropIndex("dbo.Cliente", new[] { "CondicionPagoId" });
            DropIndex("dbo.Cliente", new[] { "GrupoDescuentoId" });
            DropTable("dbo.Cliente");
        }
    }
}
