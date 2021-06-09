using HRProject.Areas.Settings.Models;
using HRProject.Models.DTO;
using HRProject.Security;
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
                _context.DocumentTypes.Add(data);
            }
            else
            {
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
            var company = _context.DocumentTypes.Find(id);
            if (company != null)
            {
                _context.DocumentTypes.Remove(company);
                _context.SaveChanges();
            }
        }
    }
}
