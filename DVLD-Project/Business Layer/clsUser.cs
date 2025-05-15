using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DataAccessLayer;
namespace Business_Layer
{
   public class clsUser
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int UserID { set; get; }
        public int PersonID { set; get; }

        public clsPerson PersonInfo;
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }

        public clsUser()

        {
            this.UserID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = true;
            Mode = enMode.AddNew;
        }

        private clsUser(int UserID, int PersonID, string Username, string Password,
            bool IsActive)

        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            //this.PersonInfo = clsPerson.Find(PersonID);
            this.UserName = Username;
            this.Password = Password;
            this.IsActive = IsActive;

            Mode = enMode.Update;
        }

        public static bool _AddNewUser(int PersonID,ref int UserID, string  UserName,string Password, bool IsActive )
        {
            //call DataAccess Layer 

            UserID = UserData.AddNewUser(PersonID,UserName,
                 Password, IsActive);

            return (UserID != -1);
        }


        public static int _AddNewUser(int PersonID, string UserName, string Password, bool IsActive)
        {
            //call DataAccess Layer 

            int UserID = -1;
            UserID = UserData.AddNewUser(PersonID, UserName,
                 Password, IsActive);

            return UserID; 
        }
        public static bool _UpdateUser( int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            //call DataAccess Layer 

            return UserData.UpdateUser(UserID, PersonID,UserName,
                Password, IsActive);
        }
        public static clsUser FindByUserID(int UserID)
        {
            int PersonID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;

            bool IsFound = UserData.GetUserInfoByUserID
                                (UserID, ref PersonID, ref UserName, ref Password, ref IsActive);

            if (IsFound)
                //we return new object of that User with the right data
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }
        public static clsUser FindByPersonID(int PersonID)
        {
            int UserID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;

            bool IsFound = UserData.GetUserInfoByPersonID
                                (PersonID, ref UserID, ref UserName, ref Password, ref IsActive);

            if (IsFound)
                //we return new object of that User with the right data
                return new clsUser(UserID, UserID, UserName, Password, IsActive);
            else
                return null;
        }
        public static clsUser FindByUsernameAndPassword(string UserName, string Password)
        {
            int UserID = -1;
            int PersonID = -1;

            bool IsActive = false;

            bool IsFound = UserData.GetUserInfoByUsernameAndPassword
                                (UserName, Password, ref UserID, ref PersonID, ref IsActive);

            if (IsFound)
                //we return new object of that User with the right data
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }

        //public bool Save()
        //{
        //    switch (Mode)
        //    {
        //        case enMode.AddNew:
        //            if (_AddNewUser())
        //            {

        //                Mode = enMode.Update;
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }

        //        case enMode.Update:

        //            return _UpdateUser();

        //    }

        //    return false;
        //}

        public static DataTable GetAllUsers()
        {
            return UserData.GetAllUsers();
        }

        public static bool DeleteUser(int UserID)
        {
            return UserData.DeleteUser(UserID);
        }

    }
}
