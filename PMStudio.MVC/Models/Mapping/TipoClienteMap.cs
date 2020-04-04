using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PMStudio.MVC.Models.Mapping
{
    public class TipoClienteMap : EntityTypeConfiguration<TipoCliente>
    {
        public TipoClienteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TIPO_CLIENTE");
            this.Property(t => t.Id).HasColumnName("COD_TIPO_CLIENTE");
            this.Property(t => t.Descricao).HasColumnName("DCR_TIPO_CLIENTE");
        }
    }
}