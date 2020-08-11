﻿using Autofac;
using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Service;
using HospitalManagement.Core.UnitOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySqlProject.Areas.Admin.Models
{
    public class DepartmentUpdateModel : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        private IDepartmentService _departmentService;
       // private IApplicationBuilder _applicationBuilder=new ApplicationBuilder();
        private IServiceProvider _serviceProvider;
        public DepartmentUpdateModel()
       {

            _departmentService = Startup.AutofacContainer.Resolve<IDepartmentService>();//Startup.container.GetRequiredService<IDepartmentService>(); //_applicationBuilder.ApplicationServices
            // .CreateScope().ServiceProvider.GetRequiredService<IDepartmentService>();
            //_serviceProvider=
        }
        public DepartmentUpdateModel(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        public void AddDepartment()
        {
            try
            {
                _departmentService.AddNewDepartment(new Department
                {
                    Name=this.Name,
                    Description=this.Description
                });
                Notification = new NotificationModel("Success !", "Department Added Successfully", NotificationModel.NotificationType.Success);

            }
            catch (Exception ex)
            {
                Notification = new NotificationModel("Failed !!", "Failed to Insert Department", NotificationModel.NotificationType.Fail);
            }
        }
        public void Load(int id)
        {
            var department = _departmentService.GetDepartment(id);
            if(department != null)
            {
                Id = department.Id;
                Name = department.Name;
                this.Description = department.Description;
            }

        }

        public void Edit()
        {
            try
            {
                var department = new Department
                {
                    Id = Id,
                    Name = Name,
                    Description = Description
                };
                _departmentService.EditDepartment(department);
                Notification = new NotificationModel("Success !", "Department Added Successfully", NotificationModel.NotificationType.Success);
            }
            catch (Exception ex)
            {
                Notification = new NotificationModel("Failed !!", "Failed to Update Department", NotificationModel.NotificationType.Fail);
            }
        }
    }
}
