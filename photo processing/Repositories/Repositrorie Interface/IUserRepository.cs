using Photo_processing.Data.Entities;

namespace Photo_processing.Repositories.Repositrorie_Interface
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        User GetUserById(int userId);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int userId);
    }
}
