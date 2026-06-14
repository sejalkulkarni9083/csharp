using Delegate;
using Departments;
using Notification;

public class Program
{

    public static void Main(string[] args)
    {
        bool exit = false;
        InsurancePolicyManager policyManager = new InsurancePolicyManager();
        SalesDepartment salesDepartment = new SalesDepartment();
        AccountsDepartment accountsDepartment = new AccountsDepartment();
        ClaimDepartment claimDepartment = new ClaimDepartment();
        RenewalDepartment renewalDepartment = new RenewalDepartment();
        NotificationService notificationService = new NotificationService();

        policyManager.PolicyPurchased += salesDepartment.OnPolicyPurchased;
policyManager.PolicyPurchased += notificationService.CustomerNotificationService;

policyManager.PremiumPaid += accountsDepartment.OnPremiumPaid;
policyManager.PremiumPaid += notificationService.SMSNotificationService;

policyManager.ClaimRegistered += claimDepartment.OnClaimRegistered;
policyManager.ClaimRegistered += notificationService.SurveyorTeam;

policyManager.PolicyRenewed += renewalDepartment.OnPolicyRenewed;
policyManager.PolicyRenewed += notificationService.EmailNotificationService;

        while (!exit)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Insurance Management System");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Purchase Policy");
            Console.WriteLine("2. Pay Premium");
            Console.WriteLine("3. Register Claim");
            Console.WriteLine("4. Renew Policy");
            Console.WriteLine("5. exit");
        
            Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    policyManager.PurchasePolicy();

                    break;
                case 2:
                    policyManager.PayPremium();

                    break;
                case 3:
                    policyManager.RegisterClaim();

                    break;
                case 4:
                    policyManager.RenewPolicy();

                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}