using AutoMapper;
using LTM.MVC.ViewModels;
using LTM.Domain.Entities;

namespace LTM.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Produto, ProductViewModel>();
        }
    }
}