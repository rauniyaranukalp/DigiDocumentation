using DigiDocumentation.Extenstions;
using MongoDB.Driver;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.ConfigureDbContext(builder.Configuration
//builder.Services.AddSingleton<MongoDbConnection>();

builder.Services.AddSingleton<IMongoClient>(sp =>
{
    var configuration = sp.GetRequiredService<IConfiguration>();
    var connectionString = "mongodb+srv://bigdawg:NU6Qmpy4EA563a49@techdocumentation.8gjjh.mongodb.net/TechDocumentationDB?retryWrites=true&w=majority&appName=TechDocumentation"; 
    return new MongoClient(connectionString);
});

// Register MongoDbConnection as a singleton
builder.Services.AddSingleton<MongoDbConnection>();
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureServiceManager();
builder.Services.ConfigureCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// Configure the HTTP request pipeline.
app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
