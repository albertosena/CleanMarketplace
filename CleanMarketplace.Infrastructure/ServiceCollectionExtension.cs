using CleanMarketplace.Application.Interfaces;
using CleanMarketplace.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CleanMarketplace.Infrastructure
{
    public static class ServiceCollectionExtension
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IProdutoRepository, ProdutoRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
