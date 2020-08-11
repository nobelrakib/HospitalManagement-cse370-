using HospitalManagement.Core.Service;
using HospitalManagement.Core.UnitOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MySqlProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySqlProject.Areas.Admin.Models
{
    public class DoctorViewModel
    {
        private IDoctorService _doctorService;
        private IApplicationBuilder _applicationBuilder;
        public DoctorViewModel(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }
        public DoctorViewModel()
        {
            _doctorService = _applicationBuilder.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<IDoctorService>();
        }
        public object GetDoctors(DataTablesAjaxRequestModel tableModel)
        {
            int total = 0;
            int totalFiltered = 0;

            var records = _doctorService.GetDoctors(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                out total,
                out totalFiltered);

            return new
            {
                recordsTotal = total,
                recordsFiltered = totalFiltered,
                data = (from record in records
                        select new string[]
                        {
                                record.Name,
                                record.Department?.Description,
                                record.Designation,
                                record.Designation,
                                record.Id.ToString()
                        }
                    ).ToArray()

            };
        }

        public void Delete(int id)
        {
            _doctorService.DeleteDoctor(id);
        }
    }
}
