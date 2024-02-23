using FN.Store.Domain.Entities;
using System.Data.Entity;

namespace FN.Store.Data.EF
{
    public class FNStoreDataContext : DbContext
    {
        public FNStoreDataContext() : base("FNStoreConn")
        {
            //Database.SetInitializer<FNStoreDataContext>(null); //nunca vai gerar a base
            Database.SetInitializer(new DbInitilizer());
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Perfil> Perfis { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ClientesEndereco> ClientesEndereco { get; set; }
        public DbSet<UnidadeFederativa> UnidadeFederativa { get; set; }
        public DbSet<EstadoCivil> EstadoCivil { get; set; }
        public DbSet<Sexo> Sexo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Pedido>()
                .HasMany(p => p.Produtos)
                .WithMany(p => p.Pedidos)
                .Map(m => {

                    m.ToTable("PedidoProduto");
                    m.MapLeftKey("PedidoId");
                    m.MapRightKey("ProdutoId");
                });*/
        }


    }
}
