
namespace InsuranceAPI.Models;


public class Policy
{
    public string PolicyNumber { get; set; }
    public string CustomerName { get; set; }
    public string PolicyType { get; set; }
    public decimal PremiumAmount { get; set; }
}