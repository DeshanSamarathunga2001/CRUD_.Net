var builder = WebApplication.CreateBuilder(args);

//services
builder.Services.AddControllers();

var app = builder.Build();


//Middleware
app.MapControllers();

app.Run();
