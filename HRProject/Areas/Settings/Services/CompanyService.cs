using HRProject.Models.DTO;
using HRProject.Security;
using HRProject.Areas.Settings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRProject.Areas.Settings.Models;
using Microsoft.EntityFrameworkCore;

namespace HRProject.Areas.Settings.Services
{
    public class CompanyService
    {
        private readonly HRContext _context;
        public CompanyService(HRContext context)
        {
            _context = context;
        }

        public CompanyDto Save(CompanyViewModel model)
        {
            model.IsNew = false;

            if (model.Id == Guid.Empty)
            {

                model.Id = new Guid();
                model.IsNew = true;
            }
            var data = ModelConverter.ConvertToCompanyDto(model);

            if (model.IsNew == true)
            {
                data.CreatedDate = DateTime.Now;
                data.UpdatedDate = null;
                _context.Companies.Add(data);
            }
            else
            {
                var date = _context.Companies.Where(x => x.Id == data.Id).AsNoTracking().FirstOrDefault().CreatedDate;
                data.CreatedDate = date;
                data.UpdatedDate = DateTime.Now;
                _context.Companies.Update(data);
            }
            _context.SaveChanges();
            return data;
        }


        public CompanyViewModel GetById(Guid Id)
        {
            var viewModel = new CompanyViewModel();
            var data = _context.Companies.FirstOrDefault(x=>x.Id==Id);
            if (data != null)
            {
                viewModel = ModelConverter.ConvertToCompanyViewModel(data);
            }
            return viewModel;

        }
        public IQueryable<CompanyDto> GetAll()
        {
          
            var data = _context.Companies.ToList().AsQueryable();

            return data;

        }

        public void Remove(Guid? id)
        {
            var company = _context.Companies.Find(id);
            if (company != null)
            {
                _context.Companies.Remove(company);
                _context.SaveChanges();
            }
        }



    }
}
