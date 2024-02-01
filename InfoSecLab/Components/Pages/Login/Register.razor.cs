using Microsoft.AspNetCore.Components;
using System.Text.RegularExpressions;

namespace InfoSecLab.Components.Pages.Login
{
    public partial class Register : ComponentBase
    {
        private const String EmailPattern = @"^[^@]+@[^@]+\.[^.]+$";

        [GeneratedRegex(EmailPattern)]
        private static partial Regex EmailRegex();

        [Inject]
        protected NavigationManager? NavigationManager { get; set; }

        private String Email { get; set; } = String.Empty;
        private bool EmailValid { get; set; } = true;
        private String EmailErrorClass => EmailValid ? String.Empty : "is-invalid";

        private String Password { get; set; } = String.Empty;
        private String PasswordConfirmation { get; set; } = String.Empty;
    }
}
