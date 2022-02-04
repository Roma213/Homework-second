using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Company
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid? CityId { get; set; }

        public virtual ICollection<City> Cities { get; set; }

        public virtual ICollection<Employer> Employers { get; set; }
    }
}
