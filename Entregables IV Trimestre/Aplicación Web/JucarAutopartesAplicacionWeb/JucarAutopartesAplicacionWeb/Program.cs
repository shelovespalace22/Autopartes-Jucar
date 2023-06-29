using JucarAutopartesAplicacionWeb.Data;
using JucarAutopartesAplicacionWeb.Services.Email;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration["DefaultConnection:ConnectionStrings"];

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

//Servicio de Identity

builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

//builder.Services.AddTransient<IEmailSender, EmailSender>();

//Url de retorno 

builder.Services.ConfigureApplicationCookie(options =>
{
	options.LoginPath = new PathString("/Cuentas/Acceso");
	options.AccessDeniedPath = new PathString("/Cuentas/Bloqueado");
});

//Configuraciones contraseña más segura

builder.Services.Configure<IdentityOptions>(options =>
{
	options.Password.RequiredLength = 8; //La contraseña debe tener minimo 8 caracteres
	options.Password.RequireLowercase = true; //Requiere letras minusculas
	options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1); //Tiempo de bloqueo de un minuto, si no ingresa bien las credenciales
	options.Lockout.MaxFailedAccessAttempts = 3; //Intentos máximos para fallar la contraseña 
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
