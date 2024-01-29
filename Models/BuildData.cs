using System.ComponentModel.DataAnnotations;

namespace AKSClusterBuilderWebClient.Models;

public class BuildData
{
    public string selectedClusterRegion { get; set; }

    [Required(ErrorMessage = "Name prefix is required")]
    [MinLength(5, ErrorMessage = "Name prefix must be at least 5 characters long")]
    [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "No special characters allowed")]
    public string namePrefix { get; set; }
    public string selectedGrafanaRegion { get; set; }
    public string selectedAMWRegion { get; set; }
    public string egressType { get; set; }
    public string ingressType { get; set; }
    public string linuxOS { get; set; }
    public string networkPluginMode { get; set; }

}
