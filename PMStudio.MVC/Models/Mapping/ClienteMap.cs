using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PMStudio.MVC.Models.Mapping
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
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

            this.Property(t => t.Contato)
                .HasMaxLength(20);

            this.Property(t => t.Email)
                .HasMaxLength(20);

            this.Property(t => t.Observacao)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("CLIENTE");
            this.Property(t => t.Id).HasColumnName("COD_CLIENTE");
            this.Property(t => t.IdEmpresa).HasColumnName("COD_EMPRESA");
            this.Property(t => t.IdTipoCliente).HasColumnName("COD_TIPO_CLIENTE");
            this.Property(t => t.Nome).HasColumnName("NOM_CLIENTE");
            this.Property(t => t.CNPJ).HasColumnName("DCR_CNPJ_CLIENTE");
            this.Property(t => t.Telefone).HasColumnName("DCR_TEL_CLIENTE");
            this.Property(t => t.Fax).HasColumnName("DCR_FAX_CLIENTE");
            this.Property(t => t.Contato).HasColumnName("DCR_CONTATO_CLIENTE");
            this.Property(t => t.Email).HasColumnName("DCR_EMAIL_CLIENTE");
            this.Property(t => t.Observacao).HasColumnName("DCR_OBS_CLIENTE");

            // Relationships
            this.HasRequired(t => t.Empresa)
                .WithMany(t => t.Clientes)
                .HasForeignKey(d => d.IdEmpresa);
            this.HasRequired(t => t.TipoCliente)
                .WithMany(t => t.Clientes)
                .HasForeignKey(d => d.IdTipoCliente);

        }
    }
}