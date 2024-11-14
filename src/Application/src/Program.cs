using CommandoTools.Gestapo.Application;
using CommandoTools.Gestapo.Server;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = Host.CreateApplicationBuilder(args);

host.Services.AddSingleton<IServer, GestapoServer>();
host.Services.AddHostedService<HostedServerAdapter>();

await host.Build().RunAsync();
