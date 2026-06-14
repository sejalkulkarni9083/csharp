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
        string fileName=@"/home/tfl/Downloads/InsuranceRestAPIApp (2)/InsuranceRestAPIApp/InsuranceRestAPIApp/Data/licies.json";
        string jsonString=File.ReadAllText(fileName);
        var options = new JsonSerializerOptions{ PropertyNameCaseInsensitive = true};
        List<Policy>? policies =JsonSerializer.Deserialize<List<Policy>>(jsonString,options);
        return   policies;
    }


    public bool SaveAllPolicies(List<Policy> policies)
    {
        bool status = false;
        string fileName = @"/home/tfl/Downloads/InsuranceRestAPIApp (2)/InsuranceRestAPIApp/InsuranceRestAPIApp/Data/payPremuim.json";
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        string jsonString = JsonSerializer.Serialize(policies, options);
        File.WriteAllText(fileName, jsonString);
        status = true;
        return status;
    }

      public List<Premium> GetAllPremimum()
    {
        string fileName=@"/home/tfl/Downloads/InsuranceRestAPIApp (2)/InsuranceRestAPIApp/InsuranceRestAPIApp/Data/payPremuim.json";
        string jsonString=File.ReadAllText(fileName);
        var options = new JsonSerializerOptions{ PropertyNameCaseInsensitive = true};
        List<Premium>? premiums =JsonSerializer.Deserialize<List<Premium>>(jsonString,options);
        return   premiums;
    }


    public bool  SaveAllPremium(List<Premium> premiums)
    {
        bool status=false;
        string fileName=@"/home/tfl/Downloads/InsuranceRestAPIApp (2)/InsuranceRestAPIApp/InsuranceRestAPIApp/Data/payPremuim.json";
        var options = new JsonSerializerOptions{ PropertyNameCaseInsensitive = true};
        string jsonString=JsonSerializer.Serialize(premiums,options);
        File.WriteAllText(fileName, jsonString);
        status=true;
        return status;
    }
}