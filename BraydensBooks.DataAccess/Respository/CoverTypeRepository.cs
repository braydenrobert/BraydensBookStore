using BraydensBooks.DataAccess.Respository.IRepository;
using BraydensBooks.Models;
using BraydensBookStore.DataAcccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BraydensBooks.DataAccess.Respository
{
    public class CoverTypeRepository : ICoverTypeRepository
    {
        private ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext _db)
        {
            this._db = _db;
        }
    }
}
