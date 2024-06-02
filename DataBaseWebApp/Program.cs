using DataBaseWebApp.Components;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddLocalization(); //For Localization
builder.Services.AddControllers(); //For CultureController

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

string[] supportedCultures = ["en-US", "pt-BR"];
var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture(supportedCultures[0])
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);
app.UseRequestLocalization(localizationOptions);

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

app.MapControllers(); //For CultureController

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
