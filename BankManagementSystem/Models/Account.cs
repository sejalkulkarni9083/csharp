namespace BankManagementSystem.Models
{
    public class Account
    {
        public int AccountNo { get; set; }
        public string AccountHolderName { get; set; }
        public decimal Balance { get; set; }
        public DateTime  LastTransaction { get; set; }
    }
}