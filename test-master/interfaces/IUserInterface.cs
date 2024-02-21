using test_master.Models;

namespace test_master.interfaces
{
    public interface IUserInterface
    {
        List<User> GetUsers();
        User GetUser(int id);
        void Add(User user);
        void Update(User user);
        void Delete(int id);
    }
}
