using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using HRProject.Areas.Structure.Models;
using HRProject.Areas.Structure.Services;
using HRProject.Controllers;
using HRProject.Models.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Areas.Structure.Controllers
{
    [Area("Structure")]
    [Route("Structure/OrganizationStructure")]
    public class OrganizationStructureController : AbstractController
    {
        public static string Name = "OrganizationStructure";
        private readonly OrganizationStructureService _service;
        public OrganizationStructureController(IServiceProvider provider) : base(provider)
        {
            _service = Resolve<OrganizationStructureService>();
        }
        [HttpPost]
        [Route("form")]
        public IActionResult Form(OrganizationStructureViewModel viewModel)
        {
            var response = _service.Save(viewModel);
            return View(nameof(Index));
        }
        [HttpGet]
        [Route("form")]
        public IActionResult Form(Guid id)
        {
            var result = _service.GetById(id);
            return PartialView("Form", result);
        }
        [HttpGet]
        [Route("getall")]
        public IActionResult GetAll(DataSourceLoadOptions option)
        {
            var loadResult = DataSourceLoader.Load(_service.GetAll(), option);
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
            _service.Remove(id);
            return View(nameof(Index));
        }
    }
}
