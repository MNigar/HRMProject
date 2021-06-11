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
    public class SpecialitieService
    {
        private readonly HRContext _context;
        public SpecialitieService(HRContext context)
        {
            _context = context;
        }

        public SpecialitieDTO Save(SpecialitieViewModel model)
        {
            model.IsNew = false;

            if (model.Id == Guid.Empty)
            {

                model.Id = new Guid();
                model.IsNew = true;
            }
            var data = ModelConverter.ConvertToSpecialitieDTO(model);

            if (model.IsNew == true)
            {
                data.CreatedDate = DateTime.Now;
                data.UpdatedDate = null;
                _context.Specialities.Add(data);
            }
            else
            {
                var date = _context.Specialities.Where(x => x.Id == data.Id).AsNoTracking().FirstOrDefault().CreatedDate;
                data.CreatedDate = date;
                data.UpdatedDate = DateTime.Now;
                _context.Specialities.Update(data);
            }
            _context.SaveChanges();
            return data;
        }


        public SpecialitieViewModel GetById(Guid Id)
        {
            var viewModel = new SpecialitieViewModel();
            var data = _context.Specialities.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                viewModel = ModelConverter.ConvertToSpecialitieViewModel(data);
            }
            return viewModel;

        }
        public IQueryable<SpecialitieDTO> GetAll()
        {

            var data = _context.Specialities.ToList().AsQueryable();

            return data;

        }

        public void Remove(Guid? id)
        {
            var data = _context.Specialities.Find(id);
            if (data != null)
            {
                _context.Specialities.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
