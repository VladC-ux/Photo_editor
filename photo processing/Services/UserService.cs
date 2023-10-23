using Photo_processing.Data.Entities;
using Photo_processing.Repositories.Repositrorie_Interface;
using Photo_processing.Enum;
using Photo_processing.Repositories;
using Photo_processing.Services.Service_Interface;
using Photo_processing.Repositories.Repositrorie_Interface;
using Photo_processing.Data.Entities;
using System.Drawing;


namespace Photo_processing.Services
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetUserById(int userId)
        {
            return _userRepository.GetUserById(userId);
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public void DeleteUser(int userId)
        {
            _userRepository.DeleteUser(userId);
        }
    }

}
