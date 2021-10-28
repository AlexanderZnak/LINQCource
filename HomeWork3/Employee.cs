using System;

namespace HomeWork3
{
    public class Employee : User
    {
        public Company Company { get; set; }

        public override void Display()
        {
            base.Display();
            Console.WriteLine(
                $"{JobTitle} {JobDescription} in {Company.Name}, {Company.Country}, {Company.City}, {Company.Address} with salary {JobSalary}");
        }
    }
}