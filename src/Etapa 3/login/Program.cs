using projeto_adotapet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;

var builder = WebApplication.CreateBuilder(args);

// Adicionando os servi�os ao container
builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

// Configura��o do banco de dados (SQL Server)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configura��o de Autentica��o por Cookie
builder.Services.AddAuthentication("CookieAuth")
    .AddCookie("CookieAuth", options =>
    {
        options.LoginPath = "/Login/Index"; // P�gina de login
        options.LogoutPath = "/Login/Logout"; // P�gina de logout
        options.ExpireTimeSpan = TimeSpan.FromMinutes(60); // Tempo de expira��o do cookie
        options.SlidingExpiration = true; // Expira��o deslizante do cookie
    });

// Configura��o de Sess�es
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Tempo de expira��o da sess�o
    options.Cookie.HttpOnly = true;  // Seguran�a adicional para o cookie de sess�o
    options.Cookie.IsEssential = true; // O cookie � essencial para a aplica��o funcionar
});

var app = builder.Build();

// Configura��o do pipeline de requisi��es HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // HSTS (HTTP Strict Transport Security)
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Ordem dos middlewares
app.UseSession(); // Coloque UseSession antes de UseAuthentication
app.UseAuthentication(); // Autentica��o
app.UseAuthorization(); // Autoriza��o

// Configura��o das rotas
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}"); // Alterado para LoginController

app.Run();
