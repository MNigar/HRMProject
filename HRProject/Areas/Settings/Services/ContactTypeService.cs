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
    public class ContactTypeService
    {
        private readonly HRContext _context;
        public ContactTypeService(HRContext context)
        {
            _context = context;
        }

        public ContactTypeDTO Save(ContactTypeViewModel model)
        {
            model.IsNew = false;

            if (model.Id == Guid.Empty)
            {

                model.Id = new Guid();
                model.IsNew = true;
            }
            var data = ModelConverter.ConvertToContactTypeDTO(model);

            if (model.IsNew == true)
            {
                data.CreatedDate = DateTime.Now;
                data.UpdatedDate = null;
                _context.ContactTypes.Add(data);
            }
            else
            {
                var date = _context.ContactTypes.Where(x => x.Id == data.Id).AsNoTracking().FirstOrDefault().CreatedDate;
                data.CreatedDate = date;
                data.UpdatedDate = DateTime.Now;
                _context.ContactTypes.Update(data);
            }
            _context.SaveChanges();
            return data;
        }


        public ContactTypeViewModel GetById(Guid Id)
        {
            var viewModel = new ContactTypeViewModel();
            var data = _context.ContactTypes.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                viewModel = ModelConverter.ConvertToContactTypeViewModel(data);
            }
            return viewModel;

        }
        public IQueryable<ContactTypeDTO> GetAll()
        {

            var data = _context.ContactTypes.ToList().AsQueryable();

            return data;

        }

        public void Remove(Guid? id)
        {
            var data = _context.ContactTypes.Find(id);
            if (data != null)
            {
                _context.ContactTypes.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
