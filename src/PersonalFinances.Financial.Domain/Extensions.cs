using Microsoft.Extensions.DependencyInjection;
using PersonalFinances.Financial.Domain.Interfaces.Services;
using PersonalFinances.Financial.Domain.Services;

namespace PersonalFinances.Financial.Domain
{
    public static class Extensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IExpenseService, ExpenseService>();

            return services;
        }
    }
}
