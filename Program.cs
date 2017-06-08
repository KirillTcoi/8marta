using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8marta
{
    class Program
    {
        static void Main(string[] args)
        {
            Item flower1 = new Item(type.Flower1, 60);
            Item flower2 = new Item(type.Flower2, 55);
            Item paper = new Item(type.Paper, 20);
            Item green = new Item(type.Green, 15);

            Buket buket = new Buket() {Elements = new List<Item>(), Cost = 0};

            
            



            bool sw = false;
            while (sw == false) //Добавляем елементы
            {
                Console.Clear();
                Console.WriteLine("Создание букета: Что добавить? \nИтоговая стоимость:" + buket.Cost + "\n1. Цветок1\n2. Цветок2\n3. Бумага\n4. Зелень\n5. Выход");
                var swich = Console.ReadLine();
                switch (swich)
                {
                    case "1":
                        buket.Elements.Add(flower1);
                        break;
                    case "2":
                        buket.Elements.Add(flower2);
                        break;
                    case "3":
                        buket.Elements.Add(paper);
                        break;
                    case "4":
                        buket.Elements.Add(green);
                        break;
                    case "5":
                        sw = true;
                        break;
                }
                buket.RCost();
            }

            sw = false;
            while (sw == false) //убираем элементы
            {
                Console.Clear();
                Console.WriteLine("Убираем элементы букета: Что убрать? \nИтоговая стоимость:" + buket.Cost + "\n1. Цветок1\n2. Цветок2\n3. Бумага\n4. Зелень\n5. Выход");
                var swich = Console.ReadLine();
                switch (swich)
                {
                    case "1":
                        buket.Ubrat(flower1);
                        break;
                    case "2":
                        buket.Ubrat(flower2);
                        break;
                    case "3":
                        buket.Ubrat(paper);
                        break;
                    case "4":
                        buket.Ubrat(green);
                        break;
                    case "5":
                        sw = true;
                        break;
                }
                
            }
            Console.Clear();
            Console.WriteLine("ИТОГО: "+buket.Cost); //Итоговая стоимость букета
            Console.ReadKey();
        }
    }
}
