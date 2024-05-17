using NLog;
using NLog.Web;

// Add services to the container.
var logger = LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
try
{
	logger.Debug("init main");
	var builder = WebApplication.CreateBuilder(args);

	//將NLog註冊到此專案內
	builder.Logging.ClearProviders();
	//設定log紀錄的最小等級
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
	// 捕獲設定錯誤的錯誤紀錄
	logger.Error(ex, "Stopped program because of exception");
	throw;
}
finally
{
	//須確定在關閉時，把nlog關閉
	LogManager.Shutdown();
}