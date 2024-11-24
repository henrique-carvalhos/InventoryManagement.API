using FluentValidation;
using FluentValidation.AspNetCore;
using InventoryManagement.Application.Commands.InsertCaregory;
using InventoryManagement.Application.Commands.InsertProduct;
using InventoryManagement.Application.Commands.InsertSale;
using InventoryManagement.Application.Models;
using InventoryManagement.Application.Queries.GetCategoryById;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryManagement.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services
                .AddHandlers()
                .AddValidation();

            return services;
        }

        public static IServiceCollection AddHandlers(this IServiceCollection services)
        {
            services.AddMediatR(config =>
            config.RegisterServicesFromAssemblyContaining<GetCategoryByIdQuery>());

            return services;
        }

        public static IServiceCollection AddValidation(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation()
                .AddValidatorsFromAssemblyContaining<InsertCategoryCommand>();

            services.AddTransient<IPipelineBehavior<InsertProductCommand, ResultViewModel<int>>, ValidateInsertProductCommandBehavior>();
            services.AddTransient<IPipelineBehavior<InsertSaleCommand, ResultViewModel<int>>, ValidateInsertSaleCommandBehavior>();

            return services;
        }
    }
}
