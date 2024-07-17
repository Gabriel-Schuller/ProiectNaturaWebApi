using AutoMapper;
using ProiectNatura.DTOs;
using ProiectNatura.Models;
using ProiectNatura.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProiectNatura.DTOs;
using ProiectNatura.Models;
using ProiectNatura.Repositories.Interfaces;
using ProiectNatura.Services.Interfaces;

namespace ProiectNatura.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDTO>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllUsersAsync();
            return _mapper.Map<IEnumerable<UserDTO>>(users);
        }

        public async Task<UserDTO> GetUserByIdAsync(int id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            return _mapper.Map<UserDTO>(user);
        }

        public async Task<UserDTO> AddUserAsync(UserDTO userDto)
        {
            var user = _mapper.Map<User>(userDto);
            var newUser = await _userRepository.AddUserAsync(user);
            return _mapper.Map<UserDTO>(newUser);
        }

        public async Task UpdateUserAsync(UserDTO userDto)
        {
            var user = _mapper.Map<User>(userDto);
            await _userRepository.UpdateUserAsync(user);
        }

        public async Task DeleteUserAsync(int id)
        {
            await _userRepository.DeleteUserAsync(id);
        }
    }
}
