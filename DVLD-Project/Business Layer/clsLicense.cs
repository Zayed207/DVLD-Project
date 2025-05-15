using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
namespace Business_Layer
{
    public class clsLicense

    {
       
        public  enum enIssueReason { FirstTime = 1, Renew = 2, DamagedReplacement = 3, LostReplacement = 4 };

        public clsDriver DriverInfo;
        public int LicenseID { set; get; }
        public int ApplicationID { set; get; }
        public int DriverID { set; get; }
        public int LicenseClassID { set; get; }

        public clsLicenseClass LicenseClassIfo;
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public string Notes { set; get; }
        public float PaidFees { set; get; }
        public bool IsActive { set; get; }
        public enIssueReason IssueReason { set; get; }
       
        public int CreatedByUserID { set; get; }
        clsPerson person = new clsPerson();
       
        public clsLicense()

        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClassID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = 0;
            this.IsActive = true;
            this.IssueReason = enIssueReason.FirstTime;
            this.CreatedByUserID = -1;

            

        }

        public clsLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass,
            DateTime IssueDate, DateTime ExpirationDate, string Notes,
            float PaidFees, bool IsActive, enIssueReason IssueReason, int CreatedByUserID)

        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClassID = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;

         

        }



        public static bool IsHeHasLicense(int ApplicationID)
        {
            return LicenseData.IsHeHasLicense(ApplicationID);
        }
        public static bool IsLicenseExist(int LicenseID)
        {
            return LicenseData.IsLicenseExist(LicenseID);
        }


        public static int GetLicenseIDByAppID(int ApplicationID)
        {
            return LicenseData.GetLicenseIDByAppID(ApplicationID);
        }

        public static bool GetDriverLicenseByID(int LicenseID, ref string Name, ref int DriverID, ref string LicenseClass,
           ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes,
           ref String NationalNo, ref bool IsActive, ref byte IssueReason, ref int Gendor, ref DateTime DateOfBirth,ref string ImagePath)
        {

            return LicenseData.GetDriverLicenseByID(LicenseID, ref Name, ref DriverID, ref LicenseClass,
            ref IssueDate, ref ExpirationDate, ref Notes,
            ref NationalNo, ref IsActive, ref IssueReason, ref Gendor, ref DateOfBirth,ref ImagePath);
        }

        public static int AddNewLicense(int ApplicationID, int DriverID, int LicenseClass,
            DateTime IssueDate, DateTime ExpirationDate, string Notes,
            double PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            return LicenseData.AddNewLicense(ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
        }

    }
}
