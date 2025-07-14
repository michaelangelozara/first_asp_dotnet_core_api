using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstASPDotnetAPI.Database;
using MyFirstASPDotnetAPI.Entity.model;

namespace MyFirstASPDotnetAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController(ApplicationDbContext DbContext) : ControllerBase {

        private readonly ApplicationDbContext DbContext = DbContext;

        [HttpGet]
        public IActionResult getEmployees() {
            var employees = DbContext.Employees.ToList();
            return Ok(employees);
        }
    }
}
