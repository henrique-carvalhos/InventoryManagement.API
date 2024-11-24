using FluentValidation;
using InventoryManagement.Application.Commands.InsertCaregory;

namespace InventoryManagement.Application.Validators
{
    public class InsertCategoryValidator : AbstractValidator<InsertCategoryCommand>
    {
        public InsertCategoryValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .WithMessage("Nome não pode ser vazio")
                .MaximumLength(150)
                .WithMessage("Tamanho máximo é de 150 caracteres");

            RuleFor(p => p.Description)
                .NotEmpty()
                .WithMessage("Descrição não pode ser vazia")
                .MaximumLength(150)
                .WithMessage("Tamanho máximo é de 150 caracteres");
        }
    }
}
