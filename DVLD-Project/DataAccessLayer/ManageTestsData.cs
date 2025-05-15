using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
   public  class ManageTestsData
    {


      

        public static DataTable GetTypesOfTests()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(MainData.ConnectionString);

            string Qurey = "select * from TestTypes order by TestTypeID";
            SqlCommand command = new SqlCommand(Qurey, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }
       

        public static bool UpdateTestType(int TestTypeID, string Title, string Description, float Fees)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(MainData.ConnectionString);

            string query = @"Update  TestTypes  
                            set TestTypeTitle = @TestTypeTitle,
                                TestTypeDescription=@TestTypeDescription,
                                TestTypeFees = @TestTypeFees
                                where TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@TestTypeTitle", Title);
            command.Parameters.AddWithValue("@TestTypeDescription", Description);
            command.Parameters.AddWithValue("@TestTypeFees", Fees);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }


        public static float GetPaidFeesInfo(int TestTypeID)


        {
            float Fees = -1;

            SqlConnection connection = new SqlConnection(MainData.ConnectionString);

            string query = "select TestTypeFees From TestTypes where TestTypeID=@testtypeid";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@testtypeid", TestTypeID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    Fees = (int)reader["TestTypeFees"];

                }
                reader.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine("erorr",ex);
            }
            finally
            {
                connection.Close();
            }
            return Fees;
           
        }

    }



}

