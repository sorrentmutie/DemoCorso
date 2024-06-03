using DemoCorso.Business;
using DemoCorso.Core;
using DemoCorso.Core.Interfaces;
using DemoCorso.Data;
using DemoCorso.UI.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

//builder.Services.AddSingleton<IPeopleData, ManagePeople>();
builder.Services.AddScoped<IPeopleData, ManagePeople>();
builder.Services.AddScoped<ISalute, ManageStaticSalute>();


//builder.Services.AddSingleton<IPeopleData, ManagePeopleOnSqlServer>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(DemoCorso.UI.Client._Imports).Assembly);

app.Run();
