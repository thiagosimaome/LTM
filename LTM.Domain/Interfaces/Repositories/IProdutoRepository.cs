using LTM.Domain.Entities;
using System.Collections.Generic;

namespace LTM.Domain.Interfaces
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> FindByName(string name); 
    }
}
