namespace AKSClusterBuilderWebClient.Models;



public record Regions(string Name, string Code)
{
    public static IEnumerable<Regions> ClusterRegions
    {
        get
        {
            return new Regions[]
            {
                new Regions("AustraliaEast", "australiaeast"),
                new Regions("BrazilSouth", "brazilsouth"),
                new Regions("CanadaCentral", "canadacentral"),
                new Regions("EastAsia", "eastasia"),
                new Regions("EastUS", "eastus"),
                new Regions("EastUS2", "eastus2"),
                new Regions("FranceCentral", "francecentral"),
                new Regions("GermanyWestCentral", "germanywestcentral"),
                new Regions("CentralIndia", "centralindia"),
                new Regions("CentralUS", "centralus"),
                new Regions("ChinaNorth3", "chinanorth3"),
                new Regions("NorthEurope", "northeurope"),
                new Regions("NorwayEast", "norwayeast"),
                new Regions("JapanEast", "japaneast"),
                new Regions("KoreaCentral", "koreacentral"),
                new Regions("QatarCentral", "qatarcentral"),
                new Regions("SoutheastAsia", "southeastasia"),
                new Regions("SouthCentralUS", "southcentralus"),
                new Regions("SouthAfricaNorth", "southafricanorth"),
                new Regions("SwedenCentral", "swedencentral"),
                new Regions("SwitzerlandNorth", "switzerlandnorth"),
                new Regions("UAENorth", "uaenorth"),
                new Regions("UKSouth", "uksouth"),
                new Regions("USGovVirginia", "usgovvirginia"),
                new Regions("WestEurope", "westeurope"),
                new Regions("WestUS2", "westus2"),
                new Regions("WestUS3", "westus3"),
            };
        }
    }

    public static IEnumerable<Regions> GrafanaRegions
    {
        get
        {
            return new Regions[]
            {
                new Regions("AustraliaEast", "australiaeast"),
                new Regions("CanadaCentral", "canadacentral"),
                new Regions("EastAsia", "eastasia"),
                new Regions("EastUS", "eastus"),
                new Regions("EastUS2", "eastus2"),
                new Regions("CentralUS", "centralus"),
                new Regions("NorthEurope", "northeurope"),
                new Regions("SouthCentralUS", "southcentralus"),
                new Regions("SwedenCentral", "swedencentral"),
                new Regions("UKSouth", "uksouth"),
                new Regions("WestCentralUS", "westcentralus"),
                new Regions("WestEurope", "westeurope"),
                new Regions("WestUS3", "westus3")
            };
        }
    }

    public static IEnumerable<Regions> AMWRegions
    {
        get
        {
            return new Regions[]
            {
                new Regions("EastUS", "eaastus"),
                new Regions("CentralIndia", "centralIndia"),
                new Regions("CentralUS", "centralus"),
                new Regions("NorthEurope", "northeurope"),
                new Regions("SouthCentralUS", "southcentralus"),
                new Regions("SoutheastAsia", "southeastasia"),
                new Regions("UKSouth", "uksouth"),
                new Regions("WestEurope", "westeurope"),
                new Regions("WestUS", "westus"),
                new Regions("WestUS2", "westus2")
            };
        }
    }
} 
