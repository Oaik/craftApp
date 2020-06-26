using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using craft.Models;
using craft.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace craft.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public JsonFileProductService productService;
        
        public IEnumerable<Product> Products { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, JsonFileProductService productService)
        {
            _logger = logger;
            this.productService = productService;
        }

        public void OnGet()
        {
            Products = productService.GetProducts();
        }
    }
}
