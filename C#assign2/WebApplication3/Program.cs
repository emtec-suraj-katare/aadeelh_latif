var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

//app.MapGet("/weatherforecast", () =>
//{
//    var forecast = Enumerable.Range(1, 5).Select(index =>
//        new WeatherForecast
//        (
//            DateTime.Now.AddDays(index),
//            Random.Shared.Next(-20, 55),
//            summaries[Random.Shared.Next(summaries.Length)]
//        ))
//        .ToArray();
//    return forecast;
//})
//.WithName("GetWeatherForecast");

app.MapPost("/Calculator" , (Calculatormodel Calculator) => {
switch (Calculator.CalculatorOperation)
    {
        case  "+":
            return Results.Json(Calculator.Num1 + Calculator.Num2);
        case "-":
            return Results.Json(Calculator.Num1 - Calculator.Num2);
        case "*":
            return Results.Json(Calculator.Num1 * Calculator.Num2);
        case "/":
            return Results.Json(Calculator.Num1 / Calculator.Num2);
    }
    return Results.Json("not supported");
});

app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

public class Calculatormodel
{
    public int Num1{get; set;}
    public int Num2{get; set;}

    public string? CalculatorOperation{get; set;}
}