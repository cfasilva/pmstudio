using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PMStudio.MVC.Models.Mapping
{
    public class CarteiraProjetoMap : EntityTypeConfiguration<CarteiraProjeto>
    {
        public CarteiraProjetoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("CARTEIRA_PROJETO");
            this.Property(t => t.Id).HasColumnName("COD_CARTROJ");
            this.Property(t => t.IdProjeto).HasColumnName("COD_PROJETO");
            this.Property(t => t.IdCarteira).HasColumnName("COD_CARTEIRA");

            // Relationships
            this.HasRequired(t => t.Carteira)
                .WithMany(t => t.CarteiraProjetoList)
                .HasForeignKey(d => d.IdCarteira);
            this.HasRequired(t => t.Projeto)
                .WithMany(t => t.CarteiraProjetoList)
                .HasForeignKey(d => d.IdProjeto);

        }
    }
}