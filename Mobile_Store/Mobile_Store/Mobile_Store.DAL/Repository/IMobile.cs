using System;
using System.Collections.Generic;
using System.Text;
using Mobile_Store.Entity;
namespace Mobile_Store.DAL.Repository
{
    interface IMobile
    {
        string Save_Mobile(Mobile_Details M_details);
        string Update_Mobile(Mobile_Details M_detail);
        string Delete_Mobile(string Model_name);

        Mobile_Details GetMobile(string Model_Name);
        List<Mobile_Details> GetAllMobile();
    }
}
