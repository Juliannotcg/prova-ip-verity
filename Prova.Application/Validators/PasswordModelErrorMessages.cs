namespace Prova.Application.Validators
{
    public static class PasswordModelErrorMessages
    {
        public readonly static string Empty = "A senha não pode ser vazia.";
        public readonly static string MinLengthMaxLength = "A senha deve ter no minimo 1 caracter e no máximo 20 caracteres.";
        public readonly static string MinOneCharLower = "A senha deve possuir pelo meno 1 caracter mínusculo.";
        public readonly static string MinOneCharUpper = "A senha deve possuir pelo meno 1 caracter maiúsculo.";
        public readonly static string DuplicateChar = "A senha não deve ter caracteres repetidos no conjunto.";
        public readonly static string SpecialChar = "A senha deve possuir pelo menos um desses caracteres: (!@#$%^&*()-+)";
    }
}
