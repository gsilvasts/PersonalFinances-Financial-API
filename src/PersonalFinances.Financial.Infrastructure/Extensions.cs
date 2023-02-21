using Microsoft.Extensions.DependencyInjection;
using PersonalFinances.Financial.Domain.Interfaces.Repositories;
using PersonalFinances.Financial.Infrastructure.Persistence.Repositories;

namespace PersonalFinances.Financial.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IExpenseRepository, ExpenseRepository>();

            return services;
        }
    }
}
