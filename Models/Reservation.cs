namespace PalateParadise.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }

        public int UserId { get; set; }

        public int TableId { get; set; }

        public int NumberOfPeople { get; set; }

        public int MenuId { get; set; }
        public Menu Menu { get; set; }

        public int SpecialMenuCount { get; set; }

        public int BeverageId { get; set; }
        public Beverage Beverage { get; set; }

        public DateTime ReservationDate { get; set; }

        public decimal TotalAmount { get; set; }
    }
}
