using DependencyInjection.EmailServices;

namespace DependencyInjection.BadExample2
{
    public class UserLogicBadExample2
    {
        private OutlookOAuthService _authService;
        private OutlookEmailService _emailService;

        public UserLogicBadExample2()
        {
            _authService = new OutlookOAuthService();
            _emailService = new OutlookEmailService();
        }


        public void Register(string emailAddress, string password)
        {
            OutlookOAuthService authResult = _authService.RegisterUser(emailAddress, password);
            _emailService.SendEmail(emailAddress, authResult.ConfirmationMessage);
        }
    }
}
