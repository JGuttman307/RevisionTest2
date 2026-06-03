using Microsoft.EntityFrameworkCore;

namespace RevTest2;

public class DatabaseContext(DbContextOptions opt) : DbContext(opt)
{
    
}