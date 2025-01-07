using CustomerExam.UI.Models;
using CustomerExam.UI.Models.DTOs;
using CustomerExam.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CustomerExam.UI.Controllers
{
    public class HomeController(ICustomerApiService _customerApiService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var customers = await _customerApiService.GetAllCustomerAsync();
            return View(customers);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var customer = await _customerApiService.GetCustomerByIdAsync(id);
            return View(customer);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCustomerVM customer)
        {
            if (ModelState.IsValid)
            {
                await _customerApiService.CreateCustomerAsync(customer);
                return RedirectToAction(nameof(Index));
            }

            return View(customer);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var customer = await _customerApiService.GetCustomerByIdAsync(id);
            return View(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, CustomerDto customer)
        {
            if (ModelState.IsValid)
            {
                await _customerApiService.UpdateCustomerAsync(id, customer);
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var customer = await _customerApiService.GetCustomerByIdAsync(id);
            return View(customer);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _customerApiService.DeleteCustomerAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
