using LTM.Application.Interfaces;
using LTM.Domain.Entities;
using LTM.Domain.Services;

namespace LTM.Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _IClienteService;

        public ClienteAppService(IClienteService iclienteService) : base(iclienteService)
        {
            _IClienteService = iclienteService;
        }
    }
}