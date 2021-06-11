using HRProject.Areas.Settings.Models;
using HRProject.Models;
using HRProject.Models.DTO;
using HRProject.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Areas.Settings.Services
{
    public class KnowledgeLevelService
    {
        private readonly HRContext _context;
        public KnowledgeLevelService(HRContext context)
        {
            _context = context;
        }

        public KnowledgeLevelDTO Save(KnowledgeLevelViewModel model)
        {
            model.IsNew = false;

            if (model.Id == Guid.Empty)
            {

                model.Id = new Guid();
                model.IsNew = true;
            }
            var data = ModelConverter.ConvertToKnowledgeLevelDTO(model);

            if (model.IsNew == true)
            {
                _context.KnowledgeLevels.Add(data);
            }
            else
            {
                _context.KnowledgeLevels.Update(data);
            }
            _context.SaveChanges();
            return data;
        }


        public KnowledgeLevelViewModel GetById(Guid Id)
        {
            var viewModel = new KnowledgeLevelViewModel();
            var data = _context.KnowledgeLevels.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                viewModel = ModelConverter.ConvertToKnowledgeLevelViewModel(data);
            }
            return viewModel;

        }
        public IQueryable<KnowledgeLevelDTO> GetAll()
        {

            var data = _context.KnowledgeLevels.ToList().AsQueryable();

            return data;

        }

        public void Remove(Guid? id)
        {
            var company = _context.KnowledgeLevels.Find(id);
            if (company != null)
            {
                _context.KnowledgeLevels.Remove(company);
                _context.SaveChanges();
            }
        }
    }
}
