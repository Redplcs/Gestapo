using CommandoTools.Gestapo.Server;
using Microsoft.Extensions.Hosting;

namespace CommandoTools.Gestapo.Application;

public class HostedServerAdapter(IServer server) : IHostedService
{
	public Task StartAsync(CancellationToken cancellationToken)
	{
		return server.StartAsync(cancellationToken);
	}

	public Task StopAsync(CancellationToken cancellationToken)
	{
		return server.StopAsync(cancellationToken);
	}
}
