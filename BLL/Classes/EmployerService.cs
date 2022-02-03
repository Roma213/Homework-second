using System;
using System.Collections.Generic;
using System.Text;
using BLL.Interfaces;
using Domain;
using Domain.Models;

namespace BLL.Classes
{
    public class EmployerService: BaseService<Employer>, IEmployerService
    {
        private readonly ApplicationContext _context;
        
        public EmployerService(ApplicationContext context):base(context)
        {
        }
    }
}
