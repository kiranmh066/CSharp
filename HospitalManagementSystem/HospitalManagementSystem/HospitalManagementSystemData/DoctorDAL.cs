using HospitalManagementSystemEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;
using System.Data;

namespace HospitalManagementSystemData
{
    public class DoctorDAL
    {
        public static string sqlcon = "Data Source=VDC01LTC2164; Initial Catalog=HospitalManagementSystem; Integrated Security=True;";
        public List<Doctor> doctorList = new List<Doctor>();

        public string AddDoctorDAL(Doctor doctorObj)
        {
            string msg = "";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("insert into TblDoctor values(" + doctorObj.DoctorId + ",'" + doctorObj.DoctorName + "','" + doctorObj.DoctorEmail + "','" + doctorObj.DoctorPassword + "')", con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            if (row > 0)
            {
                msg = "Inserted";
            }
            return msg;
        }

        public string UpadateDoctorDAl(Doctor doctorObj)
        {
            string msg = "";
            SqlConnection conn = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("Update TblDoctor set DoctorId="+doctorObj.DoctorId+", DoctorName='" + doctorObj.DoctorName + "',DoctorEmail='" + doctorObj.DoctorEmail + "',DoctorPassword='" + doctorObj.DoctorPassword + "'where DoctorId=" + doctorObj.DoctorId, conn);
            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            if (row > 0)
            {
                msg = "Updated";
            }

            return msg;
        }

        public string DeleteDoctorDAL(int DoctorId)
        {
            string msg = "";
            SqlConnection conn = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("Delete from TblDoctor where DoctorId=" + DoctorId, conn);
            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            if (row > 0)
            {
                msg = "Deleted";
            }

            return msg;
        }

        public List<Doctor> ShowAllDoctorDAL()
        {
            SqlConnection conn = new SqlConnection(sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter("Select * from TblDoctor ", conn);
            DataTable dt = new DataTable();
            List<Doctor> doctorList = new List<Doctor>();
            adp.Fill(dt);

            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    doctorList.Add(new Doctor
                    {
                        DoctorId = Convert.ToInt32(dt.Rows[i]["DoctorId"]),
                        DoctorName = dt.Rows[i]["DoctorName"].ToString(),
                        DoctorEmail = dt.Rows[i]["DoctorEmail"].ToString(),
                        DoctorPassword = dt.Rows[i]["DoctorPassword"].ToString()
                    });
                }
            }

            return doctorList;
        }
    }
}
