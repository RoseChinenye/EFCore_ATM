namespace ATM_DAL.Entities
{
    public class TransactionHistory : BaseEntity
    {
        public decimal Balance { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public string Remark { get; set; }
        public int CustomersId { get; set; }


        public Customers CustomersNavigation { get; set; }

    }
}
