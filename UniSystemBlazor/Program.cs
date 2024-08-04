using UniSystemBlazor.Components;
using UniSystem.Plugins;
using Microsoft.EntityFrameworkCore;
using UniSystem.UseCases.Interfaces;
using UniSystem.UseCases.TablesUseCases;
using UniSystem.Core.PluginInterfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer("Server=localhost;Database=University;TrustServerCertificate=true;Trusted_Connection=true;"));

builder.Services.AddScoped<IGetFacultiesUseCase, GetFacultiesUseCase>();
builder.Services.AddScoped<IFacultyRepository, FacultyRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
