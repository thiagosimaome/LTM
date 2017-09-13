using LTM.Application.Interfaces;
using LTM.Domain.Entities;
using LTM.Domain.Services;

namespace LTM.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _IProdutoAppService;

        public ProdutoAppService(IProdutoService ProdutpAppService) : base(ProdutpAppService)
        {
            _IProdutoAppService = ProdutpAppService;
        }
    }
}
