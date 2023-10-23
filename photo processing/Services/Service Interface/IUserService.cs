using Photo_processing.Data.Entities;

namespace Photo_processing.Services.Service_Interface
{
    public interface IUserService
    {
        public interface IUserService
        {
            User GetUserById(int userId);         
            List <User> GetAllUsers();
            void DeleteUser(int userId);
        }

    }
}
