using DependencyInjection.EmailServices;

namespace DependencyInjection.GoodExample
{
    public class UserLogic
    {
        private IOpenAuthService _authService;
        private IEmailService _emailService;

        // 1.Constructor Injection
        public UserLogic(IOpenAuthService authService, IEmailService emailService)
        {
            _authService = authService;
            _emailService = emailService;
        }
        // For (2) and (3) Injection type 
        public UserLogic() { }


        // 2.Property Setter Injection
        public IOpenAuthService AuthService
        {
            get { return _authService; }
            set { _authService = value; }
        }
        public IEmailService EmailService
        {
            get { return _emailService; }
            set { _emailService = value; }
        }


        // 3.Method Injection
        public void Register(string emailAddress, string password,
                             IEmailService emailService, IOpenAuthService authService)
        {
            IOpenAuthService authResult = authService.RegisterUser(emailAddress, password);
            emailService.SendEmail(emailAddress, authResult.ConfirmationMessage);
        }


        // For (1) and (2) Injection type 
        public void Register(string emailAddress, string password)
        {
            IOpenAuthService authResult = _authService.RegisterUser(emailAddress, password);
            _emailService.SendEmail(emailAddress, authResult.ConfirmationMessage);
        }
    }
}
