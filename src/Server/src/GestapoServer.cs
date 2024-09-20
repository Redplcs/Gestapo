namespace CommandoTools.Gestapo.Server;

public class GestapoServer : IServer
{
	private readonly GestapoServerOptions _options;

	public GestapoServer(GestapoServerOptions options)
	{
		_options = options;
	}

	public void Dispose()
	{
		throw new NotImplementedException();
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
