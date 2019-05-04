namespace DependencyInjection.EmailServices
{
    public interface IEmailService
    {
        void SendEmail(string emailAddress, string message);
    }
}
