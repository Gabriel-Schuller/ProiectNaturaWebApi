using ProiectNatura.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProiectNatura.DTOs;

namespace ProiectNatura.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> GetAllUsersAsync();
        Task<UserDTO> GetUserByIdAsync(int id);
        Task<UserDTO> AddUserAsync(UserDTO userDto);
        Task UpdateUserAsync(UserDTO userDto);
        Task DeleteUserAsync(int id);
    }
}
