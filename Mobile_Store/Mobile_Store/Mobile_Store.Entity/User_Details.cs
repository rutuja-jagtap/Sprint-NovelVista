using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mobile_Store.Entity
{
    public class User_Details
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int User_id { get; set; }
        public string User_Name { get; set; }
        public string User_Address { get; set; }
        public string User_Gender { get; set; }
        public string User_Phone { get; set; }
        public string User_Mail { get; set; }
        public string User_Password { get; set; }


    }
}
