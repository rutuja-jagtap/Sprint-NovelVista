using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mobile_Store.Entity
{
    public class Mobile_Details
    {
        

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Mobile_id { get; set; }
        public string Company_Name { get; set; }
        public string Model_Name { get; set; }
        public string Rear_Cam { get; set; }
        public string Front_Cam { get; set; }
        public string Ram { get; set; }
        public string Internal_Storage { get; set; }
        public string Sim_Type { get; set; }
        public string Network_Type { get; set; }
        public string Price { get; set; }
        public string colour { get; set; }
        public string Display { get; set; }
        public string Fingerprint_sensor { get; set; }



    }
}
