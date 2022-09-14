using Microsoft.EntityFrameworkCore;
using TKMaster.AulaCSharp.Core.Data.Context;
using TKMaster.AulaCSharp.Core.Domain.Entities;
using TKMaster.AulaCSharp.Core.Domain.Interfaces.Repositories;

namespace TKMaster.AulaCSharp.Core.Data.Repository
{
    public class FornecedorRepository : RepositoryBase<Fornecedor>, IFornecedorRepository
    {
        #region Constructor

        public FornecedorRepository(MeuContextoDB context) : base(context) { }

        #endregion

        #region Methods

        public async Task<Fornecedor> NomeExiste(string nomeDoFornecedor)
        {
            return await DbSet.Where(x => x.Nome.ToLower().Trim().Contains(nomeDoFornecedor.ToLower().Trim())).FirstOrDefaultAsync();
        }

        public async Task<Fornecedor> DocumentoExiste(string documento)
        {
            return await DbSet.Where(x => x.Documento.Trim().Equals(documento.Trim())).FirstOrDefaultAsync();
        }

        #endregion
    }
}
