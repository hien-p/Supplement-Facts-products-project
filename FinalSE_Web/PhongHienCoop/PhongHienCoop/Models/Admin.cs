using System.ComponentModel.DataAnnotations;

namespace PhongHienCoop.Models
{
    public class Admin
    {
        [Key]
        public int acc_id { get; set; }
        public string acc_log_name { get; set; }
        public int acc_pass { get; set; }
        public int acc_name { get; set; }
        public string acc_address { get; set; } 
        public int acc_tel { get; set; }
    }
}
