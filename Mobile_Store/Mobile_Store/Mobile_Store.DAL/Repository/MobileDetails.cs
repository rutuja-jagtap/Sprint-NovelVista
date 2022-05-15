using System;
using System.Collections.Generic;
using System.Text;
using Mobile_Store.Entity;

namespace Mobile_Store.DAL.Repository
{
    class MobileDetails : IMobile
    {
        public string Delete_Mobile(string Model_Name)
        {
            return "Deleted";
        }

        public List<Mobile_Details> GetAllMobile()
        {
            return new List<Mobile_Details>(); 
        }

        public Mobile_Details GetMobile(string Model_Name)
        {
            Mobile_Details M_detail = new Mobile_Details();
            return M_detail;
        }

        public string Save_Mobile(Mobile_Details M_details)
        {
            return "Saved";  
        }

        public string Update_Mobile(Mobile_Details M_detail)
        {
            return "Upated";   
        }
    }
}
