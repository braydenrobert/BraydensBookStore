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
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<CoverTypes>> GetAllCoverTypes()
        {
            return await _db.CoverTypes.ToListAsync();
        }

        public async Task<CoverTypes> GetCoverTypeById(int id)
        {
            return await _db.CoverTypes.FindAsync(id);
        }

        public async Task AddCoverType(CoverTypes coverType)
        {
            await _db.CoverTypes.AddAsync(coverType);
            await _db.SaveChangesAsync();
        }

        public async Task UpdateCoverType(CoverTypes coverType)
        {
            _db.CoverTypes.Update(coverType);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteCoverType(int id)
        {
            var coverType = await _db.CoverTypes.FindAsync(id);
            if (coverType != null)
            {
                _db.CoverTypes.Remove(coverType);
                await _db.SaveChangesAsync();
            }
        }
    }
}
