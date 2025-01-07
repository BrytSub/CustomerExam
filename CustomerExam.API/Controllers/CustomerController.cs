using CustomerExam.API.Models.DTOs;
using CustomerExam.API.Models.Entities;
using CustomerExam.API.Repositories;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CustomerExam.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController(ICustomerRepository _customerRepository, ILogger<CustomerController> _logger) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDto>>> GetAll()
        {
            try
            {
                var customers = await _customerRepository.GetAllAsync();

                var customerDtos = customers.Adapt<IEnumerable<CustomerDto>>(); //Map Customer to CustomerDto

                return Ok(customerDtos);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving all customers.");
                return StatusCode(StatusCodes.Status500InternalServerError, "An unexpected error occurred.");
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CustomerDto>> GetById(Guid id)
        {
            try
            {
                var customer = await _customerRepository.GetByIdAsync(id);
                if (customer is null)
                {
                    return NotFound("Customer not found.");
                }

                var customerDto = customer.Adapt<CustomerDto>();

                return Ok(customerDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while retrieving customer with ID {id}.");
                return StatusCode(StatusCodes.Status500InternalServerError, "An unexpected error occurred.");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCustomerRequestDto request)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid customer data.");

            try
            {
                var customer = request.Adapt<Customer>(); //Map CreateCustomerRequestDto to Customer

                await _customerRepository.CreateAsync(customer);

                var createCustomerDto = customer.Adapt<CustomerDto>(); //Map Customer to CustomerDto

                return CreatedAtAction(nameof(GetById), new { id = createCustomerDto.Id }, new { customerId = createCustomerDto.Id });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while creating a new customer.");
                return StatusCode(StatusCodes.Status500InternalServerError, "An unexpected error occurred.");
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateCustomerRequestDto request)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid customer data.");

            try
            {
                var customer = await _customerRepository.GetByIdAsync(id);
                if (customer is null)
                    return NotFound("Customer not found.");

                request.Adapt(customer); //Map UpdateCustomerRequestDto to Customer

                await _customerRepository.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while updating customer with ID {id}.");
                return StatusCode(StatusCodes.Status500InternalServerError, "An unexpected error occurred.");
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var customer = await _customerRepository.GetByIdAsync(id);
                if (customer is null)
                    return NotFound("Customer not found.");

                await _customerRepository.DeleteAsync(customer);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while deleting customer with ID {id}.");
                return StatusCode(StatusCodes.Status500InternalServerError, "An unexpected error occurred.");
            }
        }
    }
}
