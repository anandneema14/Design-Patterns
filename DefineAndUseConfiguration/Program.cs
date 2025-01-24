using DefineAndUseConfiguration;

var builder = Host.CreateApplicationBuilder(args);
var x = builder.Environment.EnvironmentName;
builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();