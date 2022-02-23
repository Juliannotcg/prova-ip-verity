using FluentValidation.Results;

namespace Prova.Application.ViewModels
{
    public  class ResponseViewModel
    {
        public ResponseViewModel()
        {
            Validations = new List<string>();
        }
        public bool Success { get; set; }
        public List<string> Validations { get; set; }
    }
}
