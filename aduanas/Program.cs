using aduanas;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);
var starup = new Starup(builder.Configuration);
starup.ConfigurationServices(builder.Services);
var app = builder.Build();
starup.Configure(app, app.Environment);
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
app.Run();
