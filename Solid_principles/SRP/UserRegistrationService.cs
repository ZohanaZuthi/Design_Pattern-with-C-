using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid_principles.SRP
{
    public class UserRegistrationService
    {
        private readonly PasswordValidator _validator;
        private readonly UserRepository _repo;
        private readonly EmailService _email;


        public UserRegistrationService()
        {
            _validator = new PasswordValidator();
            _repo = new UserRepository();
            _email = new EmailService();
        }
        public void Register(User user)
        {
            if (!_validator.IsValid(user.Password))
            {
                throw new Exception("Weak password");
            }
            _repository.save(user);
            _email.SendWelcomeEmail(user);
        }
    }
}