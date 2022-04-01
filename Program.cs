using Microsoft.EntityFrameworkCore;
using DvlaProject.Models;
using DvlaProject.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = ConfigurationHelper.GetHerokuConnectionString();

if (string.IsNullOrEmpty(connectionString)) {
    connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
}

// builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ClientContext>(options =>
    options.UseNpgsql(connectionString)
);

builder.Services.AddControllers();
builder.Services.AddDbContext<ClientContext>(opt =>
    opt.UseInMemoryDatabase("ClientInformation"));
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "DvlaProject", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DvlaProject v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();