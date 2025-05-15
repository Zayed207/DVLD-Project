using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DataAccessLayer;
namespace Business_Layer
{
    public class clsManageTests
    {
        public int TestTypeID;
        public string
        Title,
        Description;
        public float Fees;


        public clsManageTests(int testtypeID, string title, string description, float fees)
        {
            TestTypeID = testtypeID;
            Title = title;
            Description = description;
            Fees = fees;
            
        }
        public static bool UpdateTestType(int TestTypeID, string Title, string Description, float Fees)
        {



            return ManageTestsData.UpdateTestType(   TestTypeID,Title ,Description, Fees);
        }

        public static DataTable GetAllTypesOfTest(){



            return ManageTestsData.GetTypesOfTests();
        }
        public static float GetPaidFeesInfo(int TestTypeID)
        {

            return ManageTestsData.GetPaidFeesInfo(TestTypeID);

        }
    }
}
