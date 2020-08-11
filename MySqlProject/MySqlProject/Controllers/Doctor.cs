using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalManagement.Core.Contexts;
using HospitalManagement.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using MySqlProject.Models;

namespace MySqlProject.Controllers
{
    public class Doctor : Controller
    {
        public HospitalContext hospitalContext;
        public int pageSize = 3;
        public Doctor(HospitalContext hospitalContext)
        {
            this.hospitalContext = hospitalContext;
        }
        public IActionResult Index(int pageNumber=1)
             => View(new DoctorListModel
             {
                 Doctors = hospitalContext.Doctors
                   .OrderBy(d => d.Id)
                   .Skip((pageNumber - 1) * pageSize)
                   .Take(pageSize),
                 PagingInfo = new PagingInfo
                 {
                     CurrentPage = pageNumber,
                     ItemsPerPage = pageSize,
                     TotalItems = hospitalContext.Doctors.Count()
                 }
             });
    }
}
