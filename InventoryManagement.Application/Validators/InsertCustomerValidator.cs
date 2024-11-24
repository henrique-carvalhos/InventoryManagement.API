using FluentValidation;
using InventoryManagement.Application.Commands.InsertCustomer;

namespace InventoryManagement.Application.Validators
{
    public class InsertCustomerValidator : AbstractValidator<InsertCustomerCommand>
    {
        public InsertCustomerValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .WithMessage("Descrição não pode ser vazia")
                .MaximumLength(150)
                .WithMessage("Tamanho máximo é de 150 caracteres");

            RuleFor(p => p.Email)
                .NotEmpty()
                .WithMessage("E-mail não pode ser vazio")
                .MaximumLength(150)
                .WithMessage("Tamanho máximo é de 150 caracteres");

            RuleFor(p => p.Phone)
                .NotEmpty()
                .WithMessage("Telefone não pode ser vazio")
                .MaximumLength(15)
                .WithMessage("Tamanho máximo é de 15 caracteres");
        }
    }
}
