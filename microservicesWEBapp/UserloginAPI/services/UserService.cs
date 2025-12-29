using UserloginAPI.Models;
using UserloginAPI.Repository;
using UserloginAPI.services;

namespace UserloginAPI.services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _UserRepository;

        public UserService(IUserRepository UserRepository)
        {
            _UserRepository = UserRepository;
        }

        public User? Register(register request)
        {
            var existingUser = _UserRepository.GetByUsername(request.Username);
            if (existingUser != null)
                return null;

            var user = new User
            {
                Username = request.Username,
                Password = request.Password,
                Email = request.Email
            };

            return _UserRepository.Add(user);
        }

        public User? Login(login request)
        {
            var user = _UserRepository.GetByUsername(request.Username);

            if (user == null || user.Password != request.Password)
                return null;

            return user;
        }
    }
}