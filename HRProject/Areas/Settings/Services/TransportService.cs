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
    public class TransportService
    {
        private readonly HRContext _context;
        public TransportService(HRContext context)
        {
            _context = context;
        }

        public TransportDTO Save(TransportViewModel model)
        {
            model.IsNew = false;

            if (model.Id == Guid.Empty)
            {

                model.Id = new Guid();
                model.IsNew = true;
            }
            var data = ModelConverter.ConvertToTransportDTO(model);

            if (model.IsNew == true)
            {
                data.CreatedDate = DateTime.Now;
                data.UpdatedDate = null;
                _context.Transports.Add(data);
            }
            else
            {
                var date = _context.Transports.Where(x => x.Id == data.Id).AsNoTracking().FirstOrDefault().CreatedDate;
                data.CreatedDate = date;
                data.UpdatedDate = DateTime.Now;
                _context.Transports.Update(data);
            }
            _context.SaveChanges();
            return data;
        }


        public TransportViewModel GetById(Guid Id)
        {
            var viewModel = new TransportViewModel();
            var data = _context.Transports.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                viewModel = ModelConverter.ConvertToTransportViewModel(data);
            }
            return viewModel;

        }
        public IQueryable<TransportDTO> GetAll()
        {

            var data = _context.Transports.ToList().AsQueryable();

            return data;

        }

        public void Remove(Guid? id)
        {
            var data = _context.Transports.Find(id);
            if (data != null)
            {
                _context.Transports.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
