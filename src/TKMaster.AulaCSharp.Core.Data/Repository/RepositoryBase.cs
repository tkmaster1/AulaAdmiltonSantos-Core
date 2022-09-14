using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TKMaster.AulaCSharp.Core.Data.Context;
using TKMaster.AulaCSharp.Core.Domain.Entities;
using TKMaster.AulaCSharp.Core.Domain.Interfaces.Repositories;

namespace TKMaster.AulaCSharp.Core.Data.Repository
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : Entity, new()
    {
        #region Properties

        protected readonly MeuContextoDB Db;
        protected readonly DbSet<TEntity> DbSet;

        #endregion

        #region Constructor

        public RepositoryBase(MeuContextoDB context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        #endregion

        #region Methods

        public virtual void Adicionar(TEntity entity)
        {
            entity.DataCadastro = DateTime.Now;
            entity.Status = true;
            DbSet.Add(entity);
        }

        public virtual void Adicionar(IEnumerable<TEntity> entities)
        {
            DbSet.AddRange(entities.ToArray());
        }

        public void Atualizar(TEntity entity)
        {
            DbSet.Update(entity);
        }

        public virtual void Atualizar(IEnumerable<TEntity> entities)
        {
            DbSet.UpdateRange(entities.ToList());
        }

        public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public virtual async Task<bool> Existe(int codigo)
        {
            return await ObterPorCodigo(codigo) != null;
        }

        public IQueryable<TEntity> Get()
        {
            return DbSet;
        }

        public virtual async Task<IEnumerable<TEntity>> ListarTodos()
        {
            return await DbSet.ToListAsync();
        }

        public virtual async Task<TEntity> ObterPorCodigo(int codigo)
        {
            return await DbSet.FindAsync(codigo);
        }

        public virtual async Task<IEnumerable<TEntity>> ObterPorCodigos(IEnumerable<int> codigos)
        {
            return await DbSet.Where(x => codigos.Contains(x.Codigo)).ToListAsync();
        }

        public virtual async Task<TEntity> ObterPorNome(string nome)
        {
            return await DbSet.FindAsync(nome);
        }

        public virtual void Remover(int codigo)
        {
            var entity = DbSet.Find(codigo);

            if (entity != null)
                DbSet.Remove(entity);
        }

        public virtual void Remover(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public async Task<int> Salvar()
        {
            return await Db.SaveChangesAsync();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }

        #endregion
    }
}
