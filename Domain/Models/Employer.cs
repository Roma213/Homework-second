using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;

namespace Domain.Models
{
    public class Employer
    {
        public Guid Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime BirstDate { get; set; }

        public Guid? CompanyId { get; set; }

        public virtual Company Company { get; set; }
        
        public Guid? JobTitleId { get; set; }
        
        public virtual JobTitle JobTitle { get; set; }

        public virtual ICollection<EmployerSkill> EmployerSkills { get; set; }
    }
}
