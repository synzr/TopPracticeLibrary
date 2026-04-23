using Microsoft.EntityFrameworkCore;

namespace TopPracticeLibrary.Contexts;

public class LibraryDbContext : DbContext
{
    public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
    {
    }
}
