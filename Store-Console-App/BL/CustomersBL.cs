using System.Collections.Generic;
using DL;
using Model;

namespace BL
{
    public class CustomersBL : ICustomersBL
    {
        /// <summary>
        /// We are defining the dependenices this class needs in the constructor
        /// We do it this way (with interfaces) because we can easily switch out the implementation of DL when we want to change data source 
        /// (change from file system into database stored in the cloud)
        /// </summary>
        private IRepository _repo;
        public CustomersBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public Customers AddCustomers(Customers p_cust)
        {
            p_cust.State = p_cust.State.ToUpper();
            return _repo.AddCustomers(p_cust);
        }

        public List<Customers> GetAllCustomers()
        {
            return _repo.GetAllCustomers();
        }
    }
}