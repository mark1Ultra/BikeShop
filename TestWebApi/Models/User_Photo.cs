﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApi.Models
{
    public class User_Photo
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

    }
}
