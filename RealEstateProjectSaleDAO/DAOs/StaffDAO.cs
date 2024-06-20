using Microsoft.EntityFrameworkCore;
using RealEstateProjectSaleBusinessObject.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProjectSaleDAO.DAOs
{
    public class StaffDAO
    {

        private readonly RealEstateProjectSaleSystemDBContext _context;
        public StaffDAO()
        {
            _context = new RealEstateProjectSaleSystemDBContext();
        }

        public List<Staff> GetAllStaff()
        {
            try
            {
                return _context.Staffs!.Include(c => c.Account)
                                       .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddNewStaff(Staff staff)
        {
            try
            {
                _context.Add(staff);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Staff GetStaffByID(Guid id)
        {
            try
            {
                var staff = _context.Staffs!.Include(a => a.Account)
                                           .SingleOrDefault(c => c.StaffID == id);
                return staff;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateStaff(Staff staff)
        {
            try
            {
                var existingStaff = _context.Staffs!.FirstOrDefault(t => t.StaffID == staff.StaffID);
                if (existingStaff != null)
                {
                    existingStaff.Name = staff.Name;
                    existingStaff.Email = staff.Email;
                    existingStaff.DateOfBirth = staff.DateOfBirth;
                    existingStaff.Image = staff.Image;
                    existingStaff.Imagesignature = staff.Imagesignature;
                    existingStaff.IdentityCardNumber = staff.IdentityCardNumber;
                    existingStaff.Sex = staff.Sex;
                    existingStaff.Nationality = staff.Nationality;
                    existingStaff.Placeoforigin = staff.Placeoforigin;
                    existingStaff.PlaceOfresidence = staff.PlaceOfresidence;
                    existingStaff.DateRange = staff.DateRange;
                    existingStaff.Taxcode = staff.Taxcode;
                    existingStaff.BankName = staff.BankName;
                    existingStaff.BankNumber = staff.BankNumber;
                    existingStaff.Status = staff.Status;
                    existingStaff.AccountID = staff.AccountID;
                    _context.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ChangeStatusStaff(Staff staff)
        {
            var _staff = _context.Staffs!.FirstOrDefault(c => c.StaffID.Equals(staff.StaffID));


            if (_staff == null)
            {
                return false;
            }
            else
            {
                _staff.Status = false;
                _context.Entry(_staff).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
        }

    }
}
