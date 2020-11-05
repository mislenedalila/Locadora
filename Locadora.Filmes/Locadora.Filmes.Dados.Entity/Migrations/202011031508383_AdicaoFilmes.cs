namespace Locadora.Filmes.Dados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicaoFilmes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Filme",
                c => new
                    {
                        IdFilme = c.Long(nullable: false, identity: true),
                        NomeFilme = c.String(nullable: false, maxLength: 100),
                        IdAlbum = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdFilme)
                .ForeignKey("dbo.Album", t => t.IdAlbum, cascadeDelete: true)
                .Index(t => t.IdAlbum);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Filme", "IdAlbum", "dbo.Album");
            DropIndex("dbo.Filme", new[] { "IdAlbum" });
            DropTable("dbo.Filme");
        }
    }
}
