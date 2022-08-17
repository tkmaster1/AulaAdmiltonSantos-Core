using Microsoft.EntityFrameworkCore;
using TKMaster.AulaCSharp.Core.Domain.Entities;

namespace TKMaster.AulaCSharp.Core.Data.Context
{
    public class MeuContextoDB : DbContext
    {
        #region Constructor

        public MeuContextoDB(DbContextOptions options) : base(options)
        {
            ChangeTracker.LazyLoadingEnabled = false;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        #endregion

        #region DBSets

        public DbSet<Fornecedor> Fornecedores { get; set; }

        #endregion

        #region ModelBuilder

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                                     .SelectMany(e => e.GetProperties()
                                     .Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(255)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuContextoDB).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                                                    .SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull; //Delete Cascade

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging(false); // Desabilitando log da aplicação
        }

        #endregion
    }
}