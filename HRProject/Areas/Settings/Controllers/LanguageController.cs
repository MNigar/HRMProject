using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using HRProject.Areas.Settings.Models;
using HRProject.Areas.Settings.Services;
using HRProject.Controllers;
using HRProject.Models.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Areas.Settings.Controllers
{
    [Area("Settings")]
    [Route("Settings/Language")]
    public class LanguageController : AbstractController
    {
        public static string Name = "Language";
        private readonly LanguageService _companyService;
        public LanguageController(IServiceProvider provider) : base(provider)
        {
            _companyService = Resolve<LanguageService>();
        }
        [HttpPost]
        [Route("form")]
        public IActionResult Form(LanguageViewModel viewModel)
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
