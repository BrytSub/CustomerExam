using CustomerExam.API.Models.Entities;

namespace CustomerExam.API.Repositories;

public interface ICustomerRepository
{
    Task<IEnumerable<Customer>> GetAllAsync();
    Task<Customer?> GetByIdAsync(int id);
    Task<int> CreateAsync(Customer entity);
    Task DeleteAsync(Customer entity);
    Task SaveChangesAsync();
}
