using AutoMapper;
using ContactsExercise.Models;
using ContactsExercise.Models.ViewModels;

namespace ContactsExercise
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Contact, ContactViewModel>().ReverseMap();
            CreateMap<Contact, ContactDetailViewModel>()
                .ForMember(dst => dst.Box, opt => opt.MapFrom(src => src.Address.Box))
                .ForMember(dst => dst.Street, opt => opt.MapFrom(src => src.Address.Street))
                .ForMember(dst => dst.HouseNumber, opt => opt.MapFrom(src => src.Address.HouseNumber))
                .ForMember(dst => dst.PostalCode, opt => opt.MapFrom(src => src.Address.PostalCode))
                .ForMember(dst => dst.Residence, opt => opt.MapFrom(src => src.Address.Residence))
                .ForMember(dst => dst.AddressId, opt => opt.MapFrom(src => src.AddressId))
                .ReverseMap();
            CreateMap<Contact, ContactCreateViewModel>()
                 .ForMember(dst => dst.Box, opt => opt.MapFrom(src => src.Address.Box))
                 .ForMember(dst => dst.Street, opt => opt.MapFrom(src => src.Address.Street))
                 .ForMember(dst => dst.HouseNumber, opt => opt.MapFrom(src => src.Address.HouseNumber))
                 .ForMember(dst => dst.PostalCode, opt => opt.MapFrom(src => src.Address.PostalCode))
                 .ForMember(dst => dst.Residence, opt => opt.MapFrom(src => src.Address.Residence))
                 .ForMember(dst => dst.AddressId, opt => opt.MapFrom(src => src.AddressId))
                 .ReverseMap();
            CreateMap<Contact, ContactUpdateViewModel>()
                 .ForMember(dst => dst.Box, opt => opt.MapFrom(src => src.Address.Box))
                 .ForMember(dst => dst.Street, opt => opt.MapFrom(src => src.Address.Street))
                 .ForMember(dst => dst.HouseNumber, opt => opt.MapFrom(src => src.Address.HouseNumber))
                 .ForMember(dst => dst.PostalCode, opt => opt.MapFrom(src => src.Address.PostalCode))
                 .ForMember(dst => dst.Residence, opt => opt.MapFrom(src => src.Address.Residence))
                 .ForMember(dst => dst.AddressId, opt => opt.MapFrom(src => src.Address.Id))
                 .ReverseMap();
            CreateMap<Contact, ContactDeleteViewModel>().ReverseMap();
        }
    }
}