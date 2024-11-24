using FluentValidation;
using InventoryManagement.Application.Commands.InsertSale;

namespace InventoryManagement.Application.Validators
{
    public class InsertSaleValidator : AbstractValidator<InsertSaleCommand>
    {
        public InsertSaleValidator()
        {
            RuleFor(p => p.TotalAmount)
                .NotEmpty()
                .WithMessage("Total não pode ser vazio")
                .GreaterThan(0)
                    .WithMessage("Total deve ser maior R$0,00");
        }
    }
}
