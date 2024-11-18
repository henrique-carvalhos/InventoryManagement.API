using InventoryManagement.Application.Models;
using MediatR;

namespace InventoryManagement.Application.Queries.GetAllCategory
{
    public class GetAllCategoryQuery : IRequest<ResultViewModel<List<CategoryViewModel>>>
    {
        public GetAllCategoryQuery(string search)
        {
            Search = search;
        }
     
        public string Search { get; set; }
    }
}
