using AKSClusterBuilderWebClient.Models;

namespace AKSClusterBuilderWebClient.Services;


public class BuildEnvironment 
{
    //private readonly GetCredentials _getCredentials;


    public string BuildCluster(BuildData buildData)
    {
        string clusterName = buildData.namePrefix + "Cluster";
        string clusterRegion = buildData.selectedClusterRegion;
        string clusterResourceGroup = buildData.namePrefix + "ClusterResourceGroup";
        string clusterVNet = buildData.namePrefix + "ClusterVNet";
       
        Console.WriteLine("Creating cluster " + clusterName + " in region " + clusterRegion + " with resource group " + clusterResourceGroup + " and VNet " + clusterVNet);
        //Console.WriteLine($"Subscription Id: {_getCredentials.subscriptionId}");

        return clusterName;
    }

}
