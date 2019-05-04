using DependencyInjection.EmailServices;

namespace DependencyInjection.BadExample1
{
    public class UserLogicBadExample1
    {
        private GoogleOAuthService _authService;
        private GoogleEmailService _emailService;

        public UserLogicBadExample1()
        {
            _authService = new GoogleOAuthService();
            _emailService = new GoogleEmailService();
        }

        public void Register(string emailAddress, string password)
        {
            GoogleOAuthService authResult = _authService.RegisterUser(emailAddress, password);
            _emailService.SendEmail(emailAddress, authResult.ConfirmationMessage);
        }
    }
}
