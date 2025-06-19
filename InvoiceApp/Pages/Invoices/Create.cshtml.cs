using InvoiceApp.Models;
using InvoiceApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InvoiceApp.Pages.Invoices
{
    public class CreateModel : PageModel
    {
        private ApplicationDbContextClass context;

        [BindProperty]
        public InvoiceDto InvoiceDto { get; set; } = new ();

        public CreateModel(ApplicationDbContextClass context)
        {
            this.context = context;
        }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            if(!ModelState.IsValid)
            {
                return;
            }
        }
    }
}
