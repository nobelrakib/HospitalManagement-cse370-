using HospitalManagement.Core.Contexts;
using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySqlProject.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            HospitalContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<HospitalContext>();
            var service = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<IDepartmentService>();
            //if (context.Database.GetPendingMigrations().Any())
            //{
            //    context.Database.Migrate();
            //}

            //context.Entry(Doctor).State = EntityState.Added;
            context.Doctors.AddRange(
                    new Doctor
                    {
                        Name = "Joy",
                        Description = "A boat for one person",
                        Designation="Professor",
                        DepartmentId=1,
                        //Department=service.GetDepartment(9),
                        ImageName="Joy.jpg",
                    },
                       new Doctor
                       {
                           Name = "Nabik",
                           Description = "A boat for one person",
                           Designation = "Professor",
                           DepartmentId = 1,
                          // Department = service.GetDepartment(9),
                           ImageName = "nabik.jpg",
                       },
                       new Doctor
                       {
                           Name = "Abbas",
                           Description = "A boat for one person",
                           Designation = "Professor",
                           DepartmentId = 1,
                           //Department = service.GetDepartment(9),
                           ImageName = "abbas.jpg",
                       },
                          new Doctor
                          {
                              Name = "Nakib",
                              Description = "A boat for one person",
                              Designation = "Professor",
                             DepartmentId = 1,
                            //  Department = service.GetDepartment(9),
                              ImageName = "nakib.jpg",
                          },
                           new Doctor
                           {
                               Name = "kasem",
                               Description = "A boat for one person",
                               Designation = "Professor",
                               DepartmentId = 1,
                              // Department = service.GetDepartment(9),
                               ImageName = "g2.jpg",
                           },
                           new Doctor
                           {
                               Name = "bulbul",
                               Description = "A boat for one person",
                               Designation = "Professor",
                               DepartmentId = 1,
                              // Department = service.GetDepartment(9),
                               ImageName = "g3.jpg",
                           },
                           new Doctor
                           {
                               Name = "hasan",
                               Description = "A boat for one person",
                               Designation = "Professor",
                               DepartmentId = 1,
                               // Department = service.GetDepartment(9),
                               ImageName = "g4.jpg",
                           }


                );
                context.SaveChanges();
            
        }
    }
}
