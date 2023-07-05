using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POS.Data.Payment;

namespace POS.Payment.Api.Controllers;

[ApiController]
[Route("api/transactions")]
public class TransactionsController : ControllerBase
{
    private readonly PaymentDbContext _context;

    public TransactionsController(PaymentDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IEnumerable<Transaction>> Get()
    {
        return await _context.Transactions.ToArrayAsync();
    }
}