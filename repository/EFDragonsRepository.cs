using midterm_project.Migrations;
using midterm_project.Models;

namespace midterm_project.Repositories;

public class EFDragonsRepository : IDragonsRepository
{
    private readonly DragonsDbContext _context;

    public EFDragonsRepository(DragonsDbContext context)
    {
        _context = context;
    }
    // CREATEDRAGONS
    public Dragons CreateDragon(Dragons newDragon)
    {
    _context.Dragons.Add(newDragon);
    _context.SaveChanges();
    return newDragon;    }
    // CREATEDRAGONS

    // // DELETEDRAGONS
    public void DeleteDragonById(int dragonId)
    {
    var dragon = _context.Dragons.Find(dragonId); 
    if (dragon != null) {
        _context.Dragons.Remove(dragon); 
        _context.SaveChanges(); 
    }    }
    // // DELETEDRAGONS

    // // GETALLDRAGONS
    public IEnumerable<Dragons> GetAllDragons()
    {
        return _context.Dragons.ToList();
    }
    // // GETALLDRAGONS

    // GETDRAGONBYID
    public Dragons GetDragonById(int dragonId)
    {
        return _context.Dragons.SingleOrDefault(c => c.DragonId == dragonId);
    }
    // // GETDRAGONBYID

    // // UPDATEDRAGON
    public Dragons UpdateDragon(Dragons newDragon)
    {
    var originalDragon = _context.Dragons.Find(newDragon.DragonId);
    if (originalDragon != null) {
        originalDragon.dragonName = newDragon.dragonName;
        originalDragon.dragonImage = newDragon.dragonImage;
        originalDragon.dragonDescription = newDragon.dragonDescription;
        originalDragon.dragonDetails = newDragon.dragonDetails;

        _context.SaveChanges();
    }
    return originalDragon;    }
    // // UPDATEDRAGON

}
