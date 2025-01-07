using CustomerExam.UI.Models;
using CustomerExam.UI.Models.DTOs;

namespace CustomerExam.UI.Services;

public class CustomerApiService(HttpClient _httpClient) : ICustomerApiService
{
    public async Task CreateCustomerAsync(CreateCustomerVM customer)
    {
        var response = await _httpClient.PostAsJsonAsync("api/customer", customer);
        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteCustomerAsync(Guid id)
    {
        var response = await _httpClient.DeleteAsync($"api/customer/{id}");
        response.EnsureSuccessStatusCode();
    }

    public async Task<List<CustomerDto>> GetAllCustomerAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<List<CustomerDto>>("api/customer");
        return response ?? new List<CustomerDto>();
    }

    public async Task<CustomerDto?> GetCustomerByIdAsync(Guid id)
    {
        return await _httpClient.GetFromJsonAsync<CustomerDto>($"api/customer/{id}");
    }

    public async Task UpdateCustomerAsync(Guid id, CustomerDto customer)
    {
        var response = await _httpClient.PutAsJsonAsync($"api/customer/{id}", customer);
        response.EnsureSuccessStatusCode();
    }
}
