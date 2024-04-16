var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Map("/date", async (app) => await app.Response.SendFileAsync("date.html"));
app.Map("/time", async (app) => await app.Response.SendFileAsync("clock.html"));
app.Map("/", async (app) => await app.Response.SendFileAsync("Welcome.html"));

app.Run();
