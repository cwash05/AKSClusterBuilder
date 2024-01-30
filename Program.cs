using AKSClusterBuilderWebClient;
using AKSClusterBuilderWebClient.Models;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.FluentUI.AspNetCore.Components;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");




builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddFluentUIComponents();
builder.Services.AddSingleton<BuildData>();


builder.Services.AddMsalAuthentication(options =>
{
    builder.Configuration.Bind("AzureAd", options.ProviderOptions.Authentication);

    var defaultScope = builder.Configuration["AzureAd:ClientIdScope"];
    if (!string.IsNullOrWhiteSpace(defaultScope))
    {
        options.ProviderOptions.DefaultAccessTokenScopes.Add(defaultScope);
    }

    var additionalScopes = builder.Configuration.GetSection("AzureAd:AdditionalScopesToConsent").Get<string[]>();
    if (additionalScopes != null)
    {
        foreach (var scope in additionalScopes)
        {
            options.ProviderOptions.AdditionalScopesToConsent.Add(scope);
        }
    }
    options.ProviderOptions.LoginMode = "redirect";
    //options.UserOptions.NameClaim = "name";
    //options.UserOptions.RoleClaim = "role";
    //options.UserOptions.ScopeClaim = "scope";



    //builder.Configuration.Bind("AzureAd", options.ProviderOptions.Authentication);
    //options.ProviderOptions.DefaultAccessTokenScopes.Add("https://management.azure.com/.default");
    //options.ProviderOptions.DefaultAccessTokenScopes.Add("79c344c5-0ef6-483e-ba43-c45d99657e5b/.default");
    //options.ProviderOptions.AdditionalScopesToConsent.Add("https://management.azure.com/.default");
    //options.ProviderOptions.DefaultAccessTokenScopes.Add(builder.Configuration["AppApiScope"]); // Add your API scope

});

builder.Services.AddHttpClient();


await builder.Build().RunAsync();
