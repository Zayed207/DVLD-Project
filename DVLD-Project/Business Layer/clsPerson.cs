using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using DataAccessLayer;
using static Business_Layer.clsUser;

namespace Business_Layer
{
    public class clsPerson
    {
       public enum enGender {Male=0,Female=1 }
        public int PersonID { get; set; }
        public int UserID { get; set; }
        public string FirstName { get; set; }
           
        public string SecondName { get; set; }
        public string ThirdName { get; set; }

        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }
        }

        public string LastName { get; set; }
        public string NationalNo { get; set; }
        public int Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }
        public DateTime DateOfBirth
        { get; set; }




        public clsPerson()

        {
            this.PersonID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";

            
        }

        private clsPerson(int PersonID, string FirstName, string SecondName, string ThirdName,
            string LastName, string NationalNo, DateTime DateOfBirth, short Gendor,
             string Address, string Phone, string Email,
            int NationalityCountryID, string ImagePath)

        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.NationalNo = NationalNo;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
          
           
        }

        public static DataTable GetDataByFiltration(string coulmn,string  where)
        {

            return PersonData.SendQuery(coulmn, where);
                




            }

        public static DataTable GetAllData()
        {

            return PersonData.GetAllPeople();





        }


        public static int AddNewPerson(clsPerson person)        {


           return PersonData.AddNewPerson( person.FirstName, person.SecondName, person.ThirdName, person.LastName, person.NationalNo, person.Gender, person.Phone, person.Email, person.Address, person.NationalityCountryID, person.ImagePath, person.DateOfBirth);

        }
        

        public static bool DeletePerson(int id ) {

            return PersonData.DeletePerson(id);
        
        
        
        }

        public static clsPerson Find(int PersonID)
        {

            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", NationalNo = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int NationalityCountryID = -1;
            short Gendor = 0;

            bool IsFound = PersonData.GetPersonInfoByID
                                (
                                    PersonID, ref FirstName, ref SecondName,
                                    ref ThirdName, ref LastName, ref NationalNo, ref DateOfBirth,
                                    ref Gendor, ref Address, ref Phone, ref Email,
                                    ref NationalityCountryID, ref ImagePath
                                );

            if (IsFound)
                //we return new object of that person with the right data
                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName,
                          NationalNo, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }

        public static clsPerson Find(string NationalNo)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int PersonID = -1, NationalityCountryID = -1;
            short Gendor = 0;

            bool IsFound = PersonData.GetPersonInfoByNationalNo
                                (
                                    NationalNo, ref PersonID, ref FirstName, ref SecondName,
                                    ref ThirdName, ref LastName, ref DateOfBirth,
                                    ref Gendor, ref Address, ref Phone, ref Email,
                                    ref NationalityCountryID, ref ImagePath
                                );

            if (IsFound)

                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName,
                          NationalNo, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }

        public static int GetPersonIDByNationalNo(string NationalNo)
        {

            return PersonData.GetPersonIDByNationalNo(NationalNo);
        }

        //public static clsPerson ShowDetails(clsPerson p)
        //{
        //    DataTable dt = new DataTable();
        //    dt=  PersonData.FindById();


        //}
    }
}
