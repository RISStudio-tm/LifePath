using LifePath.Api.Startup;

namespace LifePath.Api;

public sealed class Program
{
    public static void Main(
        string[] args)
    {
        var builder = WebApplication
            .CreateBuilder(args);

        builder.Services.ConfigureServices();

        var app = builder
            .Build();

        app.ConfigureMiddleware();

        app.Run();
    }
}