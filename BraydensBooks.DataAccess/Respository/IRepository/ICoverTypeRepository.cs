using BraydensBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BraydensBooks.DataAccess.Respository.IRepository
{
    public interface ICoverTypeRepository
    {
        Task<IEnumerable<CoverTypes>> GetAllCoverTypes();
        Task<CoverTypes> GetCoverTypeById(int id);
        Task AddCoverType(CoverTypes coverType);
        Task UpdateCoverType(CoverTypes coverType);
        Task DeleteCoverType(int id);
    }
}
