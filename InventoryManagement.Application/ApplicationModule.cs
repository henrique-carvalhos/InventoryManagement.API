using FluentValidation;
using FluentValidation.AspNetCore;
using InventoryManagement.Application.Queries.GetCategoryById;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //services.AddFluentValidationAutoValidation()
            //    .AddValidatorsFromAssemblyContaining<CreateProductCommand>();

            //services.AddTransient<IPipelineBehavior<CreateProductCommand, ResultViewModel<int>>, ValidateCreateProductCommandBehavior>();

            return services;
        }
    }
}
