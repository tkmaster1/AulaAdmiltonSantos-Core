using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKMaster.AulaCSharp.Core.Domain.Entities;

namespace TKMaster.AulaCSharp.Core.Domain.Interfaces.Services
{
    public interface IFornecedorAppService : IDisposable
    {
        Task<IEnumerable<Fornecedor>> ListarTodos();

        Task<Fornecedor> ObterPorCodigo(int codigo);

        Task<int> Adicionar(Fornecedor entity);

        Task<bool> Alterar(Fornecedor entity);

        Task<bool> Excluir(Fornecedor entity);

        Task<bool> Reativar(Fornecedor entity);

        Task<Fornecedor> NomeExiste(string nomeDoCliente);

        Task<Fornecedor> DocumentoExiste(string documento);
    }
}
