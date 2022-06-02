using AuthenticationService.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IMapper _mapper;
        private ILogger _logger;
        private IUserRepository _userRepository;
        public UserController(ILogger logger, IMapper mapper, IUserRepository userRepository)
        {
            _logger = logger;
            _mapper = mapper;

            _userRepository = userRepository;

            _logger.WriteEvent("Сообщение о событии в программе");
            _logger.WriteError("Сообщение об ошибки в программе");



        }

        [HttpGet]
        public User GetUser()
        {
            return new User
            {
                Id = System.Guid.NewGuid(),
                LastName = "Ivanov",
                FirstName = "Ivan",
                Login = "ivanov",
                Password = "111112222qqq",
                Email = "ivan@gmail.com"
            };
        }

        [HttpGet]
        [Route("viewmodel")]
        public UserViewModel GetUserViewModel()
        {
            User user = new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Иван",
                LastName = "Иванов",
                Email = "ivan@gmail.com",
                Password = "11111122222qq",
                Login = "ivanov"
            };

            var userViewModel = _mapper.Map<UserViewModel>(user);
           // UserViewModel userViewModel = new UserViewModel(user);

            return userViewModel;
        }
    }
}
