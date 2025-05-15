using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Security.Policy;
using System.Collections;

namespace DataAccessLayer
{
    public class PersonData
    {

        //NationalNo        FirstName SecondName      ThirdName LastName DateOfBirth Gendor Address Phone Email NationalityCountryID ImagePath




        public static DataTable SendQuery(string Item, string Where)
        {

            string query = "";


            switch (Item.ToLower())
            {
                case "personid":

                    query = " select * from FilterPeople where FilterPeople.PersonID= @where";

                    return GetPeopleByFiltration(query, Where);
                case "nationalid":
                    query = " select * from FilterPeople where FilterPeople.NationalNo= @where";

                    return GetPeopleByFiltration(query, Where);

                case "firstname":
                    query = " select * from FilterPeople where FilterPeople.FirstName= @where";
                    return GetPeopleByFiltration(query, Where);

                case "secondname":
                    query = " select * from FilterPeople where FilterPeople.SecondName= @where";
                    return GetPeopleByFiltration(query, Where);

                case "thirdname":
                    query = " select * from FilterPeople where FilterPeople.ThirdName= @where";
                    return GetPeopleByFiltration(query, Where);

                case "lastname":
                    query = " select * from FilterPeople where FilterPeople.lastName= @where";
                    return GetPeopleByFiltration(query, Where);


                case "nationality":
                    query = " select * from FilterPeople where FilterPeople.CountryName= @where";
                    return GetPeopleByFiltration(query, Where);


                case "gender":
                    query = " select * from FilterPeople where FilterPeople.Gender= @where";
                    return GetPeopleByFiltration(query, Where);


                case "phone":
                    query = " select * from FilterPeople where FilterPeople.Phone= @where";
                    return GetPeopleByFiltration(query, Where);


                case "email":
                    query = " select * from FilterPeople where FilterPeople.Email= @where";
                    return GetPeopleByFiltration(query, Where);


                default:
                    return new DataTable();






            }
        }
        public static DataTable GetPeopleByID(string query, int where)
        {
            DataTable dt = new DataTable();


            SqlConnection connection = new SqlConnection(MainData.ConnectionString);
            // string qurey = " select * from People where People.PersonID= @where";


            SqlCommand command = new SqlCommand(query, connection);
            //command.Parameters.AddWithValue("@coulmn",coulmn);
            command.Parameters.AddWithValue("@where", where);

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
        public static DataTable GetPeopleByFiltration(string query, string where)
        {
            DataTable dt = new DataTable();


            SqlConnection connection = new SqlConnection(MainData.ConnectionString);
           // string qurey = " select * from People where People.PersonID= @where";

            
            SqlCommand command = new SqlCommand(query, connection);
            //command.Parameters.AddWithValue("@coulmn",coulmn);
            command.Parameters.AddWithValue("@where",where);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)

                {
                    dt.Load (reader);
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

        public static DataTable GetAllData()
        {
            DataTable dt = new DataTable();


            SqlConnection connection = new SqlConnection(MainData.ConnectionString);
             string qurey = " select * from People ";


            SqlCommand command = new SqlCommand(qurey, connection);
           
            

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

        public static int AddNewPerson(string FirstName, string SecondName, string ThirdName
          , string lastName, string NationalNO, int Gender, string Phone, string Email, string address, int Nationality, string image, DateTime date)
        {




            int ID = -1;
            SqlConnection connection = new SqlConnection(MainData.ConnectionString);


            string qurey = "INSERT INTO People  (NationalNo,FirstName ,SecondName,ThirdName,LastName,DateOfBirth,Gendor,Address,Phone,Email,NationalityCountryID,ImagePath )values (@NationalNo , @FirstName, @SecondName  ,    @ThirdName, @LastName, @DateOfBirth, @Gendor ,@Address, @Phone ,@Email ,@NationalityCountryID,@ImagePath ) ;    SELECT SCOPE_IDENTITY(); ";
            SqlCommand command = new SqlCommand(qurey, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNO);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@DateOfBirth", date);
            command.Parameters.AddWithValue("@Gendor", Gender);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID", Nationality);
            command.Parameters.AddWithValue("@ImagePath", image);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null)
                {
                    ID = Convert.ToInt32(result);
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return ID;


        }

        public static bool DeletePerson( int Personid)
        {

            //Delette person by ID


            int succed= 0;

            SqlConnection connection = new SqlConnection(MainData.ConnectionString);


            string qurey = "delete from People where People.PersonID=@id ";

             SqlCommand command = new SqlCommand(qurey, connection);

            command.Parameters.AddWithValue("@id", Personid);
            
   
            try
            {
                connection.Open();

                succed = command.ExecuteNonQuery();


            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }





            return (succed > 0);
            
           

        }

        public static bool GetPersonInfoByID(int PersonID, ref string FirstName, ref string SecondName,
       ref string ThirdName, ref string LastName, ref string NationalNo, ref DateTime DateOfBirth,
        ref short Gendor, ref string Address, ref string Phone, ref string Email,
        ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(MainData.ConnectionString);

            string query = "SELECT * FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];

                    //ThirdName: allows null in database so we should handle null
                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }
                    else
                    {
                        ThirdName = "";
                    }

                    LastName = (string)reader["LastName"];
                    NationalNo = (string)reader["NationalNo"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (byte)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];


                    //Email: allows null in database so we should handle null
                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }

                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    //ImagePath: allows null in database so we should handle null
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


        public static bool GetPersonInfoByNationalNo(string NationalNo, ref int PersonID, ref string FirstName, ref string SecondName,
        ref string ThirdName, ref string LastName, ref DateTime DateOfBirth,
         ref short Gendor, ref string Address, ref string Phone, ref string Email,
         ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(MainData.ConnectionString);

            string query = "SELECT * FROM People WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];

                    //ThirdName: allows null in database so we should handle null
                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }
                    else
                    {
                        ThirdName = "";
                    }

                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (byte)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];

                    //Email: allows null in database so we should handle null
                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }

                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    //ImagePath: allows null in database so we should handle null
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }



        public static DataTable GetAllPeople()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(MainData.ConnectionString);

            string query =
              @"SELECT People.PersonID, People.NationalNo,
              People.FirstName, People.SecondName, People.ThirdName, People.LastName,
			  People.DateOfBirth, People.Gendor,  
				  CASE
                  WHEN People.Gendor = 0 THEN 'Male'

                  ELSE 'Female'

                  END as GendorCaption ,
			  People.Address, People.Phone, People.Email, 
              People.NationalityCountryID, Countries.CountryName, People.ImagePath
              FROM            People INNER JOIN
                         Countries ON People.NationalityCountryID = Countries.CountryID
                ORDER BY People.FirstName";




            SqlCommand command = new SqlCommand(query, connection);

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

       

        public static bool IsPersonExist(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(MainData.ConnectionString);

            string query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool IsPersonExist(string NationalNo)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(MainData.ConnectionString);

            string query = "SELECT Found=1 FROM People WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


        public static int GetPersonIDByNationalNo(string NationalNo) {
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(MainData.ConnectionString);

            string query = "SELECT People.PersonID FROM People WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                

                    PersonID = (int)reader["PersonID"];
                }


                else
                {
                    // The record was not found
                 
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }
            finally
            {
                connection.Close();
            }

            return PersonID;
        }


    }
}


     
    
