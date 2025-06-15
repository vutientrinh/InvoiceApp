using InvoiceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace InvoiceApp.Services
{
    public class ApplicationDbContextClass : DbContext
    {
        public ApplicationDbContextClass(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Invoice> Invoices { get; set; } = null!;
    }
}
