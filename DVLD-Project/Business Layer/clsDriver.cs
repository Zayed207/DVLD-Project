using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Business_Layer
{
   public  class clsDriver
    {
        public int DriverID;

        public int PersonID;

        public int CreatedByUserID;

        public DateTime CreatedDate;


        public clsDriver(int driverid,int personid,int c_userid,DateTime createddate)
        {

            DriverID = driverid;
            PersonID = personid;
            CreatedByUserID = c_userid;
            CreatedDate = createddate;


        }


        public clsDriver()
        {
            DriverID = -1;

        }

        public static int  AddNewDriver(int PersonID, int CreatedByUserID)
        {

            return DriverData.AddNewDriver(PersonID, CreatedByUserID);


        }


        public static DataTable GetAllDrivers()
        {
            return DriverData.GetAllDrivers();
        }
        public static int GetDriverIDByPersonID(int PersonID)
        {
            return GetDriverIDByPersonID(PersonID);
        }

    }
}
