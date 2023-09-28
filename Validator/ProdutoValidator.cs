using FluentValidation;
using LojaGames.Model;

namespace LojaGames.Validator
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(p => p.Nome)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(255);

            RuleFor(p => p.Descricao)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(2000);

            RuleFor(p => p.Console)
                .NotEmpty()
                .MinimumLength(2)
                .MaximumLength(255);

            RuleFor(p => p.Preco)
                .NotEmpty();

            RuleFor(p => p.Foto)
                .NotEmpty()
                .MinimumLength(8)
                .MaximumLength(2000);
        }
    }
}