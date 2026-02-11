var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); //  обязательно
builder.Services.AddSwaggerGen(); //  из Swashbuckle

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