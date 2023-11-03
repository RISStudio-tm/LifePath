namespace LifePath.Api.Startup;

public static class ServiceInitializer
{
    public static IServiceCollection ConfigureServices(
        this IServiceCollection services)
    {
        services.AddControllers();

        return services;
    }
}