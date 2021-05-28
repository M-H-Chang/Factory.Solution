using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : dbContext
  {
    public virtual Dbset<Engineer> Engineers { get; set; }
    public virtual Dbset<Machine> Machines { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}