namespace MarvelBoots.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("OrderProduct")]
    public partial class OrderProduct
    {
        [Key]
        public int IdOrderProduct { get; set; }

        public int OrderId { get; set; }

        public int CategoryId { get; set; }

        public int ProductId { get; set; }

        public int ManufacturerId { get; set; }

        public decimal Size { get; set; }

        public int Amount { get; set; }

        public decimal PricePerUnit { get; set; }

        public virtual Category Category { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
