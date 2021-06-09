using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Controllers
{
    public class AbstractController : Controller
    {
        IServiceProvider _serviceprovider;
        public static string ApplicationPath = "";
        public AbstractController(IServiceProvider provider)
        {
            _serviceprovider = provider;
            ApplicationPath = Resolve<IWebHostEnvironment>().WebRootPath;
        }
        protected T Resolve<T>()
        {
            return (T)_serviceprovider.GetService(typeof(T));
        }

    }
}
