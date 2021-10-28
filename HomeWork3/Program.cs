using System.Collections.Generic;
using Bogus;

namespace HomeWork3
{
    class Program
    {
        private static List<User> _entities = new List<User>();

        static void Main(string[] args)
        {
            var userFactory = new UserFactory();
            var faker = new Faker();

            var employees = userFactory.GetEntity<Employee>().Generate(faker.Random.Number(10));
            var candidates = userFactory.GetEntity<Candidate>().Generate(faker.Random.Number(10));

            IReportGenerator employeeReportGenerator = new EmployeeReportGenerator();
            IReportGenerator candidateReportGenerator = new CandidateReportGenerator();

            employeeReportGenerator.SortEntities(ref employees);
            candidateReportGenerator.SortEntities(ref candidates);

            _entities.AddRange(employees);
            _entities.AddRange(candidates);

            _entities.ForEach(entity => entity.Display());
        }
    }
}