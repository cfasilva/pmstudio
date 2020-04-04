using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PMStudio.MVC.Models.Mapping
{
    public class TipoProjetoMap : EntityTypeConfiguration<TipoProjeto>
    {
        public TipoProjetoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TIPO_PROJETO");
            this.Property(t => t.Id).HasColumnName("COD_TIPO_PROJETO");
            this.Property(t => t.IdEmpresa).HasColumnName("COD_EMPRESA");
            this.Property(t => t.Descricao).HasColumnName("DCR_TIPO_PROJETO");
            this.Property(t => t.Situacao).HasColumnName("SIT_TIPO_PROJETO");

            // Relationships
            this.HasRequired(t => t.Empresa)
                .WithMany(t => t.TiposProjetos)
                .HasForeignKey(d => d.IdEmpresa);

        }
    }
}