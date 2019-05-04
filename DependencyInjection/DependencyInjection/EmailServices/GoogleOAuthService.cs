namespace DependencyInjection.EmailServices
{
    public class GoogleOAuthService : IOpenAuthService
    {
        public string ConfirmationMessage { get; set; }

        IOpenAuthService IOpenAuthService.RegisterUser(string emailAddress, string password)
        {
            // Register a new user
            // Then returning IOpenAuthService object

            return null;
        }


        public GoogleOAuthService RegisterUser(string emailAddress, string password)
        {
            // Register a new user
            // Then returning GoogleOAuthService object

            return null;
        }
    }
}
