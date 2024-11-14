namespace CommandoTools.Gestapo.Server.Tests;

public class GestapoServerTests
{
	[Fact]
	public async Task StartAsync_AlreadyStarted_ThrowsInvalidOperationException()
	{
		var server = new GestapoServer();
		await server.StartAsync();

		await Assert.ThrowsAsync<InvalidOperationException>(async () =>
		{
			await server.StartAsync();
		});
	}
}