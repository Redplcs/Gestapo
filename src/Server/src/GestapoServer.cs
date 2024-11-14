namespace CommandoTools.Gestapo.Server;

public sealed class GestapoServer : IServer
{
	public void Dispose()
	{
		// Ungraceful shutdown
		var canceledToken = new CancellationToken(canceled: true);
		StopAsync(canceledToken).GetAwaiter().GetResult();
	}

	public Task StartAsync(CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task StopAsync(CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}
}
