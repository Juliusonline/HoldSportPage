using HoldSportPage.Model;

namespace HoldSportPage.Services
{
    public interface IUserRepository
    {

        User? UserLoggedIn { get; }

        void AddUser(User user);
        bool CheckUser(string username, string password);
        void LogoutUser();
        void RemoveUser(User user);
    }
}