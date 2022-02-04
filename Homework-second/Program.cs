using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Classes;
using BLL.Interfaces;
using Domain;
using Domain.Models;

namespace Homework_second
{
    
    class Program
    {
        private static readonly IEmployerService _employerService;
        private static readonly ICityService _cityService;

        static Program()
        {
            _employerService = new EmployerService();
            _cityService = new CityService();
        }
        
        static void Main(string[] args)
        {
            City city = new City { Name = "Berlin" };
            AddNewCity(city);
        }

        private static void AddNewCity(City city)
        {
            _cityService.Add(city);
            _cityService.SaveChanges();
        }

        private static void DeleteCity(City city)
        {
            _cityService.Remove(city);
            _cityService.SaveChanges();
        }

        private static IEnumerable<Employer> GetEmployers()
        {
            return _employerService.GetMany(e => e.FirstName == "John");
        }
        

    }
}