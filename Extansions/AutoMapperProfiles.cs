using AutoMapper;
using Test.API.Dtos;
using Test.API.Models;

namespace Test.API.Extansions
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UsersToListDto>().ForMember(dest => dest.Age , opt =>
            {
                opt.ResolveUsing(d => d.DateOfBirth.CalculateAge());
            });
            CreateMap<UserForRegisterDto, User>();

        }
    }
}