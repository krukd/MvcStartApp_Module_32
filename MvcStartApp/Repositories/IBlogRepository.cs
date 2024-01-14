using MvcStartApp.Models.Db;

namespace MvcStartApp.Repositories
{
    public interface IBlogRepository
    {

        Task<User[]> GetUsers();
        Task AddUser(User user);
    }

    
}
