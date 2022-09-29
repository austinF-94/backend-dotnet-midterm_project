using midterm_project.Models;

namespace midterm_project.Repositories;

public interface IDragonsRepository
{
    IEnumerable<Dragons> GetAllDragons();
    Dragons GetDragonById(int dragonId);
    Dragons CreateDragon(Dragons newDragon);
    Dragons UpdateDragon(Dragons newDragon);
    void DeleteDragonById(int dragonId);
}