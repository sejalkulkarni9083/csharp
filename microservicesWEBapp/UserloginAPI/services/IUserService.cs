using UserloginAPI.Models;

namespace UserloginAPI.services
{
    public interface IUserService
    {
        User? Register(register request);
        User? Login(login request);
    }
}