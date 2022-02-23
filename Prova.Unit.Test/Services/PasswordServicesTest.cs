using Prova.Application.Services;
using Prova.Application.ViewModels;
using System.Linq;
using System.Threading;
using Xunit;

namespace Prova.Unit.Test.Services
{
    public  class PasswordServicesTest
    {
        [Fact]
        public async void PasswordServices_SenhaValida_DeveRetornarSucesso()
        {
            var service = new PasswordService();

            var result = await service.Handle(new InputPassViewModel { Password = "asdasd" }, CancellationToken.None);
            Assert.Equal("A senha deve ter no minimo 1 caracter e no máximo 20 caracteres.", result?.Validations.First());
        }

        [Fact]
        public async void PasswordServices_SenhaMaior20Caracters_DeveRetornarSucesso()
        {
            var service = new PasswordService();

            var result = await service.Handle(new InputPassViewModel { Password = "abcdefghIJLmnOpQRstUV@" }, CancellationToken.None);
            Assert.Equal("A senha deve ter no minimo 1 caracter e no máximo 20 caracteres.", result?.Validations.First());
        }
    }
}
