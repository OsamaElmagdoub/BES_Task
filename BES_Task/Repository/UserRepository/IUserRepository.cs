using BES_Task.Data.Models;

namespace BES_Task.Repository.UserRepository
{
    public interface IUserRepository
    {
        User GetUserByUsername(string username);

    }
}
