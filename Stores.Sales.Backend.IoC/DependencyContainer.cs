namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddNorthWindSalesServices(
    this IServiceCollection services,
    Action<DBOptions> configureDBOptions)
    {
        services.AddUseCasesServices()
        .AddRepositories(configureDBOptions)
        .AddPresenters();
        return services;
    }
}