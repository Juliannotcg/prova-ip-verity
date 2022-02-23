using MediatR;

namespace Prova.Application.ViewModels
{
    public class InputPassViewModel : IRequest<ResponseViewModel>
    {
        public string Password { get; set; }
    }
}
