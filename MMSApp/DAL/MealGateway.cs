using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MMSApp.MODEL;

namespace MMSApp.DAL
{
    public class MealGateway
    {
        private string databaseConString = ConfigurationManager.ConnectionStrings["conStrings"].ConnectionString;
        public int AddMeal(Meal aMeal)
        {
            SqlConnection connection = new SqlConnection(databaseConString);
            string query = "INSERT INTO tbl_Meals VALUES ('" + aMeal.MemberId + "','" +
                           aMeal.MealDate + "','" + aMeal.MealNumber + "')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int dbRowAffected = command.ExecuteNonQuery();
            connection.Close();

            return dbRowAffected;
        }

        public List<Meal> GetMealById(int memberId)
        {
            SqlConnection connection = new SqlConnection(databaseConString);
            string query = "select * from tbl_Members as m inner join tbl_Users as u on m.user_id = u.u_id join tbl_Meals as ml on ml.member_id = m.m_id WHERE member_id = +'" +
                memberId + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Meal> memberMealList = new List<Meal>();

            int serialNo = 1;
            //float countMeal = 0;
            while (reader.Read())
            {
                Meal aMeal = new Meal();
                aMeal.SerialNo = serialNo++;
                //aBazaar.MemberName = reader["user_name"].ToString();
                //aBazaar.MemberEmail = reader["email"].ToString();
                aMeal.MealDate = reader["meal_date"].ToString();
                aMeal.MealNumber = float.Parse(reader["meal_number"].ToString());
                //countMeal = aMeal.MealNumber + countMeal;
                //aMeal.Count = countMeal;
                memberMealList.Add(aMeal);
            }
            
            reader.Close();
            connection.Close();

            return memberMealList;
        }

        private string GetTotalSingleMeal(int memberId)
        {
            SqlConnection connection = new SqlConnection(databaseConString);
            string query = "SELECT SUM(meal_number) from tbl_Meals WHERE member_id = '" + memberId + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            //float mealCount = 0;
            //mealCount = float.Parse(reader["meal_number"].ToString());
            //while (reader.Read())
            //{
            //    mealCount = float.Parse(reader["meal_number"].ToString());
            //}
            reader.Close();
            connection.Close();

            return query;
        }

        //public float GetMealCount(int memberId)
        //{
        //    SqlConnection connection = new SqlConnection(databaseConString);
        //    string query = "Select sum(meal_number) from tbl_Meals Where member_id = '" + memberId + "'";
        //    SqlCommand command = new SqlCommand(query, connection);
        //    connection.Open();
           
        //}
    }
}