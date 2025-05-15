using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Xml.Linq;
using DataAccessLayer;
namespace Business_Layer
{
    public class clsMain

    {

        public static MainData Businessmain = new MainData();

        public static int FindByUser(string User, string Password) {

            Businessmain.Username = User.ToString();
            Businessmain.Password = Password;

            Businessmain = MainData.FindByUser(ref Businessmain);


            return Businessmain.UserID;


        }





    }



}

