using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamersManager gamerManager = new GamersManager(new MernisServiceAdapter());
            gamerManager.Save(new Gamer
            {
                DateOfBirth = new DateTime(1985, 1, 6),
                FirstName = "Engin",
                LastName = "Demiroğ",
                NationalityId = "28861499108",
                NickName = "EnginDemiro",
                Country = "Turkey",
                City = "Ankara",
                CreditCardNumber = "9999-8888-7777-6666",
                MailAddress = "https://github.com/engindemiro",
                Id = 1
            });
            Console.ReadLine();
        }
    }
}
