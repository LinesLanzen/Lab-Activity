﻿using Microsoft.AspNetCore.Mvc;
using System;

namespace Lab_Activity.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsTenured { get; set; }
        public string Rank { get; set; }
        public DateTime HiringDate { get; set; }
    }
}