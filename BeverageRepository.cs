using Microsoft.EntityFrameworkCore;
using PalateParadise.Data;
using PalateParadise.Interfaces;
using PalateParadise.Models;
using System.Diagnostics;

namespace PalateParadise.Repository
{
    public class BeverageRepository:IBeverageRepostiroy
    {
        private readonly ApplicationDbContext _context;

        public BeverageRepository(ApplicationDbContext context)
        {
           _context = context;
        }

        public bool Add(Beverage beverage)
        {
            _context.Add(beverage);
            return Save();
        }

        public bool Delete(Beverage beverage)
        {
            _context.Remove(beverage);
            return Save();
        }

        public async Task<List<Beverage>> GetAllAsync()
        {
            return await _context.Beverages.ToListAsync();
        }

        public async Task<Beverage> GetById(int id)
        {
            return await _context.Beverages.FirstOrDefaultAsync(b => b.BeverageId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;

        }

        public bool Update(Beverage beverage)
        {
            _context.Update(beverage);
            return Save();
        }
    
    }
}
