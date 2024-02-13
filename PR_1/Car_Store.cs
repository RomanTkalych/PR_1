using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_1
{
    public class Car_Store: wild
    {
        string Name { get; set; }
        string Type { get; set; }

        string Action { get; set; }


        public void ReadValues()
        {
            if (this.Name == null)
            {
                Console.WriteLine("Введіть марку транспорту яку хочете взяти для тесту");
                this.Name = Console.ReadLine();
            }
        }

        public void Types()
        {
            if (this.Type == null)
            {
                Console.WriteLine("Напишіть тип машини для тесту... \n(авто - (спорт, джип, седан ....)  ");
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


        public void Impression()
        {

            if (this.Action == null)
            {
                Console.WriteLine("Введіть ваші враження щодо транспортного засобу (1 - Все супер, працює відмінно) \n (2 - Повільний, не зручний) \n (3- Транспорт взагалі не завівся, сміття)  ");
                this.Action = Console.ReadLine();
                switch (this.Action)
                {
                    case "1":
                        this.Action = Name + "Все супер, працює відмінно ";
                        break;
                    case "2":
                        this.Action = Name + "Повільний, не зручний ";
                        break;
                    case "3":
                        this.Action = Name + "Транспорт взагалі не завівся, сміття ";
                        Console.WriteLine("Нам дуже шкода що ми зіпсували ваше враження. Наступого разу все буде на найвищому рвіні");
                        break;
                }
            }


        }

        public void WriteInfo()
        {
            Console.WriteLine("\t Відгук клієнта щодо транспорту:");
            Console.WriteLine("Марка транспорту - " + Name + "\t Тип транспорту - " + Type + "\t враження щодо транспорту - " + Action ,"\n \n");
        }
    }
}
