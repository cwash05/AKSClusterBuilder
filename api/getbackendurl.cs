
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Azure.Identity;
using Microsoft.Graph;
using Azure;
using System.Text.RegularExpressions;
using Azure.Data.Tables;
using System.Threading.Tasks;
using System;
using Microsoft.Extensions.Logging;
using Microsoft.Graph.Models.Security;
using System.Linq;



namespace api
{
    public static class getbackendurl
    {
        [FunctionName("getbackendurl")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req, ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string tableName = "userbackend";
            string partitionKey = await GetBusinessPhoneAsync();
            string rowKey = req.Query["rowKey"];

            if (string.IsNullOrEmpty(partitionKey) || string.IsNullOrEmpty(rowKey))
            {
                return new BadRequestObjectResult("Please provide both partitionKey and rowKey in the query string.");
            }

            var serviceClient = new TableServiceClient(new Uri("https://akscbsa.table.core.windows.net"), new DefaultAzureCredential());
            var tableClient = serviceClient.GetTableClient(tableName);


            try
            {
                var response = await tableClient.GetEntityAsync<TableEntity>(partitionKey, rowKey);
                if (response != null)
                {
                    var url = response.Value.GetString("Url");
                    return new OkObjectResult(url);
                }
            }
            catch (RequestFailedException ex) when (ex.Status == 404)
            {
                return new OkObjectResult("Entity not found. Sending message...");
                // Add message sending logic here
            }

            return new OkObjectResult("An unexpected error occurred.");
        }

        private static async Task<string> GetBusinessPhoneAsync()
        {
            string[] scopes = new[] { "https://graph.microsoft.com/.default" };
            ChainedTokenCredential tokenCredential = new ChainedTokenCredential(new ManagedIdentityCredential(), new AzureCliCredential());
            GraphServiceClient graphClient = new GraphServiceClient(tokenCredential, scopes);

            try
            {
                
                var user = await graphClient.Me.GetAsync();
                var businessPhone = user.BusinessPhones.FirstOrDefault();
                //Console.WriteLine($"Business phone: {businessPhone}");

                string pattern = @"\((\d{3})\)";

                // Use Regex to find matches
                Match match = Regex.Match(businessPhone, pattern);

                if (match.Success)
                {
                    string areaCode = match.Groups[1].Value;
                    Console.WriteLine($"Area Code: {areaCode}");
                    return areaCode;
                }
                else
                {
                    Console.WriteLine("Area code not found.");
                }

                return businessPhone ?? "No business phone available";
            }
            catch (Exception ex)
            {
                // Handle exceptions
                return $"Error: {ex.Message}";
            }
        }
    }
}
