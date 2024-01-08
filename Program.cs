using Microsoft.EntityFrameworkCore;
using StudentsManagement.Helpers.DbHelpers;
using StudentsManagement.BLL.Repository.Interfaces;
using StudentsManagement.BLL.Repository.Implementation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<StudentsManagementContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection"));
});

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddTransient<IStudentRepository, StudentRepository>();

builder.Services.AddDevExpressBlazor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();