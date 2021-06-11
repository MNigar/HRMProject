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
                data.CreatedDate = DateTime.Now;
                data.UpdatedDate = null;
                _context.Positions.Add(data);
            }
            else
            {
                var date = _context.Positions.Where(x => x.Id == data.Id).AsNoTracking().FirstOrDefault().CreatedDate;
                data.CreatedDate = date;
                data.UpdatedDate = DateTime.Now;
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
            var data = _context.Positions.Find(id);
            if (data != null)
            {
                _context.Positions.Remove(data);
                _context.SaveChanges();
            }
        }

    }
}
