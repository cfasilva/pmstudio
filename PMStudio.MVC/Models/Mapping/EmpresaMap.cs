using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PMStudio.MVC.Models.Mapping
{
    public class EmpresaMap : EntityTypeConfiguration<Empresa>
    {
        public EmpresaMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CNPJ)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Telefone)
                .HasMaxLength(15);

            this.Property(t => t.Fax)
                .HasMaxLength(15);

            this.Property(t => t.Site)
                .HasMaxLength(20);

            this.Property(t => t.Contato)
                .HasMaxLength(20);

            this.Property(t => t.Logradouro)
                .HasMaxLength(120);

            this.Property(t => t.Complemento)
                .HasMaxLength(100);

            this.Property(t => t.Cidade)
                .HasMaxLength(50);

            this.Property(t => t.Bairro)
                .HasMaxLength(50);

            this.Property(t => t.UF)
                .HasMaxLength(2);

            this.Property(t => t.Email)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("EMPRESA");
            this.Property(t => t.Id).HasColumnName("COD_EMPRESA");
            this.Property(t => t.Nome).HasColumnName("NOM_EMPRESA");
            this.Property(t => t.CNPJ).HasColumnName("DCR_CNPJ_EMPRESA");
            this.Property(t => t.Telefone).HasColumnName("DCR_TEL_EMPRESA");
            this.Property(t => t.Fax).HasColumnName("DCR_FAX_EMPRESA");
            this.Property(t => t.Site).HasColumnName("DCR_SITE_EMPRESA");
            this.Property(t => t.Contato).HasColumnName("DCR_CONTATO_EMPRESA");
            this.Property(t => t.Logradouro).HasColumnName("DCR_LOG_EMPRESA");
            this.Property(t => t.Complemento).HasColumnName("DCR_COMPL_EMPRESA");
            this.Property(t => t.Cidade).HasColumnName("DCR_CIDADE_EMPRESA");
            this.Property(t => t.Bairro).HasColumnName("DCR_BAIRRO_EMPRESA");
            this.Property(t => t.UF).HasColumnName("DCR_UF_EMPRESA");
            this.Property(t => t.Email).HasColumnName("DCR_EMAIL_EMPRESA");
            this.Property(t => t.Situacao).HasColumnName("SIT_EMPRESA");
        }
    }
}