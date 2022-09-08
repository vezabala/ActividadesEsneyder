using Actividad7.Models;
using Actividad7.Services;
using Microsoft.AspNetCore.Mvc;

namespace Actividad7.Controllers
{
    public class EnterpriseController : Controller
    {
        private readonly EnterpriseService enterpriseService;

        public EnterpriseController(EnterpriseService enterpriseService)
        {
            this.enterpriseService = enterpriseService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var enterprises = await enterpriseService.GetAllEnterprises();
            return View(enterprises);
        }

        [HttpPost]
        public async Task<IActionResult> Create(string nit, string name, string direccion)
        {
            var enterprise = Enterprise.Build(Guid.NewGuid(),nit, name, direccion);
            await this.enterpriseService.Create(enterprise);
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Guid id, string nit, string name, string direccion)
        {
            var enterprise = Enterprise.Build(id, nit, name, direccion);
            await this.enterpriseService.Update(enterprise);
            return View();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id, string nit, string name, string direccion)
        {
            var enterprise = Enterprise.Build(id, nit, name, direccion);
            await this.enterpriseService.Delete(enterprise);
            return View();
        }
    }
}
