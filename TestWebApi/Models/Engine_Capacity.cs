﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestWebApi.Models
{
    public class Engine_Capacity
    {
        public int Id { get; set; }
        public int capacity { get; set; }

        public List<Bike> List_Bike { get; set; }
    }
}
