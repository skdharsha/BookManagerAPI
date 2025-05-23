﻿using System.Collections;

namespace BookManagerAPI.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } 
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        //Navigation properties
        public ICollection< Books> Books { get; set; }
    }
}
