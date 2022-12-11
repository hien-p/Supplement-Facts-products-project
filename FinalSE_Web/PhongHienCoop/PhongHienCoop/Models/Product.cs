using System.ComponentModel.DataAnnotations;

namespace PhongHienCoop.Models
{
    public class Product
    {
        [Key]
        public int product_id { get; set; }
        public string product_name { get; set; }
        public string price { get; set; }
        public string product_info { get; set; }
        public string product_img { get; set; }


    }
}
