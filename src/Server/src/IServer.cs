namespace CommandoTools.Gestapo.Server;

public interface IServer : IDisposable
{
	Task StartAsync(CancellationToken cancellationToken = default);
	Task StopAsync(CancellationToken cancellationToken = default);
}
