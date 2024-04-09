using PalateParadise.Models;

namespace PalateParadise.Interfaces
{
    public interface IMenuRepository
    {
        Task<List<Menu>> GetAllAsync();
        Task<Menu> GetById(int id);
        bool Add(Menu club);
        bool Update(Menu club);
        bool Delete(Menu club);
        bool Save();
    }
}
