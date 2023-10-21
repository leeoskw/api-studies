using api_study.Interfaces.BrasilApi;
using api_study.Mappings.BrasilApi;
using api_study.Repositories;
using api_study.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IEndereco, EnderecoService>();
builder.Services.AddSingleton<IBrasilApi, BrasilApiRepository>();
//builder.Services.AddSingleton<IBanco,  BancoService>();

builder.Services.AddAutoMapper(typeof(EnderecoMapping));

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
