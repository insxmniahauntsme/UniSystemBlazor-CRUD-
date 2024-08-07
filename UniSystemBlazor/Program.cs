using UniSystemBlazor.Components;
using UniSystem.Plugins;
using Microsoft.EntityFrameworkCore;
using UniSystem.UseCases.Interfaces;
using UniSystem.UseCases.GetUseCases;
using UniSystem.Core.PluginInterfaces;
using UniSystem.Plugins.Repositories;
using UniSystem.UseCases.TableActionsUseCases;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer("Server=localhost;Database=University;TrustServerCertificate=true;Trusted_Connection=true;"));

builder.Services.AddTransient<IGetFacultiesUseCase, GetFacultiesUseCase>();
builder.Services.AddTransient<IFacultyRepository, FacultyRepository>();

builder.Services.AddTransient<IGetGroupsUseCase, GetGroupsUseCase>();
builder.Services.AddTransient<IGroupRepository, GroupRepository>();

builder.Services.AddTransient<IGetStudentsUseCase, GetStudentsUseCase>();
builder.Services.AddTransient<IStudentRepository, StudentRepository>();

builder.Services.AddTransient<IAddFacultyUseCase, AddFacultyUseCase>();
builder.Services.AddTransient<IDeleteFacultyUseCase, DeleteFacultyUseCase>();
builder.Services.AddTransient<IAddGroupUseCase, AddGroupUseCase>();
builder.Services.AddTransient<IDeleteGroupUseCase, DeleteGroupUseCase>();
builder.Services.AddTransient<IAddStudentUseCase, AddStudentUseCase>();
builder.Services.AddTransient<IDeleteStudentUseCase, DeleteStudentUseCase>();




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
