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
    public class IssuedOrganizationService
    {
        private readonly HRContext _context;
        public IssuedOrganizationService(HRContext context)
        {
            _context = context;
        }

        public IssuedOrganizationDTO Save(IssuedOrganizationViewModel model)
        {
            model.IsNew = false;

            if (model.Id == Guid.Empty)
            {

                model.Id = new Guid();
                model.IsNew = true;
            }
            var data = ModelConverter.ConvertToIssuedOrganizationDTO(model);

            if (model.IsNew == true)
            {
                data.CreatedDate = DateTime.Now;
                data.UpdatedDate = null;
                _context.IssuedOrganizations.Add(data);
            }
            else
            {
                var date = _context.IssuedOrganizations.Where(x => x.Id == data.Id).AsNoTracking().FirstOrDefault().CreatedDate;
                data.CreatedDate = date;
                data.UpdatedDate = DateTime.Now;
                _context.IssuedOrganizations.Update(data);
            }
            _context.SaveChanges();
            return data;
        }


        public IssuedOrganizationViewModel GetById(Guid Id)
        {
            var viewModel = new IssuedOrganizationViewModel();
            var data = _context.IssuedOrganizations.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                viewModel = ModelConverter.ConvertToIssuedOrganizationViewModel(data);
            }
            return viewModel;

        }
        public IQueryable<IssuedOrganizationDTO> GetAll()
        {

            var data = _context.IssuedOrganizations.ToList().AsQueryable();

            return data;

        }

        public void Remove(Guid? id)
        {
            var data = _context.IssuedOrganizations.Find(id);
            if (data != null)
            {
                _context.IssuedOrganizations.Remove(data);
                _context.SaveChanges();
            }
        }

    }
}
