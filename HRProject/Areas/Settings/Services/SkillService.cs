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
    public class SkillService
    {
        private readonly HRContext _context;
        public SkillService(HRContext context)
        {
            _context = context;
        }

        public SkillDTO Save(SkillViewModel model)
        {
            model.IsNew = false;

            if (model.Id == Guid.Empty)
            {

                model.Id = new Guid();
                model.IsNew = true;
            }
            var data = ModelConverter.ConvertToSkillDTO(model);

            if (model.IsNew == true)
            {
                data.CreatedDate = DateTime.Now;
                data.UpdatedDate = null;
                _context.Skills.Add(data);
            }
            else
            {
                var date = _context.Skills.Where(x => x.Id == data.Id).AsNoTracking().FirstOrDefault().CreatedDate;
                data.CreatedDate = date;
                data.UpdatedDate = DateTime.Now;
                _context.Skills.Update(data);
            }
            _context.SaveChanges();
            return data;
        }


        public SkillViewModel GetById(Guid Id)
        {
            var viewModel = new SkillViewModel();
            var data = _context.Skills.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                viewModel = ModelConverter.ConvertToSkillViewModel(data);
            }
            return viewModel;

        }
        public IQueryable<SkillDTO> GetAll()
        {

            var data = _context.Skills.ToList().AsQueryable();

            return data;

        }

        public void Remove(Guid? id)
        {
            var data = _context.Skills.Find(id);
            if (data != null)
            {
                _context.Skills.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
