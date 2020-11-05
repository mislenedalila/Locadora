using Locadora.Filmes.Dominio;
using Locadora.Filmes.Generica.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Filmes.Dados.Entity.TypeConfiguration
{
    class FilmeTypeConfiguration : LocadoraEntityAbstractConfig<Filme>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.IdFilme)
                .HasColumnName("IdFilme")
                .HasDatabaseGeneratedOption(System.ComponentModel
                                            .DataAnnotations.Schema
                                            .DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(p => p.NomeFilme)
                .HasColumnName("NomeFilme")
                .HasMaxLength(100)
                .IsRequired();

            Property(p => p.IdAlbum)
                .HasColumnName("IdAlbum")
                .IsRequired();

        }

        protected override void ConfigurarChaveEstrangeira()
        {
            HasRequired(p => p.Album)
                .WithMany(p => p.Filmes)
                .HasForeignKey(fk => fk.IdAlbum);
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.IdFilme);
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("Filme");
        }
    }
}
