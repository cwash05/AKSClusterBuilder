using AKSClusterBuilderWebClient;
using AKSClusterBuilderWebClient.Models;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
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
    builder.Configuration.Bind("AzureAd", options.ProviderOptions.Authentication);
    //options.ProviderOptions.DefaultAccessTokenScopes.Add("https://management.azure.com/.default");
    options.ProviderOptions.DefaultAccessTokenScopes.Add("79c344c5-0ef6-483e-ba43-c45d99657e5b/.default");
    options.ProviderOptions.AdditionalScopesToConsent.Add("https://management.azure.com/.default");
  //options.ProviderOptions.DefaultAccessTokenScopes.Add(builder.Configuration["AppApiScope"]); // Add your API scope
    options.ProviderOptions.LoginMode = "redirect";
});

builder.Services.AddHttpClient();

// Add an HttpClient for connecting to your API
//builder.Services.AddHttpClient("API", client =>
//{
// Replace with your API base address
//client.BaseAddress = new Uri("https://your-api-base-address/");
//})
//.AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Supply HttpClient instances that include access tokens when making requests to the server project
//builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("API"));


await builder.Build().RunAsync();
