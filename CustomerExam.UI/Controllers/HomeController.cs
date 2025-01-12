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
            ViewBag.SuccessMessage = TempData["SuccessMessage"];
            return View(customers);
        }

        public async Task<IActionResult> Details(int id)
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
                TempData["SuccessMessage"] = "Customer created!";
                return RedirectToAction(nameof(Index));
            }

            return View(customer);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var customer = await _customerApiService.GetCustomerByIdAsync(id);
            return View(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, CustomerDto customer)
        {
            if (ModelState.IsValid)
            {
                await _customerApiService.UpdateCustomerAsync(id, customer);
                TempData["SuccessMessage"] = "Customer updated!";
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var customer = await _customerApiService.GetCustomerByIdAsync(id);
            return View(customer);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _customerApiService.DeleteCustomerAsync(id);
            TempData["SuccessMessage"] = "Customer deleted!";
            return RedirectToAction(nameof(Index));
        }
    }
}
