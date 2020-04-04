using PMStudio.MVC.Models.Mapping;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PMStudio.MVC.Models
{
    public partial class PMStudioContext : DbContext
    {
        static PMStudioContext()
        {
            Database.SetInitializer<PMStudioContext>(null);
        }

        public PMStudioContext()
            : base("Name=PMSTUDIO")
        {
        }

        public DbSet<Carteira> Carteiras { get; set; }
        public DbSet<CarteiraProjeto> CarteiraProjetoList { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<TipoCliente> TiposClientes { get; set; }
        public DbSet<TipoProjeto> TiposProjetos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Prevents table names from being pluralized
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //Remove unused conventions
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new CateiraMap());
            modelBuilder.Configurations.Add(new CarteiraProjetoMap());
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new EmpresaMap());
            modelBuilder.Configurations.Add(new ProjetoMap());
            modelBuilder.Configurations.Add(new TipoClienteMap());
            modelBuilder.Configurations.Add(new TipoProjetoMap());
        }
    }
}
