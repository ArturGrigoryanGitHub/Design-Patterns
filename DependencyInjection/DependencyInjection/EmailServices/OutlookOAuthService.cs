namespace DependencyInjection.EmailServices
{
    public class OutlookOAuthService : IOpenAuthService
    {
        public string ConfirmationMessage { get; set; }

        IOpenAuthService IOpenAuthService.RegisterUser(string emailAddress, string password)
        {
            // Register a new user
            // Then returning IOpenAuthService object

            return null;
        }


        // For bad example
        public OutlookOAuthService RegisterUser(string emailAddress, string password)
        {
            // Register a new user
            // Then returning OutlookOAuthService object

            return null;
        }
    }
}
