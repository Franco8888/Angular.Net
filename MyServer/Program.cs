using MyServer.Services;

var builder = WebApplication.CreateBuilder(args);

// ENABLE  CORS ==========
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyHeader();
        });
});
//========================

// Add services to the container ==========
builder.Services.AddSingleton<IProductService, ProductService>();
// Add services to the container ==========

builder.Services.AddControllers();
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

app.UseHttpsRedirection();

app.UseCors();    //ENABLE CORS===========

app.UseAuthorization();

app.MapControllers();

app.Run();
