using HRProject.Areas.Settings.Models;
using HRProject.Models.DTO;
using HRProject.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Areas.Settings.Services
{
    public class LanguageService
    {
        private readonly HRContext _context;
        public LanguageService(HRContext context)
        {
            _context = context;
        }

        public LanguageDTO Save(LanguageViewModel model)
        {
            model.IsNew = false;

            if (model.Id == Guid.Empty)
            {

                model.Id = new Guid();
                model.IsNew = true;
            }
            var data = ModelConverter.ConvertToLanguageDTO(model);

            if (model.IsNew == true)
            {
                _context.Languages.Add(data);
            }
            else
            {
                _context.Languages.Update(data);
            }
            _context.SaveChanges();
            return data;
        }


        public LanguageViewModel GetById(Guid Id)
        {
            var viewModel = new LanguageViewModel();
            var data = _context.Languages.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                viewModel = ModelConverter.ConvertToLanguageViewModel(data);
            }
            return viewModel;

        }
        public IQueryable<LanguageDTO> GetAll()
        {

            var data = _context.Languages.ToList().AsQueryable();

            return data;

        }

        public void Remove(Guid? id)
        {
            var company = _context.Languages.Find(id);
            if (company != null)
            {
                _context.Languages.Remove(company);
                _context.SaveChanges();
            }
        }
    }
}
