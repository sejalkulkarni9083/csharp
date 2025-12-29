using UserloginAPI.Models;

namespace UserloginAPI.Repository
{
    public interface IUserRepository
    {
        User? GetByUsername(string username);
        User Add(User user);
    }
}