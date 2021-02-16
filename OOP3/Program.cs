using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICrediManager ihtiyacKrediManager = new IhtiyacCrediManager();
            ICrediManager tasitKrediManager = new TasitKrediManager();
            ICrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);

            List<ICrediManager> krediler = new List<ICrediManager>()
            { ihtiyacKrediManager ,tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            


        }
    }
}
