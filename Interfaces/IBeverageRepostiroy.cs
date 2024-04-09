using PalateParadise.Models;

namespace PalateParadise.Interfaces
{
    public interface IBeverageRepostiroy
    {
        Task<List<Beverage>> GetAllAsync();
        Task<Beverage> GetById(int id);
        bool Add(Beverage beverage);
        bool Update(Beverage beverage);
        bool Delete(Beverage beverage);
        bool Save();
    }
}
