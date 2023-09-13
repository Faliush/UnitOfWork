using Faliush.ContactManager.Infrastructure.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace UnitOfWork.UnitOfWork;

public static class UnitOfWorkDependencyInjectionExtention
{
	public static IServiceCollection AddUnitOfWork<TContext>(this IServiceCollection services) where TContext : DbContext
	{
		services.AddScoped<IRepositoryFactory, UnitOfWork<TContext>>();
		services.AddScoped<IUnitOfWork, UnitOfWork<TContext>>();
		services.AddScoped<IUnitOfWork<TContext>, UnitOfWork<TContext>>();

		return services;
	}
}
