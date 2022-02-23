using Prova.Application.ViewModels;
using Prova.Integration.Test.Fixtures;
using System.Linq;
using System.Net.Http.Json;
using Xunit;

namespace Prova.Api.Test.EndPointTest
{
    [Collection(nameof(IntegrationApiTestsFixtureCollection))]
    public  class PasswordValidationTest
    {
        private readonly IntegrationTestApiFixture _testsFixture;

        public PasswordValidationTest(IntegrationTestApiFixture testsFixture)
        {
            _testsFixture = testsFixture;
        }

        [Theory]
        [InlineData("Asdt@")]
        [InlineData("BfRuj@")]
        [InlineData("ulO@da")]
        public async void ValidarSenha_SenhaValida_DeveRetornarSucesso(string pass)
        {
            var result = await _testsFixture.Client.GetFromJsonAsync<ResponseViewModel>($"api/password/{pass}");
            Assert.True(result?.Success);
        }

        [Fact]
        public async void ValidarSenha_SenhaMaior20Caracters_DeveRetornarErro()
        {
            var result = await _testsFixture.Client.GetFromJsonAsync<ResponseViewModel>($"api/password/abcdefghIJLmnOpQRstUV@");
            Assert.Equal("A senha deve ter no minimo 1 caracter e no máximo 20 caracteres.", result?.Validations.First());
        }

        [Fact]
        public async void ValidarSenha_SenhaSemCaracteresEspeciais_DeveRetornarErro()
        {
            var result = await _testsFixture.Client.GetFromJsonAsync<ResponseViewModel>($"api/password/adHutMC");
            Assert.Equal("A senha deve possuir pelo menos um desses caracteres: (!@#$%^&*()-+)", result?.Validations.First());
        }
    }
}
