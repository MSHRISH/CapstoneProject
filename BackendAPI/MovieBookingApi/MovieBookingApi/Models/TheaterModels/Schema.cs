namespace MovieBookingApi.Models.TheaterModels
{
    public class Schema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RowDimension { get; set; }
        public int ColumnDimension { get; set; }

        public ICollection<Screen> Screens { get; set; }
        public ICollection<ScreenLayout> Layouts { get; set; }
    }
}
