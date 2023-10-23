using Microsoft.EntityFrameworkCore;
using Photo_processing.Data.Entities;
using Photo_processing.Repositories.Repositrorie_Interface;
using Photo_processing.Data;

namespace Photo_processing.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DBImagineContext _dbContext;

        public UserRepository(DBImagineContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void CreateUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        public void DeleteUser(int userId)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Id == userId);
            if (user != null)
            {
                _dbContext.Users.Remove(user);
                _dbContext.SaveChanges();
            }
        }

        public List<User> GetAllUsers()
        {
            return _dbContext.Users.ToList();
        }

        public User GetUserById(int userId)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Id == userId);
        }

        public void UpdateUser(User user)
        {
            _dbContext.Users.Update(user);
            _dbContext.SaveChanges();
        }
    }
}
