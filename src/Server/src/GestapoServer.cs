namespace CommandoTools.Gestapo.Server;

public sealed class GestapoServer : IServer
{
	private bool _started;

	public void Dispose()
	{
		// Ungraceful shutdown
		var canceledToken = new CancellationToken(canceled: true);
		StopAsync(canceledToken).GetAwaiter().GetResult();
	}

	public Task StartAsync(CancellationToken cancellationToken = default)
	{
		if (_started)
		{
			throw new InvalidOperationException("The server is already started");
		}
		_started = true;

		return Task.CompletedTask;
	}

	public Task StopAsync(CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}
}
