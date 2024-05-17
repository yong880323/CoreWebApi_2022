using NLog;
using NLog.Web;

// Add services to the container.
var logger = LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
try
{
	logger.Debug("init main");
	var builder = WebApplication.CreateBuilder(args);

	//�NNLog���U�즹�M�פ�
	builder.Logging.ClearProviders();
	//�]�wlog�������̤p����
	//builder.Logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Information);
	builder.Host.UseNLog();
	builder.Services.AddControllers();
	// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
	builder.Services.AddEndpointsApiExplorer();
	builder.Services.AddSwaggerGen();

	var app = builder.Build();

	// Configure the HTTP request pipeline.
	if (app.Environment.IsDevelopment())
	{
		app.UseSwagger();
		app.UseSwaggerUI();
	}

	app.UseHttpsRedirection();

	app.UseAuthorization();

	app.MapControllers();

	app.Run();
}
catch (Exception ex)
{
	// ����]�w���~�����~����
	logger.Error(ex, "Stopped program because of exception");
	throw;
}
finally
{
	//���T�w�b�����ɡA��nlog����
	LogManager.Shutdown();
}