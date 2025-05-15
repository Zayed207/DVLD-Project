using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;

namespace DataAccessLayer
{
    public class TestData
    {   

        public static bool AddResultTest()
        {
            bool success = false;


            SqlConnection connection = new SqlConnection(MainData.ConnectionString);
            string query = "insert into Tests (TestAppoinmentID ,TestResult,Notes,CreatedByUserID   ) values(@TestAppoinmentID ,@TestResult,@Notes,@CreatedByUserID) SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {

                connection.Open();
                object result = command.ExecuteScalar();
                if(result!=null)
                    {
                    success = true;
                    return success;
                }

            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }


            return success;

        }



        public static bool IsTheLastTestPassed(byte TestTypeID,int LocalDrivingLicenseApplicationID)
        {


            // vision test =1
            // written test=2
            //street driving test=3
            


            bool Pass = false;

            SqlConnection connection = new SqlConnection(MainData.ConnectionString);
            string query = " select Tests.TestResult,TestAppointments.AppointmentDate from TestAppointments inner join Tests on TestAppointments.TestAppointmentID = Tests.TestAppointmentID where TestAppointments.LocalDrivingLicenseApplicationID = @LDLAID and TestAppointments.TestTypeID = @TypeID order by TestAppointments.AppointmentDate desc ;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDLAID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TypeID", TestTypeID);

            try
            {

                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    Pass = true;

                    return Pass;
                }

            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }


            return Pass;



        }

        public static bool AreAllTestsPassed( int LocalDrivingLicenseApplicationID)
        {


            // vision test =1
            // written test=2
            //street driving test=3



            bool Pass = false;

            SqlConnection connection = new SqlConnection(MainData.ConnectionString);
            string query = " select case\r\nwhen exists(   select 1 from TestAppointments inner join Tests on TestAppointments.TestAppointmentID = Tests.TestAppointmentID where TestAppointments.LocalDrivingLicenseApplicationID = @LDLAID and Tests.TestResult=1 ) then cast(1 as bit) else cast(0 as bit)end as result";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDLAID", LocalDrivingLicenseApplicationID);

//            ts.TestResult,TestAppointments.AppointmentDate from TestAppointments inner join Tests on TestAppointments.TestAppointmentID = Tests.TestAppointmentID
//--where TestAppointments.TestAppointmentID = 70TestAppointments.LocalDrivingLicenseApplicationID = 31
//where TestAppointments.TestAppointmentID = 69and TestAppointments.TestTypeID = 2
//order by TestAppointments.AppointmentDate desc

//--where TestAppointments.TestAppointmentID = 70TestAppointments.LocalDrivingLicenseApplicationID = 31




//select case
//when exists(
//  select count(*) from TestAppointments inner join Tests on TestAppointments.TestAppointmentID = Tests.TestAppointmentID

//where TestAppointments.LocalDrivingLicenseApplicationID = 31 and Tests.TestResult = 1 ) then cast(1 as bit) else cast(0 as bit)end as result














//--order by TestAppointments.AppointmentDate desc)
//select* from TestAppointments where TestAppointments.LocalDrivingLicenseApplicationID = 31 and TestAppointments.TestTypeID = 2
//order by TestAppointments.AppointmentDate desc



//select Tests.TestResult,TestAppointments.AppointmentDate from TestAppointments inner join Tests on TestAppointments.TestAppointmentID = Tests.TestAppointmentID where TestAppointments.LocalDrivingLicenseApplicationID = 31 and TestAppointments.TestTypeID = 2 order by TestAppointments.AppointmentDate asc;

                try
                {

                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    Pass = true;

                    return Pass;
                }

            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }


            return Pass;



        }



    }
}
