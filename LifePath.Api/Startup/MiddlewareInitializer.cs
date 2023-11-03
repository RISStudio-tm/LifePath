namespace LifePath.Api.Startup;

public static class MiddlewareInitializer
{
    public static WebApplication ConfigureMiddleware(
        this WebApplication app)
    {
        //app.UseHttpsRedirection();
        app.UseAuthorization();

        app.MapControllers();

        return app;
    }
}