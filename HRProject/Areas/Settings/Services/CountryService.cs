using HRProject.Areas.Settings.Models;
using HRProject.Models.DTO;
using HRProject.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Areas.Settings.Services
{
    public class CountryService
    {
        private readonly HRContext _context;
        public CountryService(HRContext context)
        {
            _context = context;
        }

        public CountryDTO Save(CountryViewModel model)
        {
            model.IsNew = false;

            if (model.Id == Guid.Empty)
            {

                model.Id = new Guid();
                model.IsNew = true;
            }
            var data = ModelConverter.ConvertToCountryDTO(model);

            if (model.IsNew == true)
            {
                _context.Countries.Add(data);
            }
            else
            {
                _context.Countries.Update(data);
            }
            _context.SaveChanges();
            return data;
        }


        public CountryViewModel GetById(Guid Id)
        {
            var viewModel = new CountryViewModel();
            var data = _context.Countries.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                viewModel = ModelConverter.ConvertToCountryViewModel(data);
            }
            return viewModel;

        }
        public IQueryable<CountryDTO> GetAll()
        {

            var data = _context.Countries.ToList().AsQueryable();

            return data;

        }

        public void Remove(Guid? id)
        {
            var company = _context.Countries.Find(id);
            if (company != null)
            {
                _context.Countries.Remove(company);
                _context.SaveChanges();
            }
        }
    }
}
