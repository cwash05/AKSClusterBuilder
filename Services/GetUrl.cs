using AKSClusterBuilderWebClient.Models;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace AKSClusterBuilderWebClient.Services;

public class GetUrl
{
    private readonly HttpClient Http;
    private string urlContent;
    public async Task<string> GetBackendUrl(string rowKey)
    {
        ResponseModel responseObj;
                
        try
        {
            // Adjust the URL path to match your Azure Function's route
            HttpResponseMessage response = await Http.GetAsync($"api/getbackendurl?rowKey={rowKey}");
            if (response.IsSuccessStatusCode)
            {
                // Assuming the function returns the business phone as a plain string
                urlContent = await response.Content.ReadAsStringAsync();
                responseObj = JsonConvert.DeserializeObject<ResponseModel>(urlContent);
                return responseObj.Url;
            }
            else
            {
                
                return "Url not found";
            }
        }
        catch (Exception ex)
        {
            return $"Error: {ex.Message}";
        }
        
    }
}
