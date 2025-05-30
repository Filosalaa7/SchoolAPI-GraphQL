﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.DTOs
{
    public class StudentDTO
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public double GPA { get; set; }

        public IEnumerable<CourseDTO>? Courses { get; set; }
    }
}
