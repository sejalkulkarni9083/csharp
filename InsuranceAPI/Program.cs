using InsuranceAPI.Managers;
using InsuranceAPI.Models;
using InsuranceAPI.Delegate;
using InsuranceAPI.Services;
using InsuranceAPI.Departments;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();

var app = builder.Build();
app.MapGet("/api/policies", () =>
{
  
  
        InsurancePolicyManager insruanceManager=new InsurancePolicyManager();
        AccountsDepartment accounts=new AccountsDepartment();
        SalesDepartment sales=new SalesDepartment();
        ClaimDepartment claims=new ClaimDepartment();
        RenewalDepartment renewals=new RenewalDepartment();

        EmailNotificationService emailSvc=new EmailNotificationService();
               
        insruanceManager.policyPurchased+=sales.OnPolicyPurchased;
        insruanceManager.policyPurchased+=emailSvc.SendMessage;

        insruanceManager.premiumPaid+=accounts.RecordPayment;
        insruanceManager.claimRegistered+=claims.OnClaimRegistered;
        insruanceManager.premiumPaid+=renewals.OnPolicyRenewed;


        return insruanceManager.GetAllPolicies();
});
app.MapPost("/api/policies/purchase", (Policy policy) =>
{
  
        InsurancePolicyManager insruanceManager=new InsurancePolicyManager();
        AccountsDepartment accounts=new AccountsDepartment();
        SalesDepartment sales=new SalesDepartment();
        ClaimDepartment claims=new ClaimDepartment();
        RenewalDepartment renewals=new RenewalDepartment();

        EmailNotificationService emailSvc=new EmailNotificationService();
               
        insruanceManager.policyPurchased+=sales.OnPolicyPurchased;
        insruanceManager.policyPurchased+=emailSvc.SendMessage;

        insruanceManager.premiumPaid+=accounts.RecordPayment;
        insruanceManager.claimRegistered+=claims.OnClaimRegistered;
        insruanceManager.premiumPaid+=renewals.OnPolicyRenewed;

  
        insruanceManager.PurchasePolicy(policy);
  return " Policy Purchased Successfully";
});

app.MapPost("/api/policies/paypremium", (Premium premium) =>
{
  
        InsurancePolicyManager insruanceManager=new InsurancePolicyManager();
        AccountsDepartment accounts=new AccountsDepartment();
        SalesDepartment sales=new SalesDepartment();
        ClaimDepartment claims=new ClaimDepartment();
        RenewalDepartment renewals=new RenewalDepartment();

        EmailNotificationService emailSvc=new EmailNotificationService();
               
        insruanceManager.policyPurchased+=sales.OnPolicyPurchased;
        insruanceManager.policyPurchased+=emailSvc.SendMessage;

        insruanceManager.premiumPaid+=accounts.RecordPayment;
        insruanceManager.claimRegistered+=claims.OnClaimRegistered;
        insruanceManager.premiumPaid += renewals.OnPolicyRenewed;
        
        insruanceManager.PayPremium(premium);
return " Preimum paid succefully";

  
});
app.MapPost("/api/policies/registerclaim", () =>
{
  
        InsurancePolicyManager insruanceManager=new InsurancePolicyManager();
        AccountsDepartment accounts=new AccountsDepartment();
        SalesDepartment sales=new SalesDepartment();
        ClaimDepartment claims=new ClaimDepartment();
        RenewalDepartment renewals=new RenewalDepartment();

        EmailNotificationService emailSvc=new EmailNotificationService();
               
        insruanceManager.policyPurchased+=sales.OnPolicyPurchased;
        insruanceManager.policyPurchased+=emailSvc.SendMessage;

        insruanceManager.premiumPaid+=accounts.RecordPayment;
        insruanceManager.claimRegistered+=claims.OnClaimRegistered;
        insruanceManager.premiumPaid+=renewals.OnPolicyRenewed;


});
app.MapPost("api/policies/renew", () =>
{
  
        InsurancePolicyManager insruanceManager=new InsurancePolicyManager();
        AccountsDepartment accounts=new AccountsDepartment();
        SalesDepartment sales=new SalesDepartment();
        ClaimDepartment claims=new ClaimDepartment();
        RenewalDepartment renewals=new RenewalDepartment();

        EmailNotificationService emailSvc=new EmailNotificationService();
               
        insruanceManager.policyPurchased+=sales.OnPolicyPurchased;
        insruanceManager.policyPurchased+=emailSvc.SendMessage;

        insruanceManager.premiumPaid+=accounts.RecordPayment;
        insruanceManager.claimRegistered+=claims.OnClaimRegistered;
        insruanceManager.premiumPaid+=renewals.OnPolicyRenewed;


});
 

app.Run();
