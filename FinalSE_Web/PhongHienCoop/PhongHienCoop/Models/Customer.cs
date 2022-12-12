using System.ComponentModel.DataAnnotations;

namespace PhongHienCoop.Models
{
    public class Customer
    {
        [Key]
        public int agent_id { get; set; }
        public string agent_name { get; set; }
        public string  agent_pass { get; set; }
        public int agent_tel { get; set; }
        public string agent_address { get; set; }

    }
}
