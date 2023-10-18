using Microsoft.EntityFrameworkCore;

namespace CustomerService.Data;

public class CustomerServiceContext : DbContext
{
    public CustomerServiceContext(DbContextOptions<CustomerServiceContext> options)
        : base(options)
    {
    }
    public DbSet<BusinessObjects.Customer>? Customers { get; set; }
}
