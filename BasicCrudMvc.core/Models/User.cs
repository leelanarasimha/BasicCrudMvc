﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCrudMvc.core.Models
{
    public class User
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Location Location { get; set; }
        public int Age {get; set; }
    }
}
