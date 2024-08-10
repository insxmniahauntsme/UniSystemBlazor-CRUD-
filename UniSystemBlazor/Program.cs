using UniSystemBlazor.Components;
using UniSystem.Plugins;
using Microsoft.EntityFrameworkCore;
using UniSystem.UseCases.Interfaces;
using UniSystem.UseCases.GetUseCases;
using UniSystem.Core.PluginInterfaces;
using UniSystem.Plugins.Repositories;
using UniSystem.UseCases.TableActionsUseCases;
using UniSystemBlazor.Components.Charts;
using Radzen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer("Server=localhost;Database=University;TrustServerCertificate=true;Trusted_Connection=true;"));

builder.Services.AddRadzenComponents();

builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<GroupsChart>();

builder.Services.AddTransient<IGetFacultiesUseCase, GetFacultiesUseCase>();
builder.Services.AddTransient<IGetFacultyByIdUseCase, GetFacultyByIdUseCase>();
builder.Services.AddTransient<IAddFacultyUseCase, AddFacultyUseCase>();
builder.Services.AddTransient<IDeleteFacultyUseCase, DeleteFacultyUseCase>();
builder.Services.AddTransient<IEditFacultyUseCase, EditFacultyUseCase>();
builder.Services.AddTransient<IFacultyRepository, FacultyRepository>();

builder.Services.AddTransient<IGetGroupsUseCase, GetGroupsUseCase>();
builder.Services.AddTransient<IGetGroupByIdUseCase, GetGroupByIdUseCase>();
builder.Services.AddTransient<IDeleteGroupUseCase, DeleteGroupUseCase>();
builder.Services.AddTransient<IEditGroupUseCase, EditGroupUseCase>();
builder.Services.AddTransient<IAddGroupUseCase, AddGroupUseCase>();
builder.Services.AddTransient<IGroupRepository, GroupRepository>();

builder.Services.AddTransient<IGetStudentsUseCase, GetStudentsUseCase>();
builder.Services.AddTransient<IGetStudentByNameUseCase, GetStudentByNameUseCase>();
builder.Services.AddTransient<IAddStudentUseCase, AddStudentUseCase>();
builder.Services.AddTransient<IDeleteStudentUseCase, DeleteStudentUseCase>();
builder.Services.AddTransient<IEditStudentUseCase, EditStudentUseCase>();
builder.Services.AddTransient<IStudentRepository, StudentRepository>();


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
