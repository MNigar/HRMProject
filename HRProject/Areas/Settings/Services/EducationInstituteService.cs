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
    public class EducationInstituteService
    {

        private readonly HRContext _context;
        public EducationInstituteService(HRContext context)
        {
            _context = context;
        }

        public EducationInstituteDTO Save(EducationInstituteViewModel model)
        {
            model.IsNew = false;

            if (model.Id == Guid.Empty)
            {

                model.Id = new Guid();
                model.IsNew = true;
            }
            var data = ModelConverter.ConvertToEducationInstituteDTO(model);

            if (model.IsNew == true)
            {
                data.CreatedDate = DateTime.Now;
                data.UpdatedDate = null;
                _context.EducationInstitutes.Add(data);
            }
            else
            {
                var date = _context.EducationInstitutes.Where(x => x.Id == data.Id).AsNoTracking().FirstOrDefault().CreatedDate;
                data.CreatedDate = date;
                data.UpdatedDate = DateTime.Now;
                _context.EducationInstitutes.Update(data);
            }
            _context.SaveChanges();
            return data;
        }


        public EducationInstituteViewModel GetById(Guid Id)
        {
            var viewModel = new EducationInstituteViewModel();
            var data = _context.EducationInstitutes.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                viewModel = ModelConverter.ConvertToEducationInstituteViewModel(data);
            }
            return viewModel;

        }
        public IQueryable<EducationInstituteDTO> GetAll()
        {

            var data = _context.EducationInstitutes.ToList().AsQueryable();

            return data;

        }

        public void Remove(Guid? id)
        {
            var data = _context.EducationInstitutes.Find(id);
            if (data != null)
            {
                _context.EducationInstitutes.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
