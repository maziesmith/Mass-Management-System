using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MMSApp.MODEL;

namespace MMSApp.DAL
{
    public class UserGateway
    {
        private string databaseConString = ConfigurationManager.ConnectionStrings["conStrings"].ConnectionString;
        public List<Role> GetAllRoleByDropDownList()
        {
            SqlConnection connection = new SqlConnection(databaseConString);
            string query = "SELECT * FROM tbl_Roles";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<Role> roleLists = new List<Role>();

            while (reader.Read())
            {
                Role aRole = new Role();
                aRole.Id = int.Parse(reader["r_id"].ToString());
                aRole.RoleName = reader["role_name"].ToString();

                roleLists.Add(aRole);
            }
            reader.Close();
            connection.Close();

            return roleLists;
        }

        public int Register(User aUser)
        {
            SqlConnection connection = new SqlConnection(databaseConString);
            string query = "INSERT INTO tbl_Users VALUES ('" + aUser.FullName + "','" + aUser.UserName + "','" +
                           aUser.Password + "','" + aUser.Email + "','" + aUser.PhoneNumber + "','" + aUser.CreatedDate +
                           "','" + aUser.PresentAddress + "','" + aUser.RoleId + "')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int dbRowAffected = command.ExecuteNonQuery();
            connection.Close();

            return dbRowAffected;
        }

        public User GetLoginUsers(string userName, string password, int role)
        {
            SqlConnection connection = new SqlConnection(databaseConString);
            string query = "SELECT * FROM tbl_Users WHERE user_name = '" + userName + "' AND password = '" + password +
                           "' AND role_id = '" + role + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            User aUser = new User();

            while (reader.Read())
            {
                aUser.Id = int.Parse(reader["u_id"].ToString());
                aUser.UserName = reader["user_name"].ToString();
                aUser.Password = reader["password"].ToString();
                aUser.RoleId = int.Parse(reader["role_id"].ToString());
            }
            reader.Close();
            connection.Close();

            return aUser;
        }

        public List<User> GetAllUsersByDropDownList()
        {
            SqlConnection connection = new SqlConnection(databaseConString);
            string query = "SELECT * FROM tbl_Users";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<User> usersList = new List<User>();

            while (reader.Read())
            {
                User aUser = new User();
                aUser.Id = int.Parse(reader["u_id"].ToString());
                aUser.FullName = reader["full_name"].ToString();
                aUser.UserName = reader["user_name"].ToString();
                aUser.Password = reader["password"].ToString();
                aUser.Email = reader["email"].ToString();
                aUser.PhoneNumber = reader["contact_number"].ToString();
                aUser.CreatedDate = reader["created_date"].ToString();
                aUser.PresentAddress = reader["present_address"].ToString();
                aUser.RoleId = int.Parse(reader["role_id"].ToString());

                usersList.Add(aUser);
            }
            reader.Close();
            connection.Close();

            return usersList;
        }

        public int SaveMember(User aUser)
        {
            SqlConnection connection = new SqlConnection(databaseConString);
            string query = "INSERT INTO tbl_Members VALUES ('" + aUser.UserId + "')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int dbRowAffected = command.ExecuteNonQuery();
            connection.Close();

            return dbRowAffected;
        }

        public List<User> GetAllMemberByRepeater()
        {
            SqlConnection connection = new SqlConnection(databaseConString);
            string query = "SELECT * FROM view_UserMember";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<User> usersList = new List<User>();

            int serialNo = 1;
            while (reader.Read())
            {
                User aUser = new User();
                aUser.SerialNo = serialNo++;
                //aUser.FullName = reader["full_name"].ToString();
                aUser.UserName = reader["user_name"].ToString();
                aUser.Password = reader["password"].ToString();
                aUser.Email = reader["email"].ToString();
                aUser.PhoneNumber = reader["contact_number"].ToString();
                //aUser.CreatedDate = reader["created_date"].ToString();
                //aUser.PresentAddress = reader["present_address"].ToString();
                aUser.RoleName = reader["role_name"].ToString();
                
                usersList.Add(aUser);
            }
            reader.Close();
            connection.Close();

            return usersList;
        }

        public List<User> GetAllMemberByDropDownList()
        {
            SqlConnection connection = new SqlConnection(databaseConString);
            string query = "select * from tbl_Members as m inner join tbl_Users as u on m.user_id = u.u_id";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<User> usersList = new List<User>();

            while (reader.Read())
            {
                User aUser = new User();
                aUser.Id = int.Parse(reader["u_id"].ToString());
                aUser.FullName = reader["full_name"].ToString();
                aUser.UserName = reader["user_name"].ToString();
                aUser.Password = reader["password"].ToString();
                aUser.Email = reader["email"].ToString();
                aUser.PhoneNumber = reader["contact_number"].ToString();
                aUser.CreatedDate = reader["created_date"].ToString();
                aUser.PresentAddress = reader["present_address"].ToString();

                usersList.Add(aUser);
            }
            reader.Close();
            connection.Close();

            return usersList;
        }
    }
}