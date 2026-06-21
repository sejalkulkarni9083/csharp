namespace Delegate;

class InsurancePolicyManager
{
    public event Insurance? PolicyPurchased;
    public event Insurance? PremiumPaid;
    public event Insurance? ClaimRegistered;
    public event Insurance? PolicyRenewed;



    public void PurchasePolicy()
    {
        Console.WriteLine("Policy Purchased Successfully.");
        PolicyPurchased?.Invoke();
    }

    public void PayPremium()
    {
        Console.WriteLine("Premium Received.");
        PremiumPaid?.Invoke();
    }

    public void RegisterClaim()
    {
        Console.WriteLine("Claim Registered Successfully.");
        ClaimRegistered?.Invoke();
    }

    public void RenewPolicy()
    {
        Console.WriteLine("Policy Renewed Successfully.");
        PolicyRenewed?.Invoke();
    }


}