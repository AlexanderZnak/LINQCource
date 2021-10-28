using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork3
{
    public class EmployeeReportGenerator : IReportGenerator
    {
        public void SortEntities<T>(ref List<T> entities) where T : User
        {
            if (typeof(T) != typeof(Employee))
            {
                throw new ArgumentException("Only type of employee is allowed");
            }

            entities = entities.Cast<Employee>()
                .OrderBy(e => e.Company.Name)
                .ThenByDescending(j => j.JobSalary)
                .Cast<T>().ToList();
        }
    }
}