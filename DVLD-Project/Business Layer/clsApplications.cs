using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DataAccessLayer;
namespace Business_Layer
{
   public class clsApplications

    {
        public  enum enMode { AddNew = 0, Update = 1 };
        public enum enApplicationType { NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense=3,
            ReplaceDamagedDrivingLicense=4, ReleaseDetainedDrivingLicsense=5, NewInternationalLicense=6,RetakeTest=7
        };

        public enMode Mode = enMode.AddNew;
        public enum enApplicationStatus { New=1, Cancelled=2,Completed=3};

        public int ApplicationID { set;
            
            get; }
        public int ApplicantPersonID { set; get; }
        public string ApplicantFullName
        {
            get
            {
                return clsPerson.Find(ApplicantPersonID).FullName;
            }
        }
        public DateTime ApplicationDate { set; get; }
        public int ApplicationTypeID { set; get; }
        public ApplicationTypesData ApplicationTypeInfo;
        public enApplicationStatus ApplicationStatus { set; get; } 
        public string StatusText   
        {
            get { 
            
                switch (ApplicationStatus)
                {
                    case enApplicationStatus.New:
                        return "New";
                    case enApplicationStatus.Cancelled:
                        return "Cancelled";
                    case enApplicationStatus.Completed:
                        return "Completed";
                    default:
                        return "Unknown";  
                }
            }   
           
        }
        public DateTime LastStatusDate { set; get; }
        public float PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public int LicenseClassID { get; set; }
        public clsUser CreatedByUserInfo;

        public clsApplications()

        {
            this.ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = enApplicationStatus.New;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
           
            Mode = enMode.AddNew;

        }

        private clsApplications(int ApplicationID, int ApplicantPersonID, 
            DateTime ApplicationDate, int ApplicationTypeID,
             enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
             float PaidFees, int CreatedByUserID)

        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
          //  this.ApplicationTypeInfo = ApplicationTypesData.Find(ApplicationTypeID);
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUser.FindByUserID(CreatedByUserID);
            Mode = enMode.Update;

        }

        public static int _AddNewApplication(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
             byte ApplicationStatus, DateTime LastStatusDate,
             float PaidFees, int CreatedByUserID)
        {
            //call DataAccess Layer 



            return clsApplications._AddNewApplication(ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
        }

        private bool _UpdateApplication()
        {
            //call DataAccess Layer 

            return ApplicationData.UpdateApplication(this.ApplicationID, this.ApplicantPersonID, this.ApplicationDate,
                this.ApplicationTypeID, (byte) this.ApplicationStatus,
                this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
           
        }

        public  static clsApplications FindBaseApplication(int ApplicationID)
        {
            int ApplicantPersonID=-1;
            DateTime ApplicationDate=DateTime.Now ;  int ApplicationTypeID=-1;
            byte ApplicationStatus =1; DateTime LastStatusDate= DateTime.Now;
            float PaidFees = 0  ;  int CreatedByUserID = -1;

            bool IsFound = ApplicationData.GetApplicationInfoByID 
                                (
                                    ApplicationID, ref  ApplicantPersonID, 
                                    ref  ApplicationDate, ref  ApplicationTypeID,
                                    ref   ApplicationStatus, ref  LastStatusDate,
                                    ref  PaidFees, ref  CreatedByUserID
                                );

            if (IsFound)
                //we return new object of that person with the right data
                return new clsApplications(ApplicationID,  ApplicantPersonID,
                                     ApplicationDate,  ApplicationTypeID,
                                    (enApplicationStatus) ApplicationStatus,  LastStatusDate,
                                     PaidFees,  CreatedByUserID);
            else
                return null;
        }



        public static int GetActiveApplicationID(int PersonID, clsApplications.enApplicationType ApplicationTypeID)
        {
            return ApplicationData.GetActiveApplicationID(PersonID, (int)ApplicationTypeID);
        }
         public static int GetActiveApplicationIDForLicenseClass(int PersonID, clsApplications.enApplicationType ApplicationTypeID, int LicenseClassID)
        {
            return ApplicationData.GetActiveApplicationIDForLicenseClass(PersonID, (int)ApplicationTypeID,LicenseClassID);
        }

      
        public bool Cancel()

        {
            return ApplicationData.UpdateStatus (ApplicationID,2);
        }

        public bool SetComplete()

        {
            return ApplicationData.UpdateStatus(ApplicationID, 3);
        }

        //public int Save()
        //{
        //    switch (Mode)
        //    {
        //        case enMode.AddNew:


        //            Mode = enMode.Update;
        //            return _AddNewApplication();
                    


        //        case enMode.Update:

        //            if (_UpdateApplication())
        //            {
        //                return 1;
        //            }
        //            else
        //                return -1;

        //        default:

        //                      return -1;
        //    }
        //}


        public  bool Delete()
        {
            return ApplicationData.DeleteApplication(this.ApplicationID); 
        }

        public static DataTable GetAllApplications()
        {


            return ApplicationData.GetAllApplications();
           
        }


        public static int GetApplicationIDByLicenseID(int LicenseID)
        {


            return ApplicationData.GetApplicationIDByLicenseID(LicenseID);
        }


        public static int GetApplicationFessByType(int apptype)
        {
            return ApplicationData.GetApplicationFessByType(apptype);
        }
    }
}
