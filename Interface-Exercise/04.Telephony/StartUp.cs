using System;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        var phones = Console.ReadLine().Split();
        var sites = Console.ReadLine().Split();
        var cellPhone = new Phone();

        foreach (var phone in phones)
        {
            if (phone.Any(char.IsLetter))
            {
                Console.WriteLine("Invalid number!");
                continue;
            }
            Console.WriteLine(cellPhone.Calling(phone));
        }

        foreach (var site in sites)
        {
            if (site.Any(char.IsDigit))
            {
                Console.WriteLine("Invalid URL!");
                continue;
            }
            Console.WriteLine(cellPhone.Browsing(site));
        }
    }
}

