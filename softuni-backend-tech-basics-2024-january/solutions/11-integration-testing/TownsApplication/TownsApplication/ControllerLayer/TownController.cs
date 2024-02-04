using TownsApplication.Data;
using TownsApplication.Data.Models;

public class TownController
{
    private readonly TownDbContext _context;

    public TownController()
    {
        _context = new TownDbContext();
        _context.Database.EnsureCreated();
    }

    public void AddTown(string townName, int population)
    {
        // Validate townName
        if (string.IsNullOrWhiteSpace(townName) || townName.Length < 3)
        {
            throw new ArgumentException("Invalid town name.");
        }

        // Validate population
        if (population <= 0)
        {
            throw new ArgumentException("Population must be a positive number.");
        }

        var existingTown = this.GetTownByName(townName);

        if (existingTown != null)
        {
            return;
        }
        else
        {
            var town = new Town { Name = townName, Population = population };
            _context.Towns.Add(town);
            _context.SaveChanges();
        }
    }

    public void UpdateTown(int id, int newPopulation)
    {
        var town = _context.Towns.FirstOrDefault(t => t.Id == id);
        if (town != null)
        {
            town.Population = newPopulation;
            _context.SaveChanges();
        }
    }

    public void DeleteTown(int id)
    {
        var town = _context.Towns.FirstOrDefault(t => t.Id == id);
        if (town != null)
        {
            _context.Towns.Remove(town);
            _context.SaveChanges();
        }
    }

    public List<Town> ListTowns()
    {
        return _context.Towns.ToList();
    }

    public void PrintAll()
    {
        var towns = _context.Towns.ToList();
        foreach (var town in towns)
        {
            Console.WriteLine($"ID: {town.Id}, Name: {town.Name}, Population: {town.Population}");
        }
    }

    public Town GetTownByName(string townName)
    {
        return _context.Towns.FirstOrDefault(t => t.Name == townName);
    }

    public void ResetDatabase()
    {
        _context.Database.EnsureDeleted();
        _context.Database.EnsureCreated();
    }
}
