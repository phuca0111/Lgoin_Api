using Login_Api.Dtos;
using Login_Api.Models;
using AutoMapper;

namespace Api_Login.Profiles
{
    public class LoginProfile : Profile
    {
        public LoginProfile()
        {
            // Source -> Target
            CreateMap<LoginCreatedDto,DangNhap>()
                .ForMember(dest => dest.UserName, act => act.MapFrom(src => src.UserName))
                .ForMember(dest => dest.Matkhau, act => act.MapFrom(src => src.Password));

            CreateMap<DangNhap, LoginReadDto>();
        }
    }
}
