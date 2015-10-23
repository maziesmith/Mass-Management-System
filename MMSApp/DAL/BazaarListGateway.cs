using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MMSApp.MODEL;

namespace MMSApp.DAL
{
    public class BazaarListGateway
    {
        private string databaseConString = ConfigurationManager.ConnectionStrings["conStrings"].ConnectionString;
        public int SaveBazaarList(BazaarList aBazaarList)
        {
            SqlConnection connection = new SqlConnection(databaseConString);
            string query = "INSERT INTO tbl_BazaarLists VALUES ('" + aBazaarList.MemberId + "','" +
                           aBazaarList.BazaarDate + "')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int dbRowAffected = command.ExecuteNonQuery();
            connection.Close();

            return dbRowAffected;
        }
        public List<BazaarList> GetBazaarListById(int memberId)
        {
            SqlConnection connection = new SqlConnection(databaseConString);
            string query = "select * from tbl_Members as m inner join tbl_Users as u on m.user_id = u.u_id join tbl_BazaarLists as bl on bl.member_id = m.m_id WHERE member_id = +'" +
                memberId + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<BazaarList> userBazaarList = new List<BazaarList>();

            int serialNo = 1;
            while (reader.Read())
            {
                BazaarList aBazaarList = new BazaarList();
                aBazaarList.SerialNo = serialNo++;
                aBazaarList.MemberName = reader["user_name"].ToString();
                aBazaarList.MemberEmail = reader["email"].ToString();
                aBazaarList.BazaarDate = reader["bazaar_date"].ToString();
                userBazaarList.Add(aBazaarList);
            }
            reader.Close();
            connection.Close();

            return userBazaarList;
        }
    }
}