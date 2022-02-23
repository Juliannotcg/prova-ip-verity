using MediatR;
using Prova.Application.ViewModels;

namespace Prova.Application.Services
{
    public class PasswordService : IRequestHandler<InputPassViewModel, ResponseViewModel>
    {
        public async Task<ResponseViewModel> Handle(InputPassViewModel request, CancellationToken cancellationToken)
        {
            var passwordViewModel = new PasswordViewModel(request.Password);
            if (!passwordViewModel.IsValid()) return await Task.FromResult(new ResponseViewModel
            {
                Success = false,
                Validations = passwordViewModel.ValidationResult.Errors.Select(x => x.ErrorMessage).ToList()
            }); ;

            return await Task.FromResult(new ResponseViewModel
            {
                Success = true,
                Validations = new List<string> { "Sua senha está correta." }
            });
        }
    }
}
