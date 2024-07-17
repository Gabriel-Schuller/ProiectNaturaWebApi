using AutoMapper;
using ProiectNatura.DTOs;
using ProiectNatura.Models;

namespace ProiectNatura.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
