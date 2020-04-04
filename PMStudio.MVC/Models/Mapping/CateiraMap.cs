using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PMStudio.MVC.Models.Mapping
{
    public class CateiraMap : EntityTypeConfiguration<Carteira>
    {
        public CateiraMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Titulo)
                .HasMaxLength(50);

            this.Property(t => t.AdFinanceira)
                .HasMaxLength(8);

            this.Property(t => t.AdFisica)
                .HasMaxLength(8);

            this.Property(t => t.Login)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("CARTEIRA");
            this.Property(t => t.Id).HasColumnName("COD_CARTEIRA");
            this.Property(t => t.IdEmpresa).HasColumnName("COD_EMPRESA");
            this.Property(t => t.Descricao).HasColumnName("DCR_CARTEIRA");
            this.Property(t => t.Valor).HasColumnName("DCR_VALOR_CARTEIRA");
            this.Property(t => t.Titulo).HasColumnName("DCR_TITULO_CARTEIRA");
            this.Property(t => t.AdFinanceira).HasColumnName("DCR_ADFINANC_CARTEIRA");
            this.Property(t => t.AdFisica).HasColumnName("DCR_ADFISICA_CARTEIRA");
            this.Property(t => t.DtCadastro).HasColumnName("DAT_CADASTRO_CARTEIRA");
            this.Property(t => t.DtAtualizacao).HasColumnName("DAT_ATUALZ_CARTEIRA");
            this.Property(t => t.Codigo).HasColumnName("COD_CARTEIRA_EMP");
            this.Property(t => t.Login).HasColumnName("DCR_LOGIN_CARTEIRA");
            this.Property(t => t.Situacao).HasColumnName("SIT_CARTEIRA");
        }
    }
}