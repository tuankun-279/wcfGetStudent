using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Publish_Student_Service
{
    [DataContract]
    public class SinhVien
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        //[DataMember]
        public string Email { get; set; }
    }

    public class TestSinhVien
    {
        public static List<SinhVien> GetSinhVien()
        {
            List<SinhVien> sinhViens = new List<SinhVien>();
            //sinhViens.Add(new SinhVien() { Id = 1, Name = "Tuan", Email = "tuan@gmail.com" });
            //sinhViens.Add(new SinhVien() { Id = 2, Name = "Linh", Email = "linh@gmail.com" });
            //sinhViens.Add(new SinhVien() { Id = 3, Name = "Minh", Email = "minh@gmail.com" });
            //sinhViens.Add(new SinhVien() { Id = 4, Name = "Duy", Email = "duy@gmail.com" });
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-03RSBTH;Initial Catalog=GetStudent;Integrated Security=True");
            string sql = "select * from SinhVien ";
            con.Open();
            SqlCommand com = new SqlCommand(sql, con);
            
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            foreach (DataRow row in dt.Rows)
            {
                sinhViens.Add(new SinhVien()
                {
                    Id = Convert.ToInt32(row["Id"].ToString()),
                    Name = row["Name"].ToString(),
                    Email = row["Email"].ToString()
                });
            }
            return sinhViens;
        }
    }
}