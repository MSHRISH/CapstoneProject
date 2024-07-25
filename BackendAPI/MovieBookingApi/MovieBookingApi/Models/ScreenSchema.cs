namespace MovieBookingApi.Models
{
    public class ScreenSchema
    {
        public int Id { get; set; }
        public int ScreenId { get; set; }
        public Screen Screen { get; set; }
        public int Row { get; set; }
        public string Column { get; set; }
        public bool IsSeat { get; set; }
        public float Price { get; set; }
    }
}
