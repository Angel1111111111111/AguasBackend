using AutoMapper;
using LOGIN.Dtos;
using LOGIN.Dtos.UserDTOs;
using LOGIN.Entities;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<CreateUserDto, UserEntity>();
        CreateMap<UserEntity, CreateUserDto>();

        CreateMap<LoginDto, UserEntity>();
        CreateMap<UserEntity, LoginDto>();

        CreateMap<LoginResponseDto, UserEntity>();
        CreateMap<UserEntity, LoginResponseDto>();
        CreateMap<LoginDto, LoginResponseDto>();

    }
}
