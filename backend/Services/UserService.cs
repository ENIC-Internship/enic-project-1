using backend.Models;
using backend.Services.Interface;
namespace backend.Services;

public class UserService : IUserService
{

  static List<Users> users = new List<Users>
  {
    new Users { id = 1, name = "John Doe", email = "johndoe@admin.com", password = "password123" },
    new Users { id = 2, name = "Jane Smith", email = "janesmith@user.com", password = "password456" }
  };

  public async Task<List<Users>> GetAllUsersAsync()
    => await Task.FromResult(users);

  public async Task<Users?> GetUserByIdAsync(int id)
  {
    var user = users.FirstOrDefault(u => u.id == id);
    return await Task.FromResult(user);
  }

  public Task<Users> CreateUserAsync(Users user)
  {
    throw new NotImplementedException();
  }

  public Task<bool> UpdateUserAsync(int id, Users user)
  {
    throw new NotImplementedException();
  }

  public Task<bool> DeleteUserAsync(int id)
  {
    throw new NotImplementedException();
  }
  
}
