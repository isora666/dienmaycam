﻿namespace dienmaycam.Models
{
    public class Customer
    {
        public Guid ID { get; set; }
        public Guid UserID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}