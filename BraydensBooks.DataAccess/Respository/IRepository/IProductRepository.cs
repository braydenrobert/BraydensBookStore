using BraydensBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BraydensBooks.DataAccess.Respository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}
