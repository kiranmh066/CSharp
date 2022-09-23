using HospitalManagementSystemData;
using HospitalManagementSystemEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystemBLL
{
    public class DoctorBLL
    {
        public bool AddDoctorBLL(Doctor doctorObj)
        {
            DoctorDAL doctorDAL = new DoctorDAL();
            doctorDAL.AddDoctorDAL(doctorObj);
            return true;
        }

        public string UpdateDoctorBLL(Doctor doctorObj)
        {
            DoctorDAL doctorDALObj = new DoctorDAL();
            return doctorDALObj.UpadateDoctorDAl(doctorObj);
        }
        public string DeleteDoctorBLL(int doctor)
        {
            DoctorDAL userDAL1 = new DoctorDAL();
            return userDAL1.DeleteDoctorDAL(doctor);
        }
        public List<Doctor> ShowAllDoctorBLL()
        {
            DoctorDAL userDAL = new DoctorDAL();
            return userDAL.ShowAllDoctorDAL();
        }
    }
}
