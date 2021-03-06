using System;


namespace Bank.Entities.Contracts
{
    public interface ICustomer
    {
        #region Propeties
        Guid CustomerID { get; set; }
        long CustomerCode { get; set; }
        string CustomerName { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string Landmark { get; set; }
        string Country { get; set; }
        string Mobile { get; set; }
        #endregion
    }
}
