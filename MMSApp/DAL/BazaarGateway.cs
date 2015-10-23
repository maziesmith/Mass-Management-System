using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MMSApp.MODEL;

namespace MMSApp.DAL
{
    public class BazaarGateway
    {
        private string databaseConString = ConfigurationManager.ConnectionStrings["conStrings"].ConnectionString;
        public int AddBazaar(Bazaar aBazaar)
        {
            SqlConnection connection = new SqlConnection(databaseConString);
            string query = "INSERT INTO tbl_Bazaars VALUES ('" + aBazaar.MemberId + "','" +
                           aBazaar.BazaarDate + "','" + aBazaar.BazaarAmount + "')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int dbRowAffected = command.ExecuteNonQuery();
            connection.Close();

            return dbRowAffected;
        }

        public List<Bazaar> GetBazaarById(int memberId)
        {
            SqlConnection connection = new SqlConnection(databaseConString);
            string query = "select * from tbl_Members as m inner join tbl_Users as u on m.user_id = u.u_id join tbl_Bazaars as b on b.member_id = m.m_id WHERE member_id = +'" +
                memberId + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Bazaar> memberBazaars = new List<Bazaar>();

            int serialNo = 1;
            while (reader.Read())
            {
                Bazaar aBazaar = new Bazaar();
                aBazaar.SerialNo = serialNo++;
                //aBazaar.MemberName = reader["user_name"].ToString();
                //aBazaar.MemberEmail = reader["email"].ToString();
                aBazaar.BazaarDate = reader["bazaar_date"].ToString();
                aBazaar.BazaarAmount = int.Parse(reader["bazaar_amount"].ToString());
                memberBazaars.Add(aBazaar);
            }
            reader.Close();
            connection.Close();

            return memberBazaars;
        }
    }
}