using LR1_ASP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LR1_ASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : Controller
    {
        private readonly Company _company;

        public CompanyController()
        {
            _company = new Company(1, "Ferrari", "Test description", DateTime.Now);
        }

        [HttpGet]
        public ActionResult<Company> GetCompanyInfo()
        {
            return Ok(_company);
        }

        [HttpGet("randomNumber")]
        public ActionResult<int> GetRandomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 101);

            return Ok(randomNumber);
        }
    }
}
