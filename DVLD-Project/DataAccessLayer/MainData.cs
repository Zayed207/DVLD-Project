using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace DataAccessLayer
{
    public class MainData
    {
        public static string ConnectionString = "Server=.;Database=DVLD;User Id=sa; Password=Sql12345678;";
        public int UserID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Password { set; get; }
        public string Username { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public string Address { set; get; }
        public DateTime DateOfBirth { set; get; }

        public string ImagePath { set; get; }

        public int CountryID { set; get; }

        public int PersonId { set; get; }


        public MainData()
        {
           
        }
        public static MainData FindByUser (ref MainData Input)
                        
        {
            
            
            SqlConnection connection = new SqlConnection(ConnectionString);

            string query = "select Users.UserID from Users  where Users.UserName=@user and Users.Password=@password";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@user", Input.Username);
            command.Parameters.AddWithValue("@password", Input.Password); 

            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()) 

                    if (reader.Read())

                    {
                        Input.UserID = (int )reader["UserID"];


                        reader.Close(); 
                    }
                    else
                    {
                        Console.WriteLine("error here");
                        Input.UserID = -1;
                    }

            }
            catch (Exception ex)

            {
                Console.WriteLine("error ", ex.ToString());

            }
            finally
            {
              
                connection.Close();
            }
            
           

            return Input;
        }


    }
}
