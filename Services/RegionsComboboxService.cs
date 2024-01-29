using AKSClusterBuilderWebClient.Models;

namespace AKSClusterBuilderWebClient.Services;

public class RegionsComboboxService
{
    public static List<RegionsComboOptions> ClusterRegionOptions()
    {
        List<RegionsComboOptions> clusterRegions = new List<RegionsComboOptions> {
            new RegionsComboOptions { Id = "australiaeast", Text = "Australia East" },
            new RegionsComboOptions { Id = "brazilsouth", Text = "Brazil South" },
            new RegionsComboOptions { Id = "canadacentral", Text = "Canada Central" },
            new RegionsComboOptions { Id = "eastasia", Text = "East Asia" },
            new RegionsComboOptions { Id = "eastus", Text = "East US" },
            new RegionsComboOptions { Id = "eastus2", Text = "East US 2" },
            new RegionsComboOptions { Id = "francecentral", Text = "France Central" },
            new RegionsComboOptions { Id = "germanywestcentral", Text = "Germany West Central" },
            new RegionsComboOptions { Id = "centralindia", Text = "Central India" },
            new RegionsComboOptions { Id = "centralus", Text = "Central US" },
            new RegionsComboOptions { Id = "chinanorth3", Text = "China North 3" },
            new RegionsComboOptions { Id = "northeurope", Text = "North Europe" },
            new RegionsComboOptions { Id = "norwayeast", Text = "Norway East" },
            new RegionsComboOptions { Id = "japaneast", Text = "Japan East" },
            new RegionsComboOptions { Id = "koreacentral", Text = "Korea Central" },
            new RegionsComboOptions { Id = "qatarcentral", Text = "Qatar Central" },
            new RegionsComboOptions { Id = "southeastasia", Text = "Southeast Asia" },
            new RegionsComboOptions { Id = "southcentralus", Text = "South Central US" },
            new RegionsComboOptions { Id = "southafricanorth", Text = "South Africa North" },
            new RegionsComboOptions { Id = "swedencentral", Text = "Sweden Central" },
            new RegionsComboOptions { Id = "switzerlandnorth", Text = "Switzerland North" },
            new RegionsComboOptions { Id = "uaenorth", Text = "UAE North" },
            new RegionsComboOptions { Id = "uksouth", Text = "UK South" },
            new RegionsComboOptions { Id = "usgovvirginia", Text = "US Gov Virginia" },
            new RegionsComboOptions { Id = "westeurope", Text = "West Europe" },
            new RegionsComboOptions { Id = "westus2", Text = "West US 2" },
            new RegionsComboOptions { Id = "westus3", Text = "West US 3" },
            };

        return clusterRegions;
    }

    public static List<RegionsComboOptions> GrafanaRegionOptions()
    {
        List<RegionsComboOptions> grafanaRegions = new List<RegionsComboOptions>
        {
            new RegionsComboOptions { Id = "australiaeast", Text = "Australia East" },
            new RegionsComboOptions { Id = "canadacentral", Text = "Canada Central" },
            new RegionsComboOptions { Id = "eastasia", Text = "East Asia" },
            new RegionsComboOptions { Id = "eastus", Text = "East US" },
            new RegionsComboOptions { Id = "eastus2", Text = "East US 2" },
            new RegionsComboOptions { Id = "centralus", Text = "Central US" },
            new RegionsComboOptions { Id = "northeurope", Text = "North Europe" },
            new RegionsComboOptions { Id = "southcentralus", Text = "South Central US" },
            new RegionsComboOptions { Id = "swedencentral", Text = "Sweden Central" },
            new RegionsComboOptions { Id = "uksouth", Text = "UK South" },
            new RegionsComboOptions { Id = "westcentralus", Text = "West Central US" },
            new RegionsComboOptions { Id = "westeurope", Text = "West Europe" },
            new RegionsComboOptions { Id = "westus3", Text = "West US 3" }
        };
        return grafanaRegions;

    }

    public static List<RegionsComboOptions> AMWRegionOptions()
    {
        List<RegionsComboOptions> amwRegions = new List<RegionsComboOptions>
        {

            new RegionsComboOptions { Id = "eastus", Text = "East US" },
            new RegionsComboOptions { Id = "CentralIndia", Text = "Central India" },
            new RegionsComboOptions { Id = "centralus", Text = "Central US" },
            new RegionsComboOptions { Id = "northeurope", Text = "North Europe" },
            new RegionsComboOptions { Id = "southcentralus", Text = "South Central US" },
            new RegionsComboOptions { Id = "southeastasia", Text = "Southeast Asia" },
            new RegionsComboOptions { Id = "uksouth", Text = "UK South" },
            new RegionsComboOptions { Id = "westeurope", Text = "West Europe" },
            new RegionsComboOptions { Id = "westus", Text = "West US" },
            new RegionsComboOptions { Id = "westus2", Text = "West US 2"}
        };

        return amwRegions;
    }
}
