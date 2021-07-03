using System.Collections.Generic;
using DL;
using Models;

namespace BL
{
    public class StoreBL : IStoreBL
    {
        /// <summary>
        /// We are defining the dependenices this class needs in the constructor
        /// We do it this way (with interfaces) because we can easily switch out the implementation of DL when we want to change data source 
        /// (change from file system into database stored in the cloud)
        /// </summary>
        private IRepository _repo;
        public StoreBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public Store AddStore(Store p_stor)
        {
            p_stor.State = p_stor.State.ToUpper();
            return _repo.AddStore(p_stor);
        }

        public List<Store> GetAllStore()
        {
            return _repo.GetAllStore();
        }
    }
}