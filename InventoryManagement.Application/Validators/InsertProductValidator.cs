using FluentValidation;
using InventoryManagement.Application.Commands.InsertProduct;

namespace InventoryManagement.Application.Validators
{
    public class InsertProductValidator : AbstractValidator<InsertProductCommand>
    {
        public InsertProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .WithMessage("Descrição não pode ser vazia")
                .MaximumLength(150)
                .WithMessage("Tamanho máximo é de 150 caracteres");

            RuleFor(p => p.Description)
                .NotEmpty()
                .WithMessage("Descrição não pode ser vazia")
                .MaximumLength(150)
                .WithMessage("Tamanho máximo é de 150 caracteres");

            RuleFor(p => p.Price)
                .NotEmpty()
                .WithMessage("PReço não pode ser vazio")
                .GreaterThan(0)
                    .WithMessage("Preço deve ser maior R$0,00");

            RuleFor(p => p.QuantityInStock)
                .NotEmpty()
                .WithMessage("Quantidade em estoque não pode ser vazia")
                .GreaterThanOrEqualTo(1)
                    .WithMessage("Quantidade em estoque deve ser maior que zero");
        }
    }
}
