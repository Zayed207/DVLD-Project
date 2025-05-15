using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DataAccessLayer;
namespace Business_Layer
{
    public class clsDrivingLicensesApplicatoin : clsApplications
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int LocalDrivingLicenseApplicationID { set; get; }
        public int LicenseClassID { set; get; }

        public clsLicenseClass LicenseClassInfo;
        public string PersonFullName
        {
            get
            {
                return clsPerson.Find(ApplicantPersonID).FullName;
            }

        }

        public static bool AddNewLocalDrivingLicenseApplication(int appID,int LicenseClassID)
        {
            //DrivingLicensesApplicatoinID
            int id;


              id= DrivingLicensesApplicatoinData.AddNewLocalDrivingLicenseApplication(appID,LicenseClassID);

            return (id != -1);
        }



        public static int AddNewLocalDrivingLicenseApplicationLimted(int appID, int LicenseClassID)
        {
            //DrivingLicensesApplicatoinID
            


          return   DrivingLicensesApplicatoinData.AddNewLocalDrivingLicenseApplication(appID, LicenseClassID);

            
        }


        public static DataTable GetAllLocalDrivingLicenseApplications()
        {


            return DrivingLicensesApplicatoinData.GetAllLocalDrivingLicenseApplications();


        }

        public static int GetApplicationIDByLocalDrivingLicenseApplicationID(int locallicensApplicationId)
      
        {


            return DrivingLicensesApplicatoinData.GetApplicationIDByLocalDrivingLicenseApplicationID(locallicensApplicationId);


        }
    }
}
