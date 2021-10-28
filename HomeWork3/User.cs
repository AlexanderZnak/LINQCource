using System;

namespace HomeWork3
{
    public abstract class User : IDisplayable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public double JobSalary { get; set; }
        public Guid Id { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        public virtual void Display()
        {
           Console.WriteLine($"Hello I am {FullName} with {Id}.");
        }
    }
}