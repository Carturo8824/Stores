namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddRepositories(
    this IServiceCollection services,
    Action<DBOptions> configureDBOptions)
    {
        services.Configure(configureDBOptions);
        services.AddDbContext<StoresSalesContext>();
        services.AddScoped<ICommandsRepository, CommandsRepository>();
        return services;
    }
}