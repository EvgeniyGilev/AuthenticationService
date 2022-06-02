using AuthenticationService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AuthenticationService
{
    public class UserRepository : IUserRepository 
    {
        private List<User> users = null;
        public UserRepository()
        {
            User user1 = new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Иван",
                LastName = "Иванов",
                Email = "ivan@gmail.com",
                Password = "11111122222qq",
                Login = "ivanov"
            };
            User user2 = new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Петр",
                LastName = "Петров",
                Email = "petr@yandexl.ru",
                Password = "11111122222qq",
                Login = "petrov"
            };
            User user3 = new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Николай",
                LastName = "Сидоров",
                Email = "nsid@gmail.com",
                Password = "11111122222qq",
                Login = "sidorov"
            };

            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
        }

        //Метод IEnumerable<User> GetAll() должен возвращать всех пользователей (достаточно трёх).
        public IEnumerable<User> GetAll()
        {
            return users;
        }

        //Метод User GetByLogin(string login) должен возвращать одного пользователя
        //по его логину или значение null, если пользователь не найден (используйте Linq и его метод FirstOrDefault).
        public User GetByLogin(string login)
        {
            return users.FirstOrDefault(u => u.Login == login);
        }
    }
}
