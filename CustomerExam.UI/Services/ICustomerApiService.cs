using CustomerExam.UI.Models;
using CustomerExam.UI.Models.DTOs;

namespace CustomerExam.UI.Services;

public interface ICustomerApiService
{
    Task<List<CustomerDto>> GetAllCustomerAsync();
    Task<CustomerDto?> GetCustomerByIdAsync(int id);
    Task CreateCustomerAsync(CreateCustomerVM customer);
    Task UpdateCustomerAsync(int id, CustomerDto customer);
    Task DeleteCustomerAsync(int id);
}
