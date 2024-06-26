﻿namespace AuthServer.Core
{
    public class UserService : IUserService
    {
        private readonly List<User> _users = new List<User>();

        public void Register(User user)
        {
            _users.Add(user);
        }

        public User Authenticate(string username, string password)
        {
            return _users.SingleOrDefault(x => x.Username == username && x.PasswordHash == password);
        }

        public User GetByUsername(string username)
        {
            return _users.SingleOrDefault(x => x.Username == username);
        }
    }
}
