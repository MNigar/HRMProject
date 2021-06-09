using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using HRProject.Models.Common;
using HRProject.Areas.Settings.Models;
using HRProject.Areas.Settings.Services;
using HRProject.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Areas.Settings.Controllers
{
    [Area("Settings")]
    [Route("Settings/Company")]
    public class CompanyController : AbstractController
    {
        public static string Name = "Company";
        private readonly CompanyService _companyService;
        public CompanyController(IServiceProvider provider) : base(provider)
        {
            _companyService = Resolve<CompanyService>();
        }
        [HttpPost]
        [Route("form")]
        public IActionResult Form(CompanyViewModel viewModel)
        {
            var response = _companyService.Save(viewModel);
            return View(nameof(Index));
        }
        [HttpGet]
        [Route("form")]
        public IActionResult Form(Guid id)
        {
            var result = _companyService.GetById(id);
            return PartialView("Form", result);
        }
        [HttpGet]
        [Route("getall")]
        public IActionResult GetAll(DataSourceLoadOptions option)
        {
            var loadResult = DataSourceLoader.Load(_companyService.GetAll(), option);
            return Content(loadResult.GetSerializeObject(), "application/json");

        }
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("Remove")]
        public IActionResult Remove(Guid? id)
        {
            _companyService.Remove(id);
            return View(nameof(Index));
        }
    }
}
