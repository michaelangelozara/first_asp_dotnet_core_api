using Microsoft.AspNetCore.Mvc;
using MyFirstASPDotnetAPI.Database;
using MyFirstASPDotnetAPI.Entity.DTO;
using MyFirstASPDotnetAPI.Entity.model;

namespace MyFirstASPDotnetAPI.Controllers {
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController(ApplicationDbContext DbContext) : ControllerBase {

        private readonly ApplicationDbContext DbContext = DbContext;

        [HttpGet]
        public IActionResult GetEmployees() {
            var employees = DbContext.Employees.ToList();
            return Ok(employees);
        }

        [HttpPost]
        public IActionResult SaveEmployee([FromBody] EmployeeAddDTO DTO) {
            var mappedUser = new Employee(DTO.FirstName, DTO.MiddleName, DTO.LastName, DTO.Email, DTO.PhoneNumber, 0);

            DbContext.Employees.Add(mappedUser);
            DbContext.SaveChanges();

            return Created("Success Insert", mappedUser);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateEmployee(Guid id, [FromBody] EmployeeUpdateDTO DTO) {
            var fetchedEmployee = DbContext.Employees.Find(id);

            if(fetchedEmployee is null) {
                return NotFound("User not found.");
            }

            fetchedEmployee.FirstName = DTO.FirstName;
            if(!String.IsNullOrEmpty(DTO.MiddleName)) {
                fetchedEmployee.MiddleName = DTO.MiddleName;
            }
            fetchedEmployee.LastName = DTO.LastName;
            if(String.IsNullOrEmpty(DTO.PhoneNumber)) {
                fetchedEmployee.PhoneNumber = DTO.PhoneNumber;
            }
            fetchedEmployee.Email = DTO.Email;
            DbContext.SaveChanges();

            return Ok(fetchedEmployee);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteEmployee(Guid id) {
            var fetchedEmployee = DbContext.Employees.Find(id);
            if(fetchedEmployee is null) {
                return NotFound("User not found.");
            }

            DbContext.Employees.Remove(fetchedEmployee);
            DbContext.SaveChanges();

            return Ok("Employee is deleted.");
        }
    }
}
