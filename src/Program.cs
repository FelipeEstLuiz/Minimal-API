var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();

app.MapGet("/cliente", () => new Cliente("Felipe", "fel13.luiz@gmail.com"));

app.UseSwaggerUI();

app.Run();

public record Cliente(string Nome, string Email);
