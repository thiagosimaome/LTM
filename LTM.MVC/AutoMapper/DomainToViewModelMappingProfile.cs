using AutoMapper;
using LTM.Domain.Entities;
using LTM.MVC.ViewModels;

namespace LTM.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ProductViewModel, Produto>();
        }
    }
}