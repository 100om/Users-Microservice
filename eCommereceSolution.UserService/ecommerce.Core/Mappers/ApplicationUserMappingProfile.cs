using AutoMapper;
using eCommerce.Core.DTO;
using eCommerce.Core.Entities;

namespace ecommerce.Core.Mappers;

public class ApplicationUserMappingProfile : Profile
{
    public ApplicationUserMappingProfile()
    {
        CreateMap<ApplicationUser, AuthenticationResponse>().
            ForMember(dest => dest.UserID, opt => opt.MapFrom(source => source.UserID))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(source => source.Email))
            .ForMember(dest => dest.PersonName, opt => opt.MapFrom(source => source.PersonName))
            .ForMember(dest => dest.Gender, opt => opt.MapFrom(source => source.Gender))
            .ForMember(dest => dest.Success, opt => opt.Ignore())
            .ForMember(dest => dest.Token, opt => opt.Ignore());
         
    }


}
