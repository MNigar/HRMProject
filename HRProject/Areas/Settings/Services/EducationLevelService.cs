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
    public class EducationLevelService
    {
        private readonly HRContext _context;
        public EducationLevelService(HRContext context)
        {
            _context = context;
        }

        public EducationLevelDTO Save(EducationLevelViewModel model)
        {
            model.IsNew = false;

            if (model.Id == Guid.Empty)
            {

                model.Id = new Guid();
                model.IsNew = true;
            }
            var data = ModelConverter.ConvertToEducationLevelDTO(model);

            if (model.IsNew == true)
            {
                data.CreatedDate = DateTime.Now;
                data.UpdatedDate = null;
                _context.EducationLevels.Add(data);
            }
            else
            {
                var date = _context.EducationLevels.Where(x => x.Id == data.Id).AsNoTracking().FirstOrDefault().CreatedDate;
                data.CreatedDate = date;
                data.UpdatedDate = DateTime.Now;
                _context.EducationLevels.Update(data);
            }
            _context.SaveChanges();
            return data;
        }


        public EducationLevelViewModel GetById(Guid Id)
        {
            var viewModel = new EducationLevelViewModel();
            var data = _context.EducationLevels.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                viewModel = ModelConverter.ConvertToEducationLevelViewModel(data);
            }
            return viewModel;

        }
        public IQueryable<EducationLevelDTO> GetAll()
        {

            var data = _context.EducationLevels.ToList().AsQueryable();

            return data;

        }

        public void Remove(Guid? id)
        {
            var company = _context.EducationLevels.Find(id);
            if (company != null)
            {
                _context.EducationLevels.Remove(company);
                _context.SaveChanges();
            }
        }
    }
}
