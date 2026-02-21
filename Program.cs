var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Comentamos esta línea porque Render maneja HTTPS automáticamente
// app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();
app.Run();