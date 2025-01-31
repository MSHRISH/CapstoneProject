﻿namespace MovieBookingApi.Models.TheaterModels
{
    public class Theater
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string District { get; set; }

        public ICollection<Screen> Screens { get; set; }
        public ICollection<Snack> Snacks { get; set; }
    }
}
