using DemoCorso.Business;
using DemoCorso.Core;
using DemoCorso.UI.Components;

var builder = WebApplication.CreateBuilder(args);


var managePeople = new ManagePeople();
managePeople.AddPerson(new Person
{
    Id = 1, FirstName = "Mario", LastName = "Rossi"
});
var people = managePeople.GetPeople();


// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

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
