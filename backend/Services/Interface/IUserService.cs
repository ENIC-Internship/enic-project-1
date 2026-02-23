using backend.Models;
namespace backend.Services.Interface;

public interface IUserService
{
  Task<List<Users>> GetAllUsersAsync();

  Task<Users?> GetUserByIdAsync(int id);

  Task<Users> CreateUserAsync(Users user);

  Task<bool> UpdateUserAsync(int id, Users user);

  Task<bool> DeleteUserAsync(int id);
}
