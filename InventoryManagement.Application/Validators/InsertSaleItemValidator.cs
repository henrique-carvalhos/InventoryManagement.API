using FluentValidation;
using InventoryManagement.Application.Commands.InsertSaleItem;

namespace InventoryManagement.Application.Validators
{
    public class InsertSaleItemValidator : AbstractValidator<InsertSaleItemCommand>
    {
        public InsertSaleItemValidator()
        {
            RuleFor(p => p.Quantity)
                .NotEmpty()
                .WithMessage("Quantidade não pode ser vazio")
                .GreaterThan(0)
                    .WithMessage("Quantidade deve ser maior que zero");

            RuleFor(p => p.UnitPrice)
                .NotEmpty()
                .WithMessage("Preço unitário não pode ser vazio")
                .GreaterThan(0)
                    .WithMessage("Preço unitário deve ser maior R$0,00");
        }
    }
}
