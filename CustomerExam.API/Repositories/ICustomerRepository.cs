using CustomerExam.API.Models.Entities;

namespace CustomerExam.API.Repositories;

public interface ICustomerRepository
{
    Task<IEnumerable<Customer>> GetAllAsync();
    Task<Customer?> GetByIdAsync(Guid id);
    Task<Guid> CreateAsync(Customer entity);
    Task DeleteAsync(Customer entity);
    Task SaveChangesAsync();
}
