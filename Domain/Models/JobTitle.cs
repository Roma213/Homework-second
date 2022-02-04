using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class JobTitle
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }
        
        public decimal? Salary { get; set; }

        public virtual ICollection<Employer> Employers { get; set; }
    }
}