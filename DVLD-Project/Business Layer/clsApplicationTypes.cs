﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DataAccessLayer;
namespace Business_Layer
{
    public class clsApplicationTypes
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int ID { set; get; }
        public string Title { set; get; }
        public float Fees { set; get; }

        public clsApplicationTypes()

        {
            this.ID = -1;
            this.Title = "";
            this.Fees = 0;
            Mode = enMode.AddNew;

        }

        public clsApplicationTypes(int ID, string ApplicationTypeTitel, float ApplicationTypeFees)

        {
            this.ID = ID;
            this.Title = ApplicationTypeTitel;
            this.Fees = ApplicationTypeFees;
            Mode = enMode.Update;
        }

        private bool _AddNewApplicationType()
        {
            //call DataAccess Layer 

            this.ID = ApplicationTypesData.AddNewApplicationType(this.Title, this.Fees);


            return (this.ID != -1);
        }

        private bool _UpdateApplicationType()
        {
            //call DataAccess Layer 

            return ApplicationTypesData.UpdateApplicationType(this.ID, this.Title, this.Fees);
        }

        public static clsApplicationTypes Find(int ID)
        {
            string Title = ""; float Fees = 0;

            if (ApplicationTypesData.GetApplicationTypeInfoByID((int)ID, ref Title, ref Fees))

                return new clsApplicationTypes(ID, Title, Fees);
            else
                return null;

        }

        public static DataTable GetAllApplicationTypes()
        {
            return ApplicationTypesData.GetAllApplicationTypes();

        }

        //public static DataTable GetAllAplications()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
