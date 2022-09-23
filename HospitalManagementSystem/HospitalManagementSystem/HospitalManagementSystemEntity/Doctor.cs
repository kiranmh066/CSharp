using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystemEntity
{
    public class Doctor
    {

        public int DoctorId;

        public string DoctorName;

        public string DoctorEmail;

        public string DoctorPassword;


        public Doctor(int doctorId, string doctorName, string doctorEmail, string doctorPassword)
        {
            DoctorId = doctorId;
            DoctorName = doctorName;
            DoctorEmail = doctorEmail;
            DoctorPassword = doctorPassword;
        }

        public Doctor()
        {

        }
    }
}
