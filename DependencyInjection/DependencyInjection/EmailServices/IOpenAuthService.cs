using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.EmailServices
{
    public interface IOpenAuthService
    {
        string ConfirmationMessage { get; set; }
        IOpenAuthService RegisterUser(string emailAddress, string password);
    }
}
