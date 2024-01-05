using GulYapanAPI.Persistence;
using GulYapanAPI.Infrastructure;
using GulYapanAPI.API;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddPersistanceServices();
builder.Services.AddInfrastructureServices();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseMiddleware<ExceptionHandlerMiddleware>();
app.Run();
