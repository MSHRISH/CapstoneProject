namespace MovieBookingApi.Models.TheaterModels
{
    public class Schema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RoeDimension { get; set; }
        public int ColumnDimension { get; set; }

        public ICollection<SchemaLayout> Layouts { get; set; }
    }
}
