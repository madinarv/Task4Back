using MentorTask.DataAccessLayer;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer("Server=ACER\\SQLEXPRESS;DataBase=Mentortask;Trusted_Connection=true;");
});
var app = builder.Build();

app.MapControllerRoute("default", "{controller=Trainers}/{action=Index}/{Id?}");

app.Run();
