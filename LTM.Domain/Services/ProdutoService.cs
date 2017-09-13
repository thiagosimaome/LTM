using LTM.Domain.Entities;
using LTM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTM.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _ProdutoRepository;

        public ProdutoService(IProdutoRepository ProdutoRepository) : base(ProdutoRepository)
        {
            _ProdutoRepository = ProdutoRepository;
        }
    }
}
