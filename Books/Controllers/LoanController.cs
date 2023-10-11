using Bookstore.Data;
using Bookstore.Migrations;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    public class LoanController : Controller
    {
        private readonly AppDbContext _context;
        public LoanController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var loan = _context.Loan;

            return View(loan);
        }
    }
}
