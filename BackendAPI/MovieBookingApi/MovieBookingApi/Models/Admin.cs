﻿namespace MovieBookingApi.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public AdminAuth AdminAuth {  get; set; }
    }
}
