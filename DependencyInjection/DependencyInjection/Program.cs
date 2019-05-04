using DependencyInjection.BadExample1;
using DependencyInjection.BadExample2;
using DependencyInjection.EmailServices;
using DependencyInjection.GoodExample;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            // BadExample1 uses email sending logic with google service. 
            // But it can not use other email services.
            UserLogicBadExample1 userLogicBadExample1 = new UserLogicBadExample1();
            userLogicBadExample1.Register("example@gmail.com", "examplePassword");



            // BadExample2 uses email sending logic with outlook service. 
            // But it can not use other email services.
            UserLogicBadExample2 userLogicBadExample2 = new UserLogicBadExample2();
            userLogicBadExample2.Register("example@outlook.com", "examplePassword");



            //////////////////////////////////////////////////////////////////////////////////////////////////////////////



            // Good example.
            // The types are known only in runtime
            // It uses IOpenAuthService and IEmailService interfaces for Dependency Injection(DI)
            // There are 3 types of DI


            // 1.Constructor Injection
            GoogleOAuthService googleAuth1 = new GoogleOAuthService(); // Or Outlook
            GoogleEmailService googleEmail1 = new GoogleEmailService();   // Or Outlook 
            UserLogic user1 = new UserLogic(googleAuth1, googleEmail1);

            user1.Register("example@gmail.com", "examplePassword");


            // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // 


            // 2. Property setter Injection
            GoogleOAuthService googleAuth2 = new GoogleOAuthService(); // Or Outlook
            GoogleEmailService googleEmail2 = new GoogleEmailService();   // Or Outlook 
            UserLogic user2 = new UserLogic();
            user2.AuthService = googleAuth2;
            user2.EmailService = googleEmail2;

            user2.Register("example@gmail.com", "examplePassword");


            // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // 


            // 3. Method Injection
            GoogleOAuthService googleAuth3 = new GoogleOAuthService(); // Or Outlook
            GoogleEmailService googleEmail3 = new GoogleEmailService();   // Or Outlook 
            UserLogic user3 = new UserLogic();

            user2.Register("example@gmail.com", "examplePassword", googleEmail3, googleAuth3);

        }
    }
}
