
//using Azure.ResourceManager;
//using Azure.ResourceManager.Resources;
//using Azure.Identity;
//using Microsoft.AspNetCore.Http.Abstractions;

namespace AKSClusterBuilderWebClient.Services;

public class GetCredentials
{
    public string subscriptionId { get; private set; }
    //public ArmClient? armClient { get; private set; }

    //public GetCredentials()
    //{
    //    DefaultAzureCredential credential = new DefaultAzureCredential();
    //    subscriptionId = GetSubID(credential);
    //    armClient = new ArmClient(credential, subscriptionId);
    //}

    //private string GetSubID(DefaultAzureCredential credential)
    //{

    //    ArmClient armCred = new ArmClient(credential);
    //    SubscriptionResource subscription = armCred.GetDefaultSubscription().Get();
    //    return subscription.Data.Id;
    //}

}
