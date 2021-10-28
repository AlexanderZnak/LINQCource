using System;
using Bogus;
using Bogus.Extensions;

namespace HomeWork3
{
    public class UserFactory
    {
        public Faker<T> GetEntity<T>() where T : User
        {
            Faker<T> entity = null;

            if (typeof(T) == typeof(Employee))
            {
                var employee = new Faker<Employee>()
                    .RuleFor(n => n.FirstName, f => f.Person.FirstName)
                    .RuleFor(n => n.LastName, f => f.Person.LastName)
                    .RuleFor(n => n.JobDescription, f => f.Person.Company.Bs)
                    .RuleFor(n => n.JobTitle, f => f.Person.UserName)
                    .RuleFor(n => n.Id, f => Guid.NewGuid())
                    .RuleFor(n => n.JobSalary, f => f.Random.Double(1, 5000))
                    .RuleForType(typeof(Company), f => new Company()
                    {
                        Address = f.Address.StreetAddress(),
                        City = f.Address.City(),
                        Country = f.Address.Country(),
                        Name = f.Company.CompanyName()
                    });

                entity = (Faker<T>) Convert.ChangeType(employee, typeof(Faker<T>));
            }
            else if (typeof(T) == typeof(Candidate))
            {
                var candidate = new Faker<Candidate>()
                    .RuleFor(n => n.FirstName, f => f.Person.FirstName)
                    .RuleFor(n => n.LastName, f => f.Person.LastName)
                    .RuleFor(n => n.JobDescription, f => f.Person.Company.Bs)
                    .RuleFor(n => n.JobTitle, f => f.Person.UserName)
                    .RuleFor(n => n.Id, f => Guid.NewGuid())
                    .RuleFor(n => n.JobSalary, f => f.Random.Double(1, 5000))
                    .RuleFor(n => n.DismissalReason, f => f.PickRandom<DismissalReason>().OrNull(f));

                entity = (Faker<T>) Convert.ChangeType(candidate, typeof(Faker<T>));
            }

            return entity;
        }
    }
}