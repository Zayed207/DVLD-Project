using DataAccessLayer;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_Layer
{
   public class clsTest
    {
        public int TestId;
        public int TestAppoinemntId;
        public string Notes;
        public string Result;
        public int CreatedByUserID;

        public clsTest(int Testid,int Testappoinmentid,string notes,string result,int createdbyuserid)
        {
            TestId = Testid;
            TestAppoinemntId = Testappoinmentid;
            Notes = notes;
            Result = result;
            CreatedByUserID = createdbyuserid;

        }

        public clsTest()
        {
            TestId = -1;



        }


       public static bool IsTheLastTestPassed(byte TypeID,int LocalDrivingLicenseApplicationID)
        {
           return TestData.IsTheLastTestPassed(TypeID, LocalDrivingLicenseApplicationID);

        }
    }
}
