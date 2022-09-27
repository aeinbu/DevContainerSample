using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Starting...");

        using var db = new TestDbContext();

        Console.WriteLine($"There are {db.Students!.Count()} students");

        Console.WriteLine("Ending...");
    }
}


public class TestDbContext : DbContext
{
    private const string ConnectionString = "Server=db;Port=5432;Database=postgres;User Id=postgres;Password=postgres;";

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(ConnectionString);
    }

    public DbSet<Student>? Students { get; set; }
}

public class Student
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
}