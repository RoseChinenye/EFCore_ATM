using ATM_BLL.ViewsModels;
using ATM_DAL.Entities;

namespace ATM_BLL.Interface
{
    public interface ICustomerOperations
    {
        Task<Customers> Login(string accountNumber, string pin);
        Task<CustomerViewModel> WithdrawAsync(string accountNumber, string pin, decimal amount);
        Task CheckBalanceAsync(string accountNumber, string pin);
        Task<CustomerViewModel> DepositAsync(string accountNumber, string pin, decimal amount);
        Task TransferAsync(string accountNumber, string pin, string receiverAcc, decimal TransferAmount);

    }
}
