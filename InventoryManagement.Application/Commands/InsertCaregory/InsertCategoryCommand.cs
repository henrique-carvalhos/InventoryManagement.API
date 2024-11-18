using InventoryManagement.Application.Models;
using InventoryManagement.Core.Entities;
using MediatR;

namespace InventoryManagement.Application.Commands.InsertCaregory
{
    public class InsertCategoryCommand : IRequest<ResultViewModel<int>>
    {
        public string Name { get;  set; }
        public string Description { get;  set; }

        public Category ToEntity()
            => new Category(Name, Description);
    }
}
