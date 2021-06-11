using HRProject.Areas.Settings.Models;
using HRProject.Models;
using HRProject.Models.DTO;
using HRProject.Security;
using Microsoft.EntityFrameworkCore;
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
                data.CreatedDate = DateTime.Now;
                data.UpdatedDate = null;
                _context.KnowledgeLevels.Add(data);
            }
            else
            {
                var date = _context.KnowledgeLevels.Where(x => x.Id == data.Id).AsNoTracking().FirstOrDefault().CreatedDate;
                data.CreatedDate = date;
                data.UpdatedDate = DateTime.Now;
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
            var data = _context.KnowledgeLevels.Find(id);
            if (data != null)
            {
                _context.KnowledgeLevels.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
