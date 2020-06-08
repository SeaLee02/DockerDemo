using System.ComponentModel.DataAnnotations.Schema;

namespace YOYO.Models
{
    public class Product
    {
        public Product()
        {

        }

        public Product(string name = null, string category = null, decimal price = 0)
        {
            Name = name;
            Cateory = category;
            Price = price;
        }

        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Cateory { get; set; }
        
        [Column(TypeName="decimal(18,4)")]
        public decimal Price { get; set; }
    }

}