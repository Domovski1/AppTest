using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseTest _db = new BaseTest();
            mainTable tablee = new mainTable();
            Random rand = new Random();

            string[] str = new string[20] {
            "Photoshop",
            "cmd", 
            "PowerShell", 
            "Excel", 
            "Word",
            "Visual Studio",
            "Visual Code", 
            "MS SQL",
            "Google Chrome",
            "GitHub",
            "Discord",
            "Telegram",
            "Whats App",
            "YouTube",
            "VK Messenger",
            "Paint",
            "Microsoft Edge",
            "Picasa",
            "Visio",
            "Проводник"
            };

            for (int i = 0; i < 1000; i++)
            {

                try
                {
                    tablee.Title = str[rand.Next(20)];
                    tablee.GroupID = rand.Next(1, 5);
                    tablee.Size = rand.Next(2200);
                    _db.mainTable.Add(tablee);
                    _db.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            
            }
                Console.WriteLine("Данные добавлены");





            Console.ReadKey();
        }
    }
}
