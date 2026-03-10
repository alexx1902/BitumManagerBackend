
using Bitum.Application.MaterialUnits;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); //  обязательно
builder.Services.AddSwaggerGen(); //  из Swashbuckle
builder.Services.AddHttpContextAccessor();// чтобы получать ссылку на текущий хост, на котором работает сервис
builder.Services.AddScoped<IQrCodeGenerator, Bitum.Infrastructure.QrCodeGenerator>();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();        // сервирует /swagger/v1/swagger.json
    app.UseSwaggerUI();      // сервирует UI по /swagger
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();