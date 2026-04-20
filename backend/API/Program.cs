var builder = WebApplication.CreateBuilder(args);
const string cors = "cors";
const string frontendUrl = "http://localhost:5173";

builder.Services.AddOpenApi();

builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: cors,
        policy  =>
        {
            policy.WithOrigins(frontendUrl)
                .AllowAnyHeader()
                .AllowAnyMethod();;
        });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseCors(cors);
app.MapControllers();
app.Run();