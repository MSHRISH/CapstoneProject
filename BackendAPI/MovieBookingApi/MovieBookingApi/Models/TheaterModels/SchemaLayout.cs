namespace MovieBookingApi.Models.TheaterModels
{
    public class SchemaLayout
    {
        public int Id { get; set; }
        public int SchemaId { get; set; }
        public Schema Schema { get; set; }
        public int Row { get; set; }
        public string Column { get; set; }
        public bool IsSeat { get; set; }
        public float Price { get; set; }
    }
}
