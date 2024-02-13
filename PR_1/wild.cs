using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_1
{
    public class wild : Ianimal
    {


        string Name { get; set; } 
        string Type { get; set; }

        string Action { get; set; } 


        public void ReadValues()
        {
            if (this.Name == null)
            {
                Console.WriteLine("Введіть назву тварини");
                this.Name = Console.ReadLine();
            }
        }

        public void Types() {
            if (this.Type == null)
            {
                Console.WriteLine("Введіть тип тварини (м'ясоїдна, травоїдна ) ");
                this.Type = Console.ReadLine();
            }
        }


        public void Actions() {

            if (this.Action == null)
            {
                Console.WriteLine("Введіть що тварина робить.(якщо спить - 1, якщо полює - 2 , якщо бігає по полю - 3)    ");
                this.Action = Console.ReadLine();
                switch (this.Action)
                {
                    case "1":
                        this.Action = Name + " Спить";
                        break;
                    case "2":
                        this.Action = Name + " Полює";
                        break;
                    case "3":
                        this.Action = Name + " Бігає по полю";
                        break;
                }
            }

       
        }

        public void WriteInfo() 
        {
            Console.WriteLine("\t Інформація:");
            Console.WriteLine("Назва тварини - " + Name + "\t Тип тварини - " + Type + "\t Дія тварини - "  + Action);
        }


    }    
}
