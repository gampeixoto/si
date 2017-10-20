using MV5.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MV5.Data
{
    public class MVCContext : DbContext
    {
        public MVCContext(): base("MVC_Desenv")
        {

        }

        
        public DbSet <Produtos> Produto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}