using AutoMapper;
using LOGIN.Dtos;
using LOGIN.Dtos.Communicates;
using LOGIN.Dtos.ReportDto;
using LOGIN.Dtos.StateDto;
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

        CreateMap<CommunicateDto, CommunicateEntity>();
        CreateMap<CommunicateEntity, CommunicateDto>();
        CreateMap<CreateCommunicateDto, CommunicateEntity>();

        CreateMap<StateDto, StateEntity>();
        CreateMap<StateEntity, StateDto>();

        CreateMap<ReportDto, ReportEntity>();
        CreateMap<ReportEntity, ReportDto>();
        CreateMap<CreateReportDto, ReportEntity>();

    }
}
