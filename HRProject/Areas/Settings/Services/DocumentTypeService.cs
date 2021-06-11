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
    public class DocumentTypeService
    {
        private readonly HRContext _context;
        public DocumentTypeService(HRContext context)
        {
            _context = context;
        }

        public DocumentTypeDTO Save(DocumentTypeViewModel model)
        {
            model.IsNew = false;

            if (model.Id == Guid.Empty)
            {

                model.Id = new Guid();
                model.IsNew = true;
            }
            var data = ModelConverter.ConvertToDocumentTypeDTO(model);

            if (model.IsNew == true)
            {
                data.CreatedDate = DateTime.Now;
                data.UpdatedDate = null;
                _context.DocumentTypes.Add(data);
            }
            else
            {
                var date = _context.DocumentTypes.Where(x => x.Id == data.Id).AsNoTracking().FirstOrDefault().CreatedDate;
                data.CreatedDate = date;
                data.UpdatedDate = DateTime.Now;
                _context.DocumentTypes.Update(data);
            }
            _context.SaveChanges();
            return data;
        }


        public DocumentTypeViewModel GetById(Guid Id)
        {
            var viewModel = new DocumentTypeViewModel();
            var data = _context.DocumentTypes.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                viewModel = ModelConverter.ConvertToDocumentTypeViewModel(data);
            }
            return viewModel;

        }
        public IQueryable<DocumentTypeDTO> GetAll()
        {

            var data = _context.DocumentTypes.ToList().AsQueryable();

            return data;

        }

        public void Remove(Guid? id)
        {
            var data = _context.DocumentTypes.Find(id);
            if (data != null)
            {
                _context.DocumentTypes.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
