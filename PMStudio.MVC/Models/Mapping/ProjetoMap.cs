using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PMStudio.MVC.Models.Mapping
{
    public class ProjetoMap : EntityTypeConfiguration<Projeto>
    {
        public ProjetoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Identificador)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.Meta)
                .HasMaxLength(250);

            this.Property(t => t.Login)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("PROJETO");
            this.Property(t => t.Id).HasColumnName("COD_PROJETO");
            this.Property(t => t.IdTipoProjeto).HasColumnName("COD_TIPO_PROJETO");
            this.Property(t => t.IdCliente).HasColumnName("COD_CLIENTE");
            this.Property(t => t.Identificador).HasColumnName("DCR_IDENT_PROJETO");
            this.Property(t => t.Nome).HasColumnName("DCR_NOM_PROJETO");
            this.Property(t => t.Justificativa).HasColumnName("DCR_JUST_PROJETO");
            this.Property(t => t.Objetivo).HasColumnName("DCR_OBJ_PROJETO");
            this.Property(t => t.Prazo).HasColumnName("DRC_PRAZO_PROJETO");
            this.Property(t => t.Custo).HasColumnName("DCR_CUSTO_PROJETO");
            this.Property(t => t.Descricao).HasColumnName("DCR_PROJETO");
            this.Property(t => t.Meta).HasColumnName("DCR_META_PROJETO");
            this.Property(t => t.DtCadastro).HasColumnName("DAT_CAD_PROJETO");
            this.Property(t => t.DtAtualizacao).HasColumnName("DAT_ATUALZ_PROJETO");
            this.Property(t => t.DtInicio).HasColumnName("DAT_INI_PROJETO");
            this.Property(t => t.DtFim).HasColumnName("DAT_FIM_PROJETO");
            this.Property(t => t.Login).HasColumnName("DCR_LOGIN_PROJETO");
            this.Property(t => t.Situacao).HasColumnName("SIT_PROJETO");

            // Relationships
            this.HasRequired(t => t.Cliente)
                .WithMany(t => t.Projetos)
                .HasForeignKey(d => d.IdCliente);
            this.HasRequired(t => t.TiposProjetos)
                .WithMany(t => t.Projetos)
                .HasForeignKey(d => d.IdTipoProjeto);

        }
    }
}