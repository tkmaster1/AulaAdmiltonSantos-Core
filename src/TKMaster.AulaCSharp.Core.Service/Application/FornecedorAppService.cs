using TKMaster.AulaCSharp.Core.Domain.Entities;
using TKMaster.AulaCSharp.Core.Domain.Interfaces.Repositories;
using TKMaster.AulaCSharp.Core.Domain.Interfaces.Services;

namespace TKMaster.AulaCSharp.Core.Service.Application
{
    public class FornecedorAppService : IFornecedorAppService
    {
        #region Properties

        private readonly IFornecedorRepository _fornecedorRepository;

        #endregion

        #region Constructor

        public FornecedorAppService(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        #endregion

        #region Properties

        #endregion
        public async Task<int> Adicionar(Fornecedor entity)
        {
            _fornecedorRepository.Adicionar(entity);
            await _fornecedorRepository.Salvar();
            return entity.Codigo;
        }

        public Task<bool> Alterar(Fornecedor entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<Fornecedor> DocumentoExiste(string documento)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Excluir(Fornecedor entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Fornecedor>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public Task<Fornecedor> NomeExiste(string nomeDoCliente)
        {
            throw new NotImplementedException();
        }

        public Task<Fornecedor> ObterPorCodigo(int codigo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Reativar(Fornecedor entity)
        {
            throw new NotImplementedException();
        }
    }
}