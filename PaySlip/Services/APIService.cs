using PaySlip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaySlip.Services
{
    public class APIService : IAPIService
    {
        public List<Dept> GetDepts()
        {
            List<Dept> dept = new List<Dept>();
            return dept;
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            return employees;
        }
    }
}
