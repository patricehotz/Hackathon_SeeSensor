using SeeSensor.Api.Configuration;
using SeaSensor.Repositories;
using MongoDB.Driver;
using SeeSensor.Repositories.MongoDB;
using SeeSensor.Services.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var mongoDbSettings = new MongoDBSettings();

builder.Configuration.AddJsonFile(Environment.CurrentDirectory + "/Configuration/appsettings.json");

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "_myAllowSpecificOrigins",
                      policy =>
                      {
                          policy.AllowAnyOrigin();
                          policy.AllowAnyMethod();
                          policy.AllowAnyHeader();
                      });
});


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddMvcCore();

builder.Configuration.GetSection("Persistence").Bind(mongoDbSettings);
builder.Services.AddScoped<ISeaSensorService, SeaSensorService>();

if (mongoDbSettings.Type == "mongodb")
{
    builder.Services.AddSingleton<ISeaSensorRepository, MongoSeeSensorRepository>();
    builder.Services.AddSingleton<IMongoDatabase>(x => new MongoClient(mongoDbSettings.Connectionstring).GetDatabase(mongoDbSettings.Databasename));
}

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

app.UseCors("_myAllowSpecificOrigins");

app.Run();
