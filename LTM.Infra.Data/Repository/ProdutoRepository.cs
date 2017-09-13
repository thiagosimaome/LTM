using System;
using System.Collections.Generic;
using LTM.Domain.Entities;
using LTM.Domain.Interfaces;

namespace LTM.Infra.Data.Repository
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> FindByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
