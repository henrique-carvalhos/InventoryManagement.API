using FluentValidation;
using InventoryManagement.Application.Commands.InsertSupplier;

namespace InventoryManagement.Application.Validators
{
    public class InsertSupplierValidator : AbstractValidator<InsertSupplierCommand>
    {
        public InsertSupplierValidator()
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

            RuleFor(p => p.Address)
                .NotEmpty()
                .WithMessage("Endereço não pode ser vazio")
                .MaximumLength(150)
                .WithMessage("Tamanho máximo é de 150 caracteres");

            RuleFor(p => p.Contact)
                .NotEmpty()
                .WithMessage("Contato não pode ser vazio")
                .MaximumLength(15)
                .WithMessage("Tamanho máximo é de 15 caracteres");
        }
    }
}
