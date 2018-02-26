using System;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        try
        {
            var studentTokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var studFirstN = studentTokens[0];
            var studLastN = studentTokens[1];
            var studFc = studentTokens[2];

            var workerTokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var workerFirstN = workerTokens[0];
            var workerLastN = workerTokens[1];
            var salaryPerWeek = decimal.Parse(workerTokens[2]);
            var hoursPerDay = decimal.Parse(workerTokens[3]);

            Student student = new Student(studFirstN, studLastN, studFc);
            Worker worker = new Worker(workerFirstN, workerLastN, salaryPerWeek, hoursPerDay);

            Console.WriteLine(student);
            Console.WriteLine(worker);
        }
        catch (ArgumentException ex)
        {

            Console.WriteLine(ex.Message);
        }
    }
}

