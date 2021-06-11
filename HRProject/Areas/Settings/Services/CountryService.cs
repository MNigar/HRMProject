using HRProject.Areas.Settings.Models;
using HRProject.Models.DTO;
using HRProject.Security;
using Microsoft.EntityFrameworkCore;
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
                data.CreatedDate = DateTime.Now;
                data.UpdatedDate = null;
                _context.Countries.Add(data);
            }
            else
            {
                var date = _context.Countries.Where(x => x.Id == data.Id).AsNoTracking().FirstOrDefault().CreatedDate;
                data.CreatedDate = date;
                data.UpdatedDate = DateTime.Now;
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
            var data = _context.Countries.Find(id);
            if (data != null)
            {
                _context.Countries.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
