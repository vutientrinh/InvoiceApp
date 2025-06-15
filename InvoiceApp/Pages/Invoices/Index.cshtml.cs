using InvoiceApp.Models;
using InvoiceApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InvoiceApp.Pages.Invoices
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContextClass context;
        public List<Invoice> invoiceList  = new();

        public IndexModel(ApplicationDbContextClass context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            invoiceList = context.Invoices.OrderByDescending(i=>i.Id).ToList();
        }
    }
}
