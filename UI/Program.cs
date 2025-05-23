using Microsoft.EntityFrameworkCore;
using UI.Data;
using UI.Dtos.Lecture;
using UI.Interfaces;
using UI.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IUniversityRepo, UniversityRepo>();
builder.Services.AddScoped<ICourseRepo, CourseRepo>();
builder.Services.AddScoped<IModuleRepo, ModuleRepo>();
builder.Services.AddScoped<ILectureRepo, LectureRepo>();

builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("Database"));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers().AddJsonOptions(options =>
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();