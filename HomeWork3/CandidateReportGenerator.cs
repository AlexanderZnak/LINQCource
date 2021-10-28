using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork3
{
    public class CandidateReportGenerator : IReportGenerator
    {
        public void SortEntities<T>(ref List<T> entities) where T : User
        {
            if (typeof(T) != typeof(Candidate))
            {
                throw new ArgumentException("Only type of employee is allowed");
            }

            entities = entities.Cast<Candidate>()
                .OrderBy(e => e.JobTitle)
                .ThenBy(j => j.JobSalary)
                .Cast<T>().ToList();
        }
    }
}