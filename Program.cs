using BossAzAPI.BLL.Abstract;
using BossAzAPI.BLL.Concrete;
using BossAzAPI.BLL.Mappers;
using BossAzAPI.DAL;
using BossAzAPI.DAL.Abstract;
using BossAzAPI.DAL.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSQL"));
});
builder.Services.AddAutoMapper(typeof(MapperProfiles));

builder.Services.AddScoped<IJobRepository, JobRepository>();
builder.Services.AddScoped<IJobService, JobService>();

builder.Services.AddScoped<IResumeRepository, ResumeRepository>();
builder.Services.AddScoped<IResumeService, ResumeService>();

builder.Services.AddScoped<IEnumValueRepository, EnumValueRepository>();
builder.Services.AddScoped<IEnumValueService, EnumValueService>();

builder.Services.AddScoped<IPhoneRepository, PhoneRepository>();
builder.Services.AddScoped<IPhoneService, PhoneService>();


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
