namespace BankManagementSystem.Models
{
    public class Operation
    {
        public int AccountNo { get; set; }
        public decimal Amount { get; set; }
        public string OperationType { get; set; }
    }
}