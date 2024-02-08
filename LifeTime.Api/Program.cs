using LifeTime.Api.Components;
using LifeTime.Api.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Services
builder.Services.AddTransient<ILifeTimeServiceTransient, LifeTimeService>();
builder.Services.AddScoped<ILifeTimeServiceScoped, LifeTimeService>();
builder.Services.AddSingleton<ILifeTimeServiceSingleton, LifeTimeService>();

builder.Services.AddScoped<IIntermediarioService, IntermediarioService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
