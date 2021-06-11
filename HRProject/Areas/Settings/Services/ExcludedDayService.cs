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
    public class ExcludedDayService
    {
        private readonly HRContext _context;
        public ExcludedDayService(HRContext context)
        {
            _context = context;
        }

        public ExcludedDayDTO Save(ExcludedDayViewModel model)
        {
            model.IsNew = false;
            model.IsHoliday = true;
            if (model.Id == Guid.Empty)
            {

                model.Id = new Guid();
                model.IsNew = true;
            }
            var data = ModelConverter.ConvertToExcludedDayDTO(model);

            if (model.IsNew == true)
            {
                data.CreatedDate = DateTime.Now;
                data.UpdatedDate = null;
                _context.ExcludedDays.Add(data);
            }
            else
            {
                var date = _context.ExcludedDays.Where(x => x.Id == data.Id).AsNoTracking().FirstOrDefault().CreatedDate;
                data.CreatedDate = date;
                data.UpdatedDate = DateTime.Now;
                _context.ExcludedDays.Update(data);
            }
            _context.SaveChanges();
            return data;
        }


            public ExcludedDayViewModel GetById(Guid Id)
        {
            var viewModel = new ExcludedDayViewModel();
            var data = _context.ExcludedDays.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                viewModel = ModelConverter.ConvertToExcludedDayViewModel(data);
            }
            return viewModel;

        }
        public IQueryable<ExcludedDayDTO> GetAll()
        {

            var data = _context.ExcludedDays.ToList().AsQueryable();

            return data;

        }

        public void Remove(Guid? id)
        {
            var data = _context.ExcludedDays.Find(id);
            if (data != null)
            {
                _context.ExcludedDays.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
