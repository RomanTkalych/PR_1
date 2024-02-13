using static PR_1.wild;

namespace PR_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Напишіть про тварину  ");
            var animal = new wild();
            animal.ReadValues();
            animal.Types();
            animal.Actions();
            animal.WriteInfo();
            Console.WriteLine("\n \n ");


            var car = new Car_Store();
            car.ReadValues();
            car.Types();
            car.Impression();
            car.WriteInfo();

            var moto = new Moto_Store();
            moto.ReadValues();
            moto.Types();
            moto.Impression();
            moto.WriteInfo();

        }
    }
}
