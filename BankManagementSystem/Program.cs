

using BankManagementSystem.Repositories;
using BankManagementSystem.Managers;
using BankManagementSystem.NotificationService;
using BankManagementSystem.UIManager;

var accountsRepo = new AccountsRepository();
var accounts = accountsRepo.GetAllAccounts();

INotificationService notify = new EmailService();
var accountService = new AccountService(accounts, notify);

var ui = new UIManager(accountService);
ui.Run();

