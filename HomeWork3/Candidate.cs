using System;

namespace HomeWork3
{
    public class Candidate : User
    {
        public DismissalReason? DismissalReason { get; set; }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(
                $"I want to be {JobTitle} {JobDescription} with salary {JobSalary}.");
            Console.WriteLine(DismissalReason is null
                ? "I have not worked before"
                : $"I quit my previous job for a reason of {DismissalReason}");
        }
    }
}