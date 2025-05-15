using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Business_Layer
{
   public class clsTestAppoinment
    {
        public enum enTestTypeID { VisionTest = 1, WrittenTest = 2, StreetTest = 3 }
        public int TestAppoinmentID { get; set; }

        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicoationID { get; set; }
        public DateTime AppoinmentDate { get; set; }
        public float TestFees{ get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked{ get; set; }

        public clsLicenseClass licenseClassName=new clsLicenseClass();

       
        public clsTestAppoinment(int testAppoinmentID,enTestTypeID typeid,int localDrivingLicenseApplicoationID,DateTime appoinmentDate,
            float testFees,int createdByUserID,bool isloked)
        {
            TestAppoinmentID = testAppoinmentID;
            TestTypeID = (int)typeid;
            LocalDrivingLicenseApplicoationID = localDrivingLicenseApplicoationID;
            AppoinmentDate = appoinmentDate;
            TestFees = testFees;
            CreatedByUserID = createdByUserID;
            IsLocked = isloked;


        }

        public clsTestAppoinment()
        {


         
            
        }


        public static bool IsHasAppoinment(int LocalDrivingLicenseApplicationID)
        {


            return TestAppoinmentData.IsHasAppoinment(LocalDrivingLicenseApplicationID);

        }
        public static DateTime GetTheExistDateOfAppoinment(int LocalDrivingLicenseApplicationID)
        {

            return clsTestAppoinment.GetTheExistDateOfAppoinment(LocalDrivingLicenseApplicationID);
        }

        public static DataTable GetAppoinmentsByLDLApplicationID(int LocalDrivingLicenseApplicationID)
        {
            return TestAppoinmentData.GetAppoinmentsByLDLApplicationID(LocalDrivingLicenseApplicationID);

        }

        public static int AddNewAppoinmentTest (int typeid, int localDrivingLicenseApplicoationID, DateTime appoinmentDate,
            float testFees, int createdByUserID, bool isloked)
        {
            int testAppoinmentID = -1;

            testAppoinmentID= TestAppoinmentData.AddNewAppoinmentTest( typeid, localDrivingLicenseApplicoationID, appoinmentDate, testFees, createdByUserID, isloked);
            return testAppoinmentID;
        }

    }
}
