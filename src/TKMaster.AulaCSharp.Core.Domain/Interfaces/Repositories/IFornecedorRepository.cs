using TKMaster.AulaCSharp.Core.Domain.Entities;

namespace TKMaster.AulaCSharp.Core.Domain.Interfaces.Repositories
{
    public interface IFornecedorRepository : IRepositoryBase<Fornecedor>
    {
        Task<Fornecedor> NomeExiste(string nomeDoCliente);

        Task<Fornecedor> DocumentoExiste(string documento);
    }
}
