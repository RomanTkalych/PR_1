using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_1
{
    public class Moto_Store : Car_Store
    {
        string Name { get; set; }
        string Type { get; set; }

        string Action { get; set; }

        public void ReadValues()
        {
            if (this.Name == null)
            {
                Console.WriteLine("Введіть марку мотоциклу яку хочете взяти для тесту");
                this.Name = Console.ReadLine();
            }
        }

        public void Types()
        {
            if (this.Type == null)
            {
                Console.WriteLine("Напишіть тип мотоциклу для тесту...  \n \n(мотоцикл - (спорт, кросовий, чоппер ...) ) ");
                this.Type = Console.ReadLine();
                Console.WriteLine("Зачекайте, перевірка чи транспорт в наявності...");
                Thread.Sleep(3000);
                Console.WriteLine("Транспортний засіб готується до тесту... ");
                Thread.Sleep(3000);
                Random N = new Random();
                int Number = N.Next(1, 100);
                Console.WriteLine($"Трансопртний засіб номер {Number}: \n  \n Підготовано до тесту! ");
                Thread.Sleep(3000);
                Console.WriteLine("\n \n \n");


            }
        }
    }
}