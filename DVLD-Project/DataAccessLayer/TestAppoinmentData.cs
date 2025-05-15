using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
   public class TestAppoinmentData
    {
        public static int AddNewAppoinmentTest( int typeid, int localDrivingLicenseApplicoationID, DateTime appoinmentDate,
            float testFees, int createdByUserID, bool isloked)
        {

            //this function will return the new person id if succeeded and -1 if not.
            int TestAppoinmentID = -1;

            SqlConnection connection = new SqlConnection(MainData.ConnectionString);

            string query = @"INSERT INTO TestAppoinments ( 
                            TestTypeID,LocalDrivingLicenseApplicationID,
                            AppoinmentDate,
                            PaidFees,CreatedByUserID,IsLocked)
                             VALUES (@typeid,@localDrivingLicenseApplicoationID,
                                      @appoinmentDate,@testFees,
                                      @createdByUserID,   @isloked);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

           // command.Parameters.AddWithValue("@testAppoinmentID", testAppoinmentID);
            command.Parameters.AddWithValue("@typeid", typeid);
            command.Parameters.AddWithValue("@localDrivingLicenseApplicoationID", localDrivingLicenseApplicoationID);
            command.Parameters.AddWithValue("@appoinmentDate", appoinmentDate);
            command.Parameters.AddWithValue("@testFees", testFees);
            command.Parameters.AddWithValue("@createdByUserID", createdByUserID);
            command.Parameters.AddWithValue("@isloked", isloked);




            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TestAppoinmentID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return TestAppoinmentID;
        }


        //GetAppoinmentsBylocalDrivingLicenseApplicoationID
        public static DataTable GetAppoinmentsByLDLApplicationID(int LocalDrivingLicenseApplicationID)
        {
            DataTable dt = new DataTable();
            

            SqlConnection connection = new SqlConnection(MainData.ConnectionString);
            string Query = "select TestAppoinmentID,AppoinmentDate,PaidFees,IsLocked From TestAppoinments where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

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
            catch(Exception ex)
            {
                Console.WriteLine("error", ex);

            }
            finally
            {
                connection.Close();

            }

            return dt;
        }

        public static DateTime GetTheExistDateOfAppoinment(int LocalDrivingLicenseApplicationID)
        {

   
            DateTime dt = new DateTime();


            SqlConnection connection = new SqlConnection(MainData.ConnectionString);
            string Query = "select AppoinmentDate From TestAppoinments where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {

                    dt = (DateTime)reader["AppoinmentDate"];


                }
                reader.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine("error", ex);

            }
            finally
            {
                connection.Close();

            }

            return dt;
        }
        


        public static bool IsHasAppoinment(int LocalDrivingLicenseApplicationID)
        {
            bool IsFound = false;


            SqlConnection connection = new SqlConnection(MainData.ConnectionString);
            string Query = "select Found=1 From TestAppoinments where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and TestAppointments.AppointmentDate >=  (select GETDATE())";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    IsFound = reader.HasRows;







                }
                reader.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine("error", ex);
                IsFound = false;
            }
            finally
            {
                connection.Close();

            }

            return IsFound;
        
        }

    }
}
