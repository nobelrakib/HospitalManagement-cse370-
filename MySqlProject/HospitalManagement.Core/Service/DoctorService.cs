﻿using HospitalManagement.Core.Entities;
using HospitalManagement.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalManagement.Core.Service
{
    public class DoctorService : IDoctorService
    {
        private IHospitalUnitOfWork _hospitalUnitOfWork;
        public DoctorService(IHospitalUnitOfWork hospitalUnitOfWork)
        {
            _hospitalUnitOfWork = hospitalUnitOfWork;
        }
        public void AddNewDoctor(Doctor doctor)
        {
            try
            {
                if (doctor == null || string.IsNullOrWhiteSpace(doctor.Name))
                    throw new InvalidOperationException("doctor name is missing");
                _hospitalUnitOfWork.DoctorRepository.Add(doctor);
                _hospitalUnitOfWork.Save();
            }
            catch (InvalidOperationException e)
            {
                throw e;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EditDoctor(Doctor doctor)
        {
            try
            {
                var oldDoctor = _hospitalUnitOfWork.DoctorRepository.GetById(doctor.Id);
                oldDoctor.Name = doctor.Name;
                _hospitalUnitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteDoctor(int id)
        {
            try
            {
                var doctor = _hospitalUnitOfWork.DoctorRepository.GetById(id);
                _hospitalUnitOfWork.DoctorRepository.Remove(doctor);
                _hospitalUnitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Doctor GetDoctor(int id)
        {
            return _hospitalUnitOfWork.DoctorRepository.GetById(id);
        }
        public IEnumerable<Doctor> GetDoctors(
            int pageIndex,
            int pageSize,
            string searchText,
            out int total,
            out int totalFiltered)
        {
            return _hospitalUnitOfWork.DoctorRepository.Get(
                out total,
                out totalFiltered,
                x => x.Name.Contains(searchText),
                x => x.OrderByDescending(b => b.Id),
                "",
                pageIndex,
                pageSize,
                true);
        }

    }
}
