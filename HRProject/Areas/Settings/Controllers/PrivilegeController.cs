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
    [Route("Settings/Privilege")]
    public class PrivilegeController : AbstractController
    {
        public static string Name = "Privilege";
        private readonly PrivilegeService _service;
        public PrivilegeController(IServiceProvider provider) : base(provider)
        {
            _service = Resolve<PrivilegeService>();
        }
        [HttpPost]
        [Route("form")]
        public IActionResult Form(PrivilegeViewModel viewModel)
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
