using FluentValidation;
using Prova.Application.ViewModels;

namespace Prova.Application.Validators
{
    public sealed class PasswodValidator : AbstractValidator<PasswordViewModel>
    {
        public PasswodValidator()
        {
            RuleFor(x => x.Password).NotEmpty().WithMessage(PasswordModelErrorMessages.Empty)
               .Length(1, 20).WithMessage(PasswordModelErrorMessages.MinLengthMaxLength)
               .Must(p => p.Any(c => char.IsLower(c))).WithMessage(PasswordModelErrorMessages.MinOneCharLower)
               .Must(p => p.Any(c => char.IsUpper(c))).WithMessage(PasswordModelErrorMessages.MinOneCharUpper)
               .Must(CaracterEquals).WithMessage(PasswordModelErrorMessages.DuplicateChar)
               .Matches("(?=.[!@#$%^&()-+])").WithMessage(PasswordModelErrorMessages.SpecialChar);
        }

        private bool CaracterEquals(string pass)
        {
            var alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < alfabeto.Length; i++)
            {
                var qtd = pass.Count(c => c.ToString().ToLower() == alfabeto[i].ToString().ToLower());
                if (qtd > 1)
                    return false;
            }

            return true;
        }
    }
}
