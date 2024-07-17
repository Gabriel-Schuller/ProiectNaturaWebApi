﻿using ProiectNatura.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProiectNatura.Models;

namespace ProiectNatura.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int id);
        Task<User> AddUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(int id);
    }
}
