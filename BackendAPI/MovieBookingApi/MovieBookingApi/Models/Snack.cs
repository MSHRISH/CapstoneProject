namespace MovieBookingApi.Models
{
    public class Snack
    {
        public int Id { get; set; }
        public int TheaterId { get; set; }
        public Theater Theater { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
    }
}
