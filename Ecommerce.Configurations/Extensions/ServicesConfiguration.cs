using Ecommerce.Abstractions.BLL;
using Ecommerce.Abstractions.Repository;
using Ecommerce.BLL;
using Ecommerce.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Configurations.Extensions
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection AddConfiguration(this IServiceCollection services)
        {
            #region Customer
            services.AddScoped<ICustomer, CustomerManager>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            #endregion
            return services;
        }
    }
}
