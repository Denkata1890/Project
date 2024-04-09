using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using PalateParadise.Data;
using PalateParadise.Interfaces;
using PalateParadise.Models;

namespace PalateParadise.Repository
{
    public class MenuRepository:IMenuRepository
    {
        private readonly ApplicationDbContext _context;
        public MenuRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Add(Menu menu)
        {
            _context.Add(menu);
            return Save();
        }

        public bool Delete(Menu menu)
        {
            _context.Remove(menu);
            return Save();
        }

        public async Task<List<Menu>> GetAllAsync()
        {
            return await _context.Menus.ToListAsync();
        }


        public async Task<Menu> GetById(int id)
        {
            return await _context.Menus.FirstOrDefaultAsync(c => c.MenuId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update(Menu menu)
        {
            _context.Update(menu);
            return Save();
        }
    }
}
