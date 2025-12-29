using UserloginAPI.Helpers;
using UserloginAPI.Models;
using UserloginAPI.Repository;

namespace UserloginAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly string _filePath;

        public UserRepository()
        {
            _filePath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "Data",
                "Users.json"
            );
        }

        public User? GetByUsername(string username)
        {
            var users = JsonFileHelper.ReadFromFile<User>(_filePath);
            return users.FirstOrDefault(u => u.Username == username);
        }

        public User Add(User user)
        {
            var users = JsonFileHelper.ReadFromFile<User>(_filePath);

            user.Id = users.Count + 1;
            users.Add(user);

            JsonFileHelper.WriteToFile(_filePath, users);
            return user;
        }
    }
}