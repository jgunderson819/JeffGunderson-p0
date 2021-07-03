using System.Collections.Generic;
using DL;
using Models;

namespace BL
{
    public class ProductsBL : IProductsBL
    {
        /// <summary>
        /// We are defining the dependenices this class needs in the constructor
        /// We do it this way (with interfaces) because we can easily switch out the implementation of RRDL when we want to change data source 
        /// (change from file system into database stored in the cloud)
        /// </summary>
        private IRepository _repo;
        public ProductsBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public Products AddProducts(Products p_prod)
        {
            p_prod.State = p_prod.State.ToUpper();
            return _repo.AddProducts(p_prod);
        }

        public List<Products> GetAllProducts()
        {
            return _repo.GetAllProducts();
        }
    }
}