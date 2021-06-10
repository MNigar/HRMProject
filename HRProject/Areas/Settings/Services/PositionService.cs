using HRProject.Areas.Settings.Models;
using HRProject.Models.DTO;
using HRProject.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Areas.Settings.Services
{
    public class PositionService
    {
        private readonly HRContext _context;
        public PositionService(HRContext context)
        {
            _context = context;
        }

        public PositionDTO Save(PositionViewModel model)
        {
            model.IsNew = false;

            if (model.Id == Guid.Empty)
            {

                model.Id = new Guid();
                model.IsNew = true;
            }
            var data = ModelConverter.ConvertToPositionDTO(model);

            if (model.IsNew == true)
            {
                _context.Positions.Add(data);
            }
            else
            {
                _context.Positions.Update(data);
            }
            _context.SaveChanges();
            return data;
        }


        public PositionViewModel GetById(Guid Id)
        {
            var viewModel = new PositionViewModel();
            var data = _context.Positions.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                viewModel = ModelConverter.ConvertToPositionViewModel(data);
            }
            return viewModel;

        }
        public IQueryable<PositionDTO> GetAll()
        {

            var data = _context.Positions.ToList().AsQueryable();

            return data;

        }

        public void Remove(Guid? id)
        {
            var company = _context.Positions.Find(id);
            if (company != null)
            {
                _context.Positions.Remove(company);
                _context.SaveChanges();
            }
        }

    }
}
