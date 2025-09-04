using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Scalar.AspNetCore;

namespace Distrib.Shared.Api;

public static class DefaultDistribWebApp
{
    public static WebApplication Create(Action<WebApplicationBuilder>? webappBuilder = null)
    {
        var builder = WebApplication.CreateBuilder();
        builder.Services.AddControllers();
        builder.Services.AddOpenApi();
        
        webappBuilder?.Invoke(builder);
        return builder.Build();
    }

    public static void Run(WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
            app.MapScalarApiReference();
            
        }
        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}