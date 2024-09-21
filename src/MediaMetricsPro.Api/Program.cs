var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddSwaggerGen();
builder.Services.AddEndpoints(typeof(Program).Assembly);

var app = builder.Build();

app.Run();
