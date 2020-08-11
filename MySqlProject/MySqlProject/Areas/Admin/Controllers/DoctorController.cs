using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalManagement.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MySqlProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DoctorController : Controller
    {
        public FileService fileService;
        public DoctorController(FileService fileService)
        {
            this.fileService = fileService;
        }
        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult Index(IFormFile file)
        {
            fileService.SaveFile(file);
            var x = fileService.FileName;
            return View();
        }
    }
}
