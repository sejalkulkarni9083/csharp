namespace InsuranceAPI.Managers;

using System.Drawing;
using System.Runtime.InteropServices.Marshalling;
using System.Text.Json;
using InsuranceAPI.Delegate;
using InsuranceAPI.Models;
using Microsoft.AspNetCore.Routing.Constraints;

public class InsurancePolicyManager
{
    //evnets
    public event Insurance policyPurchased;
    public event Insurance claimRegistered;
    public event Insurance premiumPaid;
    public event Insurance policyRenewed;

    public void  PurchasePolicy(Policy policy)
    {
        Console.WriteLine(policy.CustomerName + "" + policy.PolicyType);
        List<Policy> policies=GetAllPolicies();
        policies.Add(policy);
        this.SaveAllPolicies(policies);
        policyPurchased.Invoke(); 
       

    }
    public void RegisterClaim()
    {
        claimRegistered.Invoke();
        Console.WriteLine("Claim Registered Successfully");
    }

    public void  RenewPolicy()
    {
        policyRenewed.Invoke();
        Console.WriteLine(" Existing Policy renewed Successfully");
    }
      public void  PayPremium(Premium premium)
    {
         List<Premium> premiums =GetAllPremimum();
        premiums.Add(premium);
        this.SaveAllPremium(premiums);
        policyPurchased.Invoke(); 
        premiumPaid.Invoke();
        Console.WriteLine("Premium is paid Successfully");
         }

    public List<Policy> GetAllPolicies()
    {
        string fileName=@"D:\Ravi\TAP\TAP\TFLdotNET\Solutions\InsuranceRestAPIApp\Data\policies.json";
        string jsonString=File.ReadAllText(fileName);
        var options = new JsonSerializerOptions{ PropertyNameCaseInsensitive = true};
        List<Policy>? policies =JsonSerializer.Deserialize<List<Policy>>(jsonString,options);
        return   policies;
    }


    public bool  SaveAllPolicies(List<Policy> policies)
    {
        bool status=false;
        string fileName=@"D:\Ravi\TAP\TAP\TFLdotNET\Solutions\InsuranceRestAPIApp\Data\policies.json";
        var options = new JsonSerializerOptions{ PropertyNameCaseInsensitive = true};
        string jsonString=JsonSerializer.Serialize(policies,options);
        File.WriteAllText(fileName, jsonString);
        status=true;
        return status;
    }
}