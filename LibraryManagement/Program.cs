using LibraryManagement.Database;
using LibraryManagement.Interfaces;
using LibraryManagement.Services;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<IMember, MemberService>();


//Db config
builder.Services.AddDbContext<LibraryDbContext>(option =>
{
    var ConnectionStrings = builder.Configuration.GetConnectionString("local");
    option.UseSqlServer(ConnectionStrings);
    //option.UseMySql(ConnectionStrings);
});

//cycle
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
});


// Learn more about configuring Swagger
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

app.UseAuthorization();

app.MapControllers();

app.Run();
