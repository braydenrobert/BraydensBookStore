﻿using System;
using System.Collections.Generic;
using System.Text;
namespace BraydensBooks.DataAccess.Respository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }

        ICoverTypeRepository CoverType { get; }
        IProductRepository Product { get; }

        ISP_Call SP_Call { get; }

        void Save();
    }
}
