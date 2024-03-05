﻿using System;

namespace NewsFeed.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Role { get; set; }

        public string? Avatar { get; set; }
    }
}
