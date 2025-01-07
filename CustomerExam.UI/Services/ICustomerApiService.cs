using CustomerExam.UI.Models;
using CustomerExam.UI.Models.DTOs;

namespace CustomerExam.UI.Services;

public interface ICustomerApiService
{
    Task<List<CustomerDto>> GetAllCustomerAsync();
    Task<CustomerDto?> GetCustomerByIdAsync(Guid id);
    Task CreateCustomerAsync(CreateCustomerVM customer);
    Task UpdateCustomerAsync(Guid id, CustomerDto customer);
    Task DeleteCustomerAsync(Guid id);
}
