using MutirithiaYou_MeBoutique.Components;
using MutirithiaYou_MeBoutique.Services;

var builder = WebApplication.CreateBuilder(args);

// 1. Register our Core Services for the self-service portal
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Register the custom inventory service we created earlier
builder.Services.AddSingleton<InventoryService>();

var app = builder.Build();

// 2. Configure HTTP Pipeline Routing
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAntiforgery();

// Allows the website to read catalog photos from your wwwroot/images folder
app.UseStaticFiles();

// 3. Map the entry component structure
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
