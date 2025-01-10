using CustomerExam.API.Data;
using CustomerExam.API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerExam.API.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private readonly ApplicationDbContext _context;

    public CustomerRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<int> CreateAsync(Customer entity)
    {
        await _context.AddAsync(entity);
        await _context.SaveChangesAsync();

        return entity.Id;
    }

    public async Task DeleteAsync(Customer entity)
    {
        _context.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Customer>> GetAllAsync()
    {
        var customers = await _context.Customers
            .Include(c => c.Addresses)
            .Include(c => c.ContactNumbers)
            .ToListAsync();

        return customers;
    }

    public async Task<Customer?> GetByIdAsync(int id)
    {
        var customer = await _context.Customers
            .Include(c => c.Addresses)
            .Include(c => c.ContactNumbers)
            .FirstOrDefaultAsync(c => c.Id == id);

        return customer;
    }

    public Task SaveChangesAsync() => _context.SaveChangesAsync();
}
