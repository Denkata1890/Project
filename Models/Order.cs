namespace PalateParadise.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int MenuId { get; set; }
        public int BeverageId { get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }
    }
}
