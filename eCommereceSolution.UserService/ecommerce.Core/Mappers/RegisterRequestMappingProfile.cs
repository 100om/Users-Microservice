using AutoMapper;
using eCommerce.Core.DTO;
using eCommerce.Core.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ecommerce.Core.Mappers
{
    public class RegisterRequestMappingProfile  :Profile
    {

            //        The source is the object that already has data.
            //The destination is the object you want to create or fill.
        RegisterRequestMappingProfile()
        {
            
            CreateMap<RegisterRequest, ApplicationUser>().ForMember(dest => dest.Email, opt => opt.MapFrom(scr => scr.Email))
            .ForMember(dest => dest.Password, opt => opt.MapFrom(scr => scr.Password))
            .ForMember(dest => dest.Gender, opt => opt.MapFrom(scr => scr.Gender.ToString()));
        }

        
    }
}
