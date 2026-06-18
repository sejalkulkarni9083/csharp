
namespace InsuranceAPI.Models;


public class Policy
{
    public string PolicyNumber { get; set; }   //auto property
    public string CustomerName { get; set; }
    public string PolicyType { get; set; }
    public decimal PolicyAmount { get; set; }
    public bool IsRenewed { get; set; } = false;
}