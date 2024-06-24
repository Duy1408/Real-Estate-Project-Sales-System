using AutoMapper;
using RealEstateProjectSaleBusinessObject.BusinessObject;
using RealEstateProjectSaleBusinessObject.DTO.Create;
using RealEstateProjectSaleBusinessObject.DTO.Update;
using RealEstateProjectSaleBusinessObject.ViewModels;

namespace RealEstateProjectSale.Mapper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<StaffVM, Staff>().ReverseMap();
            CreateMap<StaffCreateDTO, Staff>().ReverseMap();
            CreateMap<StaffUpdateDTO, Staff>().ReverseMap();

            CreateMap<AccountVM, Account>().ReverseMap().ForMember(dest => dest.RoleName,
                                       opt => opt.MapFrom(src => src.Role!.RoleName));
            CreateMap<AccountCreateDTO, Account>().ReverseMap();
            CreateMap<AccountUpdateDTO, Account>().ReverseMap();

            CreateMap<CustomerVM, Customer>().ReverseMap();
            CreateMap<CustomerCreateDTO, Customer>().ReverseMap();
            CreateMap<CustomerUpdateDTO, Customer>().ReverseMap();


        }
    }
}
