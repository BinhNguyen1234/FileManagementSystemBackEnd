using FileManagementSystemBE.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FileManagementSystemBE.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TestController : ControllerBase
    {
        private MockupContext _context;

        public TestController(MockupContext mockupContext) { 
        
            _context = mockupContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetWithTransaction()
        {

            using (var transaction = _context.Database.BeginTransaction())
            {
                var test = await _context.TblUsers.Where(x => x.Id == new Guid("004c8f1e-bac4-4f9f-8310-534dcf86edef")).ToListAsync();
                Console.WriteLine("12312312");
            }
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateWithTransaction()
        {

            using (var transaction = _context.Database.BeginTransaction())
            {
                var test = await _context.TblUsers.FirstAsync(x => x.Id == new Guid("004c8f1e-bac4-4f9f-8310-534dcf86edef"));
                test.LastName = "By entity";
           
                _context.SaveChanges();
                Console.WriteLine("1");
                Console.WriteLine("2");
                transaction.Commit();
                Console.WriteLine("3");

            }
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {

                var test = await _context.TblUsers.Where(x => x.Id == new Guid("004c8f1e-bac4-4f9f-8310-534dcf86edef")).ToListAsync();
                Console.WriteLine("12312312");
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> Update()
        {

            var test = await _context.TblUsers.FirstAsync(x => x.Id == new Guid("004c8f1e-bac4-4f9f-8310-534dcf86edef"));
            test.LastName = "By entity";

            _context.SaveChanges();
            Console.WriteLine("1");
            Console.WriteLine("2");
  
            Console.WriteLine("3");

            Console.WriteLine("12312312");
            return Ok();
        }
    }
}
