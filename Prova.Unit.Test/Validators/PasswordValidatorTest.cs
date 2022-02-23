using Prova.Application.Validators;
using Prova.Application.ViewModels;
using Xunit;

namespace Prova.Unit.Test.Validators
{
    public  class PasswordValidatorTest
    {
        [Fact]
        public async void PasswordValidator_SenhaValida_DeveRetornarSucesso()
        {
            var validator = new PasswodValidator();
            var result = validator.Validate(new PasswordViewModel("Asdt@"));
            Assert.True(result.IsValid);
        }

        [Fact]
        public async void PasswordValidator_SenhaInvalida_DeveRetornarSucesso()
        {
            var validator = new PasswodValidator();
            var result = validator.Validate(new PasswordViewModel("AAAsdts"));
            Assert.False(result.IsValid);
        }
    }
}
