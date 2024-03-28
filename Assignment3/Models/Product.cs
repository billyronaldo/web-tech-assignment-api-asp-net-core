namespace Assignment3.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; } 
        public decimal Pricing { get; set; }
        public decimal ShippingCost { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<Cart> Carts { get; set; }
        public ICollection<Order> Orders { get; set; }
    }

}
