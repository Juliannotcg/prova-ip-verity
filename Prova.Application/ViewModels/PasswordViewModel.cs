using FluentValidation.Results;
using Prova.Application.Validators;

namespace Prova.Application.ViewModels
{
    public record PasswordViewModel
    {
        public PasswordViewModel(string password)
        {
            Password = password;
        }

        public string Password { get; init; }
        public ValidationResult ValidationResult { get; set; }

        public bool IsValid()
        {
            ValidationResult = new PasswodValidator().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
