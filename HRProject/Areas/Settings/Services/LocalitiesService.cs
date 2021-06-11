using HRProject.Areas.Settings.Models;
using HRProject.Areas.Settings.Models.GridModel;
using HRProject.Models.DTO;
using HRProject.Security;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Areas.Settings.Services
{
    public class LocalitiesService
    {
        private readonly HRContext _context;
        public LocalitiesService(HRContext context)
        {
            _context = context;
        }

        public LocalitiesDTO Save(LocalitiesViewModel model)
        {
            model.IsNew = false;

            if (model.Id == Guid.Empty)
            {

                model.Id = new Guid();
                model.IsNew = true;
            }
            var data = ModelConverter.ConvertToLocalitiesDTO(model);

            if (model.IsNew == true)
            {
                data.CreatedDate = DateTime.Now;
                data.UpdatedDate = null;
                _context.Localities.Add(data);
            }
            else
            {
                var date = _context.Localities.Where(x => x.Id == data.Id).AsNoTracking().FirstOrDefault().CreatedDate;
                data.CreatedDate = date;
                data.UpdatedDate = DateTime.Now;
                _context.Localities.Update(data);
            }
            _context.SaveChanges();
            return data;
        }


        public LocalitiesViewModel GetById(Guid Id)
        {
            var viewModel = new LocalitiesViewModel();
            var data = _context.Localities.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                viewModel = ModelConverter.ConvertToLocalitiesViewModel(data);
            }
            return viewModel;

        }
        public IQueryable<LocalitiesGridModel> GetAll()
        {

            var data = from l in _context.Localities
                         join c in _context.Countries on l.CountryId equals c.Id
                         select new LocalitiesGridModel { Id = l.Id, CountryId = c.Id, CountryName = c.Name, Name = l.Name, Description = l.Description };

            return data;

        }

        public void Remove(Guid? id)
        {
            var data = _context.Localities.Find(id);
            if (data != null)
            {
                _context.Localities.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
