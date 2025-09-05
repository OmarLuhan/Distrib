var app = DefaultDistribWebApp.Create(webappBuilder =>
{
    webappBuilder.Services.AddReverseProxy()
        .LoadFromConfig(webappBuilder.Configuration.GetSection("ReverseProxy"));
});
app.MapReverseProxy();
DefaultDistribWebApp.Run(app);

