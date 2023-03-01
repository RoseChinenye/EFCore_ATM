namespace ATM_BLL.ViewsModels
{
    public class CustomerViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountName { get; set; }
        public string Pin { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public DateTime DateCreated { get; set; }
        
    }

}
