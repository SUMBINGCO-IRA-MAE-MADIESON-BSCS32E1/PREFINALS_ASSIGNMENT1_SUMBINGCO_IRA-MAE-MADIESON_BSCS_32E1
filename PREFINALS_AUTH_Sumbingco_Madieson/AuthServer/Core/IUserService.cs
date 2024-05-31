namespace AuthServer.Core
{
    public interface IUserService
    {
        void Register(User user);
        User Authenticate(string username, string password);
        User GetByUsername(string username);
    }
}
