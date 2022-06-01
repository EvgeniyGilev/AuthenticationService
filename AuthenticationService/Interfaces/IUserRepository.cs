using System.Collections.Generic;

namespace AuthenticationService.Interfaces
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAll();
        public User GetByLogin(string login);

    }
}
