using HRProject.Areas.Settings.Models;
using HRProject.Models.DTO;
using HRProject.Security;
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
                _context.EducationInstitutes.Add(data);
            }
            else
            {
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
            var company = _context.EducationInstitutes.Find(id);
            if (company != null)
            {
                _context.EducationInstitutes.Remove(company);
                _context.SaveChanges();
            }
        }
    }
}
